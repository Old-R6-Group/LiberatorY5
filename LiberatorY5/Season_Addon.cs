using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiberatorY5
{
    internal class Season_Addon
    {
        public /*private*/ int SeasonVersion; // Starting with 0, VE ( 0 = Void Edge, 1 = Steel Wave, 2 = Shadow Legacy , etc)
        public static void MatchMaking(string CasOrRanked, string mode, long house, long gamemode, out long outmode, out long outmap, out bool isTH)
        {
            outmode = 0L;
            outmap = 0L;
            isTH = false;
            if (CasOrRanked == "Casual")
            {
                //ModeConverter(mode, gamemode, out outmode, out isTH);
                //MapConverter(Randomizer.RandomMap(0, 3), house, out outmap);
            }
            if (CasOrRanked == "Ranked")
            {
                //ModeConverter(mode, gamemode, out outmode, out isTH);
                //MapConverter(Randomizer.RandomMap(1, 3), house, out outmap);
            }
        }
        public void Seasons_Changer(string BuildID)
        {
            string tmp = BuildID.Split('.')[0].Split('S')[1];
            int tmp_int = Convert.ToInt32(tmp);
            SeasonVersion = tmp_int - 1;
        
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
