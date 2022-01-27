﻿using System;
using System.Collections.Generic;
using System.Linq;

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
        public static string house_Offset = "053a6868,C18,210,10,3C0,A48,0,C18,D78,F30,530"; //need to reverse  more :/ below and up
        public static string elim_Offset = "05393A20,108,180,120,68";
        public static string hostage_Offset = "05393A20,120,140,40,E8,40,78";
        private static string playlist = playlistManager + "," + firstOffset;
        public static string r6_daynight = playlist + ",38,0";
        public static string r6_map = playlist + ",10";
        public static string r6_gamemode = playlist + ",8";
        public static string r6_difficulty = playlist + ",30";

        public static string[] EventView_Tag = { "goldengun", "grandlarceny",};
        public static string[] EventView = {"Golden Gun", "Grand Larceny" };
        #region idk
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
        #endregion
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
        public static void GameModeConverter(string ModeName,string ParentMode,long house, long gamemode, long elim, out long output_mode,out long difficulty,out long outmap)
        {
            output_mode = gamemode;
            difficulty = elim;
            outmap = house;
            var difss = new[] { "normal", "hard", "realistic" };
            var modes = new[] { "hostage", "secure", "bomb", "warmup", "goldengun", "bombnoprep" };
            if (ParentMode == ModeName)
            {
                logs.WriteLog(ParentMode + "=" + ModeName);
                switch (ParentMode)
                {
                    case "Multiplayer":
                        ModeConverter(RandomMode(), gamemode, elim, out output_mode, out bool isTHM);
                        return;
                    case "TerroristHunt":
                        ModeConverter(RandomDifficulty(), gamemode, elim, out difficulty, out bool isTH);
                        return;
                    case "Situations":
                        //NOT DOING RANDOM SITUATION!
                        return;
                    case "Matchmaking":
                        MatchMaking(RandomMM(), RandomModeMM(), house, gamemode, elim, out output_mode, out outmap, out bool isTHMM);
                        return;
                    case "Random":
                        MatchMaking(RandomMM(), RandomModeWithDiff(), house, gamemode, elim, out long new_output_mode, out outmap, out bool isTHR);
                        if (isTHR) { difficulty = new_output_mode; } else { output_mode = new_output_mode; }
                        return;
                    default:
                        return;
                }
            }
            else if (difss.Any(ModeName.Contains))
            {
                ModeConverter(ModeName, gamemode, elim, out difficulty, out bool isTH);
                logs.WriteLog(ModeName);

            }
            else if (modes.Any(ModeName.Contains))
            {
                ModeConverter(ModeName, gamemode, elim, out output_mode, out bool isTH);
                logs.WriteLog(ModeName);

            }
            //soon
        }
        private static void ModeConverter(string mode,long gamemode,long elim,out long outmode, out bool isTH)
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
                    outmode = elim + 128L;
                    return;
                case "goldengun":
                    outmode = elim + 320L;
                    return;
                case "bombnoprep":
                    outmode = elim + 288L;
                    return;
                case "grandlarceny":
                    outmode = gamemode + 328640L;
                    return;
                case "protect":
                    outmode = gamemode + 128L; //32L + 64L + 32L
                    isTH = true;
                    return;
                case "extract":
                    outmode = gamemode + 96L; //32L + 64L
                    isTH = true;
                    return;
                case "elimination":
                    outmode = elim;
                    isTH = true;
                    return;
                case "disarm":
                    outmode = gamemode + 160L; //32L + 64L + 32L + 32L
                    isTH = true;
                    return;
                default:
                    return;

            }
        }
        private static void MatchMaking(string CasOrRanked,string mode,long house,long gamemode,long elim,out long outmode, out long outmap, out bool isTH) 
        {
            outmode = 0L;
            outmap = 0L;
            isTH = false;
            if (CasOrRanked == "Casual")
            {
                ModeConverter(mode,gamemode, elim, out outmode, out isTH);
                MapConverter(RandomMap(0), house, out outmap);
            }
            if (CasOrRanked == "Ranked")
            {
                ModeConverter(mode, gamemode,elim, out outmode, out isTH);
                MapConverter(RandomMap(1), house, out outmap);
            }
        }
        private static string RandomMap(int casorranked)
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
            logs.WriteLog("Random Map: " + map);
            return map;
        }
        private static string RandomMode()
        {
            Random rnd = new Random();
            string modes = "hostage,secure,bomb,warmup,goldengun,bombnoprep";
            int numb = rnd.Next(0, 5);
            string[] splittedmaps = modes.Split(',');
            string mode = splittedmaps[numb];
            logs.WriteLog("Random Mode: " + mode);
            return mode;
        }
        private static string RandomModeWithDiff()
        {
            Random rnd = new Random();
            string modes = "hostage,secure,bomb,warmup,goldengun,bombnoprep,normal,hard,realistic";
            int numb = rnd.Next(0, 8);
            string[] splittedmaps = modes.Split(',');
            string mode = splittedmaps[numb];
            return mode;
        }
        private static string RandomModeMM()
        {
            Random rnd = new Random();
            string modes = "hostage,secure,bomb";
            int numb = rnd.Next(0, 2);
            string[] splittedmaps = modes.Split(',');
            string mode = splittedmaps[numb];
            return mode;
        }
        private static string RandomDifficulty()
        {
            Random rnd = new Random();
            string diffs = "normal,hard,realistic";
            int numb = rnd.Next(0, 2);
            string[] splittedmaps = diffs.Split(',');
            string diff = splittedmaps[numb];
            return diff;
        }
        private static string RandomMM()
        {
            Random rnd = new Random();
            string diffs = "Casual,Ranked";
            int numb = rnd.Next(0, 1);
            string[] splittedmaps = diffs.Split(',');
            string diff = splittedmaps[numb];
            return diff;
        }
    }
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
}
