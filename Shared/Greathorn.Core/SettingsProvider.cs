// Copyright Greathorn Games Inc. All Rights Reserved.


using System.IO;

namespace Greathorn.Core
{
    /// <remarks>
    ///     If these are changed you should triple check for anything in the Bootstrap project that would need updating.
    ///     Because it does not reference anything else, changing here won't change Bootstrap.
    /// </remarks>
    public class SettingsProvider
    {
        public const string P4Port = "perforce.greathorn.games:1666";
        public const string P4CharacterSet = "auto";
        public const string P4IgnoreFileName = "p4ignore.txt";
        public const string P4ConfigFileName = "p4config.txt";
        public const string BuildHashFileName = "GG_BUILD_SHA";

        public readonly string RootFolder;
        public readonly string LogsFolder;
        public readonly string BuildBatchFilesFolder;
        public readonly string TempFile;
        public readonly string P4ConfigFile;
        public readonly string DotNETExecutablesFolder;

        public SettingsProvider(string root)
        {
            RootFolder = root;
            LogsFolder = Path.Combine(RootFolder, "Logs");
            BuildBatchFilesFolder = Path.Combine(RootFolder, "Engine", "Build", "BatchFiles");
            TempFile = Path.Combine(RootFolder, "gg.tmp");

            DotNETExecutablesFolder = Path.Combine(RootFolder, "Greathorn", "Binaries", "DotNET");
            P4ConfigFile = Path.Combine(RootFolder, SettingsProvider.P4ConfigFileName);
        }

        public void Output()
        {
            Log.WriteLine("Settings:");
            Log.WriteLine($"Root: {RootFolder}", "LOCATION", ILogOutput.LogType.Info);
        }
    }
}
