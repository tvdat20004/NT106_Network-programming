using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class student_in4 : Form
    {
        public student_in4()
        {
            InitializeComponent();
        }

        private void phoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (_name.Text == "" || mssv.Text == "" || phoneNum.Text == "" || mathGrade.Text == "" || literatureGrade.Text == "")
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }
            try
            {
                float math = float.Parse(mathGrade.Text);
                float literature = float.Parse(literatureGrade.Text);
                if (math < 0 || math > 10 || literature < 0 || literature > 10)
                {
                    MessageBox.Show("Invalid grade!");
                    return;
                }
                string line = mssv.Text + ";" + _name.Text + ";" + phoneNum.Text + ";" + mathGrade.Text + ";" + literatureGrade.Text;
                using (StreamWriter sw = new StreamWriter("input.txt", true, Encoding.UTF8))
                {
                    sw.WriteLine(line);
                }
                MessageBox.Show("Student added successfully!");

            }
            catch
            {
                MessageBox.Show("Invalid grade!");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _name.Text = "";
            mssv.Text = "";
            phoneNum.Text = "";
            mathGrade.Text = "";
            literatureGrade.Text = "";
        }

        private void mathGrade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
