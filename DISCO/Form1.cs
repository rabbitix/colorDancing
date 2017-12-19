using System;
using System.Threading;
using System.Windows.Forms;

namespace DISCO
{
    public partial class Form1 : Form
    {
        colors colorpick = new colors();

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                ThreadStart ts = new ThreadStart(colorpick.regular);
                Thread TRD = new Thread(ts);
                TRD.Start();
                ThreadStart ts1 = new ThreadStart(colorpick.regular);
                Thread TRD1 = new Thread(ts1);
                TRD1.Start();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                ThreadStart ts = new ThreadStart(colorpick.allcolors);
                Thread TRD = new Thread(ts);
                TRD.Start();
                ThreadStart ts1 = new ThreadStart(colorpick.allcolors);
                Thread TRD1 = new Thread(ts1);
                TRD1.Start();
            }
            if (checkBox2.CheckState == CheckState.Unchecked)
            {
                //nothing for now
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
            if (checkBox3.CheckState == CheckState.Unchecked)
            {
                FormBorderStyle = FormBorderStyle.FixedSingle;
                WindowState = FormWindowState.Normal;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           colorpick.Run = false;
           System.Environment.Exit(0);
        }
    }
}