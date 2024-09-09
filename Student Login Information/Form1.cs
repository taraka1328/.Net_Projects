using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

namespace Lab2
{
    public partial class form_stu_info : Form
    {
        public form_stu_info()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=PRASANNA\\SQLEXPRESS;Initial Catalog=STUDENT;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
                con.Open();
            
                string insertQuery = "INSERT INTO STUDENT_INFORMATION VALUES (@ROLL_NO ,@STUDENT_NAME, @CURRENT_YEAR ,@CURRENT_SEM, @GENDER, @M_NAME, @F_NAME, @CGPA, @TOTAL_BACKLOGS, @SAC_CLUBS)";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@Roll_NO", txt_stu_roll.Text);
                cmd.Parameters.AddWithValue("@STUDENT_NAME", txt_stu_name.Text);
                cmd.Parameters.AddWithValue("@CURRENT_YEAR", combo_c_year.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@CURRENT_SEM", combo_c_sem.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@GENDER", combo_gender.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@M_NAME", txt_mname.Text);
                cmd.Parameters.AddWithValue("@F_NAME", txt_fname.Text);
               // cmd.Parameters.AddWithValue("@FATHER_PHNO", txt_f_phno.Text);
               // cmd.Parameters.AddWithValue("@STUDENT_PHNO", txt_stu_phno.Text);
                cmd.Parameters.AddWithValue("@CGPA", txt_cgpa.Text);
                cmd.Parameters.AddWithValue("@TOTAL_BACKLOGS", txt_backlogs.Text);
                cmd.Parameters.AddWithValue("@SAC_CLUBS", l_box_sac_clubs.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Submission Completed. \n"+"Student Name : "+txt_stu_name.Text + "\nStudent RollNo: "+txt_stu_roll.Text);
            
        }
      
    }
}
