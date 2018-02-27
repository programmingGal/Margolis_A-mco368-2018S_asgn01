using PresidentialEligibility_partA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresidentialEligibility_PartC
{
    public partial class Form1 : Form
    {
        IndividualEligibility ie;

        public Form1()
        {
            InitializeComponent();
            ie = new IndividualEligibility();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ie.setPlaceBirth(true);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ie.setRebelledAgainstUS(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ie.setBirthYear(Int32.Parse(richTextBox1.Text));
            ie.setYearsResidedInUS(Int32.Parse(richTextBox2.Text));
            ie.setPriorTermsServed(Int32.Parse(richTextBox3.Text));

           Boolean eligible= ie.determineEligibility();

            if (eligible)
            {
                button1.Text = "You are eligible to run for president of the U.S.!";
                button1.Size = new System.Drawing.Size(180, 36);
            }
            else
            {
                button1.Text = "You are NOT eligible to run for president of the U.S.";
                button1.Size = new System.Drawing.Size(180, 36);
            }



        }
    }
}
