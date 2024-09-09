namespace Lab3
{
    public partial class Student_Info : Form
    {
        public Student_Info()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Submission Completed. \n" + "Student Name : " + txt_stu_roll.Text + "\nStudent RollNo: " + txt_stu_roll.Text);

        }
    }
}
