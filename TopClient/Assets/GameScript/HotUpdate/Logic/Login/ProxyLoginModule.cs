using System;
using Login;

public class ProxyLoginModule : Singleton<ProxyLoginModule>,IProxy
{
    private const string pkgName = "Login";
    public void CheckLoad(Action finishCB)
    {
        FGUILoader.Instance.AddPackage(pkgName, finishCB);
    }


    public void OpenLoginMainView()
    {
        CheckLoad(() =>
        {
            var targetView = UIMgr.Instance.OpenUIViewCom<LoginMainView>(pkgName);
            targetView.SetData("打开页面数据传递");
        });
    }

    public void CloseLoginMainView()
    {
        UIMgr.Instance.CloseUIViewCom<LoginMainView>();
    }







    #region ServerListRemoteView打开关闭Window

    public void OpenServerListRemoteViewWin()
    {
        CheckLoad(() => { UIMgr.Instance.OpenWindow<ServerListRemoteViewWin>(); });
    }

    public void CloseServerListRemoteViewWin()
    {
        UIMgr.Instance.CloseWindow<ServerListRemoteViewWin>();
    }

    #endregion

}
