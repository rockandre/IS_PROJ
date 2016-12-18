using System;
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
            listBoxDay1.DataSource = myClass.GetDays();
        }

        private void btnStatsByDay_Click(object sender, EventArgs e)
        {
            /*groupBoxGraphs.Text = "Weekly Statistics By Day";
            chartPH.Series.Add("PH");
            chartPH.ChartAreas.Add("ChartAreaPH");
            chartPH.ChartAreas["ChartAreaPH"].AxisX.Name = "Hours";*/
        }

        private void btnStatsByHour_Click(object sender, EventArgs e)
        {
           // groupBoxGraphs.Text = "Daily Statistics By Hour";
        }

        private void buttonGetInfoByParameter_Click(object sender, EventArgs e)
        {

            if (checkBoxpH.Checked)
            {
                //textBoxInfoByPara.Text = textBoxInfoByPara.Text + getInfoByParameter("PH");
            }

            if (checkBoxNh3.Checked)
            {
                //textBoxInfoByPara.Text = textBoxInfoByPara.Text + getInfoByParameter("NH3");
            }

            if (checkBoxCl2.Checked)
            {
                //textBoxInfoByPara.Text = textBoxInfoByPara.Text + getInfoByParameter("CI2");
            }

        }
    }
}
