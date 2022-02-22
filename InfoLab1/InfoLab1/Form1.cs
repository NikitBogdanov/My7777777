using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoLab1
{
    public partial class FormAuthorizatoin : Form
    {
        public FormAuthorizatoin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            FormOrg form2 = new FormOrg();
            form2.ShowDialog();
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = Convert.ToChar(0);
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
    }
}
