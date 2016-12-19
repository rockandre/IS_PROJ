﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartH2O_SeeAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetDays_Click(object sender, EventArgs e)
        {
            HandlerXML myClass = new HandlerXML("param-data.xml");
            listBoxDayOne.DataSource = myClass.GetDays();
        }

        private void btnStatsByDay_Click(object sender, EventArgs e)
        {
            /*groupBoxGraphs.Text = "Weekly Statistics By Day";*/
        }

        private void btnStatsByHour_Click(object sender, EventArgs e)
        {
            
            groupBoxGraphs.Text = "Daily Statistics By Hour";
            
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

        
    }
}
