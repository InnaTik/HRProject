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
    public partial class MainHRForm : Form
    {
        public MainHRForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainHRForm myform = new MainHRForm();
            myform.Hide();
            SearchVacancies form = new SearchVacancies();
            form.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ResumeForm form = new ResumeForm();
            form.Show();
            this.Hide();
        }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             ResumeForm form = new ResumeForm( );
            form.Show();
            this.Hide();
        }
    }
}
