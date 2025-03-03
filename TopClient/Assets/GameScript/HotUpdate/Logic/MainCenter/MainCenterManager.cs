﻿using System;
using System.Collections.Generic;
using cfg;

public class MainCenterManager : Singleton<MainCenterManager>
{
    protected override void OnInit()
    {
        base.OnInit();
        InitMainBtnCfgs();
    }

    private Dictionary<int, List<MainUIBtnConfig>> mMainBtnCfgsDic = new Dictionary<int, List<MainUIBtnConfig>>();

    private void InitMainBtnCfgs()
    {
        var cfgAlls = CfgLubanMgr.Instance.globalTab.TbMainUIBtnConfig.DataList; // ConfigMgr.Instance.LoadConfigList<MainUIBtnConfig>();
        foreach (var item in cfgAlls)
        {
            if (mMainBtnCfgsDic.TryGetValue(item.TType, out var cfgs))
            {
                cfgs.Add(item);
            }
            else
            {
                mMainBtnCfgsDic[item.TType] = new List<MainUIBtnConfig>() { item };
            }
        }
    }

    public List<MainUIBtnConfig> GetMainUIBtnList(int pType)
    {
        if (mMainBtnCfgsDic.TryGetValue(pType, out var cfgs))
        {
            return cfgs;
        }
        else
        {
            InitMainBtnCfgs();
            return mMainBtnCfgsDic[pType];
        }
    }

    private Dictionary<int, Action> mActDic = new Dictionary<int, Action>()
    {
        { 1001, () => {  } }, //英雄
        {
            1002, () =>
            {
                AudioMgr.Instance.PlayBGM("sound_explosion_enemy");
                EventCenter.Instance.Fire<string>((int)EventEnumHOT.EE_test1, "event可能是dto");
                
            }
        },
        { 1003, () => {  } },
        {
            1004, () =>
            {
                EffectLoader.Instance.LoadSceneEffectSimple("TX_BYCH_Skill");
                AudioMgr.Instance.PlayMusic("sound_weapon_player");
            }
        },
        { 1005, () => { ProxyCommonPKGModule.Instance.AddToastStr("~~~~简易 飘字---挺长的飘字哦...."); } },
        { 2001, () => {  } },
        { 2002, () => {  } },
        { 2003, () => {  } }
    };

    public void OnClickFuncBtn(int cfgID)
    {
        if (mActDic.TryGetValue(cfgID, out var act))
        {
            act();
        }
        else
        {
            Debuger.LogError("未找到对应的点击事件");
        }
    }
}

/// <summary> 按钮自定义类 </summary>
public class BtnCustomCls
{
    public int Id { get; set; } //1001英雄  1002联盟 1003背包 1004邮件 1005部队             2001功能预告  2002活动  2003福利
    public Action clikcAct { get; set; }

    public BtnCustomCls(int cId, Action act)
    {
        this.Id = cId;
        this.clikcAct = act;
    }
}