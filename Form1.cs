using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Xml.Serialization;
using System.IO;
using System.Media;
using System.Diagnostics;
using System.Numerics;
using System.Printing;

namespace Kaziklikker
{
    public partial class Form1 : Form
    {
        SoundPlayer Click_1 = new SoundPlayer("Click_1.wav");
        SoundPlayer Click_2 = new SoundPlayer("Click_2.wav");
        SoundPlayer Click_3 = new SoundPlayer("Click_3.wav");
        SoundPlayer Click_4 = new SoundPlayer("Click_4.wav");
        SoundPlayer Click_5 = new SoundPlayer("Click_5.wav");

        

        Random rd = new Random();

        
        #region ints
        
        public long Money = 5;
        public long CPS = 0;
        public long ClickerPrice = 25;
        public long FarmPrice = 125;
        public long MinePrice = 250;
        public long VillagePrice = 750;
        public long CityPrice = 1500;
        public long CountryPrice = 2500;
        public long PlanetPrice = 12500;
        public long GalaxyPrice = 25000;
        public long ClickingPrice = 750;
        public long ClickingSpeed = 1;
        public long ClickerAmount = 0;
        public long FarmAmount = 0;
        public long MineAmount = 0;
        public long VillageAmount = 0;
        public long CityAmount = 0;
        public long CountryAmount = 0;
        public long PlanetAmount = 0;
        public long GalaxyAmount = 0;
        public long ClickingAmount = 0;
        public long BankRente = 11;
        public long ClickerSpeed = 1;
        public long FarmSpeed = 3;
        public long MineSpeed = 5;
        public long VillageSpeed = 10;
        public long CitySpeed = 20;
        public long CountrySpeed = 35;
        public long PlanetSpeed = 50;
        public long GalaxySpeed = 75;
        public long OpBank = 0;
        public long ClickerBuffer = 0;
        public long FarmBuffer = 0;
        public long MineBuffer = 0;
        public long VillageBuffer = 0;
        public long CityBuffer = 0;
        public long CountryBuffer = 0;
        public long PlanetBuffer = 0;
        public long GalaxyBuffer = 0;
        public long UniverseBuffer = 0;
        public long UniversePrice = 25000000;
        public long UniverseAmount = 0;
        public long UniverseSpeed = 100000;
        public long GodPrice = 250000000;
        public long GodAmount = 0;
        public long TotalClicks = 0;
        public long GoedkoopPrice = 100000;
        public long ClickingSpeedPrice = 100000;
        public long CPSprice = 1000000;
        public long BankPrice = 1000000;
        public decimal Spam;

        public int TickSpeed = 1000;
        public int CreditsBuffer = 0;

        public bool SellMode = false;
        public bool Cheater = false;
        #endregion

        #region strings
        public string ClickerString = "Snellevingers";
        public string FarmString = "Boerenleven";
        public string MineString = "Minecraft";
        public string VillageString = "Mooidorp";
        public string CityString = "Dacity";
        public string CountryString = "Tataland";
        public string PlanetString = "Megapower";
        public string GalaxyString = "Nasa2050";
        public string UniverseString = "Nasa2070";
        public string GodString = "kazi is leven";
        public string CodeUnlocked = "Je hebt een nieuwe cheat-code uitgefabt! ";
        public string Pad = "C:/Kazi-apps/Kaziklikker/";
        #endregion

        #region opstarten
        //later contextmenu
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Clock
        private void timer1_Tick(object sender, EventArgs e)
        {
            Money += CPS;
        }
        #endregion

        #region Snelle timer
        private void timer2_Tick(object sender, EventArgs e)
        {
            //Label update
            this.Text = Money.ToString() + " Money!";
            label38.Text = GoedkoopPrice.ToString();
            label39.Text = ClickingSpeedPrice.ToString();
            label40.Text = CPSprice.ToString();
            label41.Text = BankPrice.ToString();
            label1.Text = Money.ToString();
            label2.Text = CPS.ToString();
            label3.Text = ClickerPrice.ToString();
            label4.Text = FarmPrice.ToString();
            label5.Text = MinePrice.ToString();
            label6.Text = VillagePrice.ToString();
            label7.Text = CityPrice.ToString();
            label8.Text = CountryPrice.ToString();
            label9.Text = PlanetPrice.ToString();
            label10.Text = GalaxyPrice.ToString();
            label11.Text = ClickingPrice.ToString();
            label28.Text = UniversePrice.ToString();
            label29.Text = GodPrice.ToString();
            label12.Text = ClickerAmount.ToString();
            label13.Text = FarmAmount.ToString();
            label14.Text = MineAmount.ToString();
            label15.Text = VillageAmount.ToString();
            label16.Text = CityAmount.ToString();
            label17.Text = CountryAmount.ToString();
            label18.Text = PlanetAmount.ToString();
            label19.Text = GalaxyAmount.ToString();
            label20.Text = ClickingSpeed.ToString();
            label30.Text = UniverseAmount.ToString();
            label31.Text = GodAmount.ToString();
            label33.Text = TotalClicks.ToString();
            label26.Text = OpBank.ToString();
            label27.Text = BankRente.ToString();
            
            #region Sellmode

            if (SellMode == true)
            {
                if (ClickerAmount == 0)
                {
                    button1.Enabled = false;
                }

                if (FarmAmount == 0)
                {
                    button3.Enabled = false;
                }

                if (MineAmount == 0)
                {
                    button4.Enabled = false;
                }

                if (VillageAmount == 0)
                {
                    button5.Enabled = false;
                }

                if (CityAmount == 0)
                {
                    button6.Enabled = false;
                }

                if (CountryAmount == 0)
                {
                    button7.Enabled = false;
                }

                if (PlanetAmount == 0)
                {
                    button8.Enabled = false;
                }

                if (GalaxyAmount == 0)
                {
                    button9.Enabled = false;
                }

                //
                //
                //

                if (ClickerAmount >= 1)
                {
                    button1.Enabled = true;
                }

                if (FarmAmount >= 1)
                {
                    button3.Enabled = true;
                }

                if (MineAmount >= 1)
                {
                    button4.Enabled = true;
                }

                if (VillageAmount >= 1)
                {
                    button5.Enabled = true;
                }

                if (CityAmount >= 1)
                {
                    button6.Enabled = true;
                }

                if (CountryAmount >= 1)
                {
                    button7.Enabled = true;
                }

                if (PlanetAmount >= 1)
                {
                    button8.Enabled = true;
                }

                if (GalaxyAmount >= 1)
                {
                    button9.Enabled = true;
                }
            }

            #endregion

            if (SellMode == false)
            {
                if (GodAmount >= 5)
                {
                    button18.Enabled = false;
                }

                if (Money >= GoedkoopPrice)
                {
                    button22.Enabled = true;
                }

                if (Money >= ClickingSpeedPrice)
                {
                    button23.Enabled = true;
                }

                if (Money >= CPSprice)
                {
                    button24.Enabled = true;
                }

                if (Money >= BankPrice)
                {
                    button25.Enabled = true;
                }

                //
                
                if (Money <= GoedkoopPrice - 1)
                {
                    button22.Enabled = false;
                }

                if (Money <= ClickingSpeedPrice - 1)
                {
                    button23.Enabled = false;
                }

                if (Money <= CPSprice - 1)
                {
                    button24.Enabled = false;
                }

                if (Money <= BankPrice - 1)
                {
                    button25.Enabled = false;
                }

                //

                if (Money <= UniversePrice - 1)
                {
                    button17.Enabled = false;
                }

                if (Money <= GodPrice - 1 && GodAmount <= 4)
                {
                    button18.Enabled = false;
                }

                if (Money <= ClickerPrice - 1)
                {
                    button1.Enabled = false;
                }

                if (Money <= FarmPrice - 1)
                {
                    button3.Enabled = false;
                }

                if (Money <= MinePrice - 1)
                {
                    button4.Enabled = false;
                }

                if (Money <= VillagePrice - 1)
                {
                    button5.Enabled = false;
                }

                if (Money <= CityPrice - 1)
                {
                    button6.Enabled = false;
                }

                if (Money <= CountryPrice - 1)
                {
                    button7.Enabled = false;
                }

                if (Money <= PlanetPrice - 1)
                {
                    button8.Enabled = false;
                }

                if (Money <= GalaxyPrice - 1)
                {
                    button9.Enabled = false;
                }

                if (Money <= ClickingPrice - 1)
                {
                    button10.Enabled = false;
                }

                #region true
                if (Money >= UniversePrice)
                {
                    button17.Enabled = true;
                }

                if (Money >= GodPrice)
                {
                    button18.Enabled = true;
                }
                if (Money >= ClickerPrice)
                {
                    button1.Enabled = true;
                }

                if (Money >= FarmPrice)
                {
                    button3.Enabled = true;
                }

                if (Money >= MinePrice)
                {
                    button4.Enabled = true;
                }

                if (Money >= VillagePrice)
                {
                    button5.Enabled = true;
                }

                if (Money >= CityPrice)
                {
                    button6.Enabled = true;
                }

                if (Money >= CountryPrice)
                {
                    button7.Enabled = true;
                }

                if (Money >= PlanetPrice)
                {
                    button8.Enabled = true;
                }

                if (Money >= GalaxyPrice)
                {
                    button9.Enabled = true;
                }

                if (Money >= ClickingPrice)
                {
                    button10.Enabled = true;
                }
            }
            if (Money >= 10000)
            {
                button13.Enabled = true;
                pictureBox7.Enabled = true;
            }

            if (OpBank >= 10000)
            {
                button12.Enabled = true;
                pictureBox6.Enabled = true;
            }

            if (Money <= 9999)
            {
                button13.Enabled = false;
                pictureBox7.Enabled = false;
            }

            if (OpBank <= 9999)
            {
                button12.Enabled = false;
                pictureBox6.Enabled = false;
            }

            if (Money >= 5000)
            {
                button26.Enabled = true;
            }

            if (Money >= 100000)
            {
                button27.Enabled = true;
            }

            if (Money >= 1000000000)
            {
                button28.Enabled = true;
            }

            if (Money >= 25000000000)
            {
                button29.Enabled = true;
            }

            if (Money <= 5000 - 1)
            {
                button26.Enabled = false;
            }

            if (Money <= 100000 - 1)
            {
                button27.Enabled = false;
            }

            if (Money <= 1000000000 - 1)
            {
                button28.Enabled = false;
            }

            if (Money <= 25000000000 - 1)
            {
                button29.Enabled = false;
            }

            if (OpBank <= -1)
            {
                label26.ForeColor = Color.Red;
            }

            if (OpBank >= 0)
            {
                label26.ForeColor = Color.Black;
            }
            #endregion


        }
        #endregion

        #region cheats
        private void button11_Click(object sender, EventArgs e)
        {
            #region cheats

            if (textBox1.Text == "hackm8")
            {
                button30.Visible = true;
                button31.Visible = true;
                button32.Visible = true;
                button33.Visible = true;
                button34.Visible = true;
                button35.Visible = true;
                button36.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
                label54.Visible = true;
            }

            if (textBox1.Text == ClickerString)
            {
                ClickerPrice = 1;
            }

            if (textBox1.Text == FarmString)
            {
                FarmPrice = 1;
            }

            if (textBox1.Text == MineString)
            {
                MinePrice = 1;
            }

            if (textBox1.Text == VillageString)
            {
                VillagePrice = 1;
            }

            if (textBox1.Text == CityString)
            {
                CityPrice = 1;
            }

            if (textBox1.Text == CountryString)
            {
                CountryPrice = 1;
            }

            if (textBox1.Text == PlanetString)
            {
                PlanetPrice = 1;

            }

            if (textBox1.Text == GalaxyString)
            {
                GalaxyPrice = 1;
            }

            if (textBox1.Text == UniverseString)
            {
                UniversePrice = 1;
            }

            if (textBox1.Text == GodString)
            {
                GodPrice = 1;
            }

            #endregion
            this.KeyPreview = true;
        }
        #endregion

        #region bank
        public void button13_Click(object sender, EventArgs e)
        {
            Money -= 10000;
            OpBank += 10000;
        }

        public void button12_Click(object sender, EventArgs e)
        {
            Money += 10000;
            OpBank -= 10000;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            OpBank = OpBank / 10 * BankRente;
        }

        private void label25_Click(object sender, EventArgs e)
        {
            OpBank += Money;
            Money = 0;
        }

        private void label25_DoubleClick(object sender, EventArgs e)
        {
            Money += OpBank;
            OpBank = 0;
        }
        #endregion

        #region save
        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Clear();
                textBox1.AppendText("Saving game...");
                button14.Enabled = false;
                Thread.Sleep(1000);
                textBox1.Clear();
                textBox1.AppendText("Enter cheat-code");
                MessageBox.Show("Kazidata.xml Saved.");
                Information info = new Information();
                info.Money = Money;
                info.CPS = CPS;
                info.ClickerPrice = ClickerPrice;
                info.FarmPrice = FarmPrice;
                info.MinePrice = MinePrice;
                info.VillagePrice = VillagePrice;
                info.CityPrice = CityPrice;
                info.CountryPrice = CountryPrice;
                info.PlanetPrice = PlanetPrice;
                info.GalaxyPrice = GalaxyPrice;
                info.ClickerAmount = ClickerAmount;
                info.FarmAmount = FarmAmount;
                info.MineAmount = MineAmount;
                info.VillageAmount = VillageAmount;
                info.CityAmount = CityAmount;
                info.CountryAmount = CountryAmount;
                info.PlanetAmount = PlanetAmount;
                info.GalaxyAmount = GalaxyAmount;
                info.ClickingAmount = ClickingAmount;
                info.ClickingSpeed = ClickingSpeed;
                info.ClickingPrice = ClickingPrice;
                info.BankRente = BankRente;
                info.OpBank = OpBank;
                info.GodAmount = GodAmount;
                info.GodPrice = GodPrice;
                info.UniverseAmount = UniverseAmount;
                info.UniversePrice = UniversePrice;
                info.UniverseSpeed = UniverseSpeed;
                info.TotalClicks = TotalClicks;
                info.TickSpeed = TickSpeed;
                info.GoedkoopPrice = GoedkoopPrice;
                info.ClickingSpeedPrice = ClickingSpeedPrice;
                info.CPSprice = CPSprice;
                info.BankPrice = BankPrice;
                SaveXML.SaveData(info, "kazidata.xml");
                button14.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region laad
        private void button15_Click(object sender, EventArgs e)
        {
            if (File.Exists("kazidata.xml"))
            {
                textBox1.Clear();
                textBox1.AppendText("Loading game...");
                button15.Enabled = false;
                Thread.Sleep(1000);
                textBox1.Clear();
                textBox1.AppendText("Enter cheat-code");
                XmlSerializer xs = new XmlSerializer(typeof(Information));
                FileStream read = new FileStream("kazidata.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                Information info = (Information)xs.Deserialize(read);
                CPS = info.CPS;
                Money = info.Money;
                ClickerPrice = info.ClickerPrice;
                FarmPrice = info.FarmPrice;
                MinePrice = info.MinePrice;
                VillagePrice = info.VillagePrice;
                CityPrice = info.CityPrice;
                CountryPrice = info.CountryPrice;
                PlanetPrice = info.PlanetPrice;
                GalaxyPrice = info.GalaxyPrice;
                ClickerAmount = info.CountryAmount;
                FarmAmount = info.FarmAmount;
                MineAmount = info.MineAmount;
                VillageAmount = info.VillageAmount;
                CityAmount = info.CityAmount;
                CountryAmount = info.CountryAmount;
                PlanetAmount = info.PlanetAmount;
                GalaxyAmount = info.GalaxyAmount;
                ClickingAmount = info.ClickingAmount;
                ClickingSpeed = info.ClickingSpeed;
                ClickingPrice = info.ClickingPrice;
                BankRente = info.BankRente;
                OpBank = info.OpBank;
                GodAmount = info.GodAmount;
                GodPrice = info.GodPrice;
                UniversePrice = info.UniversePrice;
                UniverseSpeed = info.UniverseSpeed;
                UniverseAmount = info.UniverseAmount;
                TotalClicks = info.TotalClicks;
                TickSpeed = info.TickSpeed;
                GoedkoopPrice = info.GoedkoopPrice;
                ClickingSpeedPrice = info.ClickingSpeedPrice;
                CPSprice = info.CPSprice;
                BankPrice = info.BankPrice;
                button15.Enabled = true;
            }
            else
            {
                MessageBox.Show("File not found");
            }
        }
        #endregion

        #region reset
        private void button16_Click(object sender, EventArgs e)
        {
            Information info = new Information();
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Kaziknop.Image = Image.FromFile("Money.png");
                Money = 0;
                CPS = 0;
                ClickerPrice = 25;
                FarmPrice = 125;
                MinePrice = 250;
                VillagePrice = 750;
                CityPrice = 1500;
                CountryPrice = 2500;
                PlanetPrice = 12500;
                GalaxyPrice = 25000;
                ClickingPrice = 750;
                ClickingSpeed = 1;
                ClickerAmount = 0;
                GodPrice = 250000000;
                GodAmount = 0;
                UniversePrice = 25000000;
                UniverseAmount = 0;
                UniverseBuffer = 0;
                FarmAmount = 0;
                MineAmount = 0;
                VillageAmount = 0;
                CityAmount = 0;
                CountryAmount = 0;
                PlanetAmount = 0;
                GalaxyAmount = 0;
                ClickingAmount = 0;
                BankRente = 11;
                ClickerSpeed = 1;
                FarmSpeed = 3;
                MineSpeed = 5;
                VillageSpeed = 10;
                CitySpeed = 20;
                CountrySpeed = 35;
                PlanetSpeed = 50;
                GalaxySpeed = 75;
                UniverseSpeed = 100000;
                OpBank = 0;
                ClickerBuffer = 0;
                FarmBuffer = 0;
                MineBuffer = 0;
                VillageBuffer = 0;
                CityBuffer = 0;
                CountryBuffer = 0;
                PlanetBuffer = 0;
                GalaxyBuffer = 0;
                TotalClicks = 0;
                TickSpeed = 1000;
                SellMode = false;
                CreditsBuffer = 1;
                checkBox3.Checked = false;
            }
            else if (dialogResult == DialogResult.No)
            {

            }

        }
        #endregion

        #region kazi
        private void Kaziknop_MouseClick(object sender, MouseEventArgs e)
        {
            Money += ClickingSpeed;
            TotalClicks += 1;

            //button30.Visible = false;

            if (checkBox1.Checked == false)
            {
                switch (rd.Next(5))
                {
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
        #endregion

        #region credits
        private void button2_Click_1(object sender, EventArgs e)
        {
            Credits cr = new Credits();
            cr.cred();
            if (CreditsBuffer == 0)
            {
                MessageBox.Show("Bedankt voor het bekijken van de credits! je krijgt 500 geld!");
                CreditsBuffer += 1;
                Money += 500;           
            }
        }
        #endregion

        #region color
        private void button19_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        #endregion

        #region fullscreen
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                this.WindowState = FormWindowState.Maximized;
            }

            if (checkBox2.Checked == false)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        #endregion

        #region sellmode
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                SellMode = true;
                button17.Enabled = false;
                button18.Enabled = false;
                button10.Enabled = false;
                
            }

            if (checkBox3.Checked == false)
            {
                SellMode = false;
            }
        
        }
        #endregion

        #region map
        private void button21_Click(object sender, EventArgs e)
        {
            Process.Start(Pad);
        }
        #endregion
        
        #region wiki
        private void button20_Click(object sender, EventArgs e)
        {
            Wiki wiki = new Wiki();
            wiki.Show();
        }
        #endregion

        #region antispam
        private void timer4_Tick(object sender, EventArgs e)
        {
            Spam -= 1;
        }
        #endregion

        #region shop
        private void button1_Click(object sender, EventArgs e)
        {
            if (SellMode == false)
            {
                CPS += ClickerSpeed;
                Money -= ClickerPrice;
                ClickerPrice += 5;
                ClickerAmount += 1;

                if (ClickerAmount >= 500 && ClickerBuffer == 0)
                {
                    MessageBox.Show(CodeUnlocked + ClickerString);
                    ClickerBuffer += 1;
                }
            }


            if (SellMode == true)
            {
                CPS -= ClickerSpeed;
                Money += 20;
                ClickerPrice -= 5;
                ClickerAmount -= 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (SellMode == false)
            {
                CPS += FarmSpeed;
                Money -= FarmPrice;
                FarmPrice += 25;
                FarmAmount += 1;

                if (FarmAmount >= 500 && FarmBuffer == 0)
                {
                    MessageBox.Show(CodeUnlocked + FarmString);
                    FarmBuffer += 1;
                }
            }

            if (SellMode == true)
            {
                CPS -= FarmSpeed;
                Money += 100;
                FarmPrice -= 25;
                FarmAmount -= 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (SellMode == false)
            {
                CPS += MineSpeed;
                Money -= MinePrice;
                MinePrice += 50;
                MineAmount += 1;

                if (MineAmount >= 500 && MineBuffer == 0)
                {
                    MessageBox.Show(CodeUnlocked + MineString);
                    MineBuffer += 1;
                }
            }

            if (SellMode == true)
            {
                CPS -= MineSpeed;
                Money += 200;
                MinePrice -= 50;
                MineAmount -= 1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (SellMode == false)
            {
                CPS += VillageSpeed;
                Money -= VillagePrice;
                VillagePrice += 100;
                VillageAmount += 1;

                if (VillageAmount >= 500 && VillageBuffer == 0)
                {
                    MessageBox.Show(CodeUnlocked + VillageString);
                    VillageBuffer += 1;
                }
            }

            if (SellMode == true)
            {
                CPS -= VillageSpeed;
                Money += 300;
                VillagePrice -= 100;
                VillageAmount -= 1;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (SellMode == false)
            {
                CPS += CitySpeed;
                Money -= CityPrice;
                //1000ste regel woe-hoe!
                CityPrice += 200;
                CityAmount += 1;
                if (CityAmount >= 500 && CityBuffer == 0)
                {
                    MessageBox.Show(CodeUnlocked + CityString);
                    CityBuffer += 1;
                }
            }

            if (SellMode == true)
            {
                CPS -= CitySpeed;
                Money += 1000;
                CityPrice -= 200;
                CityAmount -= 1;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (SellMode == false)
            {
                CPS += CountrySpeed;
                Money -= CountryPrice;
                CountryPrice += 350;
                CountryAmount += 1;

                if (CountryAmount >= 500 && CountryBuffer == 0)
                {
                    MessageBox.Show(CodeUnlocked + CountryString);
                    CountryBuffer += 1;
                }
            }

            if (SellMode == true)
            {
                CPS -= CountrySpeed;
                Money += 2000;
                CountryPrice -= 350;
                CountryAmount -= 1;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (SellMode == false)
            {
                CPS += PlanetSpeed;
                Money -= PlanetPrice;
                PlanetPrice += 500;
                PlanetAmount += 1;

                if (PlanetAmount >= 500 && PlanetBuffer == 0)
                {
                    MessageBox.Show(CodeUnlocked + PlanetString);
                    PlanetBuffer += 1;
                }
            }

            if (SellMode == true)
            {
                CPS -= PlanetSpeed;
                Money += 10000;
                PlanetPrice -= 500;
                PlanetAmount -= 1;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (SellMode == false)
            {
                CPS += GalaxySpeed;
                Money -= GalaxyPrice;
                GalaxyPrice += 1000;
                GalaxyAmount += 1;

                if (GalaxyAmount >= 500 && GalaxyBuffer == 0)
                {
                    MessageBox.Show(CodeUnlocked + GalaxyString);
                    GalaxyBuffer += 1;
                }
            }

            if (SellMode == true)
            {
                CPS -= GalaxySpeed;
                Money += 20000;
                GalaxyPrice -= 1000;
                GalaxyAmount -= 1;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            CPS += UniverseSpeed;
            Money -= UniversePrice;
            UniversePrice += 5000000;
            UniverseAmount += 1;
            UniverseSpeed += 50;

            if (UniverseAmount >= 500 && UniverseBuffer == 0)
            {
                MessageBox.Show(CodeUnlocked + UniverseString);
                UniverseBuffer += 1;
            }

            if (TickSpeed >= 250)
            {
                TickSpeed -= 1;
                clock.Interval = TickSpeed;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (GodAmount <= 4)
            {
                CPS *= 10;
                Money -= GodPrice;
                GodAmount += 1;
                GodPrice *= 15;
            }

            if (GodAmount >= 5)
            {
                MessageBox.Show("Goden max.");
                button18.Enabled = false;
                Kaziknop.Image = Image.FromFile("Money_God.png");
            }
        }


        private void button10_Click(object sender, EventArgs e)
        {
            Money -= ClickingPrice;
            ClickingSpeed *= 2;
            ClickingPrice *= 2;
            ClickingAmount += 1;
        }

        #endregion

        #region upgrades
        private void button22_Click(object sender, EventArgs e)
        {
            Money -= GoedkoopPrice;
            GoedkoopPrice *= 2;
            if (ClickerPrice >= 6)
            {
                ClickerPrice -= 5;
            }

            if (FarmPrice >= 11)
            {
                FarmPrice -= 10;
            }

            if (MinePrice >= 26)
            {
                MinePrice -= 25;
            }

            if (VillagePrice > 51)
            {
                VillagePrice -= 50;
            }

            if (CityPrice >= 101)
            {
                CityPrice -= 100;
            }

            if (CountryPrice >= 251)
            {
                CountryPrice -= 250;
            }

            if (PlanetPrice >= 1001)
            {
                PlanetPrice -= 1000;
            }

            if (GalaxyPrice >= 2001)
            {
                GalaxyPrice -= 2000;
            }


        }

        private void button23_Click(object sender, EventArgs e)
        {
            Money -= ClickingSpeedPrice;
            ClickingSpeedPrice += 50000;
            ClickingSpeed += 10;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            ClickerSpeed += 1;
            FarmSpeed += 3;
            MineSpeed += 5;
            VillageSpeed += 10;
            CitySpeed += 20;
            CountrySpeed += 35;
            PlanetSpeed += 50;
            GalaxySpeed += 70;
            UniverseSpeed += 100000;
            CPSprice *= 3;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Money -= BankPrice;
            BankPrice *= 2;
            BankRente += 1;
        }
        #endregion

        #region loterij
        private void button26_Click(object sender, EventArgs e)
        {
            switch(rd.Next(4))
            {
                case 1:
                    MessageBox.Show("Je hebt gewonnen!!!!");
                    Money += 10000;
                    break;
                default:
                    MessageBox.Show("Je hebt helaas niks gewonnen :(");
                    Money -= 5000;
                    break;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            switch(rd.Next(13))
            {
                case 1:
                    MessageBox.Show("Je hebt gewonnen!!!!");
                    Money += 1000000;
                    break;
                default:
                    MessageBox.Show("Je hebt helaas niks gewonnen :(");
                    Money -= 100000;
                    break;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            switch(rd.Next(28))
            {
                case 0:
                    MessageBox.Show("Je hebt gewonnen!!!!");
                    Money += 25000000000;
                    break;
                default:
                    MessageBox.Show("Je hebt helaas niks gewonnen :(");
                    Money -= 1000000000;
                    break;
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Dit is een gevaarlijke loterij, er is namelijk 10% kans dat je spel verwijderd word. nog steeds meedoen?", "Weet je het zeker", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                switch (rd.Next(10))
                {
                    case 0:
                        MessageBox.Show("Je hebt gewonnen!!!!");
                        Money += 1000000000000;
                        break;
                    case 1:
                        MessageBox.Show("Je hebt gewonnen!!!!");
                        Money += 1000000000000;
                        break;
                    case 2:
                        File.Delete("Kazidata.xml");
                        MessageBox.Show("Hah, je hebt verloren nu wordt je spel verwijderd!");
                        Thread.Sleep(1000);
                        this.Close();
                        break;
                    default:
                        MessageBox.Show("Je heb helaas niks gewonnen :(");
                        Money -= 25000000000;
                        break;
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Haha watje!");
            }
        }
        #endregion

        #region hackm8
        private void button30_Click_1(object sender, EventArgs e)
        {
            ClickerPrice = 1;
            FarmPrice = 1;
            MinePrice = 1;
            VillagePrice = 1;
            CityPrice = 1;
            CountryPrice = 1;
            PlanetPrice = 1;
            GalaxyPrice = 1;
            UniversePrice = 1;
            GodPrice = 1;
            ClickingPrice = 1;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Money += 100000;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Money += 1000000;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Money += 1000000000;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            CPS += 100000;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            CPS += 1000000;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            CPS += 1000000000;
        }

        #endregion

        #region kleurtjes
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.D1 && Spam <= 100)
            {
                this.Opacity = .10;
                Spam++;
            }

            if (e.KeyCode == Keys.D2 && Spam <= 100)
            {
                this.Opacity = .20;
                Spam++;
            }

            if (e.KeyCode == Keys.D3 && Spam <= 100)
            {
                this.Opacity = .30;
                Spam++;
            }

            if (e.KeyCode == Keys.D4 && Spam <= 100)
            {
                this.Opacity = .40;
                Spam++;
            }

            if (e.KeyCode == Keys.D5 && Spam <= 100)
            {
                this.Opacity = .50;
                Spam++;
            }

            if (e.KeyCode == Keys.D6 && Spam <= 100)
            {
                this.Opacity = .60;
                Spam++;
            }

            if (e.KeyCode == Keys.D7 && Spam <= 100)
            {
                this.Opacity = .70;
                Spam++;
            }

            if (e.KeyCode == Keys.D8 && Spam <= 100)
            {
                this.Opacity = .80;
                Spam++;
            }

            if (e.KeyCode == Keys.D9 && Spam <= 100)
            {
                this.Opacity = .90;
                Spam++;
            }

            if (e.KeyCode == Keys.D0 && Spam <= 100)
            {
                this.Opacity = 100;
                Spam++;
            }

            if (e.KeyCode == Keys.D && Spam <= 100)
            {
                this.BackColor = Color.LightCyan;
                Spam++;
            }

            if (e.KeyCode == Keys.Q && Spam <= 100)
            {
                this.BackColor = Color.Red;
                Spam++;
            }

            if (e.KeyCode == Keys.W && Spam <= 100)
            {
                this.BackColor = Color.Orange;
                Spam++;
            }

            if (e.KeyCode == Keys.E && Spam <= 100)
            {
                this.BackColor = Color.Yellow;
                Spam++;
            }

            if (e.KeyCode == Keys.R && Spam <= 100)
            {
                this.BackColor = Color.Green;
                Spam++;
            }

            if (e.KeyCode == Keys.T && Spam <= 100)
            {
                this.BackColor = Color.Blue;
                Spam++;
            }

            if (e.KeyCode == Keys.Y && Spam <= 100)
            {
                this.BackColor = Color.Magenta;
                Spam++;
            }

            if (e.KeyCode == Keys.F && Spam <= 100)
            {
                this.BackColor = SystemColors.Control;
                Spam++;
            }

            if (e.KeyCode == Keys.G && Spam <= 100)
            {
                this.BackColor = Color.Teal;
                Spam++;
            }

            if(Spam >= 80){ MessageBox.Show("Rustig aan!");}}
#endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.KeyPreview = false;
        }

        private void randomEvents_Tick(object sender, EventArgs e)
        {
            switch (rd.Next(10))
            {
                case 0:                  
                   if (OpBank >= 10)
                   {
                       OpBank = OpBank / BankRente * -2;
                   }

                   if (OpBank <= -1)
                   {
                       MessageBox.Show("Oh nee je bankaccount is gehackt! je hebt nu " + OpBank + " Euro schulden!");
                   }

                   if (OpBank >= 0)
                   {
                       MessageBox.Show("Oh nee je bankaccount is gehackt! je hebt nu nog maar " + OpBank + " Euro!");
                   }
                   break;
            }
        }
    }
}
