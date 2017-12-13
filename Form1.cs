using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JasonMellingerAssignment05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void citiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.citiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.citiesDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'citiesDataSet.Cities' table. You can move, or remove it, as needed.
            this.citiesTableAdapter.Fill(this.citiesDataSet.Cities);

        }

        private void totalPop_Click(object sender, EventArgs e)
        {
            decimal sum = 0;                                                        //variable to hold the query results

            sum = (decimal)this.citiesTableAdapter.SumPopulation();                 //query to find total population of all cities

            totalText.Text = sum.ToString();                                        //print to textbox
        }

        private void avgPop_Click(object sender, EventArgs e)
        {
            decimal avgPop = 0;                                                     //variable to hold the query results

            avgPop = (decimal)this.citiesTableAdapter.AveragePopulation();          //query that find average population

            avgText.Text = avgPop.ToString();                                       //print to textbox
        }

        private void highestPop_Click(object sender, EventArgs e)
        {
            decimal maxPop = 0;                                                     //variable to hold the query results

            maxPop = (decimal)this.citiesTableAdapter.HighestPopulation();          //query that finds the highest population

            highestText.Text = maxPop.ToString();                                   //print to textbox
        }

        private void lowestPop_Click(object sender, EventArgs e)
        {
            decimal minPop = 0;                                                     //variable to hold the query results

            minPop = (decimal)this.citiesTableAdapter.LowestPopulation();           //query that finds the lowest population

            lowestText.Text = minPop.ToString();                                    //print to textbox 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            totalText.Text = "";                                                    //clear textbox for each calculation
            avgText.Text = "";
            highestText.Text = "";
            lowestText.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Jacob";
        }
    }
}
