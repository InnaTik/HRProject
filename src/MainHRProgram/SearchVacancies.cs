using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainHRProgram
{
    public partial class SearchVacancies : Form
    {
        public SearchVacancies()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str;
            str = textBox1.Text;
            MessageBox.Show("Not found! :(");

        }
    }
}
