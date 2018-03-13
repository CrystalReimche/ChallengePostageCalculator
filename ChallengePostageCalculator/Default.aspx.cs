using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void widthTextBox_TextChanged(object sender, EventArgs e)
    {
        
    }

    protected void heightTextBox_TextChanged(object sender, EventArgs e)
    {

    }

    protected void lengthTextBox_TextChanged(object sender, EventArgs e)
    {
       
    }

    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        calculateVolume();
        calculatePrice(.15, volume);    // Pass in parameters
    }

    protected void airRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        calculateVolume();
        calculatePrice(.25, volume);    // Pass in parameters
    }

    protected void nextDayRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        calculateVolume();
        calculatePrice(.45, volume);    // Pass in parameters
    }


    // Define volumn and make it in global scope
    double volume;


    // Create a method that will calculate the volume
    private void calculateVolume()
    {
        // Check to see if whatever's entered can be parsed into integar
        if (!Double.TryParse(widthTextBox.Text, out double width) || !Double.TryParse(heightTextBox.Text, out double height))
        {
            // If it can, return those values into the width and height variables
            return;
        }
        else if (!Double.TryParse(lengthTextBox.Text, out double length))
        {
            // if nothing is entered in the lenght textbox, make calculations equal only width * height
            volume = width * height;
            return;
        }
        else
            // If there was a lenght, add that into the equation and return the value into variable volume
            volume = width * height * length;
        return;
    }


    // Create a method that will calculate the price
    private void calculatePrice(double multiplier, double volume)
    {
        // Define price variable and set it to 0
        double price = 0;

        // Set price equal to multiplier * volume since those are the parameters
        price = multiplier * volume;

        // Display results to user
        resultLabel.Text = String.Format("Your parcel will cost {0:C} to ship.", price);
    }

}