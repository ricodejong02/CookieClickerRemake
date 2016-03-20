using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kaziklikker.Properties;

namespace Kaziklikker {
    public static class Cheat {
        public static void Execute(string _cheat) {
            if(_cheat.StartsWith("#Money#")) {
                _cheat = _cheat.Replace("#Money#", "");
                try {
                    Settings.Default.Money = Convert.ToInt64(_cheat);
                } catch(Exception) {
                    System.Windows.Forms.MessageBox.Show("Something went wrong.");
                }
            }

            if(_cheat.StartsWith("#CPS#")) {
                _cheat = _cheat.Replace("#CPS#", "");
                try {
                    Settings.Default.CPS = Convert.ToInt64(_cheat);
                } catch(Exception) {
                    System.Windows.Forms.MessageBox.Show("Something went wrong.");
                }
            }

            if(_cheat.StartsWith("#XP#")) {
                _cheat = _cheat.Replace("#XP#", "");
                try {
                    Settings.Default.XP = Convert.ToInt64(_cheat);
                } catch(Exception) {
                    System.Windows.Forms.MessageBox.Show("Something went wrong.");
                }
            }

            if(_cheat.StartsWith("#XPCPS#")) {
                _cheat = _cheat.Replace("#XPCPS#", "");
                try {
                    Settings.Default.XPCPS = Convert.ToInt64(_cheat);
                } catch(Exception) {
                    System.Windows.Forms.MessageBox.Show("Something went wrong.");
                }
            }
        }
    }
}
