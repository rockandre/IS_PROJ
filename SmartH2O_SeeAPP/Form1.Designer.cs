﻿Skip to content
This repository
Search
Pull requests
Issues
Gist
 @rockandre
 Unwatch 2
  Star 0
  Fork 0 rockandre/IS_PROJ
 Code  Issues 0  Pull requests 0  Projects 0  Wiki Pulse  Graphs Settings
Tree: a0a418b223 Find file Copy pathIS_PROJ/SmartH2O_SeeAPP/Form1.Designer.cs
a0a418b  17 hours ago
@rockandre rockandre Correction of bugs on log and alarm.
2 contributors @fabiolage @rockandre
RawBlameHistory
488 lines(480 sloc)  27.7 KB
namespace SmartH2O_SeeAPP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(42723D, "0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(42724D, "0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(42725D, "0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(42726D, "0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(42727D, "0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(42728D, "0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(42729D, "0,0");
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(42723D, "0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(42724D, "0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(42725D, "0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(42726D, "0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(42727D, "0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(42728D, "0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(42729D, "0,0");
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(42723D, "0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint16 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(42724D, "0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint17 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(42725D, "0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint18 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(42726D, "0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint19 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(42727D, "0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint20 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(42728D, "0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint21 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(42729D, "0,0");
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.buttonGetAlarmInfo = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.buttonSeeInfo2Dates = new System.Windows.Forms.Button();
            this.listBoxDayTwo = new System.Windows.Forms.ListBox();
            this.listBoxDayOne = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonGetInfoByParameter = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.checkBoxCI2 = new System.Windows.Forms.CheckBox();
            this.checkBoxNh3 = new System.Windows.Forms.CheckBox();
            this.checkBoxpH = new System.Windows.Forms.CheckBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.btnStatsByDay = new System.Windows.Forms.Button();
            this.btnStatsByHour = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.chartPH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxGraphs = new System.Windows.Forms.GroupBox();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPH)).BeginInit();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.groupBoxGraphs.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.buttonGetAlarmInfo);
            this.groupBox4.Location = new System.Drawing.Point(13, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(391, 308);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Raised Alarms Information";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(7, 50);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(378, 252);
            this.textBox4.TabIndex = 1;
            // 
            // buttonGetAlarmInfo
            // 
            this.buttonGetAlarmInfo.Location = new System.Drawing.Point(7, 20);
            this.buttonGetAlarmInfo.Name = "buttonGetAlarmInfo";
            this.buttonGetAlarmInfo.Size = new System.Drawing.Size(378, 23);
            this.buttonGetAlarmInfo.TabIndex = 0;
            this.buttonGetAlarmInfo.Text = "Get Alarm Information";
            this.buttonGetAlarmInfo.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox5);
            this.groupBox5.Controls.Add(this.buttonSeeInfo2Dates);
            this.groupBox5.Controls.Add(this.listBoxDayTwo);
            this.groupBox5.Controls.Add(this.listBoxDayOne);
            this.groupBox5.Location = new System.Drawing.Point(410, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(401, 308);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Alarm Information Beetween 2 Dates";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 150);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(389, 152);
            this.textBox5.TabIndex = 3;
            // 
            // buttonSeeInfo2Dates
            // 
            this.buttonSeeInfo2Dates.Location = new System.Drawing.Point(6, 121);
            this.buttonSeeInfo2Dates.Name = "buttonSeeInfo2Dates";
            this.buttonSeeInfo2Dates.Size = new System.Drawing.Size(389, 23);
            this.buttonSeeInfo2Dates.TabIndex = 2;
            this.buttonSeeInfo2Dates.Text = "See Alarms Information Beetween Two Dates";
            this.buttonSeeInfo2Dates.UseVisualStyleBackColor = true;
            // 
            // listBoxDayTwo
            // 
            this.listBoxDayTwo.FormattingEnabled = true;
            this.listBoxDayTwo.Location = new System.Drawing.Point(202, 20);
            this.listBoxDayTwo.Name = "listBoxDayTwo";
            this.listBoxDayTwo.Size = new System.Drawing.Size(193, 95);
            this.listBoxDayTwo.TabIndex = 1;
            // 
            // listBoxDayOne
            // 
            this.listBoxDayOne.FormattingEnabled = true;
            this.listBoxDayOne.Location = new System.Drawing.Point(6, 20);
            this.listBoxDayOne.Name = "listBoxDayOne";
            this.listBoxDayOne.Size = new System.Drawing.Size(190, 95);
            this.listBoxDayOne.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonGetInfoByParameter);
            this.groupBox6.Controls.Add(this.textBox6);
            this.groupBox6.Controls.Add(this.checkBoxCI2);
            this.groupBox6.Controls.Add(this.checkBoxNh3);
            this.groupBox6.Controls.Add(this.checkBoxpH);
            this.groupBox6.Location = new System.Drawing.Point(817, 13);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(355, 308);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Information By Parameter";
            // 
            // buttonGetInfoByParameter
            // 
            this.buttonGetInfoByParameter.Location = new System.Drawing.Point(7, 43);
            this.buttonGetInfoByParameter.Name = "buttonGetInfoByParameter";
            this.buttonGetInfoByParameter.Size = new System.Drawing.Size(342, 23);
            this.buttonGetInfoByParameter.TabIndex = 4;
            this.buttonGetInfoByParameter.Text = "Get Information By Parameter";
            this.buttonGetInfoByParameter.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(6, 71);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(343, 231);
            this.textBox6.TabIndex = 3;
            // 
            // checkBoxCI2
            // 
            this.checkBoxCI2.AutoSize = true;
            this.checkBoxCI2.Location = new System.Drawing.Point(269, 19);
            this.checkBoxCI2.Name = "checkBoxCI2";
            this.checkBoxCI2.Size = new System.Drawing.Size(42, 17);
            this.checkBoxCI2.TabIndex = 2;
            this.checkBoxCI2.Text = "CI2";
            this.checkBoxCI2.UseVisualStyleBackColor = true;
            // 
            // checkBoxNh3
            // 
            this.checkBoxNh3.AutoSize = true;
            this.checkBoxNh3.Location = new System.Drawing.Point(138, 19);
            this.checkBoxNh3.Name = "checkBoxNh3";
            this.checkBoxNh3.Size = new System.Drawing.Size(48, 17);
            this.checkBoxNh3.TabIndex = 1;
            this.checkBoxNh3.Text = "NH3";
            this.checkBoxNh3.UseVisualStyleBackColor = true;
            // 
            // checkBoxpH
            // 
            this.checkBoxpH.AutoSize = true;
            this.checkBoxpH.Location = new System.Drawing.Point(6, 19);
            this.checkBoxpH.Name = "checkBoxpH";
            this.checkBoxpH.Size = new System.Drawing.Size(40, 17);
            this.checkBoxpH.TabIndex = 0;
            this.checkBoxpH.Text = "pH";
            this.checkBoxpH.UseVisualStyleBackColor = true;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(1078, 748);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(80, 17);
            this.hScrollBar1.TabIndex = 6;
            // 
            // btnStatsByDay
            // 
            this.btnStatsByDay.Location = new System.Drawing.Point(13, 327);
            this.btnStatsByDay.Name = "btnStatsByDay";
            this.btnStatsByDay.Size = new System.Drawing.Size(190, 23);
            this.btnStatsByDay.TabIndex = 7;
            this.btnStatsByDay.Text = "Show Weekly Statistics By Day";
            this.btnStatsByDay.UseVisualStyleBackColor = true;
            this.btnStatsByDay.Click += new System.EventHandler(this.btnStatsByDay_Click);
            // 
            // btnStatsByHour
            // 
            this.btnStatsByHour.Location = new System.Drawing.Point(209, 327);
            this.btnStatsByHour.Name = "btnStatsByHour";
            this.btnStatsByHour.Size = new System.Drawing.Size(195, 23);
            this.btnStatsByHour.TabIndex = 8;
            this.btnStatsByHour.Text = "Show Daily Statistics By Hour";
            this.btnStatsByHour.UseVisualStyleBackColor = true;
            this.btnStatsByHour.Click += new System.EventHandler(this.btnStatsByHour_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.chartPH);
            this.groupBox12.Location = new System.Drawing.Point(7, 20);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(382, 269);
            this.groupBox12.TabIndex = 0;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "pH";
            // 
            // chartPH
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea1.AxisX.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.Yes;
            chartArea1.AxisX.Title = "Days";
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.Maximum = 14D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.Title = "Value";
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartAreaPH";
            this.chartPH.ChartAreas.Add(chartArea1);
            this.chartPH.Location = new System.Drawing.Point(7, 19);
            this.chartPH.Name = "chartPH";
            series1.ChartArea = "ChartAreaPH";
            series1.EmptyPointStyle.Name = "No Info Available";
            series1.IsXValueIndexed = true;
            series1.Name = "PH";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series1.YValuesPerPoint = 2;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartPH.Series.Add(series1);
            this.chartPH.Size = new System.Drawing.Size(365, 244);
            this.chartPH.TabIndex = 0;
            this.chartPH.Text = "chartPH";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.chart1);
            this.groupBox13.Location = new System.Drawing.Point(391, 20);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(382, 269);
            this.groupBox13.TabIndex = 1;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "NH3";
            // 
            // chart1
            // 
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea2.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea2.AxisX.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.Yes;
            chartArea2.AxisX.Title = "Days";
            chartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.AxisY.Maximum = 14D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.AxisY.Title = "Value";
            chartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartAreaNH3";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(6, 19);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartAreaNH3";
            series2.EmptyPointStyle.Name = "No Info Available";
            series2.IsXValueIndexed = true;
            series2.Name = "NH3";
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series2.Points.Add(dataPoint11);
            series2.Points.Add(dataPoint12);
            series2.Points.Add(dataPoint13);
            series2.Points.Add(dataPoint14);
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series2.YValuesPerPoint = 2;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(368, 244);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chartNH3";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.chart2);
            this.groupBox14.Location = new System.Drawing.Point(772, 20);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(382, 269);
            this.groupBox14.TabIndex = 2;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "CL2";
            // 
            // chart2
            // 
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea3.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea3.AxisX.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.Yes;
            chartArea3.AxisX.Title = "Days";
            chartArea3.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisY.IsStartedFromZero = false;
            chartArea3.AxisY.Maximum = 14D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.AxisY.Title = "Value";
            chartArea3.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea3.Name = "ChartAreaNH3";
            this.chart2.ChartAreas.Add(chartArea3);
            this.chart2.Location = new System.Drawing.Point(7, 19);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartAreaNH3";
            series3.EmptyPointStyle.Name = "No Info Available";
            series3.IsXValueIndexed = true;
            series3.Name = "NH3";
            series3.Points.Add(dataPoint15);
            series3.Points.Add(dataPoint16);
            series3.Points.Add(dataPoint17);
            series3.Points.Add(dataPoint18);
            series3.Points.Add(dataPoint19);
            series3.Points.Add(dataPoint20);
            series3.Points.Add(dataPoint21);
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series3.YValuesPerPoint = 2;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(367, 244);
            this.chart2.TabIndex = 3;
            this.chart2.Text = "chartNH3";
            // 
            // groupBoxGraphs
            // 
            this.groupBoxGraphs.Controls.Add(this.groupBox14);
            this.groupBoxGraphs.Controls.Add(this.groupBox13);
            this.groupBoxGraphs.Controls.Add(this.groupBox12);
            this.groupBoxGraphs.Location = new System.Drawing.Point(12, 356);
            this.groupBoxGraphs.Name = "groupBoxGraphs";
            this.groupBoxGraphs.Size = new System.Drawing.Size(1160, 295);
            this.groupBoxGraphs.TabIndex = 4;
            this.groupBoxGraphs.TabStop = false;
            this.groupBoxGraphs.Text = "Weekly Statistics By Day";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1184, 676);
            this.Controls.Add(this.btnStatsByHour);
            this.Controls.Add(this.btnStatsByDay);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBoxGraphs);
            this.MaximumSize = new System.Drawing.Size(1200, 715);
            this.MinimumSize = new System.Drawing.Size(1200, 715);
            this.Name = "Form1";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPH)).EndInit();
            this.groupBox13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.groupBoxGraphs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAlarmInfo2Dates;
        private System.Windows.Forms.ListBox listBoxDay1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxDay2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button buttonGetAlarmInfo;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button buttonSeeInfo2Dates;
        private System.Windows.Forms.ListBox listBoxDayTwo;
        private System.Windows.Forms.ListBox listBoxDayOne;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.CheckBox checkBoxCI2;
        private System.Windows.Forms.CheckBox checkBoxNh3;
        private System.Windows.Forms.CheckBox checkBoxpH;
        private System.Windows.Forms.Button buttonGetInfoByParameter;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Button btnStatsByDay;
        private System.Windows.Forms.Button btnStatsByHour;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.GroupBox groupBoxGraphs;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPH;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}