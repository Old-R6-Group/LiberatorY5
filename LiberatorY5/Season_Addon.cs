using System;
using System.Linq;

namespace LiberatorY5
{
    public class Season_Addon
    {
        public string FuillBuildID = "";
        public string BuildID_Check = "";
        public string day_Offset = "";
        public string easyDifficulty_Offset = "";
        public string house_Offset = "";
        public string hostage_Offset = "";
        public string r6_daynight = "";
        public string r6_map = "";
        public string r6_gamemode = "";
        public string r6_difficulty = "";
        public string gamestate = "";
        public string ConnectedIP = ""; //long to ip
        public string InMatch = ""; //4 Byte but actually just one byte
        public string InHost = ""; //Byte
        public string[] EventView_Tag;
        public string[] EventView;
        public int SeasonVersion = -1;
        private int RandomizerVer = int.MinValue;  // Starting with 0, VE ( 0 = Void Edge, 1 = Steel Wave, 2 = Shadow Legacy , etc)
        public void Seasons_Changer(string BuildID)
        {
            switch (BuildID)
            {
                case "Y5S1.2.0.1_C5183038_D967006_S37789_14303219": //VE Shey
                    RandomizerVer = 0;
                    SeasonVersion = 0;
                    return;
                case "Y5S1.2.0.2_C5218952_D973190_S37789_14335319": //VE MU
                    RandomizerVer = 0;
                    SeasonVersion = 1;
                    return;
                case "Y5S2.3.1.1pc_C5493616_D1043836_S38774_14664131": //Steel wave
                    RandomizerVer = 1;
                    SeasonVersion = 2;
                    return;
                case "Y5S3.3.1_C5789341_D1135607_S40332_15018155": //SL Global
                    RandomizerVer = 2;
                    SeasonVersion = 3;
                    return;
                case "Y5S3.3.1_C5789341_D1135232321155": //SL Event
                    RandomizerVer = 2;
                    SeasonVersion = 4;
                    return;
                case "Y5S4.2.0_C5914517_D1181197_S40892_15241382": //Neon event
                    RandomizerVer = 3;
                    SeasonVersion = 5;
                    return;
                default:
                    RandomizerVer = int.MinValue;
                    SeasonVersion = int.MinValue;
                    return;
                case "Y7S1.0.0_C6789300_D1434731_S46608_38678526": //live
                    RandomizerVer = 3;
                    SeasonVersion = 1773;
                    return;
            }
        }
        public void SetInternal()
        {
            switch (SeasonVersion)
            {
                default:
                    return;
                case 0:
                    FuillBuildID = VoidEdge_Shey.FuillBuildID;
                    BuildID_Check = VoidEdge_Shey.BuildID_Check;
                    day_Offset = VoidEdge_Shey.day_Offset;
                    easyDifficulty_Offset = VoidEdge_Shey.easyDifficulty_Offset;
                    house_Offset = VoidEdge_Shey.house_Offset;
                    hostage_Offset = VoidEdge_Shey.hostage_Offset;
                    r6_daynight = VoidEdge_Shey.r6_daynight;
                    r6_map = VoidEdge_Shey.r6_map;
                    r6_gamemode = VoidEdge_Shey.r6_gamemode;
                    r6_difficulty = VoidEdge_Shey.r6_difficulty;
                    gamestate = VoidEdge_Shey.gamestate;
                    ConnectedIP = VoidEdge_Shey.ConnectedIP;
                    InMatch = VoidEdge_Shey.InMatch;
                    InHost = VoidEdge_Shey.InHost;
                    EventView_Tag = VoidEdge_Shey.EventView_Tag;
                    EventView = VoidEdge_Shey.EventView;
                    return;
                case 1:
                    FuillBuildID = VoidEdge_MU.FuillBuildID;
                    BuildID_Check = VoidEdge_MU.BuildID_Check;
                    day_Offset = VoidEdge_MU.day_Offset;
                    easyDifficulty_Offset = VoidEdge_MU.easyDifficulty_Offset;
                    house_Offset = VoidEdge_MU.house_Offset;
                    hostage_Offset = VoidEdge_MU.hostage_Offset;
                    r6_daynight = VoidEdge_MU.r6_daynight;
                    r6_map = VoidEdge_MU.r6_map;
                    r6_gamemode = VoidEdge_MU.r6_gamemode;
                    r6_difficulty = VoidEdge_MU.r6_difficulty;
                    gamestate = VoidEdge_MU.gamestate;
                    ConnectedIP = VoidEdge_MU.ConnectedIP;
                    InMatch = VoidEdge_MU.InMatch;
                    InHost = VoidEdge_MU.InHost;
                    EventView_Tag = VoidEdge_MU.EventView_Tag;
                    EventView = VoidEdge_MU.EventView;
                    return;
                case 2:
                    FuillBuildID = SteelWave.FuillBuildID;
                    BuildID_Check = SteelWave.BuildID_Check;
                    day_Offset = SteelWave.day_Offset;
                    easyDifficulty_Offset = SteelWave.easyDifficulty_Offset;
                    house_Offset = SteelWave.house_Offset;
                    hostage_Offset = SteelWave.hostage_Offset;
                    r6_daynight = SteelWave.r6_daynight;
                    r6_map = SteelWave.r6_map;
                    r6_gamemode = SteelWave.r6_gamemode;
                    r6_difficulty = SteelWave.r6_difficulty;
                    gamestate = SteelWave.gamestate;
                    ConnectedIP = SteelWave.ConnectedIP;
                    InMatch = SteelWave.InMatch;
                    InHost = SteelWave.InHost;
                    EventView_Tag = SteelWave.EventView_Tag;
                    EventView = SteelWave.EventView;
                    return;
                case 3:
                    FuillBuildID = ShadowLegacy_Global.FuillBuildID;
                    BuildID_Check = ShadowLegacy_Global.BuildID_Check;
                    day_Offset = ShadowLegacy_Global.day_Offset;
                    easyDifficulty_Offset = ShadowLegacy_Global.easyDifficulty_Offset;
                    house_Offset = ShadowLegacy_Global.house_Offset;
                    hostage_Offset = ShadowLegacy_Global.hostage_Offset;
                    r6_daynight = ShadowLegacy_Global.r6_daynight;
                    r6_map = ShadowLegacy_Global.r6_map;
                    r6_gamemode = ShadowLegacy_Global.r6_gamemode;
                    r6_difficulty = ShadowLegacy_Global.r6_difficulty;
                    gamestate = ShadowLegacy_Global.gamestate;
                    ConnectedIP = ShadowLegacy_Global.ConnectedIP;
                    InMatch = ShadowLegacy_Global.InMatch;
                    InHost = ShadowLegacy_Global.InHost;
                    EventView_Tag = ShadowLegacy_Global.EventView_Tag;
                    EventView = ShadowLegacy_Global.EventView;
                    return;
                case 4:
                    FuillBuildID = ShadowLegacy_Event.FuillBuildID;
                    BuildID_Check = ShadowLegacy_Event.BuildID_Check;
                    day_Offset = ShadowLegacy_Event.day_Offset;
                    easyDifficulty_Offset = ShadowLegacy_Event.easyDifficulty_Offset;
                    house_Offset = ShadowLegacy_Event.house_Offset;
                    hostage_Offset = ShadowLegacy_Event.hostage_Offset;
                    r6_daynight = ShadowLegacy_Event.r6_daynight;
                    r6_map = ShadowLegacy_Event.r6_map;
                    r6_gamemode = ShadowLegacy_Event.r6_gamemode;
                    r6_difficulty = ShadowLegacy_Event.r6_difficulty;
                    gamestate = ShadowLegacy_Event.gamestate;
                    ConnectedIP = ShadowLegacy_Event.ConnectedIP;
                    InMatch = ShadowLegacy_Event.InMatch;
                    InHost = ShadowLegacy_Event.InHost;
                    EventView_Tag = ShadowLegacy_Event.EventView_Tag;
                    EventView = ShadowLegacy_Event.EventView;
                    return;
                case 5:
                    FuillBuildID = NeonDawn_Event.FuillBuildID;
                    BuildID_Check = NeonDawn_Event.BuildID_Check;
                    day_Offset = NeonDawn_Event.day_Offset;
                    easyDifficulty_Offset = NeonDawn_Event.easyDifficulty_Offset;
                    house_Offset = NeonDawn_Event.house_Offset;
                    hostage_Offset = NeonDawn_Event.hostage_Offset;
                    r6_daynight = NeonDawn_Event.r6_daynight;
                    r6_map = NeonDawn_Event.r6_map;
                    r6_gamemode = NeonDawn_Event.r6_gamemode;
                    r6_difficulty = NeonDawn_Event.r6_difficulty;
                    gamestate = NeonDawn_Event.gamestate;
                    ConnectedIP = NeonDawn_Event.ConnectedIP;
                    InMatch = NeonDawn_Event.InMatch;
                    InHost = NeonDawn_Event.InHost;
                    EventView_Tag = NeonDawn_Event.EventView_Tag;
                    EventView = NeonDawn_Event.EventView;
                    return;
                case 1773:
                    FuillBuildID = DemonVeil_Release.FuillBuildID;
                    BuildID_Check = DemonVeil_Release.BuildID_Check;
                    day_Offset = DemonVeil_Release.day_Offset;
                    easyDifficulty_Offset = DemonVeil_Release.easyDifficulty_Offset;
                    house_Offset = DemonVeil_Release.house_Offset;
                    hostage_Offset = DemonVeil_Release.hostage_Offset;
                    r6_daynight = DemonVeil_Release.r6_daynight;
                    r6_map = DemonVeil_Release.r6_map;
                    r6_gamemode = DemonVeil_Release.r6_gamemode;
                    r6_difficulty = DemonVeil_Release.r6_difficulty;
                    gamestate = DemonVeil_Release.gamestate;
                    ConnectedIP = DemonVeil_Release.ConnectedIP;
                    InMatch = DemonVeil_Release.InMatch;
                    InHost = DemonVeil_Release.InHost;
                    EventView_Tag = DemonVeil_Release.EventView_Tag;
                    EventView = DemonVeil_Release.EventView;
                    return;
            }

        }
        public Object GetSeason()
        {
            switch (SeasonVersion)
            {
                default:
                    return null;
                case int.MaxValue:
                    return null;
                case 0:
                    return new VoidEdge_Shey();
                case 1:
                    return new VoidEdge_MU();
                case 2:
                    return new SteelWave();
                case 3:
                    return new ShadowLegacy_Global();
                case 4:
                    return new ShadowLegacy_Event();
                case 5:
                    return new NeonDawn_Event();
            }

        }

        //Sesason swapping stuff
        public void DiffConverter(string diffname, long diff, out long difficulty)
        {
            difficulty = diff;
            switch (SeasonVersion)
            {
                default:
                    break;
                case 0:
                    VoidEdge_Shey.DiffConverter(diffname, diff, out difficulty);
                    return;
                case 1:
                    VoidEdge_MU.DiffConverter(diffname, diff, out difficulty);
                    return;
                case 2:
                    SteelWave.DiffConverter(diffname, diff, out difficulty);
                    return;
                case 3:
                    ShadowLegacy_Global.DiffConverter(diffname, diff, out difficulty);
                    return;
                case 5:
                    NeonDawn_Event.DiffConverter(diffname, diff, out difficulty);
                    return;
                case 1773:
                    DemonVeil_Release.DiffConverter(diffname, diff, out difficulty);
                    return;
            }
        }
        public void MapConverter(string MapName, long house, out long output)
        {
            output = 0L;
            switch (SeasonVersion)
            {
                default:
                    break;
                case 0:
                    VoidEdge_Shey.MapConverter(MapName, house, out output);
                    return;
                case 1:
                    VoidEdge_MU.MapConverter(MapName, house, out output);
                    return;
                case 2:
                    SteelWave.MapConverter(MapName, house, out output);
                    return;
                case 3:
                    ShadowLegacy_Global.MapConverter(MapName, house, out output);
                    return;
                case 5:
                    NeonDawn_Event.MapConverter(MapName, house, out output);
                    return;
                case 1773:
                    DemonVeil_Release.MapConverter(MapName, house, out output);
                    return;
            }
        }
        public void EventConverter(string EventName, long house, long gamemode, out long output_map, out long output_mode)
        {
            output_map = 0L;
            output_mode = 0L;
            switch (SeasonVersion)
            {
                default:
                    break;
                case 0:
                    VoidEdge_Shey.EventConverter(EventName, house, gamemode, out output_map, out output_mode);
                    return;
                case 1:
                    VoidEdge_MU.EventConverter(EventName, house, gamemode, out output_map, out output_mode);
                    return;
                case 2:
                    SteelWave.EventConverter(EventName, house, gamemode, out output_map, out output_mode);
                    return;
                case 3:
                    ShadowLegacy_Global.EventConverter(EventName, house, gamemode, out output_map, out output_mode);
                    return;
                case 5:
                    NeonDawn_Event.EventConverter(EventName, house, gamemode, out output_map, out output_mode);
                    return;
                case 1773:
                    DemonVeil_Release.EventConverter(EventName, house, gamemode, out output_map, out output_mode);
                    return;
            }
        }
        public void ModeConverter(string mode, long gamemode, out long outmode, out bool isTH)
        {
            outmode = 0L;
            isTH = false;
            switch (SeasonVersion)
            {
                default:
                    break;
                case 0:
                    VoidEdge_Shey.ModeConverter(mode, gamemode, out outmode, out isTH);
                    return;
                case 1:
                    VoidEdge_MU.ModeConverter(mode, gamemode, out outmode, out isTH);
                    return;
                case 2:
                    SteelWave.ModeConverter(mode, gamemode, out outmode, out isTH);
                    return;
                case 3:
                    ShadowLegacy_Global.ModeConverter(mode, gamemode, out outmode, out isTH);
                    return;
                case 5:
                    NeonDawn_Event.ModeConverter(mode, gamemode, out outmode, out isTH);
                    return;
                case 1773:
                    DemonVeil_Release.ModeConverter(mode, gamemode, out outmode, out isTH);
                    return;
            }
        }
        public void GameModeConverter(string ModeName, string ParentMode, long gamemode, long diffmode, out long output_mode, out long difficulty)
        {
            output_mode = gamemode;
            difficulty = diffmode;
            var difss = new[] { "normal", "hard", "realistic" };
            var modes = new[] { "hostage", "secure", "bomb", "warmup", "goldengun", "bombnoprep" };
            if (difss.Any(ModeName.Contains))
            {
                ModeConverter(ParentMode, gamemode, out output_mode, out bool isTH);
                DiffConverter(ModeName, diffmode, out difficulty);

            }
            if (ModeName == "bombnoprep")
            {
                ModeConverter("bombnoprep", gamemode, out output_mode, out bool isTH);
                DiffConverter("normal", diffmode, out difficulty);
                return;

            }
            else if (modes.Any(ModeName.Contains))
            {
                ModeConverter(ModeName, gamemode, out output_mode, out bool isTH);
            }
        }
        public void MatchMaking(string CasOrRanked, string mode, long house, long gamemode, out long outmode, out long outmap, out bool isTH)
        {
            outmode = 0L;
            outmap = 0L;
            isTH = false;
            if (CasOrRanked == "Casual")
            {
                ModeConverter(mode, gamemode, out outmode, out isTH);
                MapConverter(Randomizer.RandomMap(0, RandomizerVer), house, out outmap);
            }
            if (CasOrRanked == "Ranked")
            {
                ModeConverter(mode, gamemode, out outmode, out isTH);
                MapConverter(Randomizer.RandomMap(1, RandomizerVer), house, out outmap);
            }
        }
        public void ParentParser(string ModeName, string ParentMode, string MapName, out string mode, out string diff, out string map)
        {
            mode = ModeName;
            map = MapName;
            diff = "normal";
            string CasOrRanked = null;
            if (ParentMode == ModeName)
            {
                switch (ParentMode)
                {
                    case "Multiplayer":
                        mode = Randomizer.RandomMode();
                        break;
                    case "TerroristHunt":
                        diff = Randomizer.RandomDifficulty();
                        break;
                    case "Matchmaking":
                        CasOrRanked = Randomizer.RandomMM();
                        mode = Randomizer.RandomModeMM();
                        break;
                    case "Random":
                        CasOrRanked = Randomizer.RandomMM();
                        mode = Randomizer.RandomMode();
                        break;
                    default:
                        break;
                }
                if (CasOrRanked == "Casual")
                {
                    map = Randomizer.RandomMap(0, RandomizerVer);
                }
                if (CasOrRanked == "Ranked")
                {
                    map = Randomizer.RandomMap(1, RandomizerVer);
                }
                logs.WriteLog(map + " " + diff + " " + mode);
            }

        }
    }
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
        //Long to IP string. RadminVPN!
        public static string LongToIP(long longvalue)
        {
            byte[] bytes = BitConverter.GetBytes(longvalue);
            int ip1 = (int)Convert.ToDecimal(bytes[0]);
            int ip2 = (int)Convert.ToDecimal(bytes[1]);
            int ip3 = (int)Convert.ToDecimal(bytes[2]);
            int ip4 = (int)Convert.ToDecimal(bytes[3]);
            //we drop the other 2-4, mostly is null, and ip is only 4 part.
            return $"{ip1}.{ip2}.{ip3}.{ip4}";
        }
    }
    #endregion
}
