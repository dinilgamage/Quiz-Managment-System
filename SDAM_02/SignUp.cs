using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDAM_02
{
    public partial class SignUp : Form
    {
        SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());
        public SignUp()
        {
            InitializeComponent();
            panel2.BackColor = Color.FromArgb(180, Color.DarkCyan);
        }


        private void btncreate_Click(object sender, EventArgs e)
        {
           
            Conn.Open();
            SqlDataAdapter sd = new SqlDataAdapter("SELECT COUNT(*) FROM StudentTbl WHERE SPass='" + txtpassword.Text + "' OR SName='" + txtuser.Text + "'", Conn);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            if (dt.Rows[0][0].ToString() != "0")
            {
                MessageBox.Show("The Username or Password Aleady Exists", "Trivia Titans", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (txtuser.Text == "" || txtage.Text == "" || txtaddress.Text == "" || txtphone.Text == "" || txtpassword.Text == "")
                {
                    MessageBox.Show("Please Add The Missing Information", "Trivia Titans", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO StudentTbl (SName, SAge, SPass, SAddress, SPhone) VALUES (@Sn,@Sa,@Sp,@Sadd, @Sph)", Conn);
                        //add parameter with name and value pairs and passed through to the sql query
                        cmd.Parameters.AddWithValue("@Sn", txtuser.Text);
                        cmd.Parameters.AddWithValue("@Sa", txtage.Text);
                        cmd.Parameters.AddWithValue("@Sp", txtpassword.Text);
                        cmd.Parameters.AddWithValue("@Sadd", txtaddress.Text);
                        cmd.Parameters.AddWithValue("@Sph", txtphone.Text);
                        cmd.ExecuteNonQuery();


                        MessageBox.Show("Account Created!", "Trivia Titans", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Login lg = new Login();
                        lg.Show();
                        this.Hide();

                        lg.Left = this.Left;
                        lg.Top = this.Top;
                        lg.Size = this.Size;
                    }
                    catch 
                    {
                        MessageBox.Show("Please Enter the Correct Details", "Trivia Titans", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                 
                }

            }
            Conn.Close();
             
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

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
