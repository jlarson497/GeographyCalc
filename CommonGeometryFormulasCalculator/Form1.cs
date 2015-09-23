using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*******************************
 *This is a Geometry calculator that allows a user to calculate the area and perimeter of a few basic shapes.
 *It also includes a few unrelated, extra features because the boss likes to require extra work for no apparent
 *reason.  There are several radio buttons that allow a user to choose their desired shape, decide what they want
 *to calculate (area, perimeter, or both), and then textboxes to input the values for the necessary measurments.
 *It also displays a picture of each shape with the corresponding variable names for each side/measurement.
 *
 * Robert Masen, Carlos Lopez, Joseph Larson
 *******************************/

namespace CommonGeometryFormulasCalculator
{
    public partial class frmGeometryCalculator : Form
    {

        public frmGeometryCalculator()
        {
            InitializeComponent();

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (rdoRectangle.Checked == true)
            {
                decimal length = Convert.ToDecimal(txtRectL.Text);
                decimal width = Convert.ToDecimal(txtRectW.Text);
                decimal perimeter = (2 * length) + (2 * width);
                decimal area = length * width;

                if (rdoArea.Checked == true)
                {
                    lblAreaAnswer.Text = Convert.ToString(area);    
                }
                else if (rdoPerimeter.Checked == true)
                {
                    lblPerimeterAnswer.Text = Convert.ToString(perimeter);
                }
                else if (rdoAreaPerimeter.Checked == true)
                {
                    lblAreaAnswer.Text = Convert.ToString(area);
                    lblPerimeterAnswer.Text = Convert.ToString(perimeter);
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void clearText()
        {
            //THis method clears all the text that has been put in the textboxes
            //it is used everytime the radio buttons switch, to keep them clear
            txtSquareS.Clear();
            txtTrapezoidA.Clear();
            txtTrapezoidB.Clear();
            txtTrapezoidC.Clear();
            txtTrapezoidD.Clear();
            txtTrapezoidH.Clear();
            txtRectL.Clear();
            txtRectW.Clear();
            txtRhombusB.Clear();
            txtRhombusH.Clear();
            txtTriangleB.Clear();
            txtTriangleH.Clear();
            txtCircleR.Clear();
            txtParallelogramA.Clear();
            txtParallelogramB.Clear();
            txtParallelogramH.Clear();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear buttons clears ALL the text
            clearText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void rdoRectangle_CheckedChanged(object sender, EventArgs e)
        {
            //when the radiobutton Rectangle is selected, the image in the picbox changes to a rectangle
            //and the textboxes and labels needed for rectangle calculations are displayed and all text 
            //is cleared -- so that if you switch shapes and switch back all the values are cleared.
            //This prevents the form from holding old values for unnecessarily long times.
            //This convention follows for all the following RadioButton[Shape] selections, so
            //comments that would be copied and pasted are omitted
            picboxShape.BackgroundImage = Properties.Resources.Rectangle;
            lblRectL.Visible = !lblRectL.Visible;
            lblRectW.Visible = !lblRectW.Visible;
            txtRectL.Visible = !txtRectL.Visible;
            txtRectW.Visible = !txtRectW.Visible;
            clearText();
        }

        private void rdoSquare_CheckedChanged(object sender, EventArgs e)
        {
            picboxShape.BackgroundImage = Properties.Resources.Square;
            lblSquareS.Visible = !lblSquareS.Visible;
            txtSquareS.Visible = !txtSquareS.Visible;
            clearText();
        }

        private void grpShape_Enter(object sender, EventArgs e)
        {

        }

        private void rdoParallelogram_CheckedChanged(object sender, EventArgs e)
        {
            picboxShape.BackgroundImage = Properties.Resources.Parallelogram;
            lblParallelogramA.Visible = !lblParallelogramA.Visible;
            lblParallelogramB.Visible = !lblParallelogramB.Visible;
            lblParallelogramH.Visible = !lblParallelogramH.Visible;
            txtParallelogramA.Visible = !txtParallelogramA.Visible;
            txtParallelogramB.Visible = !txtParallelogramB.Visible;
            txtParallelogramH.Visible = !txtParallelogramH.Visible;
            clearText();
        }

        private void rdoRhombus_CheckedChanged(object sender, EventArgs e)
        {
            picboxShape.BackgroundImage = Properties.Resources.Rhombus;
            lblRhombusH.Visible = !lblRhombusH.Visible;
            lblRhombusBase.Visible = !lblRhombusBase.Visible;
            txtRhombusB.Visible = !txtRhombusB.Visible;
            txtRhombusH.Visible = !txtRhombusH.Visible;
            clearText();

        }

        private void rdoTriangle_CheckedChanged(object sender, EventArgs e)
        {
            picboxShape.BackgroundImage = Properties.Resources.Triangle;
            lblTriangleB.Visible = !lblTriangleB.Visible;
            lblTriangleH.Visible = !lblTriangleH.Visible;
            txtTriangleB.Visible = !txtTriangleB.Visible;
            txtTriangleH.Visible = !txtTriangleH.Visible;
            clearText();
        }

        private void rdoTrapezoid_CheckedChanged(object sender, EventArgs e)
        {
            picboxShape.BackgroundImage = Properties.Resources.Trapezoid;
            lblTrapezoidA.Visible = !lblTrapezoidA.Visible;
            lblTrapezoidB.Visible = !lblTrapezoidB.Visible;
            lblTrapezoidC.Visible = !lblTrapezoidC.Visible;
            lblTrapezoidD.Visible = !lblTrapezoidD.Visible;
            lblTrapezoidH.Visible = !lblTrapezoidH.Visible;
            txtTrapezoidA.Visible = !txtTrapezoidA.Visible;
            txtTrapezoidB.Visible = !txtTrapezoidB.Visible;
            txtTrapezoidC.Visible = !txtTrapezoidC.Visible;
            txtTrapezoidD.Visible = !txtTrapezoidD.Visible;
            txtTrapezoidH.Visible = !txtTrapezoidH.Visible;
            clearText();


        }

        private void rdoCircle_CheckedChanged(object sender, EventArgs e)
        {
            picboxShape.BackgroundImage = Properties.Resources.Circle;
            lblCircleR.Visible = !lblCircleR.Visible;
            txtCircleR.Visible = !txtCircleR.Visible;
            clearText();
        }

        private void rdoArea_CheckedChanged(object sender, EventArgs e)
        {
            lblArea.Visible = !lblArea.Visible;
            lblAreaAnswer.Visible = !lblAreaAnswer.Visible;
        }

        private void rdoPerimeter_CheckedChanged(object sender, EventArgs e)
        {
            lblPerimeter.Visible = !lblPerimeter.Visible;
            lblPerimeterAnswer.Visible = !lblPerimeterAnswer.Visible;
        }

        private void rdoAreaPerimeter_CheckedChanged(object sender, EventArgs e)
        {
            lblPerimeter.Visible = !lblPerimeter.Visible;
            lblPerimeterAnswer.Visible = !lblPerimeterAnswer.Visible;
            lblArea.Visible = !lblArea.Visible;
            lblAreaAnswer.Visible = !lblAreaAnswer.Visible;
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int modulusMath(int dividend, int divisor)
        {
            //This method returns the remainder of 2 integers divided by one another
            int modulo = dividend % divisor;
            return modulo;
        }

        private int randomGenerator(int bottom, int top)
        {
            //This method generates a random number with a range and returns the value

            Random random = new Random();
            int randomNumber = random.Next(bottom, top);
            return randomNumber;
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            //Click event for modulus.  Takes the user input and performs modulus division using the 
            //modulusMath method, returns an int into a txtbox and returns the focus to the first 
            //modulus division textbox
            int dividend = Convert.ToInt16(txtDividend.Text);
            int divisor = Convert.ToInt16(txtDivisor.Text);

            int modulus = modulusMath(dividend, divisor);

            txtModulo.Text = Convert.ToString(modulus);
            txtDividend.Focus();

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //Click event for the random number generator.  Takes the values from the user input and generates a 
            //random number between them.  Returns an integer and returns the focus to the bottom of the range
            int bottom = Convert.ToInt16(txtRandomBot.Text);
            int top = Convert.ToInt16(txtRandomTop.Text);

            int newRandom = randomGenerator(bottom, top);
            txtRandomNumber.Text = Convert.ToString(newRandom);
            txtRandomBot.Focus();
        }

        public decimal Percentage(decimal a, decimal b)
        {
            //method that calculates the percentage of an initial value
            decimal val1 = a;
            decimal val2 = b;

            decimal ans = (val1 / 100) * val2;
            
            return ans;
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            //Click event for the calculate percentage button
            decimal a = Convert.ToDecimal(txtNum1.Text);
            decimal b = Convert.ToDecimal(txtPercentage.Text);

            decimal answer = Percentage(a, b);

            txtPercentageAns.Text = Convert.ToString(answer);
            txtNum1.Focus();

        }

        private void txtPercentage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
