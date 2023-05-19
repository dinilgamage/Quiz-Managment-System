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
    public partial class Subjects : Form
    {
        SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());
        public Subjects()
        {
            InitializeComponent();
            DispSubject();

        }
        int selectedRow = 0;
        private void Reset()
        {
            txtsubjectname.Clear();
            selectedRow = 0;
        }
        private void DispSubject()
        {
            //select all from table and fill the datagridview with the data in the table
            Conn.Open();
            string query = "SELECT * FROM SubjectTbl";
            SqlDataAdapter adp = new SqlDataAdapter(query, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adp);
            var dataset = new DataSet();
            adp.Fill(dataset);
            subjectsgridview.DataSource = dataset.Tables[0];

            Conn.Close();
        }
        private void Subjects_Load(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtsubjectname.Text == "")
            {
                MessageBox.Show("Please Add The Missing Information", "Trivia Titans", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    Conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO SubjectTbl (SbName) VALUES (@Sbn)", Conn);
                    //add parameter with name and value pairs and passed through to the sql query
                    cmd.Parameters.AddWithValue("@Sbn", txtsubjectname.Text);
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Subject Saved!", "Trivia Titans", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Trivia Titans", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { Conn.Close(); }
                Reset(); //resets the forms after the valuess were entered into the database.
                DispSubject(); //displays the updated table after saving
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void subjectsgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtsubjectname.Text = subjectsgridview.SelectedRows[0].Cells[1].Value.ToString();
            
            if (txtsubjectname.Text == "")
            {
                selectedRow = 0;
            }
            else
            {
                selectedRow = Convert.ToInt32(subjectsgridview.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtsubjectname.Text == "")
            {
                MessageBox.Show("Please Add The Missing Information", "Trivia Titans", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    Conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE SubjectTbl SET SbName=@Sbn WHERE SbID=@Sr", Conn);
                    //add parameter with name and value
                    cmd.Parameters.AddWithValue("@Sbn", txtsubjectname.Text);
                    cmd.Parameters.AddWithValue("@Sr" , selectedRow);
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Subject Updated!", "Trivia Titans", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Trivia Titans", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { Conn.Close(); }
                Reset(); //resets the forms after the valuess were entered into the database.
                DispSubject();
            }
        }

      

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Do You Need To Delete This Record", "Trivia Titans", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (r == DialogResult.Yes)
                {
                    Conn.Open();
                    string sql = "DELETE FROM SubjectTbl WHERE SbID=@Sr";
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
            DispSubject();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
 
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
        
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
  
        }

        private void navq_Click(object sender, EventArgs e)
        {
            Questions qs = new Questions();
            qs.Show();
            this.Hide();

            qs.Left = this.Left;
            qs.Top = this.Top;
            qs.Size = this.Size;
        }

        private void navsub_Click(object sender, EventArgs e)
        {
            Subjects sb = new Subjects();
            sb.Show();
            this.Hide();

            sb.Left = this.Left;
            sb.Top = this.Top;
            sb.Size = this.Size;
        }

        private void navstud_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Show();
            this.Hide();

            student.Left = this.Left;
            student.Top = this.Top;
            student.Size = this.Size;
        }

        private void navexit_Click(object sender, EventArgs e)
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
