using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.Xml;
using System.IO;
using System.Globalization;
using System.Net.Sockets;

namespace dubaothoitiet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // http://home.openweathermap.org/users/sign_in -- link đăng ký lấy API
        private const string API_KEY = "4ee8f7dc04ed421eb8bbcaccc3441099";

       
        private const string CurrentUrl =
            "http://api.openweathermap.org/data/2.5/weather?" +
            "@QUERY@=@LOC@&mode=xml&units=metric&lang=vi&APPID=" + API_KEY;
        private const string ForecastUrl =
            "http://api.openweathermap.org/data/2.5/forecast?" +
            "@QUERY@=@LOC@&mode=xml&units=metric&lang=en&APPID=" + API_KEY;


      
        private string[] QueryCodes = { "q", "zip", "id", };
        private TextBox text;

        private void Form1_Load(object sender, EventArgs e)
        {
            cboQuery.Items.Add("City");
            cboQuery.SelectedIndex = 0;
            string url1 = ForecastUrl.Replace("@LOC@", labhanoi.Text);
            url1 = url1.Replace("@QUERY@", QueryCodes[cboQuery.SelectedIndex]);
            string url2 = ForecastUrl.Replace("@LOC@", labdn.Text);
            url2 = url2.Replace("@QUERY@", QueryCodes[cboQuery.SelectedIndex]);
            string url3 = ForecastUrl.Replace("@LOC@", labsg.Text);
            url3 = url3.Replace("@QUERY@", QueryCodes[cboQuery.SelectedIndex]);
            using (WebClient client = new WebClient())
            {

                try
                {

                    DisplayForecast1(client.DownloadString(url2));
                    DisplayForecast2(client.DownloadString(url2));
                    DisplayForecast3(client.DownloadString(url3));
                }
                catch (WebException ex)
                {
                    DisplayError(ex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unknown error\n" + ex.Message);
                }
            }
        }

      
        private void DisplayForecast2(string xml)
        {
            char degrees = (char)176;
            XmlDocument xml_doc = new XmlDocument();
            xml_doc.LoadXml(xml);
            XmlNode time_node = xml_doc.SelectSingleNode("//time");
            txthanoi.Text = time_node.SelectSingleNode("symbol").Attributes["name"].Value + degrees;
            ndhanoi.Text = time_node.SelectSingleNode("temperature").Attributes["value"].Value + degrees;
           

        }
        private void DisplayForecast1(string xml)
        {
            char degrees = (char)176;
            XmlDocument xml_doc = new XmlDocument();
            xml_doc.LoadXml(xml);
            XmlNode time_node = xml_doc.SelectSingleNode("//time");
            textdn.Text = time_node.SelectSingleNode("symbol").Attributes["name"].Value + degrees;
            nddanang.Text = time_node.SelectSingleNode("temperature").Attributes["value"].Value + degrees;

        }
        private void DisplayForecast3(string xml)
        {
            char degrees = (char)176;
            XmlDocument xml_doc = new XmlDocument();
            xml_doc.LoadXml(xml);
            XmlNode time_node = xml_doc.SelectSingleNode("//time");
            textsg.Text = time_node.SelectSingleNode("symbol").Attributes["name"].Value + degrees;
            ndsaigon.Text = time_node.SelectSingleNode("temperature").Attributes["value"].Value + degrees;

        }







        private void btnForecast_Click(object sender, EventArgs e)
        {
            
            string url = ForecastUrl.Replace("@LOC@", txtLocation.Text);
            url = url.Replace("@QUERY@", QueryCodes[cboQuery.SelectedIndex]);

           
            using (WebClient client = new WebClient())
            {
                
                try
                {
                    DisplayForecast(client.DownloadString(url));
                }
                catch (WebException ex)
                {
                    DisplayError(ex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unknown error\n" + ex.Message);
                }
            }
        }

      
        private void DisplayForecast(string xml)
        {
           
            XmlDocument xml_doc = new XmlDocument();
            xml_doc.LoadXml(xml);

            
            XmlNode loc_node = xml_doc.SelectSingleNode("weatherdata/location");
            txtCity.Text = loc_node.SelectSingleNode("name").InnerText;
            txtCountry.Text = loc_node.SelectSingleNode("country").InnerText;
            XmlNode geo_node = loc_node.SelectSingleNode("location");
            txtLat.Text = geo_node.Attributes["latitude"].Value;
            txtLong.Text = geo_node.Attributes["longitude"].Value;
    

            
            lvwForecast.Items.Clear();
            char degrees = (char)176;
            
            foreach (XmlNode time_node in xml_doc.SelectNodes("//time"))
            {
               
                DateTime time =
                    DateTime.Parse(time_node.Attributes["from"].Value,
                        null, DateTimeStyles.AssumeUniversal);

              
                XmlNode temp_node = time_node.SelectSingleNode("temperature");
                string temp = temp_node.Attributes["value"].Value;

                ListViewItem item = lvwForecast.Items.Add(time.DayOfWeek.ToString());
                item.SubItems.Add(time.ToShortTimeString());
                item.SubItems.Add(temp + degrees);
            }
        }

      
        private void DisplayError(WebException exception)
        {
            try
            {
                StreamReader reader = new StreamReader(exception.Response.GetResponseStream());
                XmlDocument response_doc = new XmlDocument();
                response_doc.LoadXml(reader.ReadToEnd());
                XmlNode message_node = response_doc.SelectSingleNode("//message");
                MessageBox.Show(message_node.InnerText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown error\n" + ex.Message);
            }
        }


       
    }
}
