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
                // Get inputs from TextBoxes
                int quantity = Convert.ToInt32(TextBox2.Text);
                int rate = Convert.ToInt32(TextBox3.Text);

                // Calculate Gross Amount
                int grossAmount = quantity * rate;

                // Calculate Discount (10% of Gross Amount)
                float discount = grossAmount * 0.10f;

                // Calculate Net Amount (Gross Amount - Discount)
                float netAmount = grossAmount - discount;

                // Display results in the respective TextBoxes
                TextBox4.Text = grossAmount.ToString();
                TextBox5.Text = discount.ToString();
                TextBox6.Text = netAmount.ToString();
            }
            catch (FormatException)
            {
                // Handle cases where inputs are not integers
                TextBox4.Text = "Error: Enter valid numbers.";
                TextBox5.Text = "";
                TextBox6.Text = "";
            }
        }
    }
}
