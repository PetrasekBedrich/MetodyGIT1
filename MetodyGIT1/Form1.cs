using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodyGIT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime nejstarsi(DateTimePicker dt1,DateTimePicker dt2,DateTimePicker dt3)
        {
            DateTime min = dt1.Value;
            if (dt2.Value < min) min = dt2.Value;
            if (dt3.Value < min) min = dt3.Value;
            return min;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            label1.Text = nejstarsi(dateTimePicker1,dateTimePicker2,dateTimePicker3).ToString("d. M. yyyy");
        }
    }
}
