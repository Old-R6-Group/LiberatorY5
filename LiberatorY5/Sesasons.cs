using System;
using System.Linq;

namespace LiberatorY5
{
    #region Void Edge
    internal class VoidEdge_Shey
    {
        //THANK YOU SO MUCH IMAREALPERSON!!
        public static string FuillBuildID = "Y5S1.2.0.1_C5183038_D967006_S37789_14303219";
        public static string BuildID_Check = "053CF449";
        public static string playlistManager = "05393908";
        public static string firstOffset = "90";
        public static string day_Offset = "053A6868,C18,1E0,950,40,7C8,4E8";
        public static string oldHereford_Offset = "053A6868,158,308,D8,420,F0,148,0,6C0,0,0,38,D8";
        public static string easyDifficulty_Offset = "060894D8,28,0,58,90,40,10,A0,60,40,170,290,160";
        public static string house_Offset = "053A6868,C18,210,10,3C0,A48,0,C18,D78,F30,530"; //this cannot read when loading up!
        public static string hostage_Offset = "060894D8,20,228,28,40,50,0,160,40,28,590";
        private static string playlist = playlistManager + "," + firstOffset;
        public static string r6_daynight = playlist + ",38,0";
        public static string r6_map = playlist + ",10";
        public static string r6_gamemode = playlist + ",8";
        public static string r6_difficulty = playlist + ",30";
        public static string gamestate = "05393908,F0";

        public static string[] EventView_Tag = { "goldengun", "grandlarceny" };
        public static string[] EventView = { "Golden Gun", "Grand Larceny" };
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
        public static void GameModeConverter(string ModeName, string ParentMode, long house, long gamemode, long diffmode, out long output_mode, out long difficulty, out long outmap)
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
        }
        private static void ModeConverter(string mode, long gamemode, out long outmode, out bool isTH)
        {
            outmode = 0L;
            isTH = false;
            switch (mode)
            {
                case "hostage":
                    outmode = gamemode;
                    return;
                case "secure":
                    outmode = gamemode + 32;
                    return;
                case "bomb":
                    outmode = gamemode - 32;
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
        private static void MatchMaking(string CasOrRanked, string mode, long house, long gamemode, out long outmode, out long outmap, out bool isTH)
        {
            outmode = 0L;
            outmap = 0L;
            isTH = false;
            if (CasOrRanked == "Casual")
            {
                ModeConverter(mode, gamemode, out outmode, out isTH);
                MapConverter(Randomizer.RandomMap(0, 0), house, out outmap);
            }
            if (CasOrRanked == "Ranked")
            {
                ModeConverter(mode, gamemode, out outmode, out isTH);
                MapConverter(Randomizer.RandomMap(1, 0), house, out outmap);
            }
        }
    }
    internal class VoidEdge_MU
    {
        //Soon will support all things
        public static string FuillBuildID = "Y5S1.2.0.2_C5218952_D973190_S37789_14335319";
        public static string BuildID_Check = "03E8B810";
        public static string playlistManager = "053AC048";
        public static string firstOffset = "90";
        public static string day_Offset = "053AC048,200,2F8,798"; //FUCKING AWESOME POINTER! after 7 restart still doing the best!!
        //public static string oldHereford_Offset = "";
        public static string easyDifficulty_Offset = "053AC048,200,2F8,A38,20,18,C68";
        public static string house_Offset = "053AC048,110,380,258,BC8,FA8";
        public static string hostage_Offset = "053AC048,4D8,160,C00,9C8,528,F90";
        private static string playlist = playlistManager + "," + firstOffset;
        public static string r6_daynight = playlist + ",38,0";
        public static string r6_map = playlist + ",10";
        public static string r6_gamemode = playlist + ",8";
        public static string r6_difficulty = playlist + ",30";
        public static string gamestate = "053AC048,F0";

        public static string[] EventView_Tag = { "goldengun", "grandlarceny" };
        public static string[] EventView = { "Golden Gun", "Grand Larceny" };
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
                        output = house - 339371328;
                        return;
                    case "oldhereford":
                        output = house - 339368128;
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
                    output_map = house - 339371328;
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
        public static void GameModeConverter(string ModeName, string ParentMode, long house, long gamemode, long diffmode, out long output_mode, out long difficulty, out long outmap)
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
        }
        private static void ModeConverter(string mode, long gamemode, out long outmode, out bool isTH)
        {
            outmode = 0L;
            isTH = false;
            switch (mode)
            {
                case "hostage":
                    outmode = gamemode;
                    return;
                case "secure":
                    outmode = gamemode + 32;
                    return;
                case "bomb":
                    outmode = gamemode - 32;
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
        private static void MatchMaking(string CasOrRanked, string mode, long house, long gamemode, out long outmode, out long outmap, out bool isTH)
        {
            outmode = 0L;
            outmap = 0L;
            isTH = false;
            if (CasOrRanked == "Casual")
            {
                ModeConverter(mode, gamemode, out outmode, out isTH);
                MapConverter(Randomizer.RandomMap(0, 0), house, out outmap);
            }
            if (CasOrRanked == "Ranked")
            {
                ModeConverter(mode, gamemode, out outmode, out isTH);
                MapConverter(Randomizer.RandomMap(1, 0), house, out outmap);
            }
        }
    }
    #endregion
    #region Steel Wave
    internal class SteelWave
    {
        public static string FuillBuildID = "Y5S2.3.1.1pc_C5493616_D1043836_S38774_14664131";
        public static string BuildID_Check = "5051700";
        public static string playlistManager = "603DD10";
        public static string firstOffset = "F8";
        public static string day_Offset = "0603DD10,128,DC0,6B0,C60,230,C98";
        public static string oldHereford_Offset = "0603DD10,248,E48,D60,18,910,A28";
        public static string easyDifficulty_Offset = "0603DD10,248,7F0,940,E88,190,A68";
        public static string house_Offset = "0603DD10,248,E28,DB0,ED8,2A0,4F0";
        public static string hostage_Offset = "0603DD10,248,E28,1D0,FB0,A0,FC8";
        private static string playlist = playlistManager + "," + firstOffset;
        public static string r6_daynight = playlist + ",38,0";
        public static string r6_map = playlist + ",10";
        public static string r6_gamemode = playlist + ",8";
        public static string r6_difficulty = playlist + ",30";
        public static string gamestate = "603DD10,114";

        public static string[] EventView_Tag = { "goldengun", "mute", "attrition" };
        public static string[] EventView = { "Golden Gun", "MUTE Protocol", "Attrition" };

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
                        output = house - 1472;
                        return;
                    case "university":
                        output = house + 64;
                        return;
                    case "favela":
                        output = house + 96;
                        return;
                    case "tower":
                        output = house - 1184;
                        return;
                    case "club":
                        output = house - 1504;
                        return;
                    case "oregon":
                        output = house - 1536;
                        return;
                    case "yacht":
                        output = house - 1440;
                        return;
                    case "consulate":
                        output = house - 1408;
                        return;
                    case "bank":
                        output = house - 1376;
                        return;
                    case "kanal":
                        output = house - 1344;
                        return;
                    case "chalet":
                        output = house - 1088;
                        return;
                    case "cafe":
                        output = house - 1312;
                        return;
                    case "border":
                        output = house - 1280;
                        return;
                    case "skyscraper":
                        output = house + 128;
                        return;
                    case "coastline":
                        output = house - 1248;
                        return;
                    case "theme":
                        output = house - 1216;
                        return;
                    case "villa":
                        output = house - 1152;
                        return;
                    case "fortress":
                        output = house + 160;
                        return;
                    case "outback":
                        output = house - 1120;
                        return;
                    case "mute":
                        output = house + 192;
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
                case "mute":
                    output_map = house - 192;
                    output_mode = gamemode + 345152;
                    return;
                case "attrition":
                    output_map = house - 1248;
                    output_mode = gamemode + 345184;
                    return;
                case "goldengun":
                    output_map = house - 1536; //goldengun only oregon? Need make random for most goldengun maps
                    output_mode = gamemode + 345088;
                    return;
                default:
                    return;
            }
        }
        public static void GameModeConverter(string ModeName, string ParentMode, long house, long gamemode, long diffmode, out long output_mode, out long difficulty, out long outmap)
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
        }
        private static void ModeConverter(string mode, long gamemode, out long outmode, out bool isTH)
        {
            outmode = 0L;
            isTH = false;
            switch (mode)
            {
                case "hostage":
                    outmode = gamemode;
                    return;
                case "secure":
                    outmode = gamemode + 32;
                    return;
                case "bomb":
                    outmode = gamemode - 32;
                    return;
                case "warmup":
                    outmode = gamemode + 344896;
                    return;
                case "goldengun":
                    outmode = gamemode + 345088;
                    return;
                case "bombnoprep":
                    outmode = gamemode + 345056;
                    return;
                case "mute":
                    outmode = gamemode + 345152;
                    return;
                case "attrition":
                    outmode = gamemode + 345184;
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
                    difficulty = diff + 62336;
                    return;
                default:
                    return;
            }
        }
        private static void MatchMaking(string CasOrRanked, string mode, long house, long gamemode, out long outmode, out long outmap, out bool isTH)
        {
            outmode = 0L;
            outmap = 0L;
            isTH = false;
            if (CasOrRanked == "Casual")
            {
                ModeConverter(mode, gamemode, out outmode, out isTH);
                MapConverter(Randomizer.RandomMap(0, 1), house, out outmap);
            }
            if (CasOrRanked == "Ranked")
            {
                ModeConverter(mode, gamemode, out outmode, out isTH);
                MapConverter(Randomizer.RandomMap(1, 1), house, out outmap);
            }
        }
    }
    #endregion
    #region Shadow Legacy
    internal class ShadowLegacy_Global
    {
        public static string FuillBuildID = "Y5S3.3.1_C5789341_D1135607_S40332_15018155";
        public static string BuildID_Check = "56B4130";
        public static string playlistManager = "06E3FF30";
        public static string firstOffset = "68";
        public static string day_Offset = "06E3FF30,1E8,C8,18,C8,608";
        public static string easyDifficulty_Offset = "06E3FF30,2E0,270,20,A50,C50";
        public static string house_Offset = "06E3FF30,2E0,F98,BA8,3C0,BC0,5A0";
        public static string hostage_Offset = "06E3FF30,2E0,958,D0,D8,6E8";
        private static string playlist = playlistManager + "," + firstOffset;
        public static string r6_daynight = playlist + ",38,0";
        public static string r6_map = playlist + ",10";
        public static string r6_gamemode = playlist + ",8";
        public static string r6_difficulty = playlist + ",30";
        public static string gamestate = "06E3FF30,50";

        public static string[] EventView_Tag = { "goldengun", "legacy", "sugarfright" };
        public static string[] EventView = { "Golden Gun", "Legacy Event", "Sugar Fright" };
        public static void MapConverter(string MapName, long house, out long output)
        {
            output = 0L;
            if (MapName != "house")
            {
                switch (MapName)
                {
                    case "hereford":
                        output = house + 64;
                        return;
                    case "plane":
                        output = house + 128;
                        return;
                    case "university":
                        output = house + 320;
                        return;
                    case "favela":
                        output = house + 416;
                        return;
                    case "tower":
                        output = house + 544;
                        return;
                    case "club":
                        output = house + 96;
                        return;
                    case "oregon":
                        output = house + 32;
                        return;
                    case "yacht":
                        output = house + 160;
                        return;
                    case "consulate":
                        output = house + 192;
                        return;
                    case "bank":
                        output = house + 224;
                        return;
                    case "kanal":
                        output = house + 256;
                        return;
                    case "chalet":
                        output = house + 288;
                        return;
                    case "cafe":
                        output = house + 352;
                        return;
                    case "border":
                        output = house + 384;
                        return;
                    case "skyscraper":
                        output = house + 448;
                        return;
                    case "coastline":
                        output = house + 480;
                        return;
                    case "theme":
                        output = house + 512;
                        return;
                    case "villa":
                        output = house + 576;
                        return;
                    case "fortress":
                        output = house + 608;
                        return;
                    case "outback":
                        output = house + 640;
                        return;
                    case "sugarfright":
                        output = house + 672;
                        return;
                    case "oldhereford":
                        output = house + 704;
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
                case "legacy":
                    output_map = house + 704;
                    output_mode = gamemode + 361632;
                    return;
                case "sugarfright":
                    output_map = house - 672;
                    output_mode = gamemode + 361536;
                    return;
                case "goldengun":
                    output_map = house - 1536; //goldengun only oregon? Need make random for most goldengun maps
                    output_mode = gamemode + 361440;
                    return;
                default:
                    return;
            }
        }
        public static void GameModeConverter(string ModeName, string ParentMode, long house, long gamemode, long diffmode, out long output_mode, out long difficulty, out long outmap)
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
        }
        private static void ModeConverter(string mode, long gamemode, out long outmode, out bool isTH)
        {
            outmode = 0L;
            isTH = false;
            switch (mode)
            {
                case "hostage":
                    outmode = gamemode;
                    return;
                case "secure":
                    outmode = gamemode + 32;
                    return;
                case "bomb":
                    outmode = gamemode - 32;
                    return;
                case "warmup":
                    outmode = gamemode + 361248;
                    return;
                case "goldengun":
                    outmode = gamemode + 361440;
                    return;
                case "bombnoprep":
                    outmode = gamemode + 345056;
                    return;
                case "legacy":
                    outmode = gamemode + 361632;
                    return;
                case "sugarfright":
                    outmode = gamemode + 361536;
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
                    difficulty = diff - 576;
                    return;
                default:
                    return;
            }
        }
        private static void MatchMaking(string CasOrRanked, string mode, long house, long gamemode, out long outmode, out long outmap, out bool isTH)
        {
            outmode = 0L;
            outmap = 0L;
            isTH = false;
            if (CasOrRanked == "Casual")
            {
                ModeConverter(mode, gamemode, out outmode, out isTH);
                MapConverter(Randomizer.RandomMap(0, 2), house, out outmap);
            }
            if (CasOrRanked == "Ranked")
            {
                ModeConverter(mode, gamemode, out outmode, out isTH);
                MapConverter(Randomizer.RandomMap(1, 2), house, out outmap);
            }
        }
    }
    internal class ShadowLegacy_Event
    {
        // added but need to redownload cus fuck ubisoft
        public static string FuillBuildID = "";
        public static string BuildID_Check = "";
        public static string playlistManager = "";
        public static string firstOffset = "";
        public static string day_Offset = "";
        public static string easyDifficulty_Offset = "";
        public static string house_Offset = "";
        public static string hostage_Offset = "";
        private static string playlist = playlistManager + "," + firstOffset;
        public static string r6_daynight = playlist + ",38,0";
        public static string r6_map = playlist + ",10";
        public static string r6_gamemode = playlist + ",8";
        public static string r6_difficulty = playlist + ",30";
        public static string gamestate = "";

        public static string[] EventView_Tag = { "goldengun", "legacy", "sugarfright" };
        public static string[] EventView = { "Golden Gun", "Legacy Event", "Sugar Fright" };
    }
    #endregion
    #region Neon Dawn
    internal class NeonDawn_Event
    {
        public static string FuillBuildID = "Y5S4.2.0_C5914517_D1181197_S40892_15241382";
        public static string BuildID_Check = "5F44DE0";
        public static string playlistManager = "05DAED98"; //can be 06BC0568 , 05E12F30, 05E12F38 ,05E13850
        public static string firstOffset = "D8"; //can be 3F8 ,4C8
        public static string day_Offset = "05DAED98,1A0,348,2A8,60,30,B70,D8";
        public static string easyDifficulty_Offset = "05DAED98,330,350,CA0,7D0,0,118,3E0";
        public static string house_Offset = "05DAED98,330,360,940,E40,E0,100,5A0";
        public static string hostage_Offset = "05DAED98,330,360,960,48,38,0,F28";
        private static string playlist = playlistManager + "," + firstOffset;
        public static string r6_daynight = playlist + ",38,0";
        public static string r6_map = playlist + ",10";
        public static string r6_gamemode = playlist + ",8";
        public static string r6_difficulty = playlist + ",30";
        //public static string gamestate = ""; //Not found

        public static string[] EventView_Tag = { "goldengun", "reverse", "stadium2" , "snowfight" };
        public static string[] EventView = { "Golden Gun", "Reverse Hostage", "Stadium 2" , "Snowfight" };
        public static void MapConverter(string MapName, long house, out long output)
        {
            output = 0L;
            if (MapName != "house")
            {
                switch (MapName)
                {
                    case "hereford":
                        output = house + 64;
                        return;
                    case "plane":
                        output = house + 128;
                        return;
                    case "university":
                        output = house + 320;
                        return;
                    case "favela":
                        output = house + 416;
                        return;
                    case "tower":
                        output = house + 544;
                        return;
                    case "club":
                        output = house + 96;
                        return;
                    case "oregon":
                        output = house + 32;
                        return;
                    case "yacht":
                        output = house + 160;
                        return;
                    case "consulate":
                        output = house + 192;
                        return;
                    case "bank":
                        output = house + 224;
                        return;
                    case "kanal":
                        output = house + 256;
                        return;
                    case "chalet":
                        output = house + 288;
                        return;
                    case "cafe":
                        output = house + 352;
                        return;
                    case "border":
                        output = house + 384;
                        return;
                    case "skyscraper":
                        output = house + 448;
                        return;
                    case "coastline":
                        output = house + 480;
                        return;
                    case "theme":
                        output = house + 512;
                        return;
                    case "villa":
                        output = house + 576;
                        return;
                    case "fortress":
                        output = house + 608;
                        return;
                    case "outback":
                        output = house + 640;
                        return;
                    case "stadium":
                        output = house + 672;
                        return;
                    case "oldhereford":
                        output = house + 736;
                        return;
                    case "oldhouse":
                        output = house + 704;
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
                case "stadium2":
                    output_map = house + 672;
                    output_mode = gamemode + 376672;
                    return;
                case "reverse":
                    output_map = house + 576;
                    output_mode = gamemode + 376608;
                    return;
                case "goldengun":
                    output_map = house + 32; //goldengun only oregon? Need make random for most goldengun maps
                    output_mode = gamemode + 376480;
                    return;
                case "snowfight":
                    output_map = house + 288; //only chalet!
                    output_mode = gamemode + 376704;
                    return;
                default:
                    return;
            }
        }
        public static void GameModeConverter(string ModeName, string ParentMode, long house, long gamemode, long diffmode, out long output_mode, out long difficulty, out long outmap)
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
        }
        private static void ModeConverter(string mode, long gamemode, out long outmode, out bool isTH)
        {
            outmode = 0L;
            isTH = false;
            switch (mode)
            {
                case "hostage":
                    outmode = gamemode;
                    return;
                case "secure":
                    outmode = gamemode + 32;
                    return;
                case "bomb":
                    outmode = gamemode - 32;
                    return;
                case "warmup":
                    outmode = gamemode + 376288;
                    return;
                case "goldengun":
                    outmode = gamemode + 376480;
                    return;
                case "bombnoprep":
                    outmode = gamemode + 376448;
                    return;
                case "snowfight":
                    outmode = gamemode + 376704;
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
                    difficulty = diff + 66688;
                    return;
                default:
                    return;
            }
        }
        private static void MatchMaking(string CasOrRanked, string mode, long house, long gamemode, out long outmode, out long outmap, out bool isTH)
        {
            outmode = 0L;
            outmap = 0L;
            isTH = false;
            if (CasOrRanked == "Casual")
            {
                ModeConverter(mode, gamemode, out outmode, out isTH);
                MapConverter(Randomizer.RandomMap(0, 3), house, out outmap);
            }
            if (CasOrRanked == "Ranked")
            {
                ModeConverter(mode, gamemode, out outmode, out isTH);
                MapConverter(Randomizer.RandomMap(1, 3), house, out outmap);
            }
        }
    }
    #endregion
    #region Random and Global stuff
    class Randomizer
    {
        public static string RandomMap(int casorranked, int version)
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
            if (version == 1)
            {
                if (casorranked == 0)
                {
                    maps = "house,hereford,plane,university,favela,tower,club,oregon,yacht,consulate,bank,kanal,chalet,cafe,border,skyscraper,coastline,theme,villa,fortress,outback";
                    maxmap = 20;
                }
                if (casorranked == 1)
                {
                    maps = "chalet,theme,border,oregon,club,consulate,bank,kanal,kafe,coastline,villa,outback";
                    maxmap = 11;
                }
                if (casorranked == 3) //goldengun
                {
                    maps = "house,oregon,border,coastline"; //?
                    maxmap = 11;
                }
            }
            if (version == 2)
            {
                if (casorranked == 0)
                {
                    maps = "house,hereford,plane,university,favela,tower,club,oregon,yacht,consulate,bank,kanal,chalet,cafe,border,skyscraper,coastline,theme,villa,fortress,outback";
                    maxmap = 20;
                }
                if (casorranked == 1)
                {
                    maps = "chalet,theme,border,oregon,club,consulate,bank,kanal,kafe,coastline,villa,outback";
                    maxmap = 11;
                }
                if (casorranked == 3) //goldengun
                {
                    maps = "house,oregon,border,coastline";
                    maxmap = 11;
                }
            }
            if (version == 3)
            {
                if (casorranked == 0)
                {
                    maps = "house,hereford,plane,university,favela,tower,club,oregon,yacht,consulate,bank,kanal,chalet,cafe,border,skyscraper,coastline,theme,villa,fortress,outback";
                    maxmap = 20;
                }
                if (casorranked == 1)
                {
                    maps = "bank,border,chalet,club,coastline,consulate,kafe,kanal,oregon,outback,skyscraper,theme,villa";
                    maxmap = 11;
                }
                if (casorranked == 3) //goldengun
                {
                    maps = "house,oregon,border,coastline";
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
    internal class GlobalStuff
    {
        public static void DayChange(bool dayornight, long day, out long daynight)
        {
            if (dayornight)
            {
                daynight = day + 32;
            }
            else
            {
                daynight = day;
            }
            logs.WriteLog("D/N has been changed!");
        }

        public static string StateChange(int state)
        {
            switch (state)
            {
                case 1:
                    return "Is Launching";
                case 2:
                    return "In Menu"; //load that for end round
                case 3:
                    return "In Lobby"; //load that for end match
                case 4:
                    return "In Match";
                case 5:
                    return "In Choosing Option";
                case 6:
                    return "In Loading";
                case 7:
                    return "Is Playing";
                default:
                    return state.ToString();
            }
        }
    }
    #endregion
}
