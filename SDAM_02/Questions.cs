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
    public partial class Questions : Form
    {
        SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());

        public Questions()
        {
            InitializeComponent();
            getSubjects();
            DispQuestion();

     
        }
        private void getSubjects()
        { 
            Conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT SbName FROM SubjectTbl" , Conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("SbName" ,typeof(string));
            dt.Load(dr);
            cmbsubject.ValueMember = "SbName";
            cmbsubject.DataSource = dt;
            Conn.Close();
        }
        private void Reset()
        {
            txtquestion.Clear();
            txtop1.Clear();
            txtop2.Clear();
            txtop3.Clear();
            txtop4.Clear();
            cmbans.SelectedIndex= 0;
            txthint.Clear();
            cmbsubject.SelectedIndex = 0;
        }
        private void DispQuestion()
        {
            //select all from table and fill the datagridview with the data in the table
            Conn.Open();
            string query = "SELECT * FROM QuestionTbl";
            SqlDataAdapter adp = new SqlDataAdapter(query, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adp);
            var dataset = new DataSet();
            adp.Fill(dataset);
            questionsgridview.DataSource = dataset.Tables[0];

            Conn.Close();
        }

        private void Questions_Load(object sender, EventArgs e)
        {
          
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtquestion.Text == "" || txtop1.Text == "" || txtop2.Text == "" || txtop3.Text == "" || txtop4.Text == "" || txthint.Text == "")
            {
                MessageBox.Show("Please Add The Missing Information", "Trivia Titans", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    Conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO QuestionTbl (QDesc, QO1, QO2, QO3, QO4, QA, QH, QS) VALUES (@Qs,@Qo1,@Qo2,@Qo3,@Qo4,@Qa,@Qh,@Qsb)", Conn);
                    //add parameter with name and value pairs and passed through to the sql query
                    cmd.Parameters.AddWithValue("@Qs", txtquestion.Text);
                    cmd.Parameters.AddWithValue("@Qo1", txtop1.Text);
                    cmd.Parameters.AddWithValue("@Qo2", txtop2.Text);
                    cmd.Parameters.AddWithValue("@Qo3", txtop3.Text);
                    cmd.Parameters.AddWithValue("@Qo4", txtop4.Text);
                    cmd.Parameters.AddWithValue("@Qa", cmbans.Text);
                    cmd.Parameters.AddWithValue("@Qh", txthint.Text);
                    cmd.Parameters.AddWithValue("@Qsb", cmbsubject.SelectedValue.ToString());
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Question Saved!", "Trivia Titans", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Trivia Titans", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { Conn.Close(); }
                Reset(); //resets the forms after the valuess were entered into the database.
                DispQuestion(); //shows the updated table after saving
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtquestion.Text == "" || txtop1.Text == "" || txtop2.Text == "" || txtop3.Text == "" || txtop4.Text == "" || cmbans.Text == "" || txthint.Text == "")
            {
                MessageBox.Show("Please Add The Missing Information", "Trivia Titans", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    Conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE QuestionTbl SET QDesc=@Qs, QO1=@Qo1, QO2=@Qo2, QO3=@Qo3, QO4=@Qo4, QA=@Qa, QH=@Qh, QS=@Qsb WHERE QID=@Sr", Conn);                   
                    //add parameter with name and value pairs and passed through to the sql query
                    cmd.Parameters.AddWithValue("@Qs", txtquestion.Text);
                    cmd.Parameters.AddWithValue("@Qo1", txtop1.Text);
                    cmd.Parameters.AddWithValue("@Qo2", txtop2.Text);
                    cmd.Parameters.AddWithValue("@Qo3", txtop3.Text);
                    cmd.Parameters.AddWithValue("@Qo4", txtop4.Text);
                    cmd.Parameters.AddWithValue("@Qa", cmbans.Text);
                    cmd.Parameters.AddWithValue("@Qh", txthint.Text);
                    cmd.Parameters.AddWithValue("@Qsb", cmbsubject.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Sr", selectedRow);
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Question Updated!", "Trivia Titans", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Trivia Titans", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { Conn.Close(); }
                Reset(); //resets the forms after the valuess were entered into the database.
                DispQuestion(); //shows the updated table after saving
            }
        }

        int selectedRow = 0;
        private void questionsgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtquestion.Text = questionsgridview.SelectedRows[0].Cells[1].Value.ToString();
            txtop1.Text = questionsgridview.SelectedRows[0].Cells[2].Value.ToString();
            txtop2.Text = questionsgridview.SelectedRows[0].Cells[3].Value.ToString();
            txtop3.Text = questionsgridview.SelectedRows[0].Cells[4].Value.ToString();
            txtop4.Text = questionsgridview.SelectedRows[0].Cells[5].Value.ToString();
            cmbans.Text = questionsgridview.SelectedRows[0].Cells[6].Value.ToString();
            txthint.Text = questionsgridview.SelectedRows[0].Cells[7].Value.ToString();
            cmbsubject.SelectedValue = questionsgridview.SelectedRows[0].Cells[8].Value.ToString();
            if (txtquestion.Text == "")
            {
                selectedRow = 0;
            }
            else
            {
                selectedRow = Convert.ToInt32(questionsgridview.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Do You Need To Delete This Record", "Trivia Titans", MessageBoxButtons.YesNo,
               MessageBoxIcon.Information);
                if (r == DialogResult.Yes)
                {
                    Conn.Open();
                    string sql = "DELETE FROM QuestionTbl WHERE QID=@Sr";
                    SqlCommand cmd = new SqlCommand(sql, Conn);
                    cmd.Parameters.AddWithValue("@Sr", selectedRow);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Successfully Deleted", "Trivia Titans", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Trivia Titans", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conn.Close();
            }
            Reset();
            DispQuestion();
        }

        private void navq_Click(object sender, EventArgs e)
        {
            
        }

        private void navsub_Click(object sender, EventArgs e)
        {
         
        }

        private void navstud_Click(object sender, EventArgs e)
        {
        
        }

        private void navexit_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Questions qs = new Questions();
            qs.Show();
            this.Hide();

            qs.Left = this.Left;
            qs.Top = this.Top;
            qs.Size = this.Size;
        }

        private void navsub_Click_1(object sender, EventArgs e)
        {
            Subjects sb = new Subjects();
            sb.Show();
            this.Hide();

            sb.Left = this.Left;
            sb.Top = this.Top;
            sb.Size = this.Size;
        }

        private void navstud_Click_1(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Show();
            this.Hide();

            student.Left = this.Left;
            student.Top = this.Top;
            student.Size = this.Size;
        }

        private void navexit_Click_1(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();

            lg.Left = this.Left;
            lg.Top = this.Top;
            lg.Size = this.Size;

        }
    }
}
