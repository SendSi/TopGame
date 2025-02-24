/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace MainCenter
{
    public partial class CityViewInfo : GComponent
    {
        public Controller _belong;
        public GLabel _place;
        public GLabel _defense;
        public GLabel _production;
        public GLabel _influence;
        public GComponent _player;
        public GLabel _alliance;
        public GGroup _info;
        public const string URL = "ui://4ni413laubhvke";

        public static CityViewInfo CreateInstance()
        {
            return (CityViewInfo)UIPackage.CreateObject("MainCenter", "CityViewInfo");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            _belong = GetController("belong");
            _place = (GLabel)GetChild("place");
            _defense = (GLabel)GetChild("defense");
            _production = (GLabel)GetChild("production");
            _influence = (GLabel)GetChild("influence");
            _player = (GComponent)GetChild("player");
            _alliance = (GLabel)GetChild("alliance");
            _info = (GGroup)GetChild("info");
        }
    }
}