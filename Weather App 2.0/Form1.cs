using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace Weather_App_2._0
{
    public partial class Form1 : Form
    {
        public static List<Day> days = new List<Day>();
        Day d = new Day();
        public int iconNumber;

        public Form1()
        {
            InitializeComponent();
            GetData();
            ExtractCurrent();
            displayCurrent();
            ExtractForecast();
        }

        public void displayCurrent()
        {
            currentdayLabel.Text = DateTime.Now.ToString("dddd");
            currenttempLabel.Text = Form1.days[0].currentTemp + "°";
            currentconditionLabel.Text = Form1.days[0].condtion;
            loctaionLabel.Text = Form1.days[0].location;
            currentdateLabel.Text = "Last updated: " + Form1.days[0].currentDate;

            iconNumber = Convert.ToInt16(d.icon);
            #region Icon Codes

            if (iconNumber >= 200 && iconNumber < 300)
            {
                conditionPicturebox.BackgroundImage = Properties.Resources.icon_3;
            }

            else if (iconNumber >= 300 && iconNumber < 500)
            {
                conditionPicturebox.BackgroundImage = Properties.Resources.Icon_1;
            }

            else if (iconNumber == 800)
            {
                conditionPicturebox.BackgroundImage = Properties.Resources.icon_2;
            }

            else if (iconNumber >= 801 && iconNumber < 805)
            {
                conditionPicturebox.BackgroundImage = Properties.Resources.icon_4;
            }
            #endregion
        }

        private static void GetData()
        {
            WebClient client = new WebClient();

            // one day forecast
            client.DownloadFile("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0", "WeatherData.xml");
            // mulit day forecast
            client.DownloadFile("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0", "WeatherData7Day.xml");

        }

        private void ExtractCurrent()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("WeatherData.xml");

            XmlNode parent;
            parent = doc.DocumentElement;

            foreach (XmlNode child in parent.ChildNodes)
            {
                if (child.Name == "city")
                {
                    d.location = child.Attributes["name"].Value;
                }

                if (child.Name == "temperature")
                {
                    d.currentTemp = child.Attributes["value"].Value;
                }

                if (child.Name == "weather")
                {
                    d.condtion = child.Attributes["value"].Value;
                    d.icon = child.Attributes["number"].Value;
                }

                if (child.Name == "lastupdate")
                {
                    d.currentDate = child.Attributes["value"].Value;
                }

            }

            days.Add(d);
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
                        }
                        foreach (XmlNode greatGrandChild in grandChild.ChildNodes)
                        {
                            if (greatGrandChild.Name == "clouds")
                            {
                                d.condtion = greatGrandChild.Attributes["value"].Value;
                                days.Add(d);
                                d = new Day();
                            }
                        }
                    }
                }
            }
            days.RemoveAt(1);
        }
    }
}
