﻿using System;
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
            lblRectL.Visible = !lblRectL.Visible;
            lblRectW.Visible = !lblRectW.Visible;
            txtRectL.Visible = !txtRectL.Visible;
            txtRectW.Visible = !txtRectW.Visible;
        }

        private void rdoSquare_CheckedChanged(object sender, EventArgs e)
        {
            lblSquareS.Visible = !lblSquareS.Visible;
            txtSquareS.Visible = !txtSquareS.Visible;
        }

        private void grpShape_Enter(object sender, EventArgs e)
        {

        }

        private void rdoParallelogram_CheckedChanged(object sender, EventArgs e)
        {
            
            lblParallelogramA.Visible = !lblParallelogramA.Visible;
            lblParallelogramB.Visible = !lblParallelogramB.Visible;
            lblParallelogramH.Visible = !lblParallelogramH.Visible;
            txtParallelogramA.Visible = !txtParallelogramA.Visible;
            txtParallelogramB.Visible = !txtParallelogramB.Visible;
            txtParallelogramH.Visible = !txtParallelogramH.Visible;  

        }

        private void rdoRhombus_CheckedChanged(object sender, EventArgs e)
        {
            lblRhombusH.Visible = !lblRhombusH.Visible;
            lblRhombusBase.Visible = !lblRhombusBase.Visible;
            txtRhombusB.Visible = !txtRhombusB.Visible;
            txtRhombusH.Visible = !txtRhombusH.Visible;

        }

        private void rdoTriangle_CheckedChanged(object sender, EventArgs e)
        {
            lblTriangleB.Visible = !lblTriangleB.Visible;
            lblTriangleH.Visible = !lblTriangleH.Visible;
            txtTriangleB.Visible = !txtTriangleB.Visible;
            txtTriangleH.Visible = !txtTriangleH.Visible;
        }

        private void rdoTrapezoid_CheckedChanged(object sender, EventArgs e)
        {
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


        }

        private void rdoCircle_CheckedChanged(object sender, EventArgs e)
        {
            lblCircleR.Visible = !lblCircleR.Visible;
            txtCircleR.Visible = !txtCircleR.Visible;
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

        
    }
}
