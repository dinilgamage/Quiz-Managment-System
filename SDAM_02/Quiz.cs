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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SDAM_02
{
    public partial class Quiz : Form
    {
        SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());
        public Quiz()
        {
            InitializeComponent();
            lblstud.Text = Login.studentName;
            lblsubject.Text = Login.subName;
            getQuestions();
            circularProgressBar1.Value = 0;
        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            
        }
        string a1, a2, a3, a4, a5, a6, a7, a8;

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            circularProgressBar1.Value += 1;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString();
            if(circularProgressBar1.Value == 300)
            {
                timer1.Enabled = false;
                
                calcScore();
                MessageBox.Show("Time is Up!\nYour score is " + score + "/ 8", "Trivia Titans", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login lg = new Login();
                lg.Show();
                this.Hide();

                lg.Left = this.Left;
                lg.Top = this.Top;
                lg.Size = this.Size;

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        int score = 0;
       
        private void btnsubmit_Click(object sender, EventArgs e)
        {

            timer1.Stop();
            calcScore();
           
            MessageBox.Show("Your score is " + score + "/ 8", "Trivia Titans", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Login lg = new Login();
            lg.Show();
            this.Hide();

            lg.Left = this.Left;
            lg.Top = this.Top;
            lg.Size = this.Size;

           

        }

        public void calcScore()
        {
            //sa = selected answer
            //check q1
            if (Q1O1.Checked)
            {
                string sa = "Option 1";
                if (sa == a1)
                {
                    score++;
                }
            }
            else if (Q1O2.Checked)
            {
                string sa = "Option 2";
                if (sa == a1)
                {
                    score++;
                }
            }
            else if (Q1O3.Checked)
            {
                string sa = "Option 3";
                if (sa == a1)
                {
                    score++;
                }
            }
            else if (Q1O4.Checked)
            {
                string sa = "Option 4";
                if (sa == a1)
                {
                    score++;
                }
            }
            // check q2
            if (Q2O1.Checked)
            {
                string sa = "Option 1";
                if (sa == a2)
                {
                    score++;
                }
            }
            else if (Q2O2.Checked)
            {
                string sa = "Option 2";
                if (sa == a2)
                {
                    score++;
                }
            }
            else if (Q2O3.Checked)
            {
                string sa = "Option 3";
                if (sa == a2)
                {
                    score++;
                }
            }
            else if (Q2O4.Checked)
            {
                string sa = "Option 4";
                if (sa == a2)
                {
                    score++;
                }
            }
            //check q3
            if (Q3O1.Checked)
            {
                string sa = "Option 1";
                if (sa == a3)
                {
                    score++;
                }
            }
            else if (Q3O2.Checked)
            {
                string sa = "Option 2";
                if (sa == a3)
                {
                    score++;
                }
            }
            else if (Q3O3.Checked)
            {
                string sa = "Option 3";
                if (sa == a3)
                {
                    score++;
                }
            }
            else if (Q3O4.Checked)
            {
                string sa = "Option 4";
                if (sa == a3)
                {
                    score++;
                }
            }
            //check q4
            if (Q4O1.Checked)
            {
                string sa = "Option 1";
                if (sa == a4)
                {
                    score++;
                }
            }
            else if (Q4O2.Checked)
            {
                string sa = "Option 2";
                if (sa == a4)
                {
                    score++;
                }
            }
            else if (Q4O3.Checked)
            {
                string sa = "Option 3";
                if (sa == a4)
                {
                    score++;
                }
            }
            else if (Q4O4.Checked)
            {
                string sa = "Option 4";
                if (sa == a4)
                {
                    score++;
                }
            }
            //check q5
            if (Q5O1.Checked)
            {
                string sa = "Option 1";
                if (sa == a5)
                {
                    score++;
                }
            }
            else if (Q5O2.Checked)
            {
                string sa = "Option 2";
                if (sa == a5)
                {
                    score++;
                }
            }
            else if (Q5O3.Checked)
            {
                string sa = "Option 3";
                if (sa == a5)
                {
                    score++;
                }
            }
            else if (Q5O4.Checked)
            {
                string sa = "Option 4";
                if (sa == a5)
                {
                    score++;
                }
            }
            //check q6
            if (Q6O1.Checked)
            {
                string sa = "Option 1";
                if (sa == a6)
                {
                    score++;
                }
            }
            else if (Q6O2.Checked)
            {
                string sa = "Option 2";
                if (sa == a6)
                {
                    score++;
                }
            }
            else if (Q6O3.Checked)
            {
                string sa = "Option 3";
                if (sa == a6)
                {
                    score++;
                }
            }
            else if (Q6O4.Checked)
            {
                string sa = "Option 4";
                if (sa == a6)
                {
                    score++;
                }
            }
            //check q7
            if (Q7O1.Checked)
            {
                string sa = "Option 1";
                if (sa == a7)
                {
                    score++;
                }
            }
            else if (Q7O2.Checked)
            {
                string sa = "Option 2";
                if (sa == a7)
                {
                    score++;
                }
            }
            else if (Q7O3.Checked)
            {
                string sa = "Option 3";
                if (sa == a7)
                {
                    score++;
                }
            }
            else if (Q7O4.Checked)
            {
                string sa = "Option 4";
                if (sa == a7)
                {
                    score++;
                }
            }
            //check q8
            if (Q8O1.Checked)
            {
                string sa = "Option 1";
                if (sa == a8)
                {
                    score++;
                }
            }
            else if (Q8O2.Checked)
            {
                string sa = "Option 2";
                if (sa == a8)
                {
                    score++;
                }
            }
            else if (Q8O3.Checked)
            {
                string sa = "Option 3";
                if (sa == a8)
                {
                    score++;
                }
            }
            else if (Q8O4.Checked)
            {
                string sa = "Option 4";
                if (sa == a8)
                {
                    score++;
                }
            }
        }

        public void getQuestions()
        {
            try
            {
                Conn.Open();
                string query = "SELECT * FROM QuestionTbl WHERE QS='" + lblsubject.Text + "' ORDER BY NEWID()";
                SqlCommand cmd = new SqlCommand(query,Conn);
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
               

                Q1.Text = dt.Rows[0][1].ToString();
                Q1O1.Text = dt.Rows[0][2].ToString();
                Q1O2.Text = dt.Rows[0][3].ToString();
                Q1O3.Text = dt.Rows[0][4].ToString();
                Q1O4.Text = dt.Rows[0][5].ToString();
                a1 = dt.Rows[0][6].ToString();

                Q2.Text = dt.Rows[1][1].ToString();
                Q2O1.Text = dt.Rows[1][2].ToString();
                Q2O2.Text = dt.Rows[1][3].ToString();
                Q2O3.Text = dt.Rows[1][4].ToString();
                Q2O4.Text = dt.Rows[1][5].ToString();
                a2 = dt.Rows[1][6].ToString();

                Q3.Text = dt.Rows[2][1].ToString();
                Q3O1.Text = dt.Rows[2][2].ToString();
                Q3O2.Text = dt.Rows[2][3].ToString();
                Q3O3.Text = dt.Rows[2][4].ToString();
                Q3O4.Text = dt.Rows[2][5].ToString();
                a3 = dt.Rows[2][6].ToString();

                Q4.Text = dt.Rows[3][1].ToString();
                Q4O1.Text = dt.Rows[3][2].ToString();
                Q4O2.Text = dt.Rows[3][3].ToString();
                Q4O3.Text = dt.Rows[3][4].ToString();
                Q4O4.Text = dt.Rows[3][5].ToString();
                a4 = dt.Rows[3][6].ToString();

                Q5.Text = dt.Rows[4][1].ToString();
                Q5O1.Text = dt.Rows[4][2].ToString();
                Q5O2.Text = dt.Rows[4][3].ToString();
                Q5O3.Text = dt.Rows[4][4].ToString();
                Q5O4.Text = dt.Rows[4][5].ToString();
                a5 = dt.Rows[4][6].ToString();

                Q6.Text = dt.Rows[5][1].ToString();
                Q6O1.Text = dt.Rows[5][2].ToString();
                Q6O2.Text = dt.Rows[5][3].ToString();
                Q6O3.Text = dt.Rows[5][4].ToString();
                Q6O4.Text = dt.Rows[5][5].ToString();
                a6 = dt.Rows[5][6].ToString();

                Q7.Text = dt.Rows[6][1].ToString();
                Q7O1.Text = dt.Rows[6][2].ToString();
                Q7O2.Text = dt.Rows[6][3].ToString();
                Q7O3.Text = dt.Rows[6][4].ToString();
                Q7O4.Text = dt.Rows[6][5].ToString();
                a7 = dt.Rows[6][6].ToString();

                Q8.Text = dt.Rows[7][1].ToString();
                Q8O1.Text = dt.Rows[7][2].ToString();
                Q8O2.Text = dt.Rows[7][3].ToString();
                Q8O3.Text = dt.Rows[7][4].ToString();
                Q8O4.Text = dt.Rows[7][5].ToString();
                a8 = dt.Rows[7][6].ToString();

            } 
            catch (Exception ex)
            {
                
            }
            finally
            {
        
                Conn.Close();

            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Login lg = new Login();
            lg.Show();
            this.Hide();

            lg.Left = this.Left;
            lg.Top = this.Top;
            lg.Size = this.Size;

        }

     

    }
}
