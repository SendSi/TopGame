/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Login
{
    public partial class LoginMainView : GComponent
    {
        public GLoader _bg0;
        public GButton _loginBtn;
        public GImage _inputBg;
        public GTextInput _roleInputTxt;
        public GButton _outInBtn;
        public GGroup _info;
        public GComboBox _languCom;
        public Transition _tMove0;
        public Transition _tMove1;
        public Transition _tMove2;
        public const string URL = "ui://byy9k3ghg8uq1ygcga8";

        public static LoginMainView CreateInstance()
        {
            return (LoginMainView)UIPackage.CreateObject("Login", "LoginMainView");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            _bg0 = (GLoader)GetChild("bg0");
            _loginBtn = (GButton)GetChild("loginBtn");
            _inputBg = (GImage)GetChild("inputBg");
            _roleInputTxt = (GTextInput)GetChild("roleInputTxt");
            _outInBtn = (GButton)GetChild("outInBtn");
            _info = (GGroup)GetChild("info");
            _languCom = (GComboBox)GetChild("languCom");
            _tMove0 = GetTransition("tMove0");
            _tMove1 = GetTransition("tMove1");
            _tMove2 = GetTransition("tMove2");
        }
    }
}