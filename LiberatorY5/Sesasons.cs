using System;
using System.Collections.Generic;
using System.Linq;

namespace LiberatorY5
{
    #region Void Edge
    internal class VoidEdge
    {
        //THANK YOU SO MUCH IMAREALPERSON!!
        public static string FuillBuildID = "Y5S1.2.0.1_C5183038_D967006_S37789_14303219";
        public static string versionCheck = "3E76BD3";
        public static string versionName = "14303219";
        public static string playlistManager = "05393908";
        public static string firstOffset = "90";
        public static string day_Offset = "05393908,90,38,0"; //thats probably some issue somewhen
        public static string oldHereford_Offset = "053A6868,158,308,D8,420,F0,148,0,6C0,0,0,38,D8";
        public static string easyDifficulty_Offset = "060894D8,28,0,58,90,40,10,A0,60,40,170,290,160";
        public static string house_Offset = "053A6868,C18,210,10,3C0,A48,0,C18,D78,F30,530";
        public static string hostage_Offset = "060894D8,20,228,28,40,50,0,160,40,28,590";
        private static string playlist = playlistManager + "," + firstOffset;
        public static string r6_daynight = playlist + ",38,0";
        public static string r6_map = playlist + ",10";
        public static string r6_gamemode = playlist + ",8";
        public static string r6_difficulty = playlist + ",30";

        public static string[] EventView_Tag = { "goldengun", "grandlarceny",};
        public static string[] EventView = {"Golden Gun", "Grand Larceny" };
        public static void MapConverter(string MapName, long house, out long output)
        {
            output = 0L;
            if (MapName != "house")
            {
                switch (MapName)
                {
                    case "hereford":
                        output = house + 32;
                        return;
                    case "plane":
                        output = house + 64;
                        return;
                    case "university":
                        output = house + 96;
                        return;
                    case "favela":
                        output = house + 128;
                        return;
                    case "tower":
                        output = house + 160;
                        return;
                    case "club":
                        output = house - 1504;
                        return;
                    case "oregon":
                        output = house - 1536;
                        return;
                    case "yacht":
                        output = house - 1472;
                        return;
                    case "consulate":
                        output = house - 1440;
                        return;
                    case "bank":
                        output = house - 1408;
                        return;
                    case "kanal":
                        output = house - 1376;
                        return;
                    case "chalet":
                        output = house - 1344;
                        return;
                    case "cafe":
                        output = house - 1312;
                        return;
                    case "border":
                        output = house - 1280;
                        return;
                    case "skyscraper":
                        output = house - 1248;
                        return;
                    case "coastline":
                        output = house - 1216;
                        return;
                    case "theme":
                        output = house - 1184;
                        return;
                    case "villa":
                        output = house - 1152;
                        return;
                    case "fortress":
                        output = house - 1120;
                        return;
                    case "outback":
                        output = house - 1088;
                        return;
                    case "grandlarceny":
                        output = house - 345011712;
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
                    output_map = house - 345011712;
                    output_mode = gamemode + 328640;
                    return;
                case "goldengun":
                    output_map = house - 1536; //goldengun only oregon? Need make random for most goldengun maps
                    output_mode = gamemode + 328608;
                    return;
                default:
                    return;
            }
        }
        public static void GameModeConverter(string ModeName,string ParentMode,long house, long gamemode,long diffmode, out long output_mode,out long difficulty,out long outmap)
        {
            output_mode = gamemode;
            difficulty = diffmode;
            outmap = 0L;
            var difss = new[] { "normal", "hard", "realistic" };
            var modes = new[] { "hostage", "secure", "bomb", "warmup", "goldengun", "bombnoprep" };
            if (ParentMode == ModeName)
            {
                logs.WriteLog(ParentMode + "=" + ModeName);
                switch (ParentMode)
                {
                    case "Multiplayer":
                        ModeConverter(Randomizer.RandomMode(), gamemode, out output_mode, out bool isTHM);
                        return;
                    case "TerroristHunt":
                        ModeConverter(Randomizer.RandomDifficulty(), gamemode, out difficulty, out bool isTH);
                        return;
                    case "Situations":
                        //NOT DOING RANDOM SITUATION!
                        return;
                    case "Matchmaking":
                        MatchMaking(Randomizer.RandomMM(), Randomizer.RandomModeMM(), house, gamemode, out output_mode, out outmap, out bool isTHMM);
                        return;
                    case "Random":
                        MatchMaking(Randomizer.RandomMM(), Randomizer.RandomMode(), house, gamemode, out long new_output_mode, out outmap, out bool isTHR);
                        if (isTHR) { difficulty = new_output_mode; } else { output_mode = new_output_mode; }
                        return;
                    default:
                        return;
                }
            }
            else if (difss.Any(ModeName.Contains))
            {
                ModeConverter(ParentMode, gamemode, out output_mode, out bool isTH);
                DiffConverter(ModeName, diffmode, out difficulty);
                logs.WriteLog(ModeName);

            }
            if (ModeName == "bombnoprep")
            {
                ModeConverter("bombnoprep", gamemode, out output_mode, out bool isTH);
                DiffConverter("normal", diffmode, out difficulty);
                logs.WriteLog(ModeName);
                return;

            }
            else if (modes.Any(ModeName.Contains))
            {
                ModeConverter(ModeName, gamemode, out output_mode, out bool isTH);
                logs.WriteLog(ModeName);

            }
            //soon
        }

        //Private
        private static void ModeConverter(string mode,long gamemode,out long outmode, out bool isTH)
        {
            outmode = 0L;
            isTH = false;
            switch (mode)
            {
                case "hostage":
                    outmode = gamemode;
                    return;
                case "secure":
                    outmode = gamemode + 32L;
                    return;
                case "bomb":
                    outmode = gamemode - 32L;
                    return;
                case "warmup":
                    outmode = gamemode + 328416;
                    return;
                case "goldengun":
                    outmode = gamemode + 328608;
                    return;
                case "canister":
                    outmode = gamemode + 328448;
                    return;
                case "bombnoprep":
                    outmode = gamemode + 328576;
                    return;
                case "grandlarceny":
                    outmode = gamemode + 328640;
                    return;
                case "protect":
                    outmode = gamemode + 128;
                    isTH = true;
                    return;
                case "extract":
                    outmode = gamemode + 96;
                    isTH = true;
                    return;
                case "elimination":
                    outmode = gamemode + 192;
                    isTH = true;
                    return;
                case "disarm":
                    outmode = gamemode + 160;
                    isTH = true;
                    return;
                default:
                    return;

            }
        }
        private static void DiffConverter(string diffname, long diff, out long difficulty)
        {
            difficulty = diff;
            switch (diffname)
            {
                case "normal":
                    difficulty = diff;
                    return;
                case "hard":
                    difficulty = diff + 32;
                    return;
                case "realistic":
                    difficulty = diff + 60576;
                    return;
                default:
                    return;
            }
        }
        private static void MatchMaking(string CasOrRanked,string mode,long house,long gamemode,out long outmode, out long outmap, out bool isTH) 
        {
            outmode = 0L;
            outmap = 0L;
            isTH = false;
            if (CasOrRanked == "Casual")
            {
                ModeConverter(mode,gamemode, out outmode, out isTH);
                MapConverter(Randomizer.RandomMap(0,0), house, out outmap);
            }
            if (CasOrRanked == "Ranked")
            {
                ModeConverter(mode, gamemode, out outmode, out isTH);
                MapConverter(Randomizer.RandomMap(1,0), house, out outmap);
            }
        }

    }
    #endregion
    #region Steel Wave
    internal class SteelWave
    {
        public static string FuillBuildID = "Y5S2";
        public static string versionCheck = "";
        public static string versionName = "";
        public static string playlistManager = "065370E0"; //or 603DD10
        public static string firstOffset = "60"; //or F8
        public static string day_Offset = "";
        public static string oldHereford_Offset = "";
        public static string easyDifficulty_Offset = "";
        public static string house_Offset = "065370E0,38,C68,E8,890,B00,1A0,430";
        public static string elim_Offset = "065370E0,60,C8,28,0,28,0,5D0";
        public static string hostage_Offset = "065370E0,60,C8,28,0,28,0,5B0";
        private static string playlist = playlistManager + "," + firstOffset;
        public static string r6_daynight = playlist + ",38,0";
        public static string r6_map = playlist + ",10";
        public static string r6_gamemode = playlist + ",8";
        public static string r6_difficulty = playlist + ",30";
        /*
  public static ulong ulong_0 = 100916496;
  public static ulong ulong_1 = 89380200;
  public static ulong ulong_2 = 26340099;
  public static ulong ulong_3 = 23008441;
  public static ulong ulong_4 = 23551034;
  public static ulong ulong_5 = 23492219;
  public static ulong ulong_6 = 89503312;

         */
    }
    #endregion
    #region Shadow Legacy
    internal class ShadowLegacy
    {
        public static string FuillBuildID = "Y5S3";
        public static string versionCheck = "";
        public static string versionName = "";
        public static string playlistManager = "06E90BC0"; //or 06E3D4A0
        public static string firstOffset = "130"; //or 100
        public static string day_Offset = "";
        public static string oldHereford_Offset = "";
        public static string easyDifficulty_Offset = "";
        public static string house_Offset = "";
        public static string elim_Offset = "";
        public static string hostage_Offset = "";
        private static string playlist = playlistManager + "," + firstOffset;
        public static string r6_daynight = playlist + ",38,0";
        public static string r6_map = playlist + ",10";
        public static string r6_gamemode = playlist + ",8";
        public static string r6_difficulty = playlist + ",30";
    }
    #endregion
    #region Randoms
    class Randomizer
    {
        public static string RandomMap(int casorranked,int version)
        {
            //version 0 = Void Edge, 1 = Steel Wave, 2 = Shadow Legacy , etc
            string map = null;
            Random rnd = new Random();
            int maxmap = 20;
            string maps = null;
            if (version == 0)
            {
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
                if (casorranked == 3) //goldengun
                {
                    maps = "house,oregon,border,coastline"; //?
                    maxmap = 11;
                }
            }

            int numb = rnd.Next(0, maxmap);
            string[] splittedmaps = maps.Split(',');
            map = splittedmaps[numb];
            logs.WriteLog("Random Map: " + map);
            return map;
        }
        public static string RandomMode()
        {
            Random rnd = new Random();
            string modes = "hostage,secure,bomb,warmup,goldengun,bombnoprep";
            int numb = rnd.Next(0, 5);
            string[] splittedmaps = modes.Split(',');
            string mode = splittedmaps[numb];
            logs.WriteLog("Random Mode: " + mode);
            return mode;
        }
        public static string RandomModeMM()
        {
            Random rnd = new Random();
            string modes = "hostage,secure,bomb";
            int numb = rnd.Next(0, 2);
            string[] splittedmaps = modes.Split(',');
            string mode = splittedmaps[numb];
            logs.WriteLog("Random Mode (MM): " + mode);
            return mode;
        }
        public static string RandomDifficulty()
        {
            Random rnd = new Random();
            string diffs = "normal,hard,realistic";
            int numb = rnd.Next(0, 2);
            string[] splittedmaps = diffs.Split(',');
            string diff = splittedmaps[numb];
            logs.WriteLog("Random Diff" + diff);
            return diff;
        }
        public static string RandomMM()
        {
            Random rnd = new Random();
            string diffs = "Casual,Ranked";
            int numb = rnd.Next(0, 1);
            string[] splittedmaps = diffs.Split(',');
            string diff = splittedmaps[numb];
            logs.WriteLog("Random (MM): " + diff);
            return diff;
        }
    }
    #endregion
}
