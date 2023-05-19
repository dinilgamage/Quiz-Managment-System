using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDAM_02
{
    public partial class AdminLoginPanel : Form
    {
        public AdminLoginPanel()
        {
            InitializeComponent();
            panel2.BackColor = Color.FromArgb(180, Color.DarkCyan);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text == "1234")
            { 
                Questions qs= new Questions();
                qs.Show();
                this.Hide();

                qs.Left = this.Left;
                qs.Top = this.Top;
                qs.Size = this.Size;
            }
            else
            {

                MessageBox.Show("Incorrect Password!", "Trivia Titans", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();

            lg.Left = this.Left;
            lg.Top = this.Top;
            lg.Size = this.Size;
        }

        private void AdminLoginPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
