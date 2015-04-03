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


namespace Kaziklikker
{
    public partial class Form1 : Form
    {

        #region ints
        Int64 Money = 00;
        Int64 CPS = 0;
        Int64 ClickerPrice = 10;
        Int64 FarmPrice = 50;
        Int64 MinePrice = 100;
        Int64 VillagePrice = 250;
        Int64 CityPrice = 500;
        Int64 CountryPrice = 1000;
        Int64 PlanetPrice = 5000;
        Int64 GalaxyPrice = 10000;
        Int64 ClickingPrice = 1500;
        Int64 ClickingSpeed = 1;
        Int64 ClickerAmount = 0;
        Int64 FarmAmount = 0;
        Int64 MineAmount = 0;
        Int64 VillageAmount = 0;
        Int64 CityAmount = 0;
        Int64 CountryAmount = 0;
        Int64 PlanetAmount = 0;
        Int64 GalaxyAmount = 0;
        Int64 ClickingAmount = 0;
        Int64 BankRente = 11;
        Int64 ClickerSpeed = 1;
        Int64 FarmSpeed = 3;
        Int64 MineSpeed = 5;
        Int64 VillageSpeed = 10;
        Int64 CitySpeed = 20;
        Int64 CountrySpeed = 35;
        Int64 PlanetSpeed = 50;
        Int64 GalaxySpeed = 75;
        Int64 OpBank = 0;
        Int64 Tijd = 0;
        Int64 ClickerBuffer = 0;
        Int64 FarmBuffer = 0;
        Int64 MineBuffer = 0;
        Int64 VillageBuffer = 0;
        Int64 CityBuffer = 0;
        Int64 CountryBuffer = 0;
        Int64 PlanetBuffer = 0;
        Int64 GalaxyBuffer = 0;
        Int64 UniverseBuffer = 0;
        Int64 GodBuffer = 0;
        Int64 WeinigGeldBuffer = 0;
        Int64 VeelGeldBuffer = 0;
        Int64 BankBuffer = 0;
        Int64 UniversePrice = 25000000;
        Int64 UniverseAmount = 0;
        Int64 UniverseSpeed = 100000;
        Int64 GodPrice = 250000000;
        Int64 GodAmount = 0;
        bool Autosave = false;
        #endregion

        #region strings
        string ClickerString = "Kazimoko";
        string FarmString = "Gakeje";
        string MineString = "Bobobobo";
        string VillageString = "Jeoder";
        string CityString = "Hoielkl";
        string CountryString = "Heolaak";
        string PlanetString = "Gekieko";
        string GalaxyString = "Ejobieel";
        string UniverseString = "jehuil";
        string GodString = "Heikenbash";
        #endregion

        #region opstarten
        //later contextmenu
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region Kaziknop
        private void Kaziknop_Click(object sender, EventArgs e)
        {
            Money += ClickingSpeed;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Money += CPS;
        }
        #endregion

        #region Snelle timer
        private void timer2_Tick(object sender, EventArgs e)
        {

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

            label26.Text = OpBank.ToString();
            label27.Text = BankRente.ToString();
            if (Tijd == 59)
            {
                Tijd = 0;
            }

            #region false
            if (GodAmount >= 5)
            {
                button18.Enabled = false;
            }
            if (Money <= UniversePrice)
            {
                button17.Enabled = false;
            }

            if (Money <= GodPrice)
            {
                button18.Enabled = false;
            }

            if (Money <= ClickerPrice)
            {
                button1.Enabled = false;
            }

            if (Money <= FarmPrice)
            {
                button3.Enabled = false;
            }

            if (Money <= MinePrice)
            {
                button4.Enabled = false;
            }

            if (Money <= VillagePrice)
            {
                button5.Enabled = false;
            }

            if (Money <= CityPrice)
            {
                button6.Enabled = false;
            }

            if (Money <= CountryPrice)
            {
                button7.Enabled = false;
            }

            if (Money <= PlanetPrice)
            {
                button8.Enabled = false;
            }

            if (Money <= GalaxyPrice)
            {
                button9.Enabled = false;
            }

            if (Money <= ClickingPrice)
            {
                button10.Enabled = false;
            }

            if (Money <= 999)
            {
                button13.Enabled = false;
            }

            if (OpBank <= 999)
            {
                button12.Enabled = false;
            }


            #endregion

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

            if (Money >= 1000)
            {
                button13.Enabled = true;
            }

            if (OpBank >= 1000)
            {
                button12.Enabled = true;
            }

            #endregion

            if (OpBank >= 5000)
            {
                BankRente = 12;
            }

            if (OpBank >= 10000)
            {
                BankRente = 13;
            }

            if (OpBank >= 50000)
            {
                BankRente = 14;
            }

            if (OpBank >= 100000)
            {
                BankRente = 15;
            }

        }
        #endregion

        #region shop
        private void button1_Click(object sender, EventArgs e)
        {
            CPS += ClickerSpeed;
            Money -= ClickerPrice;
            ClickerPrice += 5;           
            ClickerAmount += 1;

            if (ClickerAmount >= 50 && ClickerBuffer == 0)
            {
                MessageBox.Show("Nieuwe Cheat code gekregen! " + ClickerString);
                ClickerBuffer += 1;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CPS += FarmSpeed;
            Money -= FarmPrice;
            FarmPrice += 25;
            FarmAmount += 1;

            if (FarmAmount >= 50 && FarmBuffer == 0)
            {
                MessageBox.Show("Nieuwe Cheat code gekregen! " + FarmString);
                FarmBuffer += 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CPS += MineSpeed;
            Money -= MinePrice;
            MinePrice += 50;
            MineAmount +=1;

            if (MineAmount >= 50 && MineBuffer == 0) 
            {
                MessageBox.Show("Nieuwe Cheat code gekregen! " + MineString);
                MineBuffer += 1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CPS += VillageSpeed;
            Money -= VillagePrice;
            VillagePrice += 100;
            VillageAmount += 1;

            if (VillageAmount >= 50 && VillageBuffer == 0)
            {
                MessageBox.Show("Nieuwe Cheat code gekregen! " + VillageString);
                VillageBuffer += 1;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CPS += CitySpeed;
            Money -= CityPrice;
            CityPrice += 200;
            CityAmount += 1;

            if (CityAmount >= 50 && CityBuffer == 0)
            {
                MessageBox.Show("Nieuwe Cheat code gekregen! " + CityString);
                CityBuffer += 1;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CPS += CountrySpeed;
            Money -= CountryPrice;
            CountryPrice += 350;
            CountryAmount += 1;
            CountrySpeed += 1;

            if (CountryAmount >= 50 && CountryBuffer == 0)
            {
                MessageBox.Show("Nieuwe Cheat code gekregen! " + CountryString);
                CountryBuffer += 1;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CPS += PlanetSpeed;
            Money -= PlanetPrice;
            PlanetPrice += 500;
            PlanetAmount +=1;
            PlanetSpeed += 2;

            if (PlanetAmount >= 50 && PlanetBuffer == 0)
            {
                MessageBox.Show("Nieuwe Cheat code gekregen! " + PlanetString);
                PlanetBuffer += 1;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CPS += GalaxySpeed;
            Money -= GalaxyPrice;
            GalaxyPrice += 1000;
            GalaxyAmount += 1;
            GalaxySpeed += 5;

            if (GalaxyAmount >= 50 && GalaxyBuffer == 0)
            {
                MessageBox.Show("Nieuwe Cheat code gekregen! " + GalaxyString);
                GalaxyBuffer += 1;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            CPS += UniverseSpeed;
            Money -= UniversePrice;
            UniversePrice += 5000000;
            UniverseAmount += 1;
            UniverseSpeed += 50;

            if (UniverseAmount >= 50 && UniverseBuffer == 0)
            {
                MessageBox.Show("Nieuwe Cheat code gekregen! " + UniverseString);
                UniverseBuffer += 1;
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

            }
            if (GodAmount >= 50 && GodBuffer == 0)
            {
                MessageBox.Show("Nieuwe Cheat code gekregen! " + GodString);
                GodBuffer += 1;
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

        #region cheats
        private void button11_Click(object sender, EventArgs e)
        {
            #region cheats

            if (textBox1.Text == ClickerString)
            {
                 ClickerPrice = 0;
            }

            if (textBox1.Text == FarmString)
            {
                 FarmPrice = 0;
            }

            if (textBox1.Text == MineString)
            {
                MinePrice = 0;
            }

            if (textBox1.Text == VillageString)
            {
                VillagePrice = 0;
            }

            if (textBox1.Text == CityString)
            {
                CityPrice = 0;
            }

            if (textBox1.Text == CountryString)
            {
                CountryPrice = 0;
            }

            if (textBox1.Text == PlanetString)
            {
                PlanetPrice = 0;
            }

            if (textBox1.Text == GalaxyString)
            {
                GalaxyPrice = 0;
            }

            if (textBox1.Text == UniverseString)
            {
                UniversePrice = 0;
            }

            if (textBox1.Text == GodString)
            {
                GodPrice = 0;
            }

            #endregion
        }
        #endregion

        #region bank
        private void button13_Click(object sender, EventArgs e)
        {
            Money -= 1000;
            OpBank += 1000;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Money += 1000;
            OpBank -= 1000;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            OpBank /= 10;
            OpBank *= BankRente;
        }
        #endregion

        #region save
        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
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

                SaveXML.SaveData(info, "kazidata.xml");
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
            }
            else
            {
                MessageBox.Show("Bestand niet gevonden");
            }
        }
        #endregion

        #region reset
        private void button16_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Weet je het zeer zeker?", "Bevestig", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Money = 0;
                CPS = 0;
                ClickerPrice = 10;
                FarmPrice = 50;
                MinePrice = 100;
                VillagePrice = 250;
                CityPrice = 500;
                CountryPrice = 1000;
                PlanetPrice = 5000;
                GalaxyPrice = 10000;
                ClickingPrice = 1500;
                ClickingSpeed = 1;
                ClickerAmount = 0;
                GodPrice = 250000000;
                GodAmount = 0;
                GodBuffer = 0;
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
                Tijd = 0;
                ClickerBuffer = 0;
                FarmBuffer = 0;
                MineBuffer = 0;
                VillageBuffer = 0;
                CityBuffer = 0;
                CountryBuffer = 0;
                PlanetBuffer = 0;
                GalaxyBuffer = 0;
                WeinigGeldBuffer = 0;
                VeelGeldBuffer = 0;
                BankBuffer = 0;
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }

        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            if (Autosave == false)
            {
                Autosave = true;
                timer4.Enabled = true;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (Autosave == true)
            {
                try
                {
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

                    SaveXML.SaveData(info, "kazidata.xml");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                CPS += ClickerSpeed;
                Money -= ClickerPrice;
                ClickerPrice += 5;
                ClickerAmount += 1;

                if (ClickerAmount >= 50 && ClickerBuffer == 0)
                {
                    MessageBox.Show("Nieuwe Cheat code gekregen! " + ClickerString);
                    ClickerBuffer += 1;
                }
            }

        }

    }
}
