﻿using FairyGUI;
using UnityEngine;

namespace CommonPKG
{
    public partial class Item_Currency:GComponent
    {
        private int mCurrencyId = 0;
        public void SetData(int pCfgId)
        {
   
            var cfg = CfgLubanMgr.Instance.globalTab.TbItemConfig.Get(pCfgId);// ConfigMgr.Instance.LoadConfigOne<ItemConfig>(pCfgId.ToString());
            // Debuger.LogError($"{pCfgId}  {cfg.smallIcon}");
            _icon.icon =cfg.SmallIcon;
            _addCtrl.selectedIndex = cfg.ShowAdd;
            mCurrencyId = pCfgId;
        }

        public override void Dispose()
        {
            base.Dispose();
        }
    }
}