using System;

namespace LiberatorY5
{
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
}
