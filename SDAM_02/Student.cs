using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace SDAM_02
{
    public partial class Student : Form
    {
        SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());

        public Student()
        {
            InitializeComponent();
            DispStudent();
        }
        private void Reset ()
        {
            txtsname.Clear();
            txtsage.Clear();
            txtspassword.Clear();
            txtsaddress.Clear();
            txtsphone.Clear();
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            
            if (txtsname.Text == "" || txtsage.Text == "" || txtsaddress.Text == "" || txtsphone.Text == "" || txtspassword.Text == "")
            {
                MessageBox.Show("Please Add The Missing Information", "Trivia Titans", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    int score = 0;
                    Conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO StudentTbl (SName, SAge, SPass, SAddress, SPhone) VALUES (@Sn,@Sa,@Sp,@Sadd, @Sph)", Conn);
                    //add parameter with name and value pairs and passed through to the sql query
                    cmd.Parameters.AddWithValue("@Sn", txtsname.Text);
                    cmd.Parameters.AddWithValue("@Sa", txtsage.Text);
                    cmd.Parameters.AddWithValue("@Sp", txtspassword.Text);
                    cmd.Parameters.AddWithValue("@Sadd", txtsaddress.Text);
                    cmd.Parameters.AddWithValue("@Sph", txtsphone.Text);
                    cmd.ExecuteNonQuery(); 


                    MessageBox.Show("Student Saved!", "Trivia Titans", MessageBoxButtons.OK, MessageBoxIcon.Information );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Trivia Titans", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { Conn.Close(); }
                Reset(); //resets the forms after the valuess were entered into the database.
                DispStudent(); //shows the updated table after saving
            }
        }
        private void DispStudent() 
        { 
            //select all from table and fill the datagridview with the data in the table
            Conn.Open();
            string query = "SELECT * FROM StudentTbl";
            SqlDataAdapter adp = new SqlDataAdapter(query,Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adp);
            var dataset = new DataSet();
            adp.Fill(dataset);
            studentgridview.DataSource = dataset.Tables[0] ;

            Conn.Close();
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtsname.Text == "" || txtsage.Text == "" || txtsaddress.Text == "" || txtsphone.Text == "" || txtspassword.Text == "")
            {
                MessageBox.Show("Please Add The Missing Information", "Trivia Titans", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    int score = 0;
                    Conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE StudentTbl SET SName=@Sn, SAge=@Sa, SPass=@Sp, SAddress=@Sadd, SPhone=@Sph WHERE SID=@Sr", Conn);
                    //add parameter with name and value
                    cmd.Parameters.AddWithValue("@Sn", txtsname.Text);
                    cmd.Parameters.AddWithValue("@Sa", txtsage.Text);
                    cmd.Parameters.AddWithValue("@Sp", txtspassword.Text);
                    cmd.Parameters.AddWithValue("@Sadd", txtsaddress.Text);
                    cmd.Parameters.AddWithValue("@Sph", txtsphone.Text);
                    cmd.Parameters.AddWithValue("@Sr", selectedRow);
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Student Updated!", "Trivia Titans", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Trivia Titans", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { Conn.Close(); }
                Reset(); //resets the forms after the valuess were entered into the database.
                DispStudent();
            }
        }

        int selectedRow = 0;
        private void studentgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtsname.Text = studentgridview.SelectedRows[0].Cells[1].Value.ToString();
            txtsage.Text = studentgridview.SelectedRows[0].Cells[2].Value.ToString();
            txtsaddress.Text = studentgridview.SelectedRows[0].Cells[3].Value.ToString();
            txtsphone.Text = studentgridview.SelectedRows[0].Cells[4].Value.ToString();
            txtspassword.Text = studentgridview.SelectedRows[0].Cells[5].Value.ToString();
            if (txtsname.Text == "")
            {
                selectedRow = 0;
            }
            else
            {
                selectedRow = Convert.ToInt32(studentgridview.SelectedRows[0].Cells[0].Value.ToString());
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
                    string sql = "DELETE FROM StudentTbl WHERE SID=@Sr";
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
            DispStudent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
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
