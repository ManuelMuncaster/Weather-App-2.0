using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Net;

namespace Weather_App_2._0
{
    public partial class Forecast : UserControl
    {
        public static List<Day> days = new List<Day>();
        Day d = new Day();
        public int iconNumber;

        public Forecast()
        {
            InitializeComponent();
            GetData();
            ExtractForecast();
            displayForecast();
        }

        public void displayForecast()
        {
            day1Label.Text = days[0].date;
            day1Temp.Text = days[0].currentTemp + "°";
            day2Label.Text = days[1].date;
            day2Temp.Text = days[1].currentTemp + "°";
            day3Label.Text = days[2].date;
            day3Temp.Text = days[2].currentTemp + "°";

            iconNumber = Convert.ToInt16(d.icon);

            if (iconNumber >= 200 && iconNumber < 300)
            {
                day1Picturebox.BackgroundImage = Properties.Resources.icon_3;
                day2Picturebox.BackgroundImage = Properties.Resources.icon_3;
                day3Picturebox.BackgroundImage = Properties.Resources.icon_3;
            }

            else if (iconNumber >= 300 && iconNumber < 600)
            {
                day1Picturebox.BackgroundImage = Properties.Resources.Icon_1;
                day2Picturebox.BackgroundImage = Properties.Resources.Icon_1;
                day3Picturebox.BackgroundImage = Properties.Resources.Icon_1;
            }

            else if (iconNumber == 800)
            {
                day1Picturebox.BackgroundImage = Properties.Resources.icon_2;
                day2Picturebox.BackgroundImage = Properties.Resources.icon_2;
                day3Picturebox.BackgroundImage = Properties.Resources.icon_2;
            }

            else if (iconNumber >= 801 && iconNumber < 805)
            {
                day1Picturebox.BackgroundImage = Properties.Resources.icon_4;
                day2Picturebox.BackgroundImage = Properties.Resources.icon_4;
                day3Picturebox.BackgroundImage = Properties.Resources.icon_4;
            }

        }

        private void currentWeather_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            Current cs = new Current();
            f.Controls.Add(cs);
        }

        private void exitButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private static void GetData()
        {
            WebClient client = new WebClient();

            // one day forecast
            client.DownloadFile("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0", "WeatherData.xml");
            // mulit day forecast
            client.DownloadFile("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0", "WeatherData7Day.xml");

        }

        private void ExtractForecast()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("WeatherData7Day.xml");

            XmlNode parent;
            parent = doc.DocumentElement;

            d = new Day();

            foreach (XmlNode child in parent.ChildNodes)
            {
                if (child.Name == "forecast")
                {
                    foreach (XmlNode grandChild in child.ChildNodes)
                    {
                        if (grandChild.Name == "time")
                        {
                            d.date = grandChild.Attributes["day"].Value;
                            days.Add(d);
                            d = new Day();
                        }
                        foreach (XmlNode greatGrandChild in grandChild.ChildNodes)
                        {
                            if (greatGrandChild.Name == "symbol")
                            {
                                d.icon = greatGrandChild.Attributes["number"].Value;
                            }

                            if (greatGrandChild.Name == "temperature")
                            {
                                d.currentTemp = greatGrandChild.Attributes["day"].Value;
                            }
                        }
                    }
                }
            }
            days.RemoveAt(0);
        }
    }
}
