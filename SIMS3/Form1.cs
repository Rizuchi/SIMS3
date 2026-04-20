using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using System.Data;
using System.Reflection;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SIMS3
{
    public partial class Form1 : Form
    {
        CourseClass course = new CourseClass();
        StudentClass student = new StudentClass();


        private string firstName;
        private string role;

        public Form1(string fName, string userRole)
        {
            InitializeComponent();

            this.firstName = fName;
            this.role = userRole;

            hideSubMenu();
            label7.Text = userRole;

            CheckUserPermissions();

        }

        // hide button for teacher role 
        private void CheckUserPermissions()
        {

            if (this.role == "Teacher")
            {
                panel5.Visible = false;
                btnCourse.Visible = false;
                pnlManage.Visible = false;
                panel6.Visible = false;
                btnSetup.Visible = false;
                btnManageScore.Visible = false;
                btnManage1.Visible = false;
                btnMC.Visible = false;
            }
            else if (this.role == "Admin")
            {

                btnCourse.Visible = true;
                btnSetup.Visible = true;
                btnManageScore.Visible = true;
                btnManage1.Visible = true;
                btnMC.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // populate the combobox with courses name
            comboBox_class.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
            comboBox_class.DisplayMember = "CourseName";
            comboBox_class.ValueMember = "CourseName";

            comboBox_class.SelectedIndex = -1;

            studentCount();
        }

        private void studentCount()
        {
            label_totalstudent.Text = "Total Students: " + student.totalStudents();
            label_male.Text = "Male: " + student.maleStudents();
            label_female.Text = "Female: " + student.femaleStudents();
        }
        


        //toggle methods
        private void hideSubMenu()
        {
            pnlStudent.Visible = false;
            pnlManage.Visible = false;
            pnlCourse.Visible = false;
            pnlScore.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();           // Hide all first
                subMenu.Visible = true;  // Show the selected one
            }
            else
            {
                subMenu.Visible = false; // Hide if already open
            }
        }



        private void btnStudent_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(pnlStudent);
        }

        private void btnCourse_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(pnlCourse);
        }

        private void btnScore_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(pnlScore);
        }

        private void btnSetup_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(pnlManage);
        }

        private void label_totalstudent_Click(object sender, EventArgs e)
        {

        }

        private Form activeForm = null; // Corrected spelling from 'acativeForm'

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)

            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            openChildForm(new RegistryFormcs());
        }

        private void btnManage1_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageForm());
        }

        private void btnprint1_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintStudent());
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            openChildForm(new CourseForm());
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageCourseForm());
        }

        private void btnPrint2_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintCourseForm());
        }

        private void btnNewScore_Click(object sender, EventArgs e)
        {

            openChildForm(new ScoreForm2());

        }

        private void btnManageScore_Click(object sender, EventArgs e)

        {

            openChildForm(new ManageScoreForm());
        }

        private void btnPrint3_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintScoreForm());
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            openChildForm(new AccountCreateForm());
        }


        private void comboBox_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_class.SelectedValue == null || comboBox_class.SelectedIndex == -1)
            {
                label_enrolledmale.Text = "Male: 0";
                label_enrolledfemale.Text = "Female: 0";
                return;
            }

            string courseName = comboBox_class.Text;
            DataTable table = student.getStudentCountByCourse(courseName);

            if (table.Rows.Count > 0)
            {
                string maleCount = table.Rows[0]["MaleCount"].ToString();
                string femaleCount = table.Rows[0]["FemaleCount"].ToString();

                if (string.IsNullOrEmpty(maleCount)) maleCount = "0";
                if (string.IsNullOrEmpty(femaleCount)) femaleCount = "0";

                label_enrolledmale.Text = "Male: " + maleCount;
                label_enrolledfemale.Text = "Female: " + femaleCount;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                LoginForm login = new LoginForm();
                login.ShowDialog();
                this.Close();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
            studentCount();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
