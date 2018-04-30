using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;



namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            //7 day forcast
            todayLabel.Text = Form1.days[0].date;
            label11.Text = Form1.days[0].currentTemp;

            date1.Text = Form1.days[1].date;
            min1.Text = Form1.days[1].tempLow;
            max1.Text = Form1.days[1].tempHigh;

            date2.Text = Form1.days[2].date;
            min2.Text = Form1.days[2].tempLow;
            max2.Text = Form1.days[2].tempHigh;

            date3.Text = Form1.days[3].date;
            min3.Text = Form1.days[3].tempLow;
            max3.Text = Form1.days[3].tempHigh;

            date4.Text = Form1.days[4].date;
            min4.Text = Form1.days[4].tempLow;
            max4.Text = Form1.days[4].tempHigh;

            date5.Text = Form1.days[5].date;
            min5.Text = Form1.days[5].tempLow;
            max5.Text = Form1.days[5].tempHigh;

            date6.Text = Form1.days[6].date;
            min6.Text = Form1.days[6].tempLow;
            max6.Text = Form1.days[6].tempHigh;

        }

        private void ForecastScreen_Load(object sender, EventArgs e)
        {
           
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close Forecast Screen
            Form f = this.FindForm();
            f.Controls.Remove(this);
        }

        private void tabLabel_Click(object sender, EventArgs e)
        {
            //Close Forecast Screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            //Open Current Screen
            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
