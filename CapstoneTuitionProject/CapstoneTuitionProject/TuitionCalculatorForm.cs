using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapstoneTuitionProject
{
    public partial class TuitionCalculatorForm : Form
    {
        // constants for maintenance and tuition fees per credit hour
        private const decimal
            maintInState = 156.0m,
            maintOutState = 642.0m,
            tuition_eRate = 234.0m,
            tuitionDualEnr = 166.0m,
            tuitionTechAcc = 10.0m,
            tuitionNurs = 25.0m,
            eCampInState = 156.0m,
            eCampOutState = 642.0m,
            onlineAccess = 62.0m;

        // constants for universal fees per student
        private const decimal
            applicationFee = 20.0m,
            lateFee = 25.0m,
            parkingPermit = 15.0m,
            parkingFines = 25.0m,
            disabilityViolation = 200.0m;

        private decimal subtotal,
                        technologyAccessFee,
                        nursingCourseFee,
                        onlineAccessFee,
                        costPerCreditHr,
                        total;

        private int totalCredits,
                    totalNursingCredits,
                    totalOnlineCredits,
                    numOnlineCourses;


        public TuitionCalculatorForm()
        {
            InitializeComponent();
        }

        private void bt_addClass_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_courseCode.Text != String.Empty && tb_courseName.Text != String.Empty && tb_courseHrs.Text != String.Empty && tb_courseCode.Text != "Course code" && tb_courseName.Text != "Course name" && tb_courseHrs.Text != "Hours")
                {
                    Regex regex = new Regex("[Ww][0-9][0-9]$");

                    Course course = new Course(tb_courseCode.Text.ToUpper(), tb_courseName.Text, Int32.Parse(tb_courseHrs.Text));
                    course.IsOnline = regex.IsMatch(tb_courseCode.Text);

                    lb_courseList.Items.Add(course);

                    tb_courseCode.Text = "Course code";
                    tb_courseName.Text = "Course name";
                    tb_courseHrs.Text = "Hours";

                    if (bt_addClass.Text == "Update")
                    {
                        bt_addClass.Text = "Add";
                        bt_editClass.Enabled = true;
                        bt_deleteClass.Enabled = true;
                        bt_saveAllPrint.Enabled = true;
                    }

                    CalculateTuitionTotals();
                }
                else
                {
                    MessageBox.Show("Please enter all course information.", "Invalid Course Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Please enter a valid number for credit hours.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tb_courseHrs.Focus();
            }
            
        }

        private void bt_editClass_Click(object sender, EventArgs e)
        {
            if(lb_courseList.SelectedIndex != -1)
            {
                Course item = (Course)lb_courseList.SelectedItem;

                tb_courseCode.Text = item.CourseCode;
                tb_courseName.Text = item.CourseName;
                tb_courseHrs.Text = item.CreditHours.ToString();

                lb_courseList.Items.RemoveAt(lb_courseList.SelectedIndex);

                bt_addClass.Text = "Update";
                bt_editClass.Enabled = false;
                bt_deleteClass.Enabled = false;
                bt_saveAllPrint.Enabled = false;

                tb_courseCode.Focus();
            }

            //CalculateTuitionTotals();
        }

        private void bt_deleteClass_Click(object sender, EventArgs e)
        {
            if(lb_courseList.SelectedIndex != -1)
                lb_courseList.Items.RemoveAt(lb_courseList.SelectedIndex);

            CalculateTuitionTotals();
        }

        private void bt_saveAllPrint_Click(object sender, EventArgs e)
        {
            if(tb_studentName.Text == String.Empty || tb_studentANum.Text == String.Empty)
            {
                MessageBox.Show("Please enter your name and A#.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(total == 0)
            {
                MessageBox.Show("Please select your courses.", "Invalid Course Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                CalculateTuitionTotals();

                MessageBox.Show( String.Format("Name: {0}\nA#: {1}\n\n", tb_studentName.Text, tb_studentANum.Text) +
                                 String.Format("Total Credits: {0}\nOnline Credits: {1}\nNursing Credits: {2}\n\nPrice Per Credit Hour: {3:N2}\n\n", totalCredits, totalOnlineCredits, totalNursingCredits, costPerCreditHr) +
                                 String.Format("Subtotal: {0:N2}\nTechnology Access Fee: {1:N2}\nNursing Course Fee: {2:N2}\nOnline Access Fee: {3:N2}\n\nTotal: {4:N2}", subtotal, technologyAccessFee, nursingCourseFee, onlineAccessFee, total) );
            }
        }

        private void TuitionCalculatorForm_Load(object sender, EventArgs e)
        {
            rad_InStateTrue.Checked = true;

            tb_courseCode.Text = "Course code";
            tb_courseName.Text = "Course name";
            tb_courseHrs.Text = "Hours";

            tb_courseCode.GotFocus += tb_GotFocus;
            tb_courseCode.LostFocus += tb_LostFocus;

            tb_courseName.GotFocus += tb_GotFocus;
            tb_courseName.LostFocus += tb_LostFocus;

            tb_courseHrs.GotFocus += tb_GotFocus;
            tb_courseHrs.LostFocus += tb_LostFocus;
        }

        private void tb_LostFocus(object sender, EventArgs e)
        {
            string text = "";
            if (String.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
                if (sender.Equals(tb_courseCode)) text = "Course code";
                if (sender.Equals(tb_courseName)) text = "Course name";
                if (sender.Equals(tb_courseHrs)) text = "Hours";

                //tb_courseCode.Text = "Course code";
                ((TextBox)sender).Text = text;
            }
                
        }

        private void tb_GotFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "Course code" || tb.Text == "Course name" || tb.Text == "Hours")
                tb.Text = "";
        }

        private void onCheckedChanged(object sender, EventArgs e)
        {
            CalculateTuitionTotals();
        }

        private void CalculateTuitionTotals()
        {
            totalCredits = 0;
            totalNursingCredits = 0;
            totalOnlineCredits = 0;
            numOnlineCourses = 0;

            costPerCreditHr = 0.0m;

            foreach (object item in lb_courseList.Items)
            {
                Course course = (Course)item;
                totalCredits += course.CreditHours;

                Regex regex = new Regex("^NURS");
                if (regex.IsMatch(course.CourseCode))
                {
                    totalNursingCredits += course.CreditHours;
                }

                if (course.IsOnline)
                {
                    numOnlineCourses++;
                    totalOnlineCredits += course.CreditHours;
                }
            }

            bool onlineExclusively = (numOnlineCourses == lb_courseList.Items.Count);

            bool isDualEnrollment = cb_highSchool.Checked;
            bool isTNResident = rad_InStateTrue.Checked;
            /*
            if (isDualEnrollment)
            {
                costPerCreditHr = tuitionDualEnr;
            }
            else if (isTNResident)
            {
                costPerCreditHr = maintInState;
            }
            else // not a tennessee resident
            {
                costPerCreditHr = onlineExclusively ? tuition_eRate : maintOutState;
            }
            */
            costPerCreditHr = isDualEnrollment ? tuitionDualEnr : isTNResident ? maintInState : onlineExclusively ? tuition_eRate : maintOutState;

            subtotal = costPerCreditHr * totalCredits;
            technologyAccessFee = tuitionTechAcc * totalCredits;
            nursingCourseFee = tuitionNurs * totalNursingCredits;
            onlineAccessFee = onlineAccess * totalOnlineCredits;

            total = subtotal + technologyAccessFee + nursingCourseFee + onlineAccessFee;

            lbl_costCalcutation.Text = String.Format("{0:n2}", total);
            //total.ToString();
        }
    }
}
