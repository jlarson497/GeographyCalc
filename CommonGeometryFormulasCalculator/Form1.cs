using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonGeometryFormulasCalculator
{
    public partial class lblRhombusB : Form
    {

        public lblRhombusB()
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

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void rdoRectangle_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRectangle.Checked)
            {
                txtRectL.Visible = true;
                txtRectW.Visible = true;
                lblRectL.Visible = true;
                lblRectW.Visible = true;
            }
            else
            {
                txtRectL.Visible = false;
                txtRectW.Visible = false;
                lblRectL.Visible = false;
                lblRectW.Visible = false;
            }
        }

        private void rdoSquare_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSquare.Checked)
            {
                txtSquareS.Visible = true;
                lblSquareS.Visible = true;
            }
            else
            {
                txtSquareS.Visible = false;
                lblSquareS.Visible = false;
            }
            
        }

        private void grpShape_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
