using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaziklikker {
    public partial class Wiki : Form {
        public Wiki() {
            InitializeComponent();
        }

        private void navigationWindow_SelectedIndexChanged(object sender, EventArgs e) {
            titleBox.Text = navigationWindow.Items[navigationWindow.SelectedIndex].ToString();
            switch(navigationWindow.SelectedIndex) {
                case 0:
                    textBox.Text = WikiRes.home;
                    Level.Text = "*";
                    break;
                case 1:
                    textBox.Text = WikiRes.basics;
                    Level.Text = "*";
                    break;
                case 2:
                    textBox.Text = WikiRes.shop;
                    Level.Text = "*";
                    break;
                case 3:
                    textBox.Text = WikiRes.upgrades;
                    Level.Text = "***";
                    break;
                case 4:
                    textBox.Text = WikiRes.lottery;
                    Level.Text = "**";
                    break;
                case 5:
                    textBox.Text = WikiRes.bank;
                    Level.Text = "**";
                    break;
                case 6:
                    textBox.Text = WikiRes.experience;
                    Level.Text = "***";
                    break;
                case 7:
                    textBox.Text = WikiRes.largenumber;
                    Level.Text = "**";
                    break;
                case 8:
                    textBox.Text = WikiRes.cheat;
                    Level.Text = "**";
                    break;
                case 9:
                    textBox.Text = WikiRes.changelog;
                    Level.Text = "*";
                    break;
                case 10:
                    textBox.Text = WikiRes.credits;
                    Level.Text = "*";
                    break;
            }
        }

        private void Wiki_Load(object sender, EventArgs e) {
            textBox.Text = WikiRes.home;
        }
    }
}
