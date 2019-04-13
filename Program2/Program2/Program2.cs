/*Grading ID: A7272
 * Class: CIS 199-01
 * Program 2
 * Due: 10/19/17
 * Description: This program accepts a letter input from the user and a radio button selection to determine when the student is able to register for classes*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class Program2 : Form
    {
        public Program2()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            char LastInitial = char.ToUpper(char.Parse(LastInitialBox.Text));  //Reads the Char the user entered, converts it to upper-case and stores it in the variable

            //This is the section for the freshman
            if (FreshmanButton.Checked == true && (LastInitial == 'A' || LastInitial == 'B')) //Checks that the freshman button was selcted and what letter was entered
            {
                DateOutputLabel.Text = "Nov. 9th";//outputs the registration date into the label
                TimeOutputLabel.Text = "11:30am";//outputs the registration time into the label
            }

            else if (FreshmanButton.Checked == true && (LastInitial == 'C' || LastInitial == 'D'))
            {
                DateOutputLabel.Text = "Nov. 9th";
                TimeOutputLabel.Text = "2:00pm";
            }

            else if (FreshmanButton.Checked == true && (LastInitial == 'E' || LastInitial == 'F'))
            {
                DateOutputLabel.Text = "Nov. 9th";
                TimeOutputLabel.Text = "4:00pm";
            }

            else if (FreshmanButton.Checked == true && (LastInitial == 'G' || LastInitial == 'H' || LastInitial == 'I'))
            {
                DateOutputLabel.Text = "Nov. 10th";
                TimeOutputLabel.Text = "8:30am";
            }

            else if (FreshmanButton.Checked == true && (LastInitial == 'J' || LastInitial == 'K' || LastInitial == 'L'))
            {
                DateOutputLabel.Text = "Nov. 10th";
                TimeOutputLabel.Text = "10:00am";
            }

            else if (FreshmanButton.Checked == true && (LastInitial == 'M' || LastInitial == 'N' || LastInitial == 'O'))
            {
                DateOutputLabel.Text = "Nov. 10th";
                TimeOutputLabel.Text = "11:30am";
            }

            else if (FreshmanButton.Checked == true && (LastInitial == 'P' || LastInitial == 'Q'))
            {
                DateOutputLabel.Text = "Nov. 10th";
                TimeOutputLabel.Text = "2:00pm";
            }

            else if (FreshmanButton.Checked == true && (LastInitial == 'R' || LastInitial == 'S'))
            {
                DateOutputLabel.Text = "Nov. 10th";
                TimeOutputLabel.Text = "4:00pm";
            }

            else if (FreshmanButton.Checked == true && (LastInitial == 'T' || LastInitial == 'U' || LastInitial == 'V'))
            {
                DateOutputLabel.Text = "Nov. 9th";
                TimeOutputLabel.Text = "8:30am";
            }

            else if (FreshmanButton.Checked == true && (LastInitial == 'W' || LastInitial == 'X' || LastInitial == 'Y' || LastInitial == 'Z'))
            {
                DateOutputLabel.Text = "Nov. 9th";
                TimeOutputLabel.Text = "10:00am";
            }

            //This section is for the Sophmores

            else if (SophmoreButton.Checked == true && (LastInitial == 'A' || LastInitial == 'B'))
            {
                DateOutputLabel.Text = "Nov. 7th";
                TimeOutputLabel.Text = "11:30am";
            }

            else if (SophmoreButton.Checked == true && (LastInitial == 'C' || LastInitial == 'D'))
            {
                DateOutputLabel.Text = "Nov. 7th";
                TimeOutputLabel.Text = "2:00pm";
            }

            else if (SophmoreButton.Checked == true && (LastInitial == 'E' || LastInitial == 'F'))
            {
                DateOutputLabel.Text = "Nov. 7th";
                TimeOutputLabel.Text = "4:00pm";
            }

            else if (SophmoreButton.Checked == true && (LastInitial == 'G' || LastInitial == 'H' || LastInitial == 'I'))
            {
                DateOutputLabel.Text = "Nov. 8th";
                TimeOutputLabel.Text = "8:30am";
            }

            else if (SophmoreButton.Checked == true && (LastInitial == 'J' || LastInitial == 'K' || LastInitial == 'L'))
            {
                DateOutputLabel.Text = "Nov. 8th";
                TimeOutputLabel.Text = "10:00am";
            }

            else if (SophmoreButton.Checked == true && (LastInitial == 'M' || LastInitial == 'N' || LastInitial == 'O'))
            {
                DateOutputLabel.Text = "Nov. 8th";
                TimeOutputLabel.Text = "11:30am";
            }

            else if (SophmoreButton.Checked == true && (LastInitial == 'P' || LastInitial == 'Q'))
            {
                DateOutputLabel.Text = "Nov. 8th";
                TimeOutputLabel.Text = "2:00pm";
            }

            else if (SophmoreButton.Checked == true && (LastInitial == 'R' || LastInitial == 'S'))
            {
                DateOutputLabel.Text = "Nov. 8th";
                TimeOutputLabel.Text = "4:00pm";
            }

            else if (SophmoreButton.Checked == true && (LastInitial == 'T' || LastInitial == 'U' || LastInitial == 'V'))
            {
                DateOutputLabel.Text = "Nov. 7th";
                TimeOutputLabel.Text = "8:30am";
            }

            else if (SophmoreButton.Checked == true && (LastInitial == 'W' || LastInitial == 'X' || LastInitial == 'Y' || LastInitial == 'Z'))
            {
                DateOutputLabel.Text = "Nov. 7th";
                TimeOutputLabel.Text = "10:00am";
            }

            //This section is for Juniors

            else if (JuniorButton.Checked == true && (LastInitial == 'A' || LastInitial == 'B' || LastInitial == 'C' || LastInitial == 'D'))
            {
                DateOutputLabel.Text = "Nov. 6th";
                TimeOutputLabel.Text = "10:00am";
            }

            else if (JuniorButton.Checked == true && (LastInitial == 'E' || LastInitial == 'F' || LastInitial == 'G' || LastInitial == 'H' || LastInitial == 'I'))
            {
                DateOutputLabel.Text = "Nov. 6th";
                TimeOutputLabel.Text = "11:30am";
            }

            else if (JuniorButton.Checked == true && (LastInitial == 'J' || LastInitial == 'K' || LastInitial == 'L' || LastInitial == 'M' || LastInitial == 'M' || LastInitial == 'O'))
            {
                DateOutputLabel.Text = "Nov. 6th";
                TimeOutputLabel.Text = "2:00pm";
            }

            else if (JuniorButton.Checked == true && (LastInitial == 'P' || LastInitial == 'Q' || LastInitial == 'R' || LastInitial == 'S'))
            {
                DateOutputLabel.Text = "Nov. 6th";
                TimeOutputLabel.Text = "4:00pm";
            }

            else if (JuniorButton.Checked == true && (LastInitial == 'T' || LastInitial == 'U' || LastInitial == 'V' || LastInitial == 'W' || LastInitial == 'X' || LastInitial == 'Y' || LastInitial == 'Z'))
            {
                DateOutputLabel.Text = "Nov. 6th";
                TimeOutputLabel.Text = "8:30am";
            }

            //This section is for Seniors

            else if (SeniorButton.Checked == true && (LastInitial == 'A' || LastInitial == 'B' || LastInitial == 'C' || LastInitial == 'D'))
            {
                DateOutputLabel.Text = "Nov. 3rd";
                TimeOutputLabel.Text = "10:00am";
            }

            else if (SeniorButton.Checked == true && (LastInitial == 'E' || LastInitial == 'F' || LastInitial == 'G' || LastInitial == 'H' || LastInitial == 'I'))
            {
                DateOutputLabel.Text = "Nov. 3rd";
                TimeOutputLabel.Text = "11:30am";
            }

            else if (SeniorButton.Checked == true && (LastInitial == 'J' || LastInitial == 'K' || LastInitial == 'L' || LastInitial == 'M' || LastInitial == 'M' || LastInitial == 'O'))
            {
                DateOutputLabel.Text = "Nov. 3rd";
                TimeOutputLabel.Text = "2:00pm";
            }

            else if (SeniorButton.Checked == true && (LastInitial == 'P' || LastInitial == 'Q' || LastInitial == 'R' || LastInitial == 'S'))
            {
                DateOutputLabel.Text = "Nov. 3rd";
                TimeOutputLabel.Text = "4:00pm";
            }

            else if (SeniorButton.Checked == true && (LastInitial == 'T' || LastInitial == 'U' || LastInitial == 'V' || LastInitial == 'W' || LastInitial == 'X' || LastInitial == 'Y' || LastInitial == 'Z'))
            {
                DateOutputLabel.Text = "Nov. 3rd";
                TimeOutputLabel.Text = "8:30am";
            }


        }
    }
}
