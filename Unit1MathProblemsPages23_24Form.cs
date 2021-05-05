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
        // This project doesn't require any fields (global variables).
        
        // Constructor Method
        public Unit1MathProblemsPages23_24Form()
        {
            InitializeComponent();

            // Make tab control visible. Even if the 'Visible' property is set to 'True' in the 
            // designer, the tab control is not visible. Not sure why the tab control behaves this way.
            tabControl1.Visible = true;

            // Set the 'Text' property to "January" by default.
            // Note that the 'DropDownStyle' property was set to 'DropDownList' to make 'MonthComboBox' "read only".
            MonthComboBox.Text = "January";
        }

        #region Event Handlers

        // All your event handlers should be placed in this region.
        // For the sake of clean organization, all other methods are placed in a separate class ('MathProblems').
        // The class was added by right-clicking on the project "Unit 1 Homework Assignment 3" and selecting
        // "Add > Class..." from the context menu.

        #endregion

        private void IsPrimeButton_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(IntegerTextBox.Text);
            PrimeAnswerLabel.Text = MathProblems.IsPrime(n).ToString();
        }

        private void DiscriminantButton_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(aTextBox.Text);
            double b = Convert.ToDouble(bTextBox.Text);
            double c = Convert.ToDouble(cTextBox.Text);
            DiscriminantLabel.Text = MathProblems.Discriminant(a, b, c).ToString();
        }

        private void LinearEquationButton_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(LinearCoefficientTextBox.Text);
            double b = Convert.ToDouble(ConstantCoefficientTextBox.Text);
            double c = Convert.ToDouble(RightSideOfEquationTextBox.Text);
            LinearEquationLabel.Text = MathProblems.LinearEquationSolution(a, b, c).ToString();
        }

        private void DistanceButton_Click(object sender, EventArgs e)
        {
            double x1= Convert.ToDouble(x1TextBox.Text);
            double y1= Convert.ToDouble(y1TextBox.Text);
            double x2 = Convert.ToDouble(x2TextBox.Text);
            double y2 = Convert.ToDouble(y2TextBox.Text);
            DistanceLabel.Text = MathProblems.Distance(x1, y1, x2, y2).ToString();
        }

        private void LeapYearButton_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(YearTextBox.Text);
            LeapYearLabel.Text = MathProblems.IsLeapYear(year).ToString();
        }

        private void DayOfTheWeekButton_Click(object sender, EventArgs e)
        {
            string month = MonthComboBox.Text;
            int day = Convert.ToInt32(textBox1.Text);
            int year = Convert.ToInt32(DoomsdayYearTextBox.Text);
            DayOfTheWeekLabel.Text = MathProblems.Doomsday(month, day, year).ToString();

        }

        private void GcdButton_Click(object sender, EventArgs e)
        {
            int m = Convert.ToInt32(Integer1TextBox.Text);
            int n = Convert.ToInt32(Integer2TextBox2.Text);
            GcdLabel.Text = MathProblems.Gcd(m, n).ToString();
        }
    }
}
