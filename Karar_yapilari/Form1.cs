using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karar_yapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, s2, project, avg;
            string state;
            s1=Convert.ToInt16(textBox1.Text);
            s2 = Convert.ToInt16(textBox2.Text);
            project = Convert.ToInt16(textBox3.Text);
            avg = (s1 + s2 + project) / 3;

            if (avg>=50)
            {
                state=("Passed the lesson");
            }
            else
            {
                state=("didn't pass the lesson");
            }
            textBox4.Text = avg + "/ " + state;

        }
    }
}
