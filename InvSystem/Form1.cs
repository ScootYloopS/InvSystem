namespace InvSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UserBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PassBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogButt_Click(object sender, EventArgs e)
        {
            string username = "carljacob";
            string password = "saggincafe23";
            string userinput = UserBox.Text;
            string passinput = PassBox.Text;

            if (userinput == username && passinput == password)
            {
                MessageBox.Show("Login Successful!");
                Form2 form2 = new Form2();
                this.Hide();
                form2.Show();
            }
            else
                MessageBox.Show("Incorrect username/password");
        }
    }
}