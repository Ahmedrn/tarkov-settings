using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarkov_settings.Setting
{
    public class GameSetting
    {
        public double brightness = 0.5;
        public double contrast = 0.5;
        public double gamma = 1.0;
        public int saturation = 0;
    }

    class AppSetting : Settings<AppSetting>
    {
        public Dictionary<string, GameSetting> gameSettings = new Dictionary<string, GameSetting>
        {
            { "EscapeFromTarkov", new GameSetting() },
            { "EscapeFromTarkovArena", new GameSetting() }
        };
        public HashSet<string> pTargets = new HashSet<string>{
            "EscapeFromTarkov",
            "EscapeFromTarkovArena"
        };
        public string display = @"\\.\DISPLAY1";
        public bool minimizeOnStart = false;
    }
}
