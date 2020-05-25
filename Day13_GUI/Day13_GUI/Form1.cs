using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day13_GUI
{
    public partial class Form1 : Form
    {
        protected String name;
        protected String surname;
        protected String course;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            name = nameBox.Text;
            
        }

        private void surnameBox_TextChanged(object sender, EventArgs e)
        {
            surname = surnameBox.Text;
        }

        private void courseBox_TextChanged(object sender, EventArgs e)
        {
            course = courseBox.Text;
            int coursNumber;
            try
            {
                coursNumber = Convert.ToInt32(course);

                if (coursNumber > 1 && coursNumber < 3)
                {
                    courseError.Text = "Ievadīts nepareizs kursa numurs";
                }
            }
            catch (Exception)
            {

                courseError.Text = "Nav ievadīta skaitliska vērtība!";
            }


        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (name == null)
            {
                nameError.Text = "Nav ievadīts studenta vārds";
            }

            lblPrintName.Text = $"Vārds: {name}";

            if (surname == null)
            {
                surnameError.Text = "Nav ievadīts studenta Uzvārds";
            }

            lblPrintSurname.Text = $"Uzvārds: {surname}";

            if (course == null)
            {
                courseError.Text = "Nav ievadīts studenta mācību kurss";
            }

            lblPrintCourse.Text = $"Studiju kurs: {course}";

        }
    }
}
