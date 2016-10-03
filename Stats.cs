using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kaziklikker.Properties;

namespace Kaziklikker {
    public partial class Stats : Form {
        public Stats() {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            MoneyL.Text = Form1.NiceNumber(Settings.Default.Money).ToString();
            MoneySpentL.Text = Form1.NiceNumber(Settings.Default.MoneySpent).ToString();
            MoneySpentLotterL.Text =Form1.NiceNumber(Settings.Default.MoneySpentLottery).ToString();
            MoneySpentShopL.Text = Form1.NiceNumber(Settings.Default.MoneySpentShop).ToString();
            MoneySpentUpgradesL.Text = Form1.NiceNumber(Settings.Default.MoneySpentUpgrades).ToString();
            MoneyEarnedClicksL.Text = Form1.NiceNumber(Settings.Default.MoneyEarnedClicks).ToString();
            MoneyEarnedCPSL.Text = Form1.NiceNumber(Settings.Default.MoneyEarnedCPS).ToString();
            MoneyEarnedL.Text = Form1.NiceNumber(Settings.Default.MoneyEarned).ToString();
            MoneyEarnedLotteryL.Text = Form1.NiceNumber(Settings.Default.MoneyEarnedLottery).ToString();
            MoneyEarnedXPL.Text = Form1.NiceNumber(Settings.Default.MoneyEarnedXP).ToString();
        }
    }
}
