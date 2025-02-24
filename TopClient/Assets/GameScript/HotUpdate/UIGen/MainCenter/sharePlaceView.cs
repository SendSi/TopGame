/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace MainCenter
{
    public partial class sharePlaceView : GLabel
    {
        public Controller _state;
        public Controller _type;
        public GComponent _mask;
        public GTextField _titleTxt;
        public GButton _yesButton;
        public GTextField _txtSelectedName;
        public GList _typeList;
        public GButton _unionBtn;
        public GButton _worldBtn;
        public GTextField _coords;
        public GButton _closeButton;
        public GGroup _view1;
        public const string URL = "ui://4ni413laryma1ygcfne";

        public static sharePlaceView CreateInstance()
        {
            return (sharePlaceView)UIPackage.CreateObject("MainCenter", "sharePlaceView");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            _state = GetController("state");
            _type = GetController("type");
            _mask = (GComponent)GetChild("mask");
            _titleTxt = (GTextField)GetChild("titleTxt");
            _yesButton = (GButton)GetChild("yesButton");
            _txtSelectedName = (GTextField)GetChild("txtSelectedName");
            _typeList = (GList)GetChild("typeList");
            _unionBtn = (GButton)GetChild("unionBtn");
            _worldBtn = (GButton)GetChild("worldBtn");
            _coords = (GTextField)GetChild("coords");
            _closeButton = (GButton)GetChild("closeButton");
            _view1 = (GGroup)GetChild("view1");
        }
    }
}