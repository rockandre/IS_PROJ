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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBoxAlarmInfo = new System.Windows.Forms.ListBox();
            this.buttonGetAlarmInfo = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listBoxAlarmsDateTwoDates = new System.Windows.Forms.ListBox();
            this.buttonSeeInfo2Dates = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listBoxInfoByParameter = new System.Windows.Forms.ListBox();
            this.buttonGetInfoByParameter = new System.Windows.Forms.Button();
            this.checkBoxCI2 = new System.Windows.Forms.CheckBox();
            this.checkBoxNh3 = new System.Windows.Forms.CheckBox();
            this.checkBoxpH = new System.Windows.Forms.CheckBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.btnStatsByDay = new System.Windows.Forms.Button();
            this.btnStatsByHour = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.chartPH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.chartNH3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.chartCI2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxGraphs = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDay = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerWeek = new System.Windows.Forms.DateTimePicker();
            this.FinalDate = new System.Windows.Forms.Label();
            this.StartDate = new System.Windows.Forms.Label();
            this.dateTimePickerFinalDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPH)).BeginInit();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartNH3)).BeginInit();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCI2)).BeginInit();
            this.groupBoxGraphs.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBoxAlarmInfo);
            this.groupBox4.Controls.Add(this.buttonGetAlarmInfo);
            this.groupBox4.Location = new System.Drawing.Point(13, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(391, 308);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Raised Alarms Information";
            // 
            // listBoxAlarmInfo
            // 
            this.listBoxAlarmInfo.FormattingEnabled = true;
            this.listBoxAlarmInfo.Location = new System.Drawing.Point(7, 49);
            this.listBoxAlarmInfo.Name = "listBoxAlarmInfo";
            this.listBoxAlarmInfo.Size = new System.Drawing.Size(378, 251);
            this.listBoxAlarmInfo.TabIndex = 1;
            // 
            // buttonGetAlarmInfo
            // 
            this.buttonGetAlarmInfo.Location = new System.Drawing.Point(7, 20);
            this.buttonGetAlarmInfo.Name = "buttonGetAlarmInfo";
            this.buttonGetAlarmInfo.Size = new System.Drawing.Size(378, 23);
            this.buttonGetAlarmInfo.TabIndex = 0;
            this.buttonGetAlarmInfo.Text = "Get Alarm Information";
            this.buttonGetAlarmInfo.UseVisualStyleBackColor = true;
            this.buttonGetAlarmInfo.Click += new System.EventHandler(this.buttonGetAlarmInfo_Click_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.FinalDate);
            this.groupBox5.Controls.Add(this.StartDate);
            this.groupBox5.Controls.Add(this.dateTimePickerFinalDate);
            this.groupBox5.Controls.Add(this.dateTimePickerStartDate);
            this.groupBox5.Controls.Add(this.listBoxAlarmsDateTwoDates);
            this.groupBox5.Controls.Add(this.buttonSeeInfo2Dates);
            this.groupBox5.Location = new System.Drawing.Point(410, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(401, 308);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Alarm Information Beetween 2 Dates";
            // 
            // listBoxAlarmsDateTwoDates
            // 
            this.listBoxAlarmsDateTwoDates.FormattingEnabled = true;
            this.listBoxAlarmsDateTwoDates.Location = new System.Drawing.Point(7, 73);
            this.listBoxAlarmsDateTwoDates.Name = "listBoxAlarmsDateTwoDates";
            this.listBoxAlarmsDateTwoDates.Size = new System.Drawing.Size(388, 225);
            this.listBoxAlarmsDateTwoDates.TabIndex = 3;
            // 
            // buttonSeeInfo2Dates
            // 
            this.buttonSeeInfo2Dates.Location = new System.Drawing.Point(6, 44);
            this.buttonSeeInfo2Dates.Name = "buttonSeeInfo2Dates";
            this.buttonSeeInfo2Dates.Size = new System.Drawing.Size(389, 23);
            this.buttonSeeInfo2Dates.TabIndex = 2;
            this.buttonSeeInfo2Dates.Text = "See Alarms Information Beetween Two Dates";
            this.buttonSeeInfo2Dates.UseVisualStyleBackColor = true;
            this.buttonSeeInfo2Dates.Click += new System.EventHandler(this.buttonSeeInfo2Dates_Click_2);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listBoxInfoByParameter);
            this.groupBox6.Controls.Add(this.buttonGetInfoByParameter);
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
            // listBoxInfoByParameter
            // 
            this.listBoxInfoByParameter.FormattingEnabled = true;
            this.listBoxInfoByParameter.Location = new System.Drawing.Point(6, 72);
            this.listBoxInfoByParameter.Name = "listBoxInfoByParameter";
            this.listBoxInfoByParameter.Size = new System.Drawing.Size(343, 225);
            this.listBoxInfoByParameter.TabIndex = 5;
            // 
            // buttonGetInfoByParameter
            // 
            this.buttonGetInfoByParameter.Location = new System.Drawing.Point(6, 43);
            this.buttonGetInfoByParameter.Name = "buttonGetInfoByParameter";
            this.buttonGetInfoByParameter.Size = new System.Drawing.Size(343, 23);
            this.buttonGetInfoByParameter.TabIndex = 4;
            this.buttonGetInfoByParameter.Text = "Get Information By Parameter";
            this.buttonGetInfoByParameter.UseVisualStyleBackColor = true;
            this.buttonGetInfoByParameter.Click += new System.EventHandler(this.buttonGetInfoByParameter_Click_2);
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
            this.btnStatsByHour.Location = new System.Drawing.Point(410, 327);
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
            this.chartPH.Location = new System.Drawing.Point(7, 19);
            this.chartPH.Name = "chartPH";
            this.chartPH.Size = new System.Drawing.Size(365, 244);
            this.chartPH.TabIndex = 0;
            this.chartPH.Text = "chartPH";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.chartNH3);
            this.groupBox13.Location = new System.Drawing.Point(391, 20);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(382, 269);
            this.groupBox13.TabIndex = 1;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "NH3";
            // 
            // chartNH3
            // 
            this.chartNH3.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartNH3.Location = new System.Drawing.Point(6, 19);
            this.chartNH3.Name = "chartNH3";
            this.chartNH3.Size = new System.Drawing.Size(368, 244);
            this.chartNH3.TabIndex = 2;
            this.chartNH3.Text = "chartNH3";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.chartCI2);
            this.groupBox14.Location = new System.Drawing.Point(772, 20);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(382, 269);
            this.groupBox14.TabIndex = 2;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "CI2";
            // 
            // chartCI2
            // 
            this.chartCI2.Location = new System.Drawing.Point(7, 19);
            this.chartCI2.Name = "chartCI2";
            this.chartCI2.Size = new System.Drawing.Size(367, 244);
            this.chartCI2.TabIndex = 3;
            this.chartCI2.Text = "chartNH3";
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
            // dateTimePickerDay
            // 
            this.dateTimePickerDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDay.Location = new System.Drawing.Point(611, 329);
            this.dateTimePickerDay.Name = "dateTimePickerDay";
            this.dateTimePickerDay.Size = new System.Drawing.Size(93, 20);
            this.dateTimePickerDay.TabIndex = 9;
            this.dateTimePickerDay.Value = new System.DateTime(2016, 12, 19, 0, 0, 0, 0);
            this.dateTimePickerDay.ValueChanged += new System.EventHandler(this.dateTimePickerWeek_ValueChanged);
            // 
            // dateTimePickerWeek
            // 
            this.dateTimePickerWeek.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerWeek.Location = new System.Drawing.Point(209, 329);
            this.dateTimePickerWeek.Name = "dateTimePickerWeek";
            this.dateTimePickerWeek.Size = new System.Drawing.Size(105, 20);
            this.dateTimePickerWeek.TabIndex = 10;
            this.dateTimePickerWeek.Value = new System.DateTime(2016, 12, 19, 0, 0, 0, 0);
            // 
            // FinalDate
            // 
            this.FinalDate.AutoSize = true;
            this.FinalDate.Location = new System.Drawing.Point(220, 23);
            this.FinalDate.Name = "FinalDate";
            this.FinalDate.Size = new System.Drawing.Size(56, 13);
            this.FinalDate.TabIndex = 17;
            this.FinalDate.Text = "Final date:";
            // 
            // StartDate
            // 
            this.StartDate.AutoSize = true;
            this.StartDate.Location = new System.Drawing.Point(21, 23);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(56, 13);
            this.StartDate.TabIndex = 16;
            this.StartDate.Text = "Start date:";
            // 
            // dateTimePickerFinalDate
            // 
            this.dateTimePickerFinalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFinalDate.Location = new System.Drawing.Point(282, 21);
            this.dateTimePickerFinalDate.Name = "dateTimePickerFinalDate";
            this.dateTimePickerFinalDate.Size = new System.Drawing.Size(93, 20);
            this.dateTimePickerFinalDate.TabIndex = 15;
            this.dateTimePickerFinalDate.Value = new System.DateTime(2016, 12, 19, 0, 0, 0, 0);
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(83, 21);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(93, 20);
            this.dateTimePickerStartDate.TabIndex = 14;
            this.dateTimePickerStartDate.Value = new System.DateTime(2016, 12, 19, 0, 0, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1184, 676);
            this.Controls.Add(this.dateTimePickerWeek);
            this.Controls.Add(this.dateTimePickerDay);
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
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPH)).EndInit();
            this.groupBox13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartNH3)).EndInit();
            this.groupBox14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCI2)).EndInit();
            this.groupBoxGraphs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonGetAlarmInfo;
        private System.Windows.Forms.Button buttonSeeInfo2Dates;
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNH3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCI2;
        private System.Windows.Forms.ListBox listBoxAlarmInfo;
        private System.Windows.Forms.ListBox listBoxAlarmsDateTwoDates;
        private System.Windows.Forms.ListBox listBoxInfoByParameter;
        private System.Windows.Forms.DateTimePicker dateTimePickerDay;
        private System.Windows.Forms.DateTimePicker dateTimePickerWeek;
        private System.Windows.Forms.Label FinalDate;
        private System.Windows.Forms.Label StartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinalDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
    }
}