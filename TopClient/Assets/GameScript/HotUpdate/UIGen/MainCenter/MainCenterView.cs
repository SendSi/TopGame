/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace MainCenter
{
    public partial class MainCenterView : GComponent
    {
        public GGraph _bg;
        public FuncListEles _funcListEles;
        public MainTopEles _topEles;
        public GButton _btnAddMJ;
        public GButton _btnAddDDG;
        public Transition _quit;
        public Transition _approach;
        public Transition _a_personalboss;
        public Transition _a_worldboss;
        public const string URL = "ui://4ni413lalumy1qp8vd6";

        public static MainCenterView CreateInstance()
        {
            return (MainCenterView)UIPackage.CreateObject("MainCenter", "MainCenterView");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            _bg = (GGraph)GetChild("bg");
            _funcListEles = (FuncListEles)GetChild("funcListEles");
            _topEles = (MainTopEles)GetChild("topEles");
            _btnAddMJ = (GButton)GetChild("btnAddMJ");
            _btnAddDDG = (GButton)GetChild("btnAddDDG");
            _quit = GetTransition("quit");
            _approach = GetTransition("approach");
            _a_personalboss = GetTransition("a_personalboss");
            _a_worldboss = GetTransition("a_worldboss");
        }
    }
}