using System;

namespace LiberatorY5
{
    internal class VoidEdge
    {
        //THANK YOU SO MUCH IMAREALPERSON!!
        public static string FuillBuildID = "Y5S1.2.0.1_C5183038_D967006_S37789_14303219";
        public static string versionCheck = "3E76BD3";
        public static string versionName = "14303219";
        public static string playlistManager = "05393908";
        public static string firstOffset = "90";
        public static string day_Offset = "05393908,90,38,0"; //thats probably some issue somewhen
        public static string oldHereford_Offset = "05396158,68,28,110,D8,60,48,8";
        public static string easyDifficulty_Offset = "05390320,88,110,70,110,60,120,8,160";
        public static string house_Offset = "05393A20,90,180,F8,120,20,120,180,0";
        public static string elim_Offset = "05393A20,108,180,120,68";
        public static string hostage_Offset = "05393A20,120,140,40,E8,40,78";
        private static string playlist = playlistManager + "," + firstOffset;
        public static string r6_daynight = playlist + ",38,0";
        public static string r6_map = playlist + ",10";
        public static string r6_gamemode = playlist + ",8";
        public static string r6_difficulty = playlist + ",30";

        // All things is LONG

        //day = day_Offset  |   night  = day + 32L

        //dont think it is, crashed for me
        //easy = easyDifficulty_Offset    |     normal = easy +32L   |      hard = normal + 32L 

        // +32L = "=>" | -32L = "=<" | -1504L = "=)"
        //house = house_Offset
        //house => hereford => plane => university => favela => tower
        //house =) club =< oregon
        //house =) club => yacht => consulate => bank => canal => chalet => cafe => border => skyscraper => coastline => theme => villa => kasbah => outback
        //house +1752798400L = grandlarceny map

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

        public long canisterL = 160L;
        public long camTeleL = 192L;
        public long bombPreplessL = 288L;
        public long flyByL = 192L;
        public long explosioneL = 224L;
        public long stolenL = 352L;
        public long goldenGunL = 320L;

        public static void MapConverter(string MapName, long house, out long output)
        {
            memoryHelper mh = new memoryHelper();
            output = 0L;
            if (MapName != "house")
            {
                switch (MapName)
                {
                    case "hereford":
                        output = house + mh.plus64;
                        return;
                    case "plane":
                        output = house + mh.plus64 + mh.plus64;
                        return;
                    case "university":
                        output = house + mh.plus64 + mh.plus64 + mh.plus64;
                        return;
                    case "favela":
                        output = house + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64;
                        return;
                    case "tower":
                        output = house + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64;
                        return;
                    case "club":
                        output = house - mh.big;
                        return;
                    case "oregon":
                        output = house - mh.big + mh.min32;
                        return;
                    case "yacht":
                        output = house - mh.big + mh.plus64;
                        return;
                    case "consulate":
                        output = house - mh.big + mh.plus64 + mh.plus64;
                        return;
                    case "bank":
                        output = house - mh.big + mh.plus64 + mh.plus64 + mh.plus64;
                        return;
                    case "kanal":
                        output = house - mh.big + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64;
                        return;
                    case "chalet":
                        output = house - mh.big + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64;
                        return;
                    case "cafe":
                        output = house - mh.big + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64;
                        return;
                    case "border":
                        output = house - mh.big + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64;
                        return;
                    case "skyscraper":
                        output = house - mh.big + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64;
                        return;
                    case "coastline":
                        output = house - mh.big + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64;
                        return;
                    case "theme":
                        output = house - mh.big + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64;
                        return;
                    case "villa":
                        output = house - mh.big + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64;
                        return;
                    case "fortress":
                        output = house - mh.big + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64;
                        return;
                    case "outback":
                        output = house - mh.big + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64 + mh.plus64;
                        return;
                    case "grandlarceny":
                        output = house + 1752798400L;
                        return;
                    case "oldhereford":
                        return;
                    default:
                        return;
                }
            }
            else
            {
                output = house;
            }
        }
        public static void EventConverter(string EventName, long house, long gamemode, out long output_map, out long output_mode)
        {
            output_map = 0L;
            output_mode = 0L;
            switch (EventName)
            {
                case "grandlarceny":
                    output_map = house + 1752798400L;
                    output_mode = gamemode + 328640L;
                    return;
                case "goldengun":
                    output_map = house + 1752798400L;
                    output_mode = gamemode + 328640L - 32L;
                    return;
                default:
                    return;
            }
        }
        public static void GameModeConverter(string ModeName,string ParentMode, long gamemode, long elim, out long output_mode,out long difficulty)
        {
            output_mode = 0L;
            difficulty = 0L;
            //soon
        }
        public static void MatchMaking(string CasOrRanked,string mode,long house,long gamemode,out long outmode, out long outmap) 
        {
            outmode = 0L;
            outmap = 0L;
            if (CasOrRanked == "Casual")
            {
                switch (mode)
                {
                    case "hostage":
                        outmode = gamemode;
                        MapConverter(RandomMap(0),house,out outmap);
                        return;
                    case "secure":
                        outmode = gamemode + 32L;
                        MapConverter(RandomMap(0), house, out outmap);
                        return;
                    case "bomb":
                        outmode = gamemode - 32L;
                        MapConverter(RandomMap(0), house, out outmap);
                        return;
                    default:
                        return;
                }
            }
            if (CasOrRanked == "Ranked")
            {
                switch (mode)
                {
                    case "hostage":
                        outmode = gamemode;
                        MapConverter(RandomMap(1), house, out outmap);
                        return;
                    case "secure":
                        outmode = gamemode + 32L;
                        MapConverter(RandomMap(1), house, out outmap);
                        return;
                    case "bomb":
                        outmode = gamemode - 32L;
                        MapConverter(RandomMap(1), house, out outmap);
                        return;
                    default:
                        return;
                }
            }
        }
        public static string RandomMap(int casorranked)
        {
            string map = null;
            Random rnd = new Random();
            int maxmap = 20;
            string maps = null;
            if (casorranked == 0)
            {
                maps = "house,hereford,plane,university,favela,tower,club,oregon,yacht,consulate,bank,kanal,chalet,cafe,border,skyscraper,coastline,theme,villa,fortress,outback";
                maxmap = 20;
            }
            if (casorranked == 1)
            {
                maps = "consulate,chalet,border,club,outback,theme,oregon,villa,kafe,kanal,bank,coastline";
                maxmap = 11;
            }
            
            int numb = rnd.Next(0, maxmap);
            string[] splittedmaps = maps.Split(',');
            map = splittedmaps[numb];
            return map;
        }
    }
}
