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
    public partial class ResumeForm : Form
    {
        public ResumeForm()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ooops... NO DATA FOUND...", "Search result");
        }
    }
}
