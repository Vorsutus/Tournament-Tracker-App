using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class createPrizeForm : Form
    {
        public createPrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            //if ValidateForm method works through everything and comes back true...
            if (ValidateForm())
            {
                //create a new prizeModel object and fill the overload with the text to be parsed into the correct type
                PrizeModel model = new PrizeModel(
                    placeNumberValue.Text,
                    placeNameValue.Text,
                    prizeAmountValue.Text,
                    prizePercentageValue.Text);

                //for each thing in the Connections list (text file and Database) of type IDataConnection
                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    //we pass in our model and it returns a new model with an ID
                    db.CreatePrize(model);
                }

                //empty out the values of the form when we are done with it
                placeNumberValue.Text = "";
                placeNameValue.Text = "";
                prizeAmountValue.Text = "0.00";
                prizePercentageValue.Text = "0";
            }
            else
            {
                MessageBox.Show("This Form has invalid information. Please check and try again.");
            }
            
        }

        private bool ValidateForm()
        {
            //assume the form is valid unless errors are found
            bool output = true;

            //var to hold a 0 or 1 from the output of the tryParse bool (false/true)
            int placeNumber = 0;

            //try to parse the placeNumberValue as text and store true/false in placeNumberValidNumber var
            bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);

            //if the value is not valid at all...
            if (!placeNumberValidNumber)
            {
                output = false;
            }

            //if the actual number isn't at least one...
            if (placeNumber < 1)
            {
                output = false;
            }

            //if there is nothing in the place name value field...
            if (placeNameValue.Text.Length == 0)
            {
                output = false;
            }

            //the actual prize amount is money so it needs to be a decimal.
            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(prizePercentageValue.Text, out prizePercentage);

            //if prizeAmountValid is false or prizePercentageValid is false...
            if (!prizeAmountValid || !prizePercentageValid)
            {
                output = false;
            }

            //can't have negative money or percentage or 0.00, has to be something
            if (prizeAmount <= 0 && (prizePercentage <= 0 || prizePercentage > 100))
            {
                output = false;
            }

            return output;
        }
    }
}
