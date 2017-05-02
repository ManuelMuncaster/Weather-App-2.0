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
    public partial class Current : UserControl
    {
        public static List<Day> days = new List<Day>();
        Day d = new Day();
        public int iconNumber;

        public Current()
        {
            InitializeComponent();
            GetData();
            ExtractCurrent();
            displayCurrent();
        }

        public void displayCurrent()
        {
            currentdayLabel.Text = DateTime.Now.ToString("dddd");
            currenttempLabel.Text = days[0].currentTemp + "°";
            currentconditionLabel.Text = days[0].condtion;
            loctaionLabel.Text = days[0].location;
            currentdateLabel.Text = "Last updated: \n " + days[0].currentDate;

            iconNumber = Convert.ToInt16(d.icon);

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

        private void forecastButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            Forecast fs = new Forecast();
            f.Controls.Add(fs);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

