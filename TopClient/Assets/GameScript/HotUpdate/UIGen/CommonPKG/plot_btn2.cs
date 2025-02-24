/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonPKG
{
    public partial class plot_btn2 : GButton
    {
        public Controller _colour_title;
        public Transition _t0;
        public const string URL = "ui://2r331opvg17g1ygcfn7";

        public static plot_btn2 CreateInstance()
        {
            return (plot_btn2)UIPackage.CreateObject("CommonPKG", "plot_btn2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            _colour_title = GetController("colour_title");
            _t0 = GetTransition("t0");
        }
    }
}