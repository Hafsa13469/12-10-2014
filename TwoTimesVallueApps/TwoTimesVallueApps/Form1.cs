using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoTimesVallueApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowTwoTimesValue_Click(object sender, EventArgs e)
        {
            double aNumber = Convert.ToDouble(aNumberTextBox.Text);
            double output = GetDouble(aNumber);
            Console.WriteLine(output);

            //double result = aNumber * 2;
            

            
        }
        private double GetDouble(double aNumber)
        {
            double result = aNumber * 2;
            TwoTimesValueTextBox.Text = result.ToString();
            return result;
        }
    }
}
