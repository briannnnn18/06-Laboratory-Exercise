using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace StudentRegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Year();

        }
        private void Year()
        {
            for (int Y = 1990; Y < +2024; Y++)
            {
                ComboBox_Year.Items.Add(Y);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label_StudentR_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Button_Register_Click(object sender, EventArgs e)
        {
            string LastName = TextBox_LastN.Text;
            string FirstName = TextBox_FirstN.Text;
            string MiddleName = TextBox_MiddleN.Text;
            string gender = RadioButton_Male.Checked ? "Male" : "Female";
            string dateOfBirth = $"{Combobox_Day.Text}/{ComboBox_Month.Text}/{ComboBox_Year.Text}";
            string program = ComboBox_SelectP.Text;

            DisplayStudentInfo(LastName, FirstName);
            DisplayStudentInfo(LastName, FirstName, MiddleName);
            DisplayStudentInfo(LastName, FirstName, gender, dateOfBirth, program);
        }
        private void DisplayStudentInfo(string lastName, string firstName)
        {
            MessageBox.Show($"Student Name: {lastName}, {firstName}", "Student Information");
        }


        private void DisplayStudentInfo(string lastName, string firstName, string middleName)
        {
            MessageBox.Show($"Student Name: {lastName}, {firstName} {middleName}", "Student Information");
        }


        private void DisplayStudentInfo(string lastName, string firstName, string gender, string dateOfBirth, string program)
        {
            MessageBox.Show($"Student Name: {lastName}, {firstName}\n" +
                            $"Gender: {gender}\n" +
                            $"Date of Birth: {dateOfBirth}\n" +
                            $"Program: {program}", "Student Information");
        }

        private void Button_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
            }
        }
    }
}
