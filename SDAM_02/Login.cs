using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SDAM_02
{
    public partial class Login : Form
    {
        SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());

        public Login()
        {
            InitializeComponent();
            getSubjects();
            panel2.BackColor = Color.FromArgb(180, Color.DarkCyan);
       
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            AdminLoginPanel adminLoginPanel= new AdminLoginPanel();
            adminLoginPanel.Show();
            this.Hide();

            adminLoginPanel.Left = this.Left;
            adminLoginPanel.Top = this.Top;
            adminLoginPanel.Size = this.Size;
        }
        private void getSubjects()
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT SbName FROM SubjectTbl", Conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("SbName", typeof(string));
            dt.Load(dr);
            cmbsubject.ValueMember = "SbName";
            cmbsubject.DataSource = dt;
            Conn.Close();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            SignUp sn = new SignUp();
            sn.Show();
            this.Hide();

            sn.Left = this.Left;
            sn.Top = this.Top;
            sn.Size = this.Size;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public static string studentName="", subName = "";
        private void btnlogin_Click(object sender, EventArgs e)
        {
 
            if(txtuser.Text=="" || txtpassword.Text=="")
            {
                MessageBox.Show("Enter Username And Password", "Trivia Titans", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // returns the count of rows matching the query criteria and stores in sda, if the value is 1 means theres only one record
                Conn.Open();
                SqlDataAdapter sd = new SqlDataAdapter("SELECT COUNT(*) FROM StudentTbl WHERE SPass='"+txtpassword.Text+"' AND SName='"+txtuser.Text+"'" , Conn);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    studentName = txtuser.Text;
                    subName = cmbsubject.SelectedValue.ToString();
                    Quiz qz = new Quiz();
                    qz.Show();
                    this.Hide();
                    Conn.Close();

                    qz.Left = this.Left;
                    qz.Top = this.Top;
                    qz.Size = this.Size;
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password", "Trivia Titans", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Conn.Close();
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}