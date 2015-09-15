namespace CommonGeometryFormulasCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdoArea = new System.Windows.Forms.RadioButton();
            this.rdoPerimeter = new System.Windows.Forms.RadioButton();
            this.rdoAreaPerimeter = new System.Windows.Forms.RadioButton();
            this.grpAP = new System.Windows.Forms.GroupBox();
            this.grpShape = new System.Windows.Forms.GroupBox();
            this.rdoRectangle = new System.Windows.Forms.RadioButton();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.grpAP.SuspendLayout();
            this.grpShape.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoArea
            // 
            this.rdoArea.AutoSize = true;
            this.rdoArea.Location = new System.Drawing.Point(20, 19);
            this.rdoArea.Name = "rdoArea";
            this.rdoArea.Size = new System.Drawing.Size(47, 17);
            this.rdoArea.TabIndex = 0;
            this.rdoArea.TabStop = true;
            this.rdoArea.Text = "Area";
            this.rdoArea.UseVisualStyleBackColor = true;
            // 
            // rdoPerimeter
            // 
            this.rdoPerimeter.AutoSize = true;
            this.rdoPerimeter.Location = new System.Drawing.Point(73, 19);
            this.rdoPerimeter.Name = "rdoPerimeter";
            this.rdoPerimeter.Size = new System.Drawing.Size(69, 17);
            this.rdoPerimeter.TabIndex = 1;
            this.rdoPerimeter.TabStop = true;
            this.rdoPerimeter.Text = "Perimeter";
            this.rdoPerimeter.UseVisualStyleBackColor = true;
            // 
            // rdoAreaPerimeter
            // 
            this.rdoAreaPerimeter.AutoSize = true;
            this.rdoAreaPerimeter.Location = new System.Drawing.Point(148, 19);
            this.rdoAreaPerimeter.Name = "rdoAreaPerimeter";
            this.rdoAreaPerimeter.Size = new System.Drawing.Size(115, 17);
            this.rdoAreaPerimeter.TabIndex = 2;
            this.rdoAreaPerimeter.TabStop = true;
            this.rdoAreaPerimeter.Text = "Area and Perimeter";
            this.rdoAreaPerimeter.UseVisualStyleBackColor = true;
            // 
            // grpAP
            // 
            this.grpAP.Controls.Add(this.rdoAreaPerimeter);
            this.grpAP.Controls.Add(this.rdoArea);
            this.grpAP.Controls.Add(this.rdoPerimeter);
            this.grpAP.Location = new System.Drawing.Point(12, 134);
            this.grpAP.Name = "grpAP";
            this.grpAP.Size = new System.Drawing.Size(287, 48);
            this.grpAP.TabIndex = 3;
            this.grpAP.TabStop = false;
            // 
            // grpShape
            // 
            this.grpShape.Controls.Add(this.rdoRectangle);
            this.grpShape.Location = new System.Drawing.Point(12, 12);
            this.grpShape.Name = "grpShape";
            this.grpShape.Size = new System.Drawing.Size(934, 100);
            this.grpShape.TabIndex = 3;
            this.grpShape.TabStop = false;
            // 
            // rdoRectangle
            // 
            this.rdoRectangle.AutoSize = true;
            this.rdoRectangle.Location = new System.Drawing.Point(20, 30);
            this.rdoRectangle.Name = "rdoRectangle";
            this.rdoRectangle.Size = new System.Drawing.Size(74, 17);
            this.rdoRectangle.TabIndex = 0;
            this.rdoRectangle.TabStop = true;
            this.rdoRectangle.Text = "Rectangle";
            this.rdoRectangle.UseVisualStyleBackColor = true;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(199, 207);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 4;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(12, 207);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 233);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 283);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(157, 290);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(42, 13);
            this.lblAnswer.TabIndex = 8;
            this.lblAnswer.Text = "Answer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 646);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.grpShape);
            this.Controls.Add(this.grpAP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpAP.ResumeLayout(false);
            this.grpAP.PerformLayout();
            this.grpShape.ResumeLayout(false);
            this.grpShape.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoArea;
        private System.Windows.Forms.RadioButton rdoPerimeter;
        private System.Windows.Forms.RadioButton rdoAreaPerimeter;
        private System.Windows.Forms.GroupBox grpAP;
        private System.Windows.Forms.GroupBox grpShape;
        private System.Windows.Forms.RadioButton rdoRectangle;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAnswer;
    }
}

