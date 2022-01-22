namespace LiberatorY5
{
    internal class VoidEdge
    {
        //THANK YOU SO MUCH IMAREALPERSON!!
        public static string versionCheck = "3E76BD3";
        public static string versionName = "14303219";
        public static string playlistManager = "05393908";
        public static string firstOffset = "90";
        public static string day_Offset = "05393908,90,38,0";
        public static string oldHereford_Offset = "05396158,68,28,110,D8,60,48,8";
        public static string easyDifficulty_Offset = "05390320,88,110,70,110,60,120,8,160";
        public static string house_Offset = "05393A20,90,180,F8,120,20,120,180,0";
        public static string elim_Offset = "05393A20,108,180,120,68";
        public static string hostage_Offset = "05393A20,120,140,40,E8,40,78";
        private static string playlist = playlistManager + "," + firstOffset;
        public static string r6_daynight = playlist + "38,0";
        public static string r6_map = playlist + "10";
        public static string r6_gamemode = playlist + "8";
        public static string r6_difficulty = playlist + "30";

        // All things is LONG

        //day = day_Offset  |   night  = day + 32L

        //dont think it is, crashed for me
        //easy = easyDifficulty_Offset    |     normal = easy +32L   |      hard = normal + 32L 

        // +32L = "=>" | -32L = "=<" | -1504L = "=)"
        //house = house_Offset
        //house => hereford => plane => university => favela => tower
        //house =) club =< oregon
        //house =) club => yacht => consulate => bank => canal => chalet => cafe => border => skyscraper => coastline => theme => villa => kasbah => outback

        //gamemode
        // +32L = "=>" | -32L = "=<" | +64L = "=)"
        //hostage = house_Offset
        //hostage =< bomb 
        //hostage => secureRoom =) extractHostage => protectHostage => defuseBomb
        //hostage => secureRoom =) extractHostage =) elimination

        //elim = elim_Offset
        //extraction = elim +32L
        //protect = elim +64L
        //disarm = elim +96L

        //tdm = elim +128L
        //canister = elim +160L

        //camTele = elim +192L
        //bombPrepless = elim +288L
        //flyBy = elim +192L
        //explosion = elim +224L

        //stolenShit = elim +352L
        //goldenGun = elim +320L

    }
}
