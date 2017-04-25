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
    public partial class Next : UserControl
    {
        public Next()
        {
            InitializeComponent();
            displayForecast();
            forecastLabel.Text = Convert.ToDateTime(Form1.days[2].date).ToString("dddd");
        }
        public void displayForecast()
        {
            
            date1.Text = Form1.days[2].date;
            min1.Text = Form1.days[2].tempLow;
            max1.Text = Form1.days[2].tempHigh;

            int cVal = Convert.ToInt16(Form1.days[2].conditionValue);
            if (cVal >= 200 && cVal < 300)
            {
                pictureBox1.Image = Properties.Resources.thunder;
            }
            if (cVal >= 300 && cVal < 600)
            {
                pictureBox1.Image = Properties.Resources.rain;
            }
            if (cVal >= 600 && cVal < 700)
            {
                pictureBox1.Image = Properties.Resources.snow;
            }
            if (cVal == 800)
            {
                pictureBox1.Image = Properties.Resources.sun;
            }
            if (cVal > 800)
            {
                pictureBox1.Image = Properties.Resources.partly_cloudy;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
