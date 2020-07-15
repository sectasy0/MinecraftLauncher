using System;
using System.Diagnostics;
using System.IO;


namespace JBWMLauncher {
    class GameClient {
        private string minecraftDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".minecraft");

        public bool run_online() {
            Debug.WriteLine(minecraftDir);
            return false;
        }
    }
}
