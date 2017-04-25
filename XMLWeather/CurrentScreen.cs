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
            //dateOutput.Text = Convert.ToDateTime(Form1.days[0].date).ToString("dddd");
            //dateOutput.Text = Form1.days[0].date;
            dateOutput.Text = DateTime.Now.ToString("dd-MM-yy");

            day1Label.Text = Convert.ToDateTime(Form1.days[1].date).ToString("dddd");
            day2Label.Text = Convert.ToDateTime(Form1.days[2].date).ToString("dddd");
            day3Label.Text = Convert.ToDateTime(Form1.days[3].date).ToString("dddd");
        }


        public void DisplayCurrent()
        {
            //Math.Round()
            //Math.Round(Convert.ToDouble(Form1.days[0].currentTemp));
            cityOutput.Text = Form1.days[0].location;
            tempLabel.Text = Math.Round(Convert.ToDouble(Form1.days[0].currentTemp)) + " °C";
            minOutput.Text = Form1.days[0].tempLow;
            maxOutput.Text = Form1.days[0].tempHigh;

            int bVal = Convert.ToInt16(Form1.days[0].windSpeed);
            if (bVal >= 200 && bVal < 300)
            {
                pictureBox1.Image = Properties.Resources.thunder;
            }
            if (bVal >= 300 && bVal < 600)
            {
                pictureBox1.Image = Properties.Resources.rain;
            }
            if (bVal >= 600 && bVal < 700)
            {
                pictureBox1.Image = Properties.Resources.snow;
            }
            if (bVal == 800)
            {
                pictureBox1.Image = Properties.Resources.sun;
            }
            if (bVal > 800)
            {
                pictureBox1.Image = Properties.Resources.partly_cloudy;
            }



            int cVal = Convert.ToInt16(Form1.days[1].conditionValue);
            if (cVal >= 200 && cVal < 300)
            {
                pictureBox2.Image = Properties.Resources.thunder;
            }
            if (cVal >= 300 && cVal < 600)
            {
                pictureBox2.Image = Properties.Resources.rain;
            }
            if (cVal >= 600 && cVal < 700)
            {
                pictureBox2.Image = Properties.Resources.snow;
            }
            if (cVal == 800)
            {
                pictureBox2.Image = Properties.Resources.sun;
            }
            if (cVal > 800)
            {
                pictureBox2.Image = Properties.Resources.partly_cloudy;
            }

            int dVal = Convert.ToInt16(Form1.days[2].conditionValue);
            if (dVal >= 200 && dVal < 300)
            {
                pictureBox3.Image = Properties.Resources.thunder;
            }
            if (dVal >= 300 && dVal < 600)
            {
                pictureBox3.Image = Properties.Resources.rain;
            }
            if (dVal >= 600 && dVal < 700)
            {
                pictureBox3.Image = Properties.Resources.snow;
            }
            if (dVal == 800)
            {
                pictureBox3.Image = Properties.Resources.sun;
            }
            if (dVal > 800)
            {
                pictureBox3.Image = Properties.Resources.partly_cloudy;
            }

            int eVal = Convert.ToInt16(Form1.days[3].conditionValue);
            if (eVal >= 200 && eVal < 300)
            {
                pictureBox4.Image = Properties.Resources.thunder;
            }
            if (eVal >= 300 && eVal < 600)
            {
                pictureBox4.Image = Properties.Resources.rain;
            }
            if (eVal >= 600 && eVal < 700)
            {
                pictureBox4.Image = Properties.Resources.snow;
            }
            if (eVal == 800)
            {
                pictureBox4.Image = Properties.Resources.sun;
            }
            if (eVal > 800)
            {
                pictureBox4.Image = Properties.Resources.partly_cloudy;
            }
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            Next ns = new Next();
            f.Controls.Add(ns);
        }

        private void day3Label_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            NextNext nns = new NextNext();
            f.Controls.Add(nns);
        }
    }
}
