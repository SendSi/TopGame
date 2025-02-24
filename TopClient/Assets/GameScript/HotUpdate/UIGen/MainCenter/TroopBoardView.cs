/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace MainCenter
{
    public partial class TroopBoardView : GComponent
    {
        public Controller _lineStateCtrl;
        public GGraph _arrowObj;
        public GComponent _childRoot;
        public const string URL = "ui://4ni413lag1s71qp8vhk";

        public static TroopBoardView CreateInstance()
        {
            return (TroopBoardView)UIPackage.CreateObject("MainCenter", "TroopBoardView");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            _lineStateCtrl = GetController("lineStateCtrl");
            _arrowObj = (GGraph)GetChild("arrowObj");
            _childRoot = (GComponent)GetChild("childRoot");
        }
    }
}