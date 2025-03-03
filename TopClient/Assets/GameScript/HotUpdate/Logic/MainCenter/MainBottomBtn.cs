﻿using CommonPKG;
using FairyGUI;
using cfg;

namespace MainCenter
{
    public partial class MainBottomBtn : GButton
    {
        public void SetData(MainUIBtnConfig cfg)
        {
            if (cfg != null)
            {
                this.icon = cfg.IconURL;
                this.title = cfg.TitleTxt;
                this.onClick.Set(() => { MainCenterManager.Instance.OnClickFuncBtn(cfg.Id); });

                if (cfg.Id == 1003)
                {
                    RedPoint red = (RedPoint)this._redPoint;
                    
                    // red.SetData(RedDotDefine.BagRoot);
                }
                else
                {
                    // this._redPoint.GetController("showCtrl").selectedIndex = 0; //Random.Range(0, 3);//红点随机
                }
            }
        }

        private void OnBagRootRedDotLogicHandler(RedDotTreeNode redNode)
        {
          
        }
    }
}