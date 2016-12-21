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
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace SmartH2O_SeeAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePickerDay.Value = DateTime.Now.Date;
            dateTimePickerStartDate.Value = DateTime.Now.Date;
            dateTimePickerWeek.Value = DateTime.Now.Date;
            dateTimePickerFinalDate.Value = DateTime.Now.Date;
            InitializeCharts();
        }

        private void InitializeCharts()
        {
            chartPH.Series.Add("Maximum");
            chartPH.Series.Add("Average");
            chartPH.Series.Add("Minimum");
            chartPH.ChartAreas.Add("ChartAreaPH");
            chartPH.Legends.Add(new Legend("Media"));
            chartNH3.Legends.Add(new Legend("Media"));
            chartCI2.Legends.Add(new Legend("Media"));

            chartPH.Series["Minimum"].XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Primary;
            chartPH.Series["Minimum"].IsXValueIndexed = true;
            chartPH.Series["Minimum"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartPH.Series["Minimum"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            chartPH.Series["Average"].XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Primary;
            chartPH.Series["Average"].IsXValueIndexed = true;
            chartPH.Series["Average"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartPH.Series["Average"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            chartPH.Series["Maximum"].XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Primary;
            chartPH.Series["Maximum"].IsXValueIndexed = true;
            chartPH.Series["Maximum"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartPH.Series["Maximum"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            chartPH.ChartAreas["ChartAreaPH"].AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.FixedCount;
            chartPH.ChartAreas["ChartAreaPH"].AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
            chartPH.ChartAreas["ChartAreaPH"].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
            chartPH.ChartAreas["ChartAreaPH"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartPH.ChartAreas["ChartAreaPH"].AxisX.MajorGrid.Interval = 1;
            chartPH.ChartAreas["ChartAreaPH"].AxisX.Title = "Hours";
            chartPH.ChartAreas["ChartAreaPH"].AxisY.Title = "Values";

            chartNH3.Series.Add("Maximum");
            chartNH3.Series.Add("Average");
            chartNH3.Series.Add("Minimum");
            chartNH3.ChartAreas.Add("ChartAreaNH3");

            chartNH3.Series["Minimum"].XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Primary;
            chartNH3.Series["Minimum"].IsXValueIndexed = true;
            chartNH3.Series["Minimum"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartNH3.Series["Minimum"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            chartNH3.Series["Average"].XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Primary;
            chartNH3.Series["Average"].IsXValueIndexed = true;
            chartNH3.Series["Average"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartNH3.Series["Average"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            chartNH3.Series["Maximum"].XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Primary;
            chartNH3.Series["Maximum"].IsXValueIndexed = true;
            chartNH3.Series["Maximum"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartNH3.Series["Maximum"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            chartNH3.ChartAreas["ChartAreaNH3"].AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.FixedCount;
            chartNH3.ChartAreas["ChartAreaNH3"].AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
            chartNH3.ChartAreas["ChartAreaNH3"].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
            chartNH3.ChartAreas["ChartAreaNH3"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartNH3.ChartAreas["ChartAreaNH3"].AxisX.MajorGrid.Interval = 1;
            chartNH3.ChartAreas["ChartAreaNH3"].AxisX.Title = "Hours";
            chartNH3.ChartAreas["ChartAreaNH3"].AxisY.Title = "Values";

            chartCI2.Series.Add("Maximum");
            chartCI2.Series.Add("Average");
            chartCI2.Series.Add("Minimum");
            chartCI2.ChartAreas.Add("ChartAreaCI2");

            chartCI2.Series["Minimum"].XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Primary;
            chartCI2.Series["Minimum"].IsXValueIndexed = true;
            chartCI2.Series["Minimum"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartCI2.Series["Minimum"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            chartCI2.Series["Average"].XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Primary;
            chartCI2.Series["Average"].IsXValueIndexed = true;
            chartCI2.Series["Average"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartCI2.Series["Average"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            chartCI2.Series["Maximum"].XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Primary;
            chartCI2.Series["Maximum"].IsXValueIndexed = true;
            chartCI2.Series["Maximum"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartCI2.Series["Maximum"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            chartCI2.ChartAreas["ChartAreaCI2"].AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.FixedCount;
            chartCI2.ChartAreas["ChartAreaCI2"].AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
            chartCI2.ChartAreas["ChartAreaCI2"].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
            chartCI2.ChartAreas["ChartAreaCI2"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartCI2.ChartAreas["ChartAreaCI2"].AxisX.MajorGrid.Interval = 1;
            chartCI2.ChartAreas["ChartAreaCI2"].AxisX.Title = "Hours";
            chartCI2.ChartAreas["ChartAreaCI2"].AxisY.Title = "Values";
        }

        private void buttonGetDays_Click(object sender, EventArgs e)
        {
            //listBoxDayOne.DataSource = myClass.GetDays();
        }

        private void InitializeWeeklyCharts()
        {
            chartPH.Series["Minimum"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chartPH.Series["Average"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chartPH.Series["Maximum"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chartNH3.Series["Minimum"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chartNH3.Series["Average"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chartNH3.Series["Maximum"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chartCI2.Series["Minimum"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chartCI2.Series["Average"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chartCI2.Series["Maximum"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chartPH.ChartAreas["ChartAreaPH"].AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartPH.ChartAreas["ChartAreaPH"].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartNH3.ChartAreas["ChartAreaNH3"].AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartNH3.ChartAreas["ChartAreaNH3"].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartCI2.ChartAreas["ChartAreaCI2"].AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartCI2.ChartAreas["ChartAreaCI2"].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
        }

        private void InitializeHourlyCharts()
        {
            chartPH.Series["Minimum"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            chartPH.Series["Average"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            chartPH.Series["Maximum"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            chartNH3.Series["Minimum"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            chartNH3.Series["Average"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            chartNH3.Series["Maximum"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            chartCI2.Series["Minimum"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            chartCI2.Series["Average"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            chartCI2.Series["Maximum"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            chartPH.ChartAreas["ChartAreaPH"].AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
            chartPH.ChartAreas["ChartAreaPH"].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
            chartNH3.ChartAreas["ChartAreaNH3"].AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
            chartNH3.ChartAreas["ChartAreaNH3"].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
            chartCI2.ChartAreas["ChartAreaCI2"].AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
            chartCI2.ChartAreas["ChartAreaCI2"].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
        }

        private void btnStatsByDay_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePickerWeek.Value.Date;
            DateTime date1 = new DateTime();
            InitializeWeeklyCharts();
            groupBoxGraphs.Text = "Weekly Statistics By Day";
            
            for ( int i = 0; date.DayOfWeek != CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek; i++)
            {
                date = date.AddDays(-1);
            }
            date1 = date.AddDays(6);
            HttpWebRequest requestPH = WebRequest.Create(@"http://localhost:55500/parameters/PH/" + date.Year + "/" + date.Month + "/" + date.Day + "/"+date1.Year+ "/"+ date1 .Month+ "/"+ date1.Day) as HttpWebRequest;
            requestPH.ContentType = "application/json";
            HttpWebResponse responsePH = requestPH.GetResponse() as HttpWebResponse;
            string jsonPH = new StreamReader(responsePH.GetResponseStream()).ReadToEnd();
            List<WeeklyDay> listaPH = JsonConvert.DeserializeObject<List<WeeklyDay>>(jsonPH);
            chartPH.Series["Average"].Points.Clear();
            chartPH.Series["Minimum"].Points.Clear();
            chartPH.Series["Maximum"].Points.Clear();
            chartPH.Legends["Media"].DockedToChartArea = "ChartAreaPH";
            chartPH.Legends["Media"].IsDockedInsideChartArea = true;
            for (int i = 0; i < 7; i++)
            {
                chartPH.Series["Average"].Points.Add().SetValueXY(listaPH[i].day, Math.Round(listaPH[i].avg, 2));
                chartPH.Series["Minimum"].Points.Add().SetValueXY(listaPH[i].day, Math.Round(listaPH[i].min, 2));
                chartPH.Series["Maximum"].Points.Add().SetValueXY(listaPH[i].day, Math.Round(listaPH[i].max, 2));
            }

            float maximum = 0;
            int index = 0;
            for (int i = 0; i < 7; i++)
            {
                if (listaPH[i].max > maximum)
                {
                    maximum = listaPH[i].max;
                    index = i;
                }
            }

            chartPH.ChartAreas["ChartAreaPH"].AxisY.Maximum = Math.Round(listaPH[index].max + 3);

            float minimun = 10;
            index = 0;
            for (int i = 0; i < 7; i++)
            {
                if (listaPH[i].min < minimun)
                {
                    minimun = listaPH[i].min;
                    index = i;
                }
            }
            if (listaPH[index].min > 2)
            {
                chartPH.ChartAreas["ChartAreaPH"].AxisY.Minimum = Math.Round(listaPH[index].min - 2);
            }
            else
            {
                chartPH.ChartAreas["ChartAreaPH"].AxisY.Minimum = 0;
            }

            HttpWebRequest requestNH3 = WebRequest.Create(@"http://localhost:55500/parameters/NH3/" + date.Year + "/" + date.Month + "/" + date.Day + "/" + date1.Year + "/" + date1.Month + "/" + date1.Day) as HttpWebRequest;
            requestNH3.ContentType = "application/json";
            HttpWebResponse responseNH3 = requestNH3.GetResponse() as HttpWebResponse;
            string jsonNH3 = new StreamReader(responseNH3.GetResponseStream()).ReadToEnd();
            List<WeeklyDay> listaNH3 = JsonConvert.DeserializeObject<List<WeeklyDay>>(jsonNH3);
            chartNH3.Series["Average"].Points.Clear();
            chartNH3.Series["Minimum"].Points.Clear();
            chartNH3.Series["Maximum"].Points.Clear();
            chartNH3.Legends["Media"].DockedToChartArea = "ChartAreaNH3";
            chartNH3.Legends["Media"].IsDockedInsideChartArea = true;
            for (int i = 0; i < 7; i++)
            {
                chartNH3.Series["Average"].Points.Add().SetValueXY(listaNH3[i].day, Math.Round(listaNH3[i].avg, 2));
                chartNH3.Series["Minimum"].Points.Add().SetValueXY(listaNH3[i].day, Math.Round(listaNH3[i].min, 2));
                chartNH3.Series["Maximum"].Points.Add().SetValueXY(listaNH3[i].day, Math.Round(listaNH3[i].max, 2));
            }

            maximum = 0;
            index = 0;
            for (int i = 0; i < 7; i++)
            {
                if (listaNH3[i].max > maximum)
                {
                    maximum = listaNH3[i].max;
                    index = i;
                }
            }

            chartNH3.ChartAreas["ChartAreaNH3"].AxisY.Maximum = Math.Round(listaNH3[index].max + 3);

            minimun = 10;
            index = 0;
            for (int i = 0; i < 7; i++)
            {
                if (listaNH3[i].min < minimun)
                {
                    minimun = listaNH3[i].min;
                    index = i;
                }
            }
            if (listaNH3[index].min > 2)
            {
                chartNH3.ChartAreas["ChartAreaNH3"].AxisY.Minimum = Math.Round(listaNH3[index].min - 2);
            }
            else
            {
                chartNH3.ChartAreas["ChartAreaNH3"].AxisY.Minimum = 0;
            }

            HttpWebRequest requestCI2 = WebRequest.Create(@"http://localhost:55500/parameters/CI2/" + date.Year + "/" + date.Month + "/" + date.Day + "/" + date1.Year + "/" + date1.Month + "/" + date1.Day) as HttpWebRequest;
            requestCI2.ContentType = "application/json";
            HttpWebResponse responseCI2 = requestCI2.GetResponse() as HttpWebResponse;
            string jsonCI2 = new StreamReader(responseCI2.GetResponseStream()).ReadToEnd();
            List<WeeklyDay> listaCI2 = JsonConvert.DeserializeObject<List<WeeklyDay>>(jsonCI2);
            chartCI2.Series["Average"].Points.Clear();
            chartCI2.Series["Minimum"].Points.Clear();
            chartCI2.Series["Maximum"].Points.Clear();
            chartCI2.Legends["Media"].DockedToChartArea = "ChartAreaCI2";
            chartCI2.Legends["Media"].IsDockedInsideChartArea = true;
            for (int i = 0; i < 7; i++)
            {
                chartCI2.Series["Average"].Points.Add().SetValueXY(listaCI2[i].day, Math.Round(listaCI2[i].avg, 2));
                chartCI2.Series["Minimum"].Points.Add().SetValueXY(listaCI2[i].day, Math.Round(listaCI2[i].min, 2));
                chartCI2.Series["Maximum"].Points.Add().SetValueXY(listaCI2[i].day, Math.Round(listaCI2[i].max, 2));
            }

            maximum = 0;
            index = 0;
            for (int i = 0; i < 7; i++)
            {
                if (listaCI2[i].max > maximum)
                {
                    maximum = listaCI2[i].max;
                    index = i;
                }
            }

            chartCI2.ChartAreas["ChartAreaCI2"].AxisY.Maximum = Math.Round(listaCI2[index].max + 3);

            minimun = 10;
            index = 0;
            for (int i = 0; i < 7; i++)
            {
                if (listaCI2[i].min < minimun)
                {
                    minimun = listaCI2[i].min;
                    index = i;
                }
            }
            if (listaCI2[index].min > 2)
            {
                chartCI2.ChartAreas["ChartAreaCI2"].AxisY.Minimum = Math.Round(listaCI2[index].min - 2);
            }
            else
            {
                chartCI2.ChartAreas["ChartAreaCI2"].AxisY.Minimum = 0;
            }
        }

        private void btnStatsByHour_Click(object sender, EventArgs e)
        {
            DateTime data = Convert.ToDateTime(dateTimePickerDay.Value.Date.ToString("dd-MM-yyyy"));
            InitializeHourlyCharts();
            groupBoxGraphs.Text = "Daily Statistics By Hour";

            HttpWebRequest requestPH = WebRequest.Create(@"http://localhost:55500/parameters/PH/" + data.Year + "/" + data.Month + "/" + data.Day) as HttpWebRequest;
            requestPH.ContentType = "application/json";
            HttpWebResponse responsePH = requestPH.GetResponse() as HttpWebResponse;
            string jsonPH = new StreamReader(responsePH.GetResponseStream()).ReadToEnd();
            List<Hour> listaPH = JsonConvert.DeserializeObject<List<Hour>>(jsonPH);
            chartPH.Series["Average"].Points.Clear();
            chartPH.Series["Minimum"].Points.Clear();
            chartPH.Series["Maximum"].Points.Clear();
            chartPH.Legends["Media"].DockedToChartArea = "ChartAreaPH";
            chartPH.Legends["Media"].IsDockedInsideChartArea = true;
            for (int i = 0; i < 24; i++)
            {
                chartPH.Series["Average"].Points.Add().SetValueXY(Convert.ToDateTime(listaPH[i].hour + ":00"), Math.Round(listaPH[i].avg, 2));
                chartPH.Series["Minimum"].Points.Add().SetValueXY(Convert.ToDateTime(listaPH[i].hour + ":00"), Math.Round(listaPH[i].min, 2));
                chartPH.Series["Maximum"].Points.Add().SetValueXY(Convert.ToDateTime(listaPH[i].hour + ":00"), Math.Round(listaPH[i].max, 2));
            }

            float maximum = 0;
            int index = 0;
            for (int i = 0; i < 24; i++)
            {
                if (listaPH[i].max > maximum)
                {
                    maximum = listaPH[i].max;
                    index = i;
                }
            }

            chartPH.ChartAreas["ChartAreaPH"].AxisY.Maximum = Math.Round(listaPH[index].max + 3);

            float minimun = 10;
            index = 0;
            for(int i = 0; i < 24; i++)
            {
                if (listaPH[i].min < minimun)
                {
                    minimun = listaPH[i].min;
                    index = i;
                }
            }
            if (listaPH[index].min > 2)
            {
                chartPH.ChartAreas["ChartAreaPH"].AxisY.Minimum = Math.Round(listaPH[index].min - 2);
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
            chartNH3.Series["Average"].Points.Clear();
            chartNH3.Series["Minimum"].Points.Clear();
            chartNH3.Series["Maximum"].Points.Clear();
            chartNH3.Legends["Media"].DockedToChartArea = "ChartAreaNH3";
            chartNH3.Legends["Media"].IsDockedInsideChartArea = true;
            for (int i = 0; i < 24; i++)
            {
                chartNH3.Series["Average"].Points.Add().SetValueXY(Convert.ToDateTime(listaNH3[i].hour + ":00"), Math.Round(listaNH3[i].avg, 2));
                chartNH3.Series["Minimum"].Points.Add().SetValueXY(Convert.ToDateTime(listaNH3[i].hour + ":00"), Math.Round(listaNH3[i].min, 2));
                chartNH3.Series["Maximum"].Points.Add().SetValueXY(Convert.ToDateTime(listaNH3[i].hour + ":00"), Math.Round(listaNH3[i].max, 2));
            }

            maximum = 0;
            index = 0;
            for (int i = 0; i < 24; i++)
            {
                if (listaNH3[i].max > maximum)
                {
                    maximum = listaNH3[i].max;
                    index = i;
                }
            }
            chartNH3.ChartAreas["ChartAreaNH3"].AxisY.Maximum = Math.Round(listaNH3[index].max + 3);

            minimun = 10;
            index = 0;
            for (int i = 0; i < 24; i++)
            {
                if (listaNH3[i].min < minimun)
                {
                    minimun = listaNH3[i].min;
                    index = i;
                }
            }
            if (listaNH3[index].min > 2)
            {
                chartNH3.ChartAreas["ChartAreaNH3"].AxisY.Minimum = Math.Round(listaNH3[index].min - 2);
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
            chartCI2.Series["Average"].Points.Clear();
            chartCI2.Series["Minimum"].Points.Clear();
            chartCI2.Series["Maximum"].Points.Clear();
            chartCI2.Legends["Media"].DockedToChartArea = "ChartAreaCI2";
            chartCI2.Legends["Media"].IsDockedInsideChartArea = true;
            for (int i = 0; i < 24; i++)
            {
                chartCI2.Series["Average"].Points.Add().SetValueXY(Convert.ToDateTime(listaCI2[i].hour + ":00"), Math.Round(listaCI2[i].avg, 2));
                chartCI2.Series["Minimum"].Points.Add().SetValueXY(Convert.ToDateTime(listaCI2[i].hour + ":00"), Math.Round(listaCI2[i].min, 2));
                chartCI2.Series["Maximum"].Points.Add().SetValueXY(Convert.ToDateTime(listaCI2[i].hour + ":00"), Math.Round(listaCI2[i].max, 2));
            }

            maximum = 0;
            index = 0;
            for (int i = 0; i < 24; i++)
            {
                if (listaCI2[i].max > maximum)
                {
                    maximum = listaCI2[i].max;
                    index = i;
                }
            }
            chartCI2.ChartAreas["ChartAreaCI2"].AxisY.Maximum = Math.Round(listaCI2[index].max + 4);
            
            minimun = 10;
            index = 0;
            for (int i = 0; i < 24; i++)
            {
                if (listaCI2[i].min < minimun)
                {
                    minimun = listaCI2[i].min;
                    index = i;
                }
            }
            if (listaCI2[index].min > 2)
            {
                chartCI2.ChartAreas["ChartAreaCI2"].AxisY.Minimum = Math.Round(listaCI2[index].min - 2);
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
