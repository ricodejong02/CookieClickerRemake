using Kaziklikker.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace Kaziklikker {

    public partial class Form1 : Form {
        private SoundPlayer Click_1 = new SoundPlayer(Sounds.Click_1);
        private SoundPlayer Click_2 = new SoundPlayer(Sounds.Click_2);
        private SoundPlayer Click_3 = new SoundPlayer(Sounds.Click_3);
        private SoundPlayer Click_4 = new SoundPlayer(Sounds.Click_4);
        private SoundPlayer Click_5 = new SoundPlayer(Sounds.Click_5);
        private SoundPlayer KaziMusic = new SoundPlayer(Sounds.KaziMusic);

        private Random rd = new Random();

        #region ints
        public bool hell = false;
        public int bankclock = 180;
        public bool Cheater = false;

        #endregion ints

        #region strings
        public string Val = "€";
        public string version = "kaziklikker version 3.2.2";

        #endregion strings

        #region opstarten

        //later contextmenu
        public Form1() {
            InitializeComponent();
            switch(rd.Next(4)) {
                case 0:
                    pictureBox15.Image = Resources.Headphones_magmaon;
                    break;

                case 1:
                    pictureBox15.Image = Resources.Headphones_nitroon;
                    break;

                case 2:
                    pictureBox15.Image = Resources.Headphones_aquaon;
                    break;

                default:
                    pictureBox15.Image = Resources.Headphones_magmaon;
                    break;
            }

            switch(rd.Next(4)) {
                case 0:
                    button26.Image = Resources._1cent;
                    break;

                case 1:
                    button26.Image = Resources._50cent;
                    break;

                case 2:
                    button26.Image = Resources._2euro;
                    break;

                default:
                    button26.Image = Resources.Coin;
                    break;
            }

            switch(rd.Next(4)) {
                case 0:
                    button22.Image = Resources._1cent;
                    break;

                case 1:
                    button22.Image = Resources._50cent;
                    break;

                case 2:
                    button22.Image = Resources._2euro;
                    break;

                default:
                    button22.Image = Resources.Coin;
                    break;
            }

            switch(rd.Next(4)) {
                case 0:
                    pictureBox3.Image = Resources.Richwallet;
                    break;

                case 1:
                    pictureBox3.Image = Resources.Safe;
                    break;

                case 2:
                    pictureBox3.Image = Resources.Card;
                    break;

                default:
                    pictureBox3.Image = Resources.Wallet;
                    break;
            }

            switch(rd.Next(2)) {
                case 0:
                    pictureBox4.Image = Resources.Clock;
                    break;

                default:
                    pictureBox4.Image = Resources.Clock2;
                    break;
            }

            switch(rd.Next(4)) {
                case 0:
                    Val = "€";
                    break;

                case 1:
                    Val = "$";
                    break;

                case 2:
                    Val = "£";
                    break;

                default:
                    Val = "¥";
                    break;
            }

            switch(rd.Next(4)) {
                case 0:
                    button20.Image = Resources.Wiki;
                    break;
                case 1:
                    button20.Image = Resources.WikiBlue;
                    break;
                case 2:
                    button20.Image = Resources.WikiGreen;
                    break;
                case 3:
                    button20.Image = Resources.WikiPurple;
                    break;
            }

            switch(rd.Next(3)) {
                case 0:
                    pictureBox16.Image = Resources.Experience;
                    pictureBox6.Image = Resources.XPClock;
                    break;
                case 1:
                    pictureBox16.Image = Resources.ExperienceRed;
                    pictureBox6.Image = Resources.XPClockRed;
                    break;
                case 2:
                    pictureBox16.Image = Resources.ExperienceBlue;
                    pictureBox6.Image = Resources.XPClockBlue;
                    break;
            }

        }

        public void Form1_Load(object sender, EventArgs e) {
            panel1.BackColor = Settings.Default.AccentColor;
            button12.BackColor = Settings.Default.AccentColor;
            button13.BackColor = Settings.Default.AccentColor;

            BackColor = Settings.Default.BackColor;
            panel2.BackColor = Settings.Default.BackColor;
            panel3.BackColor = Settings.Default.BackColor;
            panel4.BackColor = Settings.Default.BackColor;
            Kaziknop.FlatAppearance.MouseDownBackColor = Settings.Default.BackColor;
            Kaziknop.FlatAppearance.MouseOverBackColor = Settings.Default.BackColor;
        }

        #endregion opstarten

        #region Clock

        private void timer1_Tick(object sender, EventArgs e) {
            bankclock--;
            if(bankclock == 0) {
                bankclock = 180;
                Settings.Default.OpBank = Convert.ToInt64(Settings.Default.OpBank / 10 * Settings.Default.BankRente);
                if(checkBox2.Checked) {
                    checkBox2.Checked = false;
                    checkBox2.Enabled = true;
                    MessageBox.Show("Your money is no longer invested.");
                }
            }
            label62.Text = bankclock.ToString();
            Settings.Default.Money += Settings.Default.CPS;
            Settings.Default.XP += Settings.Default.XPCPS;
            Settings.Default.XPToMoney += (rd.NextDouble() / 10) - 0.05;
            Settings.Default.XPToMoney = Convert.ToDouble(Math.Round(Convert.ToDecimal(Settings.Default.XPToMoney), 2));
            if(Settings.Default.XPToMoney <= 0)
                Settings.Default.XPToMoney = 0.01;

            if(checkBox2.Checked) {
                switch(rd.Next(0, 10)) {
                    case 0:
                        Settings.Default.OpBank = Convert.ToInt64(Settings.Default.OpBank * 0.80);
                        break;

                    case 1:
                        Settings.Default.OpBank = Convert.ToInt64(Settings.Default.OpBank * 1.30);
                        break;

                    case 2:
                        Settings.Default.OpBank = Convert.ToInt64(Settings.Default.OpBank * 0.75);
                        break;

                    case 3:
                        Settings.Default.OpBank = Convert.ToInt64(Settings.Default.OpBank * 1.40);
                        break;

                    case 4:
                        Settings.Default.OpBank -= rd.Next(0, 1000);
                        break;
                }
            }
        }

        #endregion Clock

        #region Snelle timer

        private void timer2_Tick(object sender, EventArgs e) {            //Label update

            bank.Interval = clock.Interval * 180;
            label68.Text = NiceNumber(Settings.Default.FireWallPrice);
            label61.Text = "1 Experience is equal to " + Settings.Default.XPToMoney.ToString() + " money";
            label59.Text = NiceNumber(Settings.Default.XP);
            this.Text = version + " " + Val + NiceNumber(Settings.Default.Money);

            label38.Text = NiceNumber(Settings.Default.GoedkoopPrice);
            label66.Text = NiceNumber(Settings.Default.XPMinePrice);
            label67.Text = NiceNumber(Settings.Default.XPMineAmount);
            label65.Text = NiceNumber(Settings.Default.XPCPS);
            label39.Text = NiceNumber(Settings.Default.ClickingSpeedPrice);
            label40.Text = NiceNumber(Settings.Default.CPSPrice);
            label41.Text = NiceNumber(Settings.Default.BankPrice);
            label1.Text =  Val + NiceNumber(Settings.Default.Money);
            label2.Text =  NiceNumber(Settings.Default.CPS);
            label3.Text =  NiceNumber(Settings.Default.ClickerPrice);
            label4.Text =  NiceNumber(Settings.Default.FarmPrice);
            label5.Text =  NiceNumber(Settings.Default.MinePrice);
            label6.Text =  NiceNumber(Settings.Default.VillagePrice);
            label7.Text =  NiceNumber(Settings.Default.CityPrice);
            label8.Text =  NiceNumber(Settings.Default.CountryPrice);
            label9.Text =  NiceNumber(Settings.Default.PlanetPrice);
            label10.Text = NiceNumber(Settings.Default.GalaxyPrice);
            label11.Text = NiceNumber(Settings.Default.ClickingPrice);
            label28.Text = NiceNumber(Settings.Default.UniversePrice);
            label29.Text = NiceNumber(Settings.Default.GodPrice);
            label12.Text = NiceNumber(Settings.Default.ClickerAmount);
            label13.Text = NiceNumber(Settings.Default.FarmAmount);
            label14.Text = NiceNumber(Settings.Default.MineAmount);
            label15.Text = NiceNumber(Settings.Default.VillageAmount);
            label16.Text = NiceNumber(Settings.Default.CityAmount);
            label17.Text = NiceNumber(Settings.Default.CountryAmount);
            label18.Text = NiceNumber(Settings.Default.PlanetAmount);
            label19.Text = NiceNumber(Settings.Default.GalaxyAmount);
            label20.Text = NiceNumber(Settings.Default.ClickingSpeed);
            label30.Text = NiceNumber(Settings.Default.UniverseAmount);
            label31.Text = NiceNumber(Settings.Default.GodAmount);
            label33.Text = NiceNumber(Settings.Default.TotalClicks);
            label26.Text = NiceNumber(Settings.Default.OpBank);
            label27.Text = Settings.Default.BankRente.ToString();

            if(Settings.Default.Money >= Settings.Default.FireWallPrice && !Settings.Default.HasFireWall) {
                button15.Enabled = true;
            }

            if(Settings.Default.Money <= Settings.Default.FireWallPrice -1) {
                button15.Enabled = false;
            }

            if(Settings.Default.XP >= Settings.Default.XPMinePrice) {
                button14.Enabled = true;
            }

            if(Settings.Default.XP <= Settings.Default.XPMinePrice - 1) {
                button14.Enabled = false;
            }

            if(Settings.Default.Money >= Settings.Default.GoedkoopPrice) {
                button22.Enabled = true;
            }

            if(Settings.Default.Money >= Settings.Default.ClickingSpeedPrice) {
                button23.Enabled = true;
            }

            if(Settings.Default.Money >= Settings.Default.CPSPrice) {
                button24.Enabled = true;
            }

            if(Settings.Default.Money >= Settings.Default.BankPrice) {
                button25.Enabled = true;
            }

            //

            if(Settings.Default.Money <= Settings.Default.GoedkoopPrice - 1) {
                button22.Enabled = false;
            }

            if(Settings.Default.Money <= Settings.Default.ClickingSpeedPrice - 1) {
                button23.Enabled = false;
            }

            if(Settings.Default.Money <= Settings.Default.CPSPrice - 1) {
                button24.Enabled = false;
            }

            if(Settings.Default.Money <= Settings.Default.BankPrice - 1) {
                button25.Enabled = false;
            }

            //

            if(Settings.Default.Money <= Settings.Default.UniversePrice - 1) {
                button17.Enabled = false;
            }

            if(Settings.Default.XP <= Settings.Default.GodPrice - 1) {
                button18.Enabled = false;
            }

            if(Settings.Default.Money <= Settings.Default.ClickerPrice - 1) {
                button1.Enabled = false;
            }

            if(Settings.Default.Money <= Settings.Default.FarmPrice - 1) {
                button3.Enabled = false;
            }

            if(Settings.Default.Money <= Settings.Default.MinePrice - 1) {
                button4.Enabled = false;
            }

            if(Settings.Default.Money <= Settings.Default.VillagePrice - 1) {
                button5.Enabled = false;
            }

            if(Settings.Default.Money <= Settings.Default.CityPrice - 1) {
                button6.Enabled = false;
            }

            if(Settings.Default.Money <= Settings.Default.CountryPrice - 1) {
                button7.Enabled = false;
            }

            if(Settings.Default.Money <= Settings.Default.PlanetPrice - 1) {
                button8.Enabled = false;
            }

            if(Settings.Default.Money <= Settings.Default.GalaxyPrice - 1) {
                button9.Enabled = false;
            }

            if(Settings.Default.XP <= Settings.Default.ClickingPrice - 1) {
                button10.Enabled = false;
            }

            #region true

            if(Settings.Default.Money >= Settings.Default.UniversePrice) {
                button17.Enabled = true;
            }

            if(Settings.Default.XP >= Settings.Default.GodPrice) {
                button18.Enabled = true;
            }
            if(Settings.Default.Money >= Settings.Default.ClickerPrice) {
                button1.Enabled = true;
            }

            if(Settings.Default.Money >= Settings.Default.FarmPrice) {
                button3.Enabled = true;
            }

            if(Settings.Default.Money >= Settings.Default.MinePrice) {
                button4.Enabled = true;
            }

            if(Settings.Default.Money >= Settings.Default.VillagePrice) {
                button5.Enabled = true;
            }

            if(Settings.Default.Money >= Settings.Default.CityPrice) {
                button6.Enabled = true;
            }

            if(Settings.Default.Money >= Settings.Default.CountryPrice) {
                button7.Enabled = true;
            }

            if(Settings.Default.Money >= Settings.Default.PlanetPrice) {
                button8.Enabled = true;
            }

            if(Settings.Default.Money >= Settings.Default.GalaxyPrice) {
                button9.Enabled = true;
            }

            if(Settings.Default.XP >= Settings.Default.ClickingPrice) {
                button10.Enabled = true;
            }

            if(Settings.Default.Money >= 5000) {
                button26.Enabled = true;
            }

            if(Settings.Default.Money >= 100000) {
                button27.Enabled = true;
            }

            if(Settings.Default.Money >= 1000000000) {
                button28.Enabled = true;
            }

            if(Settings.Default.Money >= 25000000000) {
                button29.Enabled = true;
            }

            if(Settings.Default.Money <= 5000 - 1) {
                button26.Enabled = false;
            }

            if(Settings.Default.Money <= 100000 - 1) {
                button27.Enabled = false;
            }

            if(Settings.Default.Money <= 1000000000 - 1) {
                button28.Enabled = false;
            }

            if(Settings.Default.Money <= 25000000000 - 1) {
                button29.Enabled = false;
            }

            if(Settings.Default.OpBank <= -1) {
                label26.ForeColor = Color.Red;
            }

            if(Settings.Default.OpBank >= 0) {
                label26.ForeColor = Color.Black;
            }

            #endregion true

            Settings.Default.Ticks++;
        }

        #endregion Snelle timer

        #region cheats

        private void button11_Click(object sender, EventArgs e) {
            Cheat.Execute(textBox1.Text);
            textBox1.Clear();
        }

        #endregion cheats

        #region bank

        private void timer3_Tick(object sender, EventArgs e) {


        }

        private void label25_Click(object sender, EventArgs e) {
            Settings.Default.OpBank += Settings.Default.Money;
            Settings.Default.Money = 0;
        }

        #endregion bank

        #region kazi

        private void Kaziknop_MouseClick(object sender, MouseEventArgs e) {
            Settings.Default.Money += Settings.Default.ClickingSpeed;
            Settings.Default.TotalClicks += 1;
            Settings.Default.XP++;

            //button30.Visible = false;

            if(checkBox1.Checked == false) {
                switch(rd.Next(5)) {
                    case 0:
                        Click_1.Play();
                        break;

                    case 1:
                        Click_2.Play();
                        break;

                    case 2:
                        Click_3.Play();
                        break;

                    case 3:
                        Click_4.Play();
                        break;

                    case 4:
                        Click_5.Play();
                        break;
                }
            }
        }

        #endregion kazi

        #region color

        private void button19_Click(object sender, EventArgs e) {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        #endregion color


        #region antispam

        #endregion antispam

        #region shop

        private void button1_Click(object sender, EventArgs e) {

            Settings.Default.XP += 5;
            Settings.Default.CPS += Settings.Default.ClickerSpeed;
            Settings.Default.Money -= Settings.Default.ClickerPrice;
            Settings.Default.ClickerPrice += 5;
            Settings.Default.ClickerAmount += 1;
        }

        private void button3_Click(object sender, EventArgs e) {

            Settings.Default.XP += 25;
            Settings.Default.CPS += Settings.Default.FarmSpeed;
            Settings.Default.Money -= Settings.Default.FarmPrice;
            Settings.Default.FarmPrice += 25;
            Settings.Default.FarmAmount += 1;
        }

        private void button4_Click(object sender, EventArgs e) {

            Settings.Default.XP += 50;
            Settings.Default.CPS += Settings.Default.MineSpeed;
            Settings.Default.Money -= Settings.Default.MinePrice;
            Settings.Default.MinePrice += 50;
            Settings.Default.MineAmount += 1;
        }

        private void button5_Click(object sender, EventArgs e) {

            Settings.Default.XP += 100;
            Settings.Default.CPS += Settings.Default.VillageSpeed;
            Settings.Default.Money -= Settings.Default.VillagePrice;
            Settings.Default.VillagePrice += 100;
            Settings.Default.VillageAmount += 1;
        }

        private void button6_Click(object sender, EventArgs e) {

            Settings.Default.XP += 200;
            Settings.Default.CPS += Settings.Default.CitySpeed;
            Settings.Default.Money -= Settings.Default.CityPrice;
            Settings.Default.CityPrice += 200;
            Settings.Default.CityAmount += 1;
        }

        private void button7_Click(object sender, EventArgs e) {

            Settings.Default.XP += 350;
            Settings.Default.CPS += Settings.Default.CountrySpeed;
            Settings.Default.Money -= Settings.Default.CountryPrice;
            Settings.Default.CountryPrice += 350;
            Settings.Default.CountryAmount += 1;
        }

        private void button8_Click(object sender, EventArgs e) {

            Settings.Default.XP += 500;
            Settings.Default.CPS += Settings.Default.PlanetSpeed;
            Settings.Default.Money -= Settings.Default.PlanetPrice;
            Settings.Default.PlanetPrice += 500;
            Settings.Default.PlanetAmount += 1;
        }

        private void button9_Click(object sender, EventArgs e) {

            Settings.Default.XP += 1000;
            Settings.Default.CPS += Settings.Default.GalaxySpeed;
            Settings.Default.Money -= Settings.Default.GalaxyPrice;
            Settings.Default.GalaxyPrice += 1000;
            Settings.Default.GalaxyAmount += 1;
        }

        private void button17_Click(object sender, EventArgs e) {
            Settings.Default.XP += 5000000;
            Settings.Default.CPS += Settings.Default.UniverseSpeed;
            Settings.Default.Money -= Settings.Default.UniversePrice;
            Settings.Default.UniversePrice += 5000000;
            Settings.Default.UniverseAmount += 1;
            Settings.Default.UniverseSpeed += 50;
            if(Settings.Default.TickSpeed > 250) {
                Settings.Default.TickSpeed -= 1;
                clock.Interval = Settings.Default.TickSpeed;
            }
        }

        private void button18_Click(object sender, EventArgs e) {
            Settings.Default.CPS *= 10;
            Settings.Default.XP -= Settings.Default.GodPrice;
            Settings.Default.GodAmount += 1;
            Settings.Default.GodPrice *= 15;
        }

        private void button10_Click(object sender, EventArgs e) {
            Settings.Default.XP -= Settings.Default.ClickingPrice;
            Settings.Default.ClickingSpeed *= 2;
            Settings.Default.ClickingPrice *= 2;
            Settings.Default.ClickingAmount += 1;
        }

        #endregion shop

        #region upgrades

        private void button22_Click(object sender, EventArgs e) {
            Settings.Default.XP += 1000;
            Settings.Default.Money -= Settings.Default.GoedkoopPrice;
            Settings.Default.GoedkoopPrice *= 2;
            if(Settings.Default.ClickerPrice >= 6) {
                Settings.Default.ClickerPrice -= 5;
            }

            if(Settings.Default.FarmPrice >= 11) {
                Settings.Default.FarmPrice -= 10;
            }

            if(Settings.Default.MinePrice >= 26) {
                Settings.Default.MinePrice -= 25;
            }

            if(Settings.Default.VillagePrice > 51) {
                Settings.Default.VillagePrice -= 50;
            }

            if(Settings.Default.CityPrice >= 101) {
                Settings.Default.CityPrice -= 100;
            }

            if(Settings.Default.CountryPrice >= 251) {
                Settings.Default.CountryPrice -= 250;
            }

            if(Settings.Default.PlanetPrice >= 1001) {
                Settings.Default.PlanetPrice -= 1000;
            }

            if(Settings.Default.GalaxyPrice >= 2001) {
                Settings.Default.GalaxyPrice -= 2000;
            }
        }

        private void button23_Click(object sender, EventArgs e) {
            Settings.Default.XP += 10000;
            Settings.Default.Money -= Settings.Default.ClickingSpeedPrice;
            Settings.Default.ClickingSpeedPrice += 50000;
            Settings.Default.ClickingSpeed += 10;
        }

        private void button24_Click(object sender, EventArgs e) {
            Settings.Default.XP += 10000;
            Settings.Default.ClickerSpeed += 1;
            Settings.Default.FarmSpeed += 3;
            Settings.Default.MineSpeed += 5;
            Settings.Default.VillageSpeed += 10;
            Settings.Default.CitySpeed += 20;
            Settings.Default.CountrySpeed += 35;
            Settings.Default.PlanetSpeed += 50;
            Settings.Default.GalaxySpeed += 70;
            Settings.Default.UniverseSpeed += 100000;
            Settings.Default.CPSPrice *= 3;
        }

        private void button25_Click(object sender, EventArgs e) {
            Settings.Default.XP += 10000;
            Settings.Default.Money -= Settings.Default.BankPrice;
            Settings.Default.BankPrice *= 2;
            Settings.Default.BankRente += 1;
        }

        #endregion upgrades

        #region loterij

        private void button26_Click(object sender, EventArgs e) {
            Settings.Default.XP += 200;
            switch(rd.Next(4)) {
                case 1:
                    MessageBox.Show("You won!!!");
                    Settings.Default.Money += 10000;
                    break;

                default:
                    MessageBox.Show("You lost :(");
                    Settings.Default.Money -= 5000;
                    break;
            }
        }

        private void button27_Click(object sender, EventArgs e) {
            Settings.Default.XP += 2000;
            switch(rd.Next(13)) {
                case 1:
                    MessageBox.Show("You won!!!");
                    Settings.Default.Money += 1000000;
                    break;

                default:
                    MessageBox.Show("You lost :(");
                    Settings.Default.Money -= 100000;
                    break;
            }
        }

        private void button28_Click(object sender, EventArgs e) {
            Settings.Default.XP += 20000;
            switch(rd.Next(28)) {
                case 0:
                    MessageBox.Show("You won!!!!");
                    Settings.Default.Money += 25000000000;
                    break;

                default:
                    MessageBox.Show("You lost :(");
                    Settings.Default.Money -= 1000000000;
                    break;
            }
        }

        private void button29_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("This is a dangerous lotery, because there is a 10% change that your save file will be deleted!", "Are you still sure", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes) {
                Settings.Default.XP += 100000;
                switch(rd.Next(10)) {
                    case 0:
                        MessageBox.Show("You won!!!!");
                        Settings.Default.Money += 1000000000000;
                        break;

                    case 1:
                        MessageBox.Show("You Won!!!!");
                        Settings.Default.Money += 1000000000000;
                        break;

                    case 2:
                        Settings.Default.Reset();
                        MessageBox.Show("Too bad, your save is already deleted D;");
                        Thread.Sleep(1000);
                        this.Close();
                        break;

                    default:
                        MessageBox.Show("You didn't win anything :(");
                        Settings.Default.Money -= 25000000000;
                        break;
                }
            } else if(dialogResult == DialogResult.No) {
                MessageBox.Show("Haha wimp!");
            }
        }

        #endregion loterij

        #region hackm8

        private void button30_Click_1(object sender, EventArgs e) {
            Settings.Default.ClickerPrice = 1;
            Settings.Default.FarmPrice = 1;
            Settings.Default.MinePrice = 1;
            Settings.Default.VillagePrice = 1;
            Settings.Default.CityPrice = 1;
            Settings.Default.CountryPrice = 1;
            Settings.Default.PlanetPrice = 1;
            Settings.Default.GalaxyPrice = 1;
            Settings.Default.UniversePrice = 1;
            Settings.Default.GodPrice = 1;
            Settings.Default.ClickingPrice = 1;
        }

        private void button31_Click(object sender, EventArgs e) {
            Settings.Default.Money += 100000;
        }

        private void button32_Click(object sender, EventArgs e) {
            Settings.Default.Money += 1000000;
        }

        private void button33_Click(object sender, EventArgs e) {
            Settings.Default.Money += 1000000000;
        }

        private void button34_Click(object sender, EventArgs e) {
            Settings.Default.CPS += 100000;
        }

        private void button35_Click(object sender, EventArgs e) {
            Settings.Default.CPS += 1000000;
        }

        private void button36_Click(object sender, EventArgs e) {
            Settings.Default.CPS += 1000000000;
        }

        #endregion hackm8

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void randomEvents_Tick(object sender, EventArgs e) {
            switch(rd.Next(10)) {
                case 0:
                    if(Settings.Default.OpBank >= 10 && !Settings.Default.HasFireWall) {
                        Settings.Default.OpBank = Convert.ToInt64(Settings.Default.OpBank / Settings.Default.BankRente * -2);
                    }

                    if(Settings.Default.OpBank <= -1) {
                        MessageBox.Show("Oh no your bankaccount was hacked! You have " + Settings.Default.OpBank + " Dollar debt!!");
                    }
                    break;

                case 1:
                    MessageBox.Show("Taxes have been raised, 20% less CPS.");
                    Settings.Default.Money = Convert.ToInt64(0.80 * Settings.Default.Money);
                    break;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            if(checkBox1.Checked) {
                if(!hell) {
                    KaziMusic.PlayLooping();
                } else {

                }
            } else
                KaziMusic.Stop();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            if(!Cheater) {
                Settings.Default.Save();
            }

            if(Cheater) {
                MessageBox.Show("It looks like you've cheated, your game won't get saved because of this.");
            }
        }

        private void button16_Click(object sender, EventArgs e) {
            if(MessageBox.Show("Are you sure", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                Settings.Default.Reset();
            }
        }

        private void button20_Click(object sender, EventArgs e) {
            Wiki wiki = new Wiki();
            wiki.Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            Settings.Default.Money += Convert.ToInt64(Settings.Default.XP * Settings.Default.XPToMoney);
            Settings.Default.XP = 0;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) {
            if(checkBox2.Checked) {
                checkBox2.Enabled = false;
            }
        }

        private void button12_Click_1(object sender, EventArgs e) { //deposit
            Settings.Default.OpBank += Settings.Default.Money;
            Settings.Default.Money = 0;
        }

        private void button13_Click_1(object sender, EventArgs e) { //withdraw
            if(!checkBox2.Checked) {
                Settings.Default.Money += Settings.Default.OpBank;
                Settings.Default.OpBank = 0;
            } else {
                MessageBox.Show("You can't withdraw now, because you allowed your money to be invested. Come back later to withdraw your money.");
            }
        }

        public string NiceNumber(long num) {
            if(num < 1000)
                return num.ToString();
            if(num >= 1000 && num < 1000000)
                return (Math.Round(Convert.ToDecimal(num) / 1000, 1)).ToString() + "K";
            if(num >= 1000000 && num < 1000000000)
                return (Math.Round(Convert.ToDecimal(num) / 1000000, 1)).ToString() + "M";
            if(num >= 1000000000 && num < 1000000000000)
                return (Math.Round(Convert.ToDecimal(num) / 1000000000, 1)).ToString() + "B";
            if(num >= 1000000000000 && num < 1000000000000000)
                return (Math.Round(Convert.ToDecimal(num) / 1000000000000, 1)).ToString() + "T";
            if(num >= 1000000000000000 && num < 1000000000000000000)
                return (Math.Round(Convert.ToDecimal(num) / 1000000000000000, 1)).ToString() + "Qa";
            if(num >= 1000000000000000000)
                return (Math.Round(Convert.ToDecimal(num) / 1000000000000000000, 1)).ToString() + "Qi";
            else
                return "ERR";
        }

        private void button14_Click(object sender, EventArgs e) {
            Settings.Default.XP -= Settings.Default.XPMinePrice;
            Settings.Default.XPMinePrice += 10000;
            Settings.Default.XPMineAmount++;
            Settings.Default.XPCPS += Settings.Default.XPMineSpeed;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e) {
            if(checkBox4.Checked) {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
            }

            if(!checkBox4.Checked) {
                panel1.Visible = true;
                panel2.Visible = true;
                panel3.Visible = true;
                panel4.Visible = true;
            }
        }
        private void button15_Click(object sender, EventArgs e) {
            Settings.Default.Money += 1000000;
            Settings.Default.CPS -= 1000;
        }

        private void button15_Click_1(object sender, EventArgs e) {
            Settings.Default.HasFireWall = true;
            Settings.Default.Money -= Settings.Default.FireWallPrice;
        }

        private void second_Tick(object sender, EventArgs e) {
            label69.Text = "FPS: " + Settings.Default.Ticks.ToString();
            Settings.Default.Ticks = 0;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter && textBox1.Text != "") {
                Cheat.Execute(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e) {
            panel1.BackColor = Color.FromArgb(rd.Next(50, 256), rd.Next(50, 256), rd.Next(50, 256));
            button12.BackColor = panel1.BackColor;
            button13.BackColor = panel1.BackColor;
            Settings.Default.AccentColor = panel1.BackColor;
        }

        private void pictureBox9_Click(object sender, EventArgs e) {
            BackColor = Color.FromArgb(rd.Next(50, 256), rd.Next(50, 256), rd.Next(50, 256));
            panel2.BackColor = BackColor;
            panel3.BackColor = BackColor;
            panel4.BackColor = BackColor;
            Kaziknop.FlatAppearance.MouseDownBackColor = BackColor;
            Kaziknop.FlatAppearance.MouseOverBackColor = BackColor;
            Settings.Default.BackColor = BackColor;
        }
    }
}