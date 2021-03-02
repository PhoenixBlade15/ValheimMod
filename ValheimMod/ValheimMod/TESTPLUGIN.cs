using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using BepInEx.Configuration;

namespace ValheimMod
{
    [BepInPlugin("valheimmod.testplugin", "Test Plugin", "1.0.0.0")]
    [BepInProcess("Valheim.exe")]
    public class TESTPLUGIN : BaseUnityPlugin
    {
        
        private ConfigEntry<string> configGreeting;
        private ConfigEntry<bool> configDisplayGreeting;

        void Awake()
        {
            configGreeting = Config.Bind("General",   // The section under which the option is shown
                                         "GreetingText",  // The key of the configuration option in the configuration file
                                         "Hello, world!", // The default value
                                         "A greeting text to show when the game is launched"); // Description of the option to show in the config file

            configDisplayGreeting = Config.Bind("General.Toggles",
                                                "DisplayGreeting",
                                                true,
                                                "Whether or not to show the greeting text");
            Logger.LogInfo("Hello, world!");


            if (configDisplayGreeting.Value)
                Logger.LogInfo(configGreeting.Value);

            Logger.LogInfo("This is information");
            Logger.LogWarning("This is a warning");
            Logger.LogError("This is an error");
        }
    }
}