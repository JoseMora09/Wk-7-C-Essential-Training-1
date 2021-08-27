using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using School_Library;

namespace Schools_form_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var testschool = new School();
            testschool.Name = "txtName.text";
            testschool.Address = "txtAddress.text";
            testschool.City = "txtCity.text";
            testschool.State = "txtState.text";
            testschool.Zip = "txtZip.text";
            testschool.PhoneNumber = "txtPhoneNumber";
            try
            {
                testschool.TwitterAddress = "@CentralCityHigh";
            } catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show(testschool.ToString());

            var teacher= new Teacher(); //for testing only - remove later
           
            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTestTeacher_Click(object sender, EventArgs e)
        {
            var teacher = new Teacher();
            var gp = teacher.ComputeGradeAverage();
            MessageBox.Show("the teacher's grade average is" + gp);

        }

        private void btnTestStudent_Click(object sender, EventArgs e)
        {
            var student = new Student();
            var gp = student.ComputeGradeAverage();
            MessageBox.Show("the student's grade average is" + gp);
        }
    }
}
