using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            cityOutput.Text = Form1.days[0].location;
            currentTempOutput.Text = Form1.days[0].currentTemp;
            minOutput.Text = Form1.days[0].tempLow;
            maxOutput.Text = Form1.days[0].tempHigh;
            pre.Text = Form1.days[0].precipitation;

            if (Convert.ToDouble(Form1.days[0].currentTemp) > 5)
            {
                weatherLabel.Text = "Enjoy the sun";
                pictureBox1.BackgroundImage = Properties.Resources.Sun;
                pictureBox1.Refresh();

            }

            if (Convert.ToDouble(Form1.days[0].currentTemp) < 5)
            {
                weatherLabel.Text = "Make sure to layer up";
                pictureBox1.Image = Properties.Resources.cloud;
                pictureBox1.Refresh();
            }
        }



        private void forecastLabel_Click_1(object sender, EventArgs e)
        {
            //Close Current Screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            //Open forecast Screen
            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void CurrentScreen_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close Current Screen
            Form f = this.FindForm();
            f.Controls.Remove(this);
        }
    }
}
