using Newtonsoft.Json;
using SmartH2O_Service.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SmartH2O_SeeAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeCharts();
        }

        private void InitializeCharts()
        {
            chartPH.Series.Add("PH");
            chartPH.ChartAreas.Add("ChartAreaPH");
        }

        private void buttonGetDays_Click(object sender, EventArgs e)
        {
            HandlerXML myClass = new HandlerXML("param-data.xml");
            listBoxDayOne.DataSource = myClass.GetDays();
        }

        private void btnStatsByDay_Click(object sender, EventArgs e)
        {
            groupBoxGraphs.Text = "Weekly Statistics By Day";

            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            Calendar cal = dfi.Calendar;

            //cal.GetWeekOfYear();
        }

        private void btnStatsByHour_Click(object sender, EventArgs e)
        {
            DateTime data = Convert.ToDateTime(dateTimePickerDay.Value.Date.ToString("dd-MM-yyyy"));
            groupBoxGraphs.Text = "Daily Statistics By Hour";

            HttpWebRequest requestPH = WebRequest.Create(@"http://localhost:55500/parameters/PH/2016/12/18") as HttpWebRequest;
            requestPH.ContentType = "application/json";
            HttpWebResponse response = requestPH.GetResponse() as HttpWebResponse;
            string json = new StreamReader(response.GetResponseStream()).ReadToEnd();
            List<Hour> listaPH = JsonConvert.DeserializeObject<List<Hour>>(json);

            

            for (int i = 0; i<24; i++)
            {
                chartPH.Series["PH"].Points.Add().SetValueXY(Convert.ToDateTime(listaPH[i].hour+":00"), Math.Round(listaPH[i].avg, 2));
            }
            chartPH.Series["PH"].XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Primary;
            chartPH.Series["PH"].IsXValueIndexed = true;
            chartPH.Series["PH"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            chartPH.ChartAreas["ChartAreaPH"].AxisY.Maximum = Math.Round(listaPH[25].avg + 1);
            chartPH.ChartAreas["ChartAreaPH"].AxisY.Minimum = Math.Round(listaPH[24].avg - 1);
            chartPH.ChartAreas["ChartAreaPH"].AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.FixedCount;
            /*chartPH.ChartAreas["ChartAreaPH"].AxisX.Maximum = 25;*/
            chartPH.ChartAreas["ChartAreaPH"].AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
            chartPH.ChartAreas["ChartAreaPH"].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
            chartPH.ChartAreas["ChartAreaPH"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
        }

        private void buttonGetInfoByParameter_Click(object sender, EventArgs e)
        {

            if (checkBoxpH.Checked)
            {
                //getInfoByParameter("PH");
            }

            if (checkBoxNh3.Checked)
            {
                //getInfoByParameter("NH3");
            }

            if (checkBoxCI2.Checked)
            {
                //getInfoByParameter("CI2");
            }

        }

        private void buttonSeeInfo2Dates_Click(object sender, EventArgs e)
        {
            string date1;
            string date2;

            date1 = listBoxDayOne.SelectedItem.ToString();
            date2 = listBoxDayTwo.SelectedItem.ToString();

            //getAlarmInfoTwoDates(date1, date2);
        }

        private void dateTimePickerWeek_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
