namespace Fitness_Tracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";

            username = textBox1.Text;
            password = textBox2.Text;

            if (username == "admin" && password == "1234")
            {
                //MessageBox.Show("Login Sucessful!!");
                //Health_Details Details hd = new Health Details();
                //hd.Show();
                //this.Hide();

                string connectionString = "server=DESKTOP-DEB1IV5\\SQLEXPRESS;database=fitness_tracker;integrated Security=SSPI;";

                using (SqlConnection _con = new SqlConnection(connectionString))
                {
                    string queryStatement = "SELECT  * FROM user_details;

                    using (SqlCommand _cmd = new SqlCommand(queryStatement, _con))
                    {
                        DataTable customerTable = new DataTable();

                        SqlDataAdapter _dap = new SqlDataAdapter(_cmd);

                        _con.Open();
                        _dap.Fill(customerTable);
                        _con.Close();

                    }
                }
            }
            else
            {
                MessageBox.Show("Login Failed!!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
