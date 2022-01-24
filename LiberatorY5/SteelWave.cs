using System;

namespace LiberatorY5
{
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
    }
}
