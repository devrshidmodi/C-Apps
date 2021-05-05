using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_1_Homework_Assignment_3
{
    public partial class Unit1MathProblemsPages23_24Form : Form
    {
        // This doesn't require any fields (global variables).

        // Constructor Method
        public Unit1MathProblemsPages23_24Form()
        {
            InitializeComponent();

            // Make tab control visible. Even if the 'Visible' property is set to 'True' in the 
            // designer, the tab control is not visible. Not sure why the tab control behaves this way.
            tabControl1.Visible = true;


            // Note that the 'DropDownStyle' property of each combo box was set to 'DropDownList' to make 
            // make both combo boxes "read only". This eliminates the need for input-checking code.

            // Set the combo boxes and text boxes to display today's date.
            string[] monthName = { "January", "February", "March", "April", "May", "June",
                                   "July", "August", "September", "October", "November", "December" };
            DateTime rightNow = DateTime.Now;

            // The order of the following statements matters! Try changing the order to see what happens.

            DayComboBox.Text = rightNow.Day.ToString();
            DoomsdayYearTextBox.Text = rightNow.Year.ToString();
            MonthComboBox.Text = monthName[rightNow.Month + 1];
        }


        #region Event Handlers

        // All your event handlers should be placed in this region.
        // For the sake of clean organization, all other methods are placed in a separate class ('MathProblems').
        // The class was added by right-clicking on the project "Unit 1 Homework Assignment 3" and selecting
        // "Add > Class..." from the context menu.

        // Adjust the number of days in the month depending on which month is selected.
        private void MonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 31 Days -> Jan, Mar, May, Jul, Aug, Oct, Dec (Months 1, 3, 5, 7, 8, 10, 12)
            // 30 Days -> Apr, Jun, Sep, Nov (Months 4, 6, 9, 11) 
            // 28 Days -> Feb, if not a leap year (Month 2)
            // 29 Days -> Feb, if is a leap year (Month 2)

            // "January" is at index 0, "February" is at index 1, etc. 
            int month = MonthComboBox.SelectedIndex + 1;

            int year = Convert.ToInt32(DoomsdayYearTextBox.Text);

            int daysInMonth;

            if (month % 2 == 1 & month <= 7 || month == 8 || month == 10 || month == 12) //Jan, Mar, May, Jul, Aug, Oct, Dec
            {
                daysInMonth = 31;
            }
            else if (month != 2) // Apr, Jun, Sep, Nov
            {
                daysInMonth = 30;
            }
            else //Feb
            {
                if (!MathProblems.IsLeapYear(year))
                {
                    daysInMonth = 28;
                }
                else
                {
                    daysInMonth = 29;
                }

            }

            // Save the currently selected day.
            int currentlySelectedDay = Convert.ToInt32(DayComboBox.Text);

            // Clear 'DayComboBox' then add the the consecutive integers from 1 to 'daysInMonth'.
            // This clears the currently selected day as well. This will be restored later.
            DayComboBox.Items.Clear();
            for (int i = 1; i <= daysInMonth; i++)
            {
                DayComboBox.Items.Add(i.ToString());
            }

            // Now restore the selected day if possible. If not set the day to the last day of the month.
            if (currentlySelectedDay <= daysInMonth)
            {
                DayComboBox.SelectedItem = DayComboBox.Items[currentlySelectedDay - 1].ToString();
            }
            else
            {
                DayComboBox.SelectedItem = DayComboBox.Items[DayComboBox.Items.Count - 1].ToString();
            }

        }

        // If the year changes from a non-leap year to a leap year or vice versa, AND the month is February,
        // the days in 'DayComboBox' need to be adjusted accordingly.
        private void DoomsdayYearTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MonthComboBox.Text == "February")
            {
                int year = Convert.ToInt32(DoomsdayYearTextBox.Text);
                bool isLeapYear = MathProblems.IsLeapYear(year);

                if (isLeapYear && DayComboBox.Items.Count == 28)
                {
                    // Add the 29th day to 'DayComboBox'
                    DayComboBox.Items.Add("29");
                }
                else if (!isLeapYear && DayComboBox.Items.Count == 29)
                {
                    // Save the currently selected day.
                    int currentlySelectedDay = Convert.ToInt32(DayComboBox.Text);

                    // Remove the 29th day from 'DayComboBox'
                    DayComboBox.Items.Remove("29");

                    // If 29 was originally selected, change it to 28 because date changed to a non-leap year
                    if (currentlySelectedDay == 29)
                    {
                        DayComboBox.Text = "28";
                    }
                }
            }

        }

        #endregion



    }
}
