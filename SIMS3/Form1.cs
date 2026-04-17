using System.Reflection;

namespace SIMS3
{
    public partial class Form1 : Form
    {


        StudentClass student = new StudentClass();
        public Form1()
        {
            InitializeComponent();

            hideSubMenu();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            ShowSubMenu(pnlStudent);
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

            // IMPORTANT: You need to add the child form to a Panel on your main form.
            // Replace 'panelMain' with the actual name of the empty Panel in the middle of your design.
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
    }
}
