using System;
using System.Web.UI;

namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Get inputs for total classes and present classes
                int totalClasses = Convert.ToInt32(total.Text);
                int presentClasses = Convert.ToInt32(present.Text);

                // Calculate attendance percentage
                float attendancePercentage = (float)presentClasses * 100 / totalClasses;

                // Calculate number of absent classes
                int absentClasses = totalClasses - presentClasses;

                // Display the calculated values
                percentage.Text = attendancePercentage.ToString("F2");  // Limiting to 2 decimal points
                absent.Text = absentClasses.ToString();

                // Determine fine based on attendance percentage
                if (attendancePercentage >= 75)
                {
                    fine.Text = "No Fine";
                }
                else if (attendancePercentage >= 60 && attendancePercentage < 75)
                {
                    fine.Text = "Rs 1000";
                }
                else if (attendancePercentage >= 40 && attendancePercentage < 60)
                {
                    fine.Text = "Rs 2000";
                }
                else
                {
                    fine.Text = "Not Eligible for Exam";
                }
            }
            catch (FormatException)
            {
                // Handle cases where inputs are not valid numbers
                percentage.Text = "Error: Enter valid numbers.";
                absent.Text = "";
                fine.Text = "";
            }
        }
    }
}
