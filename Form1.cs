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

namespace Kaziklikker
{
    public partial class Form1 : Form
    {

        int Money = 0;
        int CPS = 0;
        int ClickerPrice = 10;
        int FarmPrice = 50;
        int MinePrice = 100;
        int VillagePrice = 250;
        int CityPrice = 500;
        int CountryPrice = 1000;
        int PlanetPrice = 5000;
        int GalaxyPrice = 10000;
        int ClickingPrice = 2500;
        int ClickingSpeed = 1;
        int ClickerAmount = 0;
        int FarmAmount = 0;
        int MineAmount = 0;
        int VillageAmount = 0;
        int CityAmount = 0;
        int CountryAmount = 0;
        int PlanetAmount = 0;
        int GalaxyAmount = 0;
        int ClickingAmount = 0;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Money += ClickingSpeed;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Money += CPS;
        }

        #region Timer2
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

            label12.Text = ClickerAmount.ToString();
            label13.Text = FarmAmount.ToString();
            label14.Text = MineAmount.ToString();
            label15.Text = VillageAmount.ToString();
            label16.Text = CityAmount.ToString();
            label17.Text = CountryAmount.ToString();
            label18.Text = PlanetAmount.ToString();
            label19.Text = GalaxyAmount.ToString();
            label20.Text = ClickingAmount.ToString();
            
            
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
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            CPS += 1;
            Money -= ClickerPrice;
            ClickerPrice += 5;
            ClickerAmount += 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CPS += 2;
            Money -= FarmPrice;
            FarmPrice += 25;
            FarmAmount += 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CPS += 3;
            Money -= MinePrice;
            MinePrice += 50;
            MineAmount +=1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CPS += 5;
            Money -= VillagePrice;
            VillagePrice += 100;
            VillageAmount += 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CPS += 10;
            Money -= CityPrice;
            CityPrice += 200;
            CityAmount += 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CPS += 15;
            Money -= CountryPrice;
            CountryPrice += 350;
            CountryAmount += 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CPS += 25;
            Money -= PlanetPrice;
            PlanetPrice += 500;
            PlanetAmount +=1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CPS += 50;
            Money -= GalaxyPrice;
            GalaxyPrice += 1000;
            GalaxyAmount += 1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ClickingSpeed *= 2;
            ClickingPrice *= 2;
            ClickingAmount += 1;
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
