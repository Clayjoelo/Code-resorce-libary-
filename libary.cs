namespace name 
{
    class Data 
    {
        public string name;
        // a link is needed for the website or whatever
        public string link;
        // have the limited to langs, also have a option for just everything like just general info and stuff
        public string lang;
        // a discription of what its used for
        public string dis;
        // set it a still level by. "noob" "intermediate" "GOD" lol
        public string skill;
        public string maker;

        public Data(string aName, string aLink, string aLang, string aDis, string aSkill, string aMaker)
        {
            name = aName;
            link = aLink;
            lang = aLang;
            dis = aDis;
            skill = aSkill;
            maker = aMaker;
        }
    }
}
