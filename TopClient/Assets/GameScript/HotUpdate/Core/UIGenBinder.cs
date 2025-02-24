﻿using Login;
using MainCenter;
using CommonPKG;
using GMView;
using DialogTip;


public class UIGenBinder
{
    /// <summary> FairyGUI-Editor编辑器发布出的  要先绑定哦 </summary>
    public static void BindAll()
    {
        Debuger.LogWarning("--开始绑定自动生成的脚本--若没有执行OnInit(),看看此有无绑定---");
        LoginBinder.BindAll();
        MainCenterBinder.BindAll();
        DialogTipBinder.BindAll();
        CommonPKGBinder.BindAll();
        GMViewBinder.BindAll();
    }
}