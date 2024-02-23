using Exiled.API.Features;
using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MZmatch
{
    public class PluginConfig : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug {  get; set; } = false;
    }
    public class Plugin : Plugin<PluginConfig>
    {
        public override string Author => "Silver Wolf";
        public override string Name => "MZmatch";
        public override Version Version => new Version(1, 0, 0);
        public static Plugin Instance { get; set; }
        public override void OnEnabled()
        {
            Instance = this;
        }
    }
}
