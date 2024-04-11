using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class CreateOrOverwrite : Form
    {
        public CreateOrOverwrite()
        {
            InitializeComponent();
        }
        string result = "";
        private void CreateOrOverwrite_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = "create";
            this.Close();
        }
        public string getResult()
        {
            return result;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            result = "overwrite";
            this.Close();
        }
    }
}
