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
            chartPH.Series["PH"].XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Primary;
            chartPH.Series["PH"].IsXValueIndexed = true;
            chartPH.Series["PH"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            chartPH.ChartAreas["ChartAreaPH"].AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.FixedCount;
            chartPH.ChartAreas["ChartAreaPH"].AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
            chartPH.ChartAreas["ChartAreaPH"].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
            chartPH.ChartAreas["ChartAreaPH"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartPH.ChartAreas["ChartAreaPH"].AxisX.MajorGrid.Interval = 1;

            chartNH3.Series.Add("NH3");
            chartNH3.ChartAreas.Add("ChartAreaNH3");
            chartNH3.Series["NH3"].XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Primary;
            chartNH3.Series["NH3"].IsXValueIndexed = true;
            chartNH3.Series["NH3"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            chartNH3.ChartAreas["ChartAreaNH3"].AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.FixedCount;
            chartNH3.ChartAreas["ChartAreaNH3"].AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
            chartNH3.ChartAreas["ChartAreaNH3"].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
            chartNH3.ChartAreas["ChartAreaNH3"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartNH3.ChartAreas["ChartAreaNH3"].AxisX.MajorGrid.Interval = 1;

            chartCI2.Series.Add("CI2");
            chartCI2.ChartAreas.Add("ChartAreaCI2");
            chartCI2.Series["CI2"].XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Primary;
            chartCI2.Series["CI2"].IsXValueIndexed = true;
            chartCI2.Series["CI2"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            chartCI2.ChartAreas["ChartAreaCI2"].AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.FixedCount;
            chartCI2.ChartAreas["ChartAreaCI2"].AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
            chartCI2.ChartAreas["ChartAreaCI2"].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
            chartCI2.ChartAreas["ChartAreaCI2"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartCI2.ChartAreas["ChartAreaCI2"].AxisX.MajorGrid.Interval = 1;
        }

        private void buttonGetDays_Click(object sender, EventArgs e)
        {
            //listBoxDayOne.DataSource = myClass.GetDays();
        }

        private void btnStatsByDay_Click(object sender, EventArgs e)
        {
            groupBoxGraphs.Text = "Weekly Statistics By Day";

            

            //cal.GetWeekOfYear();
        }

        private void btnStatsByHour_Click(object sender, EventArgs e)
        {
            DateTime data = Convert.ToDateTime(dateTimePickerDay.Value.Date.ToString("dd-MM-yyyy"));
            groupBoxGraphs.Text = "Daily Statistics By Hour";

            HttpWebRequest requestPH = WebRequest.Create(@"http://localhost:55500/parameters/PH/" + data.Year + "/" + data.Month + "/" + data.Day) as HttpWebRequest;
            requestPH.ContentType = "application/json";
            HttpWebResponse responsePH = requestPH.GetResponse() as HttpWebResponse;
            string jsonPH = new StreamReader(responsePH.GetResponseStream()).ReadToEnd();
            List<Hour> listaPH = JsonConvert.DeserializeObject<List<Hour>>(jsonPH);
            chartPH.Series["PH"].Points.Clear();
            for (int i = 0; i < 24; i++)
            {
                chartPH.Series["PH"].Points.Add().SetValueXY(Convert.ToDateTime(listaPH[i].hour + ":00"), Math.Round(listaPH[i].avg, 2));
            }

            chartPH.ChartAreas["ChartAreaPH"].AxisY.Maximum = Math.Round(listaPH[25].avg + 1);
            
            if (listaPH[24].avg > 1)
            {
                chartPH.ChartAreas["ChartAreaPH"].AxisY.Minimum = Math.Round(listaPH[24].avg - 1);
            }
            else
            {
                chartPH.ChartAreas["ChartAreaPH"].AxisY.Minimum = 0;
            }

            HttpWebRequest requestNH3 = WebRequest.Create(@"http://localhost:55500/parameters/NH3/" + data.Year + "/" + data.Month + "/" + data.Day) as HttpWebRequest;
            requestNH3.ContentType = "application/json";
            HttpWebResponse responseNH3 = requestNH3.GetResponse() as HttpWebResponse;
            string jsonNH3 = new StreamReader(responseNH3.GetResponseStream()).ReadToEnd();
            List<Hour> listaNH3 = JsonConvert.DeserializeObject<List<Hour>>(jsonNH3);
            chartNH3.Series["NH3"].Points.Clear();
            for (int i = 0; i < 24; i++)
            {
                chartNH3.Series["NH3"].Points.Add().SetValueXY(Convert.ToDateTime(listaNH3[i].hour + ":00"), Math.Round(listaNH3[i].avg, 2));
            }

            chartNH3.ChartAreas["ChartAreaNH3"].AxisY.Maximum = Math.Round(listaNH3[25].avg + 1);

            if (listaNH3[24].avg > 1)
            {
                chartNH3.ChartAreas["ChartAreaNH3"].AxisY.Minimum = Math.Round(listaNH3[24].avg - 1);
            }
            else
            {
                chartNH3.ChartAreas["ChartAreaNH3"].AxisY.Minimum = 0;
            }

            HttpWebRequest requestCI2 = WebRequest.Create(@"http://localhost:55500/parameters/CI2/" + data.Year + "/" + data.Month + "/" + data.Day) as HttpWebRequest;
            requestCI2.ContentType = "application/json";
            HttpWebResponse responseCI2 = requestCI2.GetResponse() as HttpWebResponse;
            string jsonCI2 = new StreamReader(responseCI2.GetResponseStream()).ReadToEnd();
            List<Hour> listaCI2 = JsonConvert.DeserializeObject<List<Hour>>(jsonCI2);
            chartCI2.Series["CI2"].Points.Clear();
            for (int i = 0; i < 24; i++)
            {
                chartCI2.Series["CI2"].Points.Add().SetValueXY(Convert.ToDateTime(listaCI2[i].hour + ":00"), Math.Round(listaCI2[i].avg, 2));
            }

            chartCI2.ChartAreas["ChartAreaCI2"].AxisY.Maximum = Math.Round(listaCI2[25].avg + 1);

            if (listaCI2[24].avg > 1)
            {
                chartCI2.ChartAreas["ChartAreaCI2"].AxisY.Minimum = Math.Round(listaCI2[24].avg - 1);
            }
            else
            {
                chartCI2.ChartAreas["ChartAreaCI2"].AxisY.Minimum = 0;
            }
        }

        private void buttonGetInfoByParameter_Click(object sender, EventArgs e)
        {
            listBoxInfoByParameter.Items.Clear();
            if (checkBoxpH.Checked)
            {
                HttpWebRequest requestPH = WebRequest.Create(@"http://localhost:55500/parameters/PH") as HttpWebRequest;
                requestPH.ContentType = "application/json";
                HttpWebResponse response = requestPH.GetResponse() as HttpWebResponse;
                string json = new StreamReader(response.GetResponseStream()).ReadToEnd();
                List<Parameter> lista = JsonConvert.DeserializeObject<List<Parameter>>(json);


                for (int i = 0; i < lista.Count; i++)
                {
                    listBoxInfoByParameter.Items.Add("Name: " + lista[i].Name + "  Value: " + lista[i].Value + " Date: " + lista[i].Date);
                }
            }

            if (checkBoxNh3.Checked)
            {
                HttpWebRequest requestPH = WebRequest.Create(@"http://localhost:55500/parameters/NH3") as HttpWebRequest;
                requestPH.ContentType = "application/json";
                HttpWebResponse response = requestPH.GetResponse() as HttpWebResponse;
                string json = new StreamReader(response.GetResponseStream()).ReadToEnd();
                List<Parameter> lista = JsonConvert.DeserializeObject<List<Parameter>>(json);


                for (int i = 0; i < lista.Count; i++)
                {
                    listBoxInfoByParameter.Items.Add("Name: " + lista[i].Name + "  Value: " + lista[i].Value + " Date: " + lista[i].Date);
                }
            }

            if (checkBoxCI2.Checked)
            {
                HttpWebRequest requestPH = WebRequest.Create(@"http://localhost:55500/parameters/CI2") as HttpWebRequest;
                requestPH.ContentType = "application/json";
                HttpWebResponse response = requestPH.GetResponse() as HttpWebResponse;
                string json = new StreamReader(response.GetResponseStream()).ReadToEnd();
                List<Parameter> lista = JsonConvert.DeserializeObject<List<Parameter>>(json);


                for (int i = 0; i < lista.Count; i++)
                {
                    listBoxInfoByParameter.Items.Add("Name: " + lista[i].Name + "  Value: " + lista[i].Value + " Date: " + lista[i].Date);
                }
            }

        }

        private void buttonSeeInfo2Dates_Click(object sender, EventArgs e)
        {
            string date1;
            string date2;

            //date1 = listBoxDayOne.SelectedItem.ToString();
            //date2 = listBoxDayTwo.SelectedItem.ToString();

            //getAlarmInfoTwoDates(date1, date2);
        }

        private void dateTimePickerWeek_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonGetAlarmInfo_Click_1(object sender, EventArgs e)
        {
            HttpWebRequest requestPH = WebRequest.Create(@"http://localhost:55500/alarms") as HttpWebRequest;
            requestPH.ContentType = "application/json";
            HttpWebResponse response = requestPH.GetResponse() as HttpWebResponse;
            string json = new StreamReader(response.GetResponseStream()).ReadToEnd();
            List<Alarm> listaAlarms = JsonConvert.DeserializeObject<List<Alarm>>(json);

            listBoxAlarmInfo.Items.Clear();

            for (int i = 0; i < listaAlarms.Count; i++)
            {
                listBoxAlarmInfo.Items.Add("Name: " + listaAlarms[i].Name + "  Value: " + listaAlarms[i].Value + "  Rule: " + listaAlarms[i].RuleOperator + " " + listaAlarms[i].RuleValue + "Date: " + listaAlarms[i].Date);
            }

        }

        private void buttonSeeInfo2Dates_Click_2(object sender, EventArgs e)
        {
            DateTime startDate = Convert.ToDateTime(dateTimePickerStartDate.Value.Date.ToString("dd-MM-yyyy"));
            DateTime finalDate = Convert.ToDateTime(dateTimePickerFinalDate.Value.Date.ToString("dd-MM-yyyy"));
            string uri = "http://localhost:55500/alarms/between/" + startDate.Year + "/" + startDate.Month + "/" + startDate.Day + "/" + finalDate.Year + "/" + finalDate.Month + "/" + finalDate.Day;
            listBoxAlarmsDateTwoDates.Items.Clear();

            try
            {
                HttpWebRequest requestPH = WebRequest.Create(uri) as HttpWebRequest;
                requestPH.ContentType = "application/json";
                HttpWebResponse response = requestPH.GetResponse() as HttpWebResponse;
                string json = new StreamReader(response.GetResponseStream()).ReadToEnd();
                List<Alarm> listaAlarms = JsonConvert.DeserializeObject<List<Alarm>>(json);
                for (int i = 0; i < listaAlarms.Count; i++)
                {
                    listBoxAlarmsDateTwoDates.Items.Add("Name: " + listaAlarms[i].Name + "  Value: " + listaAlarms[i].Value + "  Rule: " + listaAlarms[i].RuleOperator + " -> " + listaAlarms[i].RuleValue + " Date: " + listaAlarms[i].Date);
                }
            }
            catch (Exception)
            {

                listBoxAlarmsDateTwoDates.Items.Add("Alarms not found.");
            }


        }

        private void buttonGetInfoByParameter_Click_2(object sender, EventArgs e)
        {
            listBoxInfoByParameter.Items.Clear();
            if (checkBoxpH.Checked)
            {
                HttpWebRequest requestPH = WebRequest.Create(@"http://localhost:55500/parameters/PH") as HttpWebRequest;
                requestPH.ContentType = "application/json";
                HttpWebResponse response = requestPH.GetResponse() as HttpWebResponse;
                string json = new StreamReader(response.GetResponseStream()).ReadToEnd();
                List<Parameter> lista = JsonConvert.DeserializeObject<List<Parameter>>(json);


                for (int i = 0; i < lista.Count; i++)
                {
                    listBoxInfoByParameter.Items.Add("Name: " + lista[i].Name + "  Value: " + lista[i].Value + " Date: " + lista[i].Date);
                }
                if (lista.Count == 0)
                {
                    listBoxInfoByParameter.Items.Add("Não foram encontrados parametros do PH!");
                }
            }

            if (checkBoxNh3.Checked)
            {
                HttpWebRequest requestPH = WebRequest.Create(@"http://localhost:55500/parameters/NH3") as HttpWebRequest;
                requestPH.ContentType = "application/json";
                HttpWebResponse response = requestPH.GetResponse() as HttpWebResponse;
                string json = new StreamReader(response.GetResponseStream()).ReadToEnd();
                List<Parameter> lista = JsonConvert.DeserializeObject<List<Parameter>>(json);


                for (int i = 0; i < lista.Count; i++)
                {
                    listBoxInfoByParameter.Items.Add("Name: " + lista[i].Name + "  Value: " + lista[i].Value + " Date: " + lista[i].Date);
                }
                if (lista.Count == 0)
                {
                    listBoxInfoByParameter.Items.Add("Não foram encontrados parametros do NH3!");
                }
            }

            if (checkBoxCI2.Checked)
            {
                HttpWebRequest requestPH = WebRequest.Create(@"http://localhost:55500/parameters/CI2") as HttpWebRequest;
                requestPH.ContentType = "application/json";
                HttpWebResponse response = requestPH.GetResponse() as HttpWebResponse;
                string json = new StreamReader(response.GetResponseStream()).ReadToEnd();
                List<Parameter> lista = JsonConvert.DeserializeObject<List<Parameter>>(json);


                for (int i = 0; i < lista.Count; i++)
                {
                    listBoxInfoByParameter.Items.Add("Name: " + lista[i].Name + "  Value: " + lista[i].Value + " Date: " + lista[i].Date);
                }
                if (lista.Count == 0)
                {
                    listBoxInfoByParameter.Items.Add("Não foram encontrados parametros do CI2!");
                }
            }
            if (listBoxInfoByParameter.Items.Count == 0)
            {
                listBoxInfoByParameter.Items.Add("Não foram selecionados parametros ou não foram encontrados!");
            }
        }
    }
}
