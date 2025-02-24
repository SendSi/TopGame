using FairyGUI;
using UnityEngine;

namespace MainCenter
{
    public partial class MainCenterView : GComponent
    {
        public override void OnInit()
        {
            base.OnInit();

            InitEles();

            EventCenter.Instance.Bind<string>((int)EventEnumHOT.EE_test1, OnEventTest);
            EventCenter.Instance.Bind<int>((int)EventEnumHOT.EE_loginIn, OnEventLoginIn);

            _btnAddMJ.onClick.Add(OnClickAddMJ);
            _btnAddDDG.onClick.Add(OnClickAddDDG);
        }

        private void OnClickAddDDG()
        {
            Debug.LogError("斗地主");
        }

        private void OnClickAddMJ()
        {
            Debug.LogError("麻将");
        }

        private void OnEventLoginIn(int arg0)
        {
            Debuger.LogError("OnEventGameOver 值 " + arg0);
        }

        private void OnEventTest(string arg0)
        {
            Debuger.LogError("MainCenterView 监听了  EN_test_" + arg0);
        }

        private void OnEventTest1(string text)
        {
            Debuger.LogError("MainCenterView 监听    EN_test:" + text);
        }

        private void OnClickOutBtn()
        {
        }

        public override void Dispose()
        {
            base.Dispose();
            DisposeEles();
            Debuger.LogWarning("调用 Dispose MainCenterView");
            EventCenter.Instance.UnBind<string>((int)EventEnumHOT.EE_test1, OnEventTest);
            EventCenter.Instance.UnBind<int>((int)EventEnumHOT.EE_loginIn, OnEventLoginIn);
        }

        public void SetData()
        {
        }

        #region UI 各方面的元素
        private main_team_right rightTeam;
        private MainTopEles topEles;
        private MainLeftEles leftEles;
        private FuncListEles funcListEles;

        private void InitEles()
        {
            topEles = (MainTopEles)_topEles;
            topEles.OnInit();

            funcListEles = (FuncListEles)_funcListEles;
            funcListEles.OnInit();
        }

        private void DisposeEles()
        {
            topEles?.Dispose();
            leftEles?.Dispose();
            funcListEles?.Dispose();
            rightTeam?.Dispose();
        }
        #endregion
    }
}