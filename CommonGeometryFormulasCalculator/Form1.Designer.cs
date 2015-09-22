namespace CommonGeometryFormulasCalculator
{
    partial class lblRhombusB
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
            this.txtCircleR = new System.Windows.Forms.TextBox();
            this.lblCircleR = new System.Windows.Forms.Label();
            this.lblTriangleH = new System.Windows.Forms.Label();
            this.lblTriangleB = new System.Windows.Forms.Label();
            this.txtTriangleH = new System.Windows.Forms.TextBox();
            this.txtTriangleB = new System.Windows.Forms.TextBox();
            this.txtTrapezoidH = new System.Windows.Forms.TextBox();
            this.txtTrapezoidB = new System.Windows.Forms.TextBox();
            this.txtTrapezoidA = new System.Windows.Forms.TextBox();
            this.lblTrapezoidH = new System.Windows.Forms.Label();
            this.lblTrapezoidB = new System.Windows.Forms.Label();
            this.lblTrapezoidA = new System.Windows.Forms.Label();
            this.lblTrapezoidD = new System.Windows.Forms.Label();
            this.lblTrapezoidC = new System.Windows.Forms.Label();
            this.txtTrapezoidD = new System.Windows.Forms.TextBox();
            this.txtTrapezoidC = new System.Windows.Forms.TextBox();
            this.lblRhombusH = new System.Windows.Forms.Label();
            this.lblRhombusBase = new System.Windows.Forms.Label();
            this.txtRhombusH = new System.Windows.Forms.TextBox();
            this.txtRhombusB = new System.Windows.Forms.TextBox();
            this.txtParallelogramH = new System.Windows.Forms.TextBox();
            this.txtParallelogramB = new System.Windows.Forms.TextBox();
            this.txtParallelogramA = new System.Windows.Forms.TextBox();
            this.lblParallelogramH = new System.Windows.Forms.Label();
            this.lblParallelogramB = new System.Windows.Forms.Label();
            this.lblParallelogramA = new System.Windows.Forms.Label();
            this.rdoCircle = new System.Windows.Forms.RadioButton();
            this.rdoTrapezoid = new System.Windows.Forms.RadioButton();
            this.rdoTriangle = new System.Windows.Forms.RadioButton();
            this.rdoRhombus = new System.Windows.Forms.RadioButton();
            this.rdoParallelogram = new System.Windows.Forms.RadioButton();
            this.txtSquareS = new System.Windows.Forms.TextBox();
            this.lblSquareS = new System.Windows.Forms.Label();
            this.lblRectW = new System.Windows.Forms.Label();
            this.rdoSquare = new System.Windows.Forms.RadioButton();
            this.lblRectL = new System.Windows.Forms.Label();
            this.rdoRectangle = new System.Windows.Forms.RadioButton();
            this.txtRectW = new System.Windows.Forms.TextBox();
            this.txtRectL = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeterAnswer = new System.Windows.Forms.Label();
            this.lblAreaAnswer = new System.Windows.Forms.Label();
            this.picboxShape = new System.Windows.Forms.PictureBox();
            this.grpAP.SuspendLayout();
            this.grpShape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxShape)).BeginInit();
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
            this.rdoArea.CheckedChanged += new System.EventHandler(this.rdoArea_CheckedChanged);
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
            this.rdoPerimeter.CheckedChanged += new System.EventHandler(this.rdoPerimeter_CheckedChanged);
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
            this.rdoAreaPerimeter.CheckedChanged += new System.EventHandler(this.rdoAreaPerimeter_CheckedChanged);
            // 
            // grpAP
            // 
            this.grpAP.Controls.Add(this.rdoAreaPerimeter);
            this.grpAP.Controls.Add(this.rdoArea);
            this.grpAP.Controls.Add(this.rdoPerimeter);
            this.grpAP.Location = new System.Drawing.Point(12, 303);
            this.grpAP.Name = "grpAP";
            this.grpAP.Size = new System.Drawing.Size(287, 48);
            this.grpAP.TabIndex = 3;
            this.grpAP.TabStop = false;
            // 
            // grpShape
            // 
            this.grpShape.Controls.Add(this.picboxShape);
            this.grpShape.Controls.Add(this.txtCircleR);
            this.grpShape.Controls.Add(this.lblCircleR);
            this.grpShape.Controls.Add(this.lblTriangleH);
            this.grpShape.Controls.Add(this.lblTriangleB);
            this.grpShape.Controls.Add(this.txtTriangleH);
            this.grpShape.Controls.Add(this.txtTriangleB);
            this.grpShape.Controls.Add(this.txtTrapezoidH);
            this.grpShape.Controls.Add(this.txtTrapezoidB);
            this.grpShape.Controls.Add(this.txtTrapezoidA);
            this.grpShape.Controls.Add(this.lblTrapezoidH);
            this.grpShape.Controls.Add(this.lblTrapezoidB);
            this.grpShape.Controls.Add(this.lblTrapezoidA);
            this.grpShape.Controls.Add(this.lblTrapezoidD);
            this.grpShape.Controls.Add(this.lblTrapezoidC);
            this.grpShape.Controls.Add(this.txtTrapezoidD);
            this.grpShape.Controls.Add(this.txtTrapezoidC);
            this.grpShape.Controls.Add(this.lblRhombusH);
            this.grpShape.Controls.Add(this.lblRhombusBase);
            this.grpShape.Controls.Add(this.txtRhombusH);
            this.grpShape.Controls.Add(this.txtRhombusB);
            this.grpShape.Controls.Add(this.txtParallelogramH);
            this.grpShape.Controls.Add(this.txtParallelogramB);
            this.grpShape.Controls.Add(this.txtParallelogramA);
            this.grpShape.Controls.Add(this.lblParallelogramH);
            this.grpShape.Controls.Add(this.lblParallelogramB);
            this.grpShape.Controls.Add(this.lblParallelogramA);
            this.grpShape.Controls.Add(this.rdoCircle);
            this.grpShape.Controls.Add(this.rdoTrapezoid);
            this.grpShape.Controls.Add(this.rdoTriangle);
            this.grpShape.Controls.Add(this.rdoRhombus);
            this.grpShape.Controls.Add(this.rdoParallelogram);
            this.grpShape.Controls.Add(this.txtSquareS);
            this.grpShape.Controls.Add(this.lblSquareS);
            this.grpShape.Controls.Add(this.lblRectW);
            this.grpShape.Controls.Add(this.rdoSquare);
            this.grpShape.Controls.Add(this.lblRectL);
            this.grpShape.Controls.Add(this.rdoRectangle);
            this.grpShape.Controls.Add(this.txtRectW);
            this.grpShape.Controls.Add(this.txtRectL);
            this.grpShape.Location = new System.Drawing.Point(12, 12);
            this.grpShape.Name = "grpShape";
            this.grpShape.Size = new System.Drawing.Size(598, 288);
            this.grpShape.TabIndex = 3;
            this.grpShape.TabStop = false;
            this.grpShape.Enter += new System.EventHandler(this.grpShape_Enter);
            // 
            // txtCircleR
            // 
            this.txtCircleR.Location = new System.Drawing.Point(551, 50);
            this.txtCircleR.Name = "txtCircleR";
            this.txtCircleR.Size = new System.Drawing.Size(37, 20);
            this.txtCircleR.TabIndex = 50;
            this.txtCircleR.Visible = false;
            // 
            // lblCircleR
            // 
            this.lblCircleR.AutoSize = true;
            this.lblCircleR.Location = new System.Drawing.Point(534, 53);
            this.lblCircleR.Name = "lblCircleR";
            this.lblCircleR.Size = new System.Drawing.Size(16, 13);
            this.lblCircleR.TabIndex = 49;
            this.lblCircleR.Text = "r: ";
            this.lblCircleR.Visible = false;
            // 
            // lblTriangleH
            // 
            this.lblTriangleH.AutoSize = true;
            this.lblTriangleH.Location = new System.Drawing.Point(358, 85);
            this.lblTriangleH.Name = "lblTriangleH";
            this.lblTriangleH.Size = new System.Drawing.Size(19, 13);
            this.lblTriangleH.TabIndex = 48;
            this.lblTriangleH.Text = "h: ";
            this.lblTriangleH.Visible = false;
            // 
            // lblTriangleB
            // 
            this.lblTriangleB.AutoSize = true;
            this.lblTriangleB.Location = new System.Drawing.Point(358, 56);
            this.lblTriangleB.Name = "lblTriangleB";
            this.lblTriangleB.Size = new System.Drawing.Size(19, 13);
            this.lblTriangleB.TabIndex = 47;
            this.lblTriangleB.Text = "b: ";
            this.lblTriangleB.Visible = false;
            // 
            // txtTriangleH
            // 
            this.txtTriangleH.Location = new System.Drawing.Point(383, 89);
            this.txtTriangleH.Name = "txtTriangleH";
            this.txtTriangleH.Size = new System.Drawing.Size(37, 20);
            this.txtTriangleH.TabIndex = 46;
            this.txtTriangleH.Visible = false;
            // 
            // txtTriangleB
            // 
            this.txtTriangleB.Location = new System.Drawing.Point(383, 59);
            this.txtTriangleB.Name = "txtTriangleB";
            this.txtTriangleB.Size = new System.Drawing.Size(37, 20);
            this.txtTriangleB.TabIndex = 45;
            this.txtTriangleB.Visible = false;
            // 
            // txtTrapezoidH
            // 
            this.txtTrapezoidH.Location = new System.Drawing.Point(474, 149);
            this.txtTrapezoidH.Name = "txtTrapezoidH";
            this.txtTrapezoidH.Size = new System.Drawing.Size(37, 20);
            this.txtTrapezoidH.TabIndex = 44;
            this.txtTrapezoidH.Visible = false;
            // 
            // txtTrapezoidB
            // 
            this.txtTrapezoidB.Location = new System.Drawing.Point(474, 76);
            this.txtTrapezoidB.Name = "txtTrapezoidB";
            this.txtTrapezoidB.Size = new System.Drawing.Size(37, 20);
            this.txtTrapezoidB.TabIndex = 43;
            this.txtTrapezoidB.Visible = false;
            // 
            // txtTrapezoidA
            // 
            this.txtTrapezoidA.Location = new System.Drawing.Point(474, 53);
            this.txtTrapezoidA.Name = "txtTrapezoidA";
            this.txtTrapezoidA.Size = new System.Drawing.Size(37, 20);
            this.txtTrapezoidA.TabIndex = 42;
            this.txtTrapezoidA.Visible = false;
            // 
            // lblTrapezoidH
            // 
            this.lblTrapezoidH.AutoSize = true;
            this.lblTrapezoidH.Location = new System.Drawing.Point(449, 152);
            this.lblTrapezoidH.Name = "lblTrapezoidH";
            this.lblTrapezoidH.Size = new System.Drawing.Size(19, 13);
            this.lblTrapezoidH.TabIndex = 41;
            this.lblTrapezoidH.Text = "h: ";
            this.lblTrapezoidH.Visible = false;
            // 
            // lblTrapezoidB
            // 
            this.lblTrapezoidB.AutoSize = true;
            this.lblTrapezoidB.Location = new System.Drawing.Point(449, 82);
            this.lblTrapezoidB.Name = "lblTrapezoidB";
            this.lblTrapezoidB.Size = new System.Drawing.Size(19, 13);
            this.lblTrapezoidB.TabIndex = 40;
            this.lblTrapezoidB.Text = "b: ";
            this.lblTrapezoidB.Visible = false;
            // 
            // lblTrapezoidA
            // 
            this.lblTrapezoidA.AutoSize = true;
            this.lblTrapezoidA.Location = new System.Drawing.Point(449, 57);
            this.lblTrapezoidA.Name = "lblTrapezoidA";
            this.lblTrapezoidA.Size = new System.Drawing.Size(19, 13);
            this.lblTrapezoidA.TabIndex = 39;
            this.lblTrapezoidA.Text = "a: ";
            this.lblTrapezoidA.Visible = false;
            // 
            // lblTrapezoidD
            // 
            this.lblTrapezoidD.AutoSize = true;
            this.lblTrapezoidD.Location = new System.Drawing.Point(449, 129);
            this.lblTrapezoidD.Name = "lblTrapezoidD";
            this.lblTrapezoidD.Size = new System.Drawing.Size(19, 13);
            this.lblTrapezoidD.TabIndex = 38;
            this.lblTrapezoidD.Text = "d: ";
            this.lblTrapezoidD.Visible = false;
            // 
            // lblTrapezoidC
            // 
            this.lblTrapezoidC.AutoSize = true;
            this.lblTrapezoidC.Location = new System.Drawing.Point(449, 105);
            this.lblTrapezoidC.Name = "lblTrapezoidC";
            this.lblTrapezoidC.Size = new System.Drawing.Size(19, 13);
            this.lblTrapezoidC.TabIndex = 37;
            this.lblTrapezoidC.Text = "c: ";
            this.lblTrapezoidC.Visible = false;
            // 
            // txtTrapezoidD
            // 
            this.txtTrapezoidD.Location = new System.Drawing.Point(474, 126);
            this.txtTrapezoidD.Name = "txtTrapezoidD";
            this.txtTrapezoidD.Size = new System.Drawing.Size(37, 20);
            this.txtTrapezoidD.TabIndex = 36;
            this.txtTrapezoidD.Visible = false;
            // 
            // txtTrapezoidC
            // 
            this.txtTrapezoidC.Location = new System.Drawing.Point(474, 102);
            this.txtTrapezoidC.Name = "txtTrapezoidC";
            this.txtTrapezoidC.Size = new System.Drawing.Size(37, 20);
            this.txtTrapezoidC.TabIndex = 35;
            this.txtTrapezoidC.Visible = false;
            // 
            // lblRhombusH
            // 
            this.lblRhombusH.AutoSize = true;
            this.lblRhombusH.Location = new System.Drawing.Point(270, 79);
            this.lblRhombusH.Name = "lblRhombusH";
            this.lblRhombusH.Size = new System.Drawing.Size(19, 13);
            this.lblRhombusH.TabIndex = 32;
            this.lblRhombusH.Text = "h: ";
            this.lblRhombusH.Visible = false;
            // 
            // lblRhombusBase
            // 
            this.lblRhombusBase.AutoSize = true;
            this.lblRhombusBase.Location = new System.Drawing.Point(270, 50);
            this.lblRhombusBase.Name = "lblRhombusBase";
            this.lblRhombusBase.Size = new System.Drawing.Size(19, 13);
            this.lblRhombusBase.TabIndex = 31;
            this.lblRhombusBase.Text = "b: ";
            this.lblRhombusBase.Visible = false;
            // 
            // txtRhombusH
            // 
            this.txtRhombusH.Location = new System.Drawing.Point(295, 83);
            this.txtRhombusH.Name = "txtRhombusH";
            this.txtRhombusH.Size = new System.Drawing.Size(37, 20);
            this.txtRhombusH.TabIndex = 30;
            this.txtRhombusH.Visible = false;
            // 
            // txtRhombusB
            // 
            this.txtRhombusB.Location = new System.Drawing.Point(295, 53);
            this.txtRhombusB.Name = "txtRhombusB";
            this.txtRhombusB.Size = new System.Drawing.Size(37, 20);
            this.txtRhombusB.TabIndex = 29;
            this.txtRhombusB.Visible = false;
            // 
            // txtParallelogramH
            // 
            this.txtParallelogramH.Location = new System.Drawing.Point(197, 102);
            this.txtParallelogramH.Name = "txtParallelogramH";
            this.txtParallelogramH.Size = new System.Drawing.Size(37, 20);
            this.txtParallelogramH.TabIndex = 28;
            this.txtParallelogramH.Visible = false;
            // 
            // txtParallelogramB
            // 
            this.txtParallelogramB.Location = new System.Drawing.Point(197, 76);
            this.txtParallelogramB.Name = "txtParallelogramB";
            this.txtParallelogramB.Size = new System.Drawing.Size(37, 20);
            this.txtParallelogramB.TabIndex = 27;
            this.txtParallelogramB.Visible = false;
            // 
            // txtParallelogramA
            // 
            this.txtParallelogramA.Location = new System.Drawing.Point(197, 52);
            this.txtParallelogramA.Name = "txtParallelogramA";
            this.txtParallelogramA.Size = new System.Drawing.Size(37, 20);
            this.txtParallelogramA.TabIndex = 26;
            this.txtParallelogramA.Visible = false;
            // 
            // lblParallelogramH
            // 
            this.lblParallelogramH.AutoSize = true;
            this.lblParallelogramH.Location = new System.Drawing.Point(172, 105);
            this.lblParallelogramH.Name = "lblParallelogramH";
            this.lblParallelogramH.Size = new System.Drawing.Size(19, 13);
            this.lblParallelogramH.TabIndex = 25;
            this.lblParallelogramH.Text = "h: ";
            this.lblParallelogramH.Visible = false;
            // 
            // lblParallelogramB
            // 
            this.lblParallelogramB.AutoSize = true;
            this.lblParallelogramB.Location = new System.Drawing.Point(172, 79);
            this.lblParallelogramB.Name = "lblParallelogramB";
            this.lblParallelogramB.Size = new System.Drawing.Size(19, 13);
            this.lblParallelogramB.TabIndex = 24;
            this.lblParallelogramB.Text = "b: ";
            this.lblParallelogramB.Visible = false;
            // 
            // lblParallelogramA
            // 
            this.lblParallelogramA.AutoSize = true;
            this.lblParallelogramA.Location = new System.Drawing.Point(172, 55);
            this.lblParallelogramA.Name = "lblParallelogramA";
            this.lblParallelogramA.Size = new System.Drawing.Size(19, 13);
            this.lblParallelogramA.TabIndex = 23;
            this.lblParallelogramA.Text = "a: ";
            this.lblParallelogramA.Visible = false;
            // 
            // rdoCircle
            // 
            this.rdoCircle.AutoSize = true;
            this.rdoCircle.Location = new System.Drawing.Point(537, 30);
            this.rdoCircle.Name = "rdoCircle";
            this.rdoCircle.Size = new System.Drawing.Size(51, 17);
            this.rdoCircle.TabIndex = 22;
            this.rdoCircle.TabStop = true;
            this.rdoCircle.Text = "Circle";
            this.rdoCircle.UseVisualStyleBackColor = true;
            this.rdoCircle.CheckedChanged += new System.EventHandler(this.rdoCircle_CheckedChanged);
            // 
            // rdoTrapezoid
            // 
            this.rdoTrapezoid.AutoSize = true;
            this.rdoTrapezoid.Location = new System.Drawing.Point(448, 30);
            this.rdoTrapezoid.Name = "rdoTrapezoid";
            this.rdoTrapezoid.Size = new System.Drawing.Size(72, 17);
            this.rdoTrapezoid.TabIndex = 21;
            this.rdoTrapezoid.TabStop = true;
            this.rdoTrapezoid.Text = "Trapezoid";
            this.rdoTrapezoid.UseVisualStyleBackColor = true;
            this.rdoTrapezoid.CheckedChanged += new System.EventHandler(this.rdoTrapezoid_CheckedChanged);
            // 
            // rdoTriangle
            // 
            this.rdoTriangle.AutoSize = true;
            this.rdoTriangle.Location = new System.Drawing.Point(361, 30);
            this.rdoTriangle.Name = "rdoTriangle";
            this.rdoTriangle.Size = new System.Drawing.Size(63, 17);
            this.rdoTriangle.TabIndex = 20;
            this.rdoTriangle.TabStop = true;
            this.rdoTriangle.Text = "Triangle";
            this.rdoTriangle.UseVisualStyleBackColor = true;
            this.rdoTriangle.CheckedChanged += new System.EventHandler(this.rdoTriangle_CheckedChanged);
            // 
            // rdoRhombus
            // 
            this.rdoRhombus.AutoSize = true;
            this.rdoRhombus.Location = new System.Drawing.Point(273, 30);
            this.rdoRhombus.Name = "rdoRhombus";
            this.rdoRhombus.Size = new System.Drawing.Size(70, 17);
            this.rdoRhombus.TabIndex = 19;
            this.rdoRhombus.TabStop = true;
            this.rdoRhombus.Text = "Rhombus";
            this.rdoRhombus.UseVisualStyleBackColor = true;
            this.rdoRhombus.CheckedChanged += new System.EventHandler(this.rdoRhombus_CheckedChanged);
            // 
            // rdoParallelogram
            // 
            this.rdoParallelogram.AutoSize = true;
            this.rdoParallelogram.Location = new System.Drawing.Point(175, 30);
            this.rdoParallelogram.Name = "rdoParallelogram";
            this.rdoParallelogram.Size = new System.Drawing.Size(88, 17);
            this.rdoParallelogram.TabIndex = 18;
            this.rdoParallelogram.TabStop = true;
            this.rdoParallelogram.Text = "Parallelogram";
            this.rdoParallelogram.UseVisualStyleBackColor = true;
            this.rdoParallelogram.CheckedChanged += new System.EventHandler(this.rdoParallelogram_CheckedChanged);
            // 
            // txtSquareS
            // 
            this.txtSquareS.Location = new System.Drawing.Point(121, 52);
            this.txtSquareS.Name = "txtSquareS";
            this.txtSquareS.Size = new System.Drawing.Size(37, 20);
            this.txtSquareS.TabIndex = 17;
            this.txtSquareS.Visible = false;
            // 
            // lblSquareS
            // 
            this.lblSquareS.AutoSize = true;
            this.lblSquareS.Location = new System.Drawing.Point(97, 55);
            this.lblSquareS.Name = "lblSquareS";
            this.lblSquareS.Size = new System.Drawing.Size(18, 13);
            this.lblSquareS.TabIndex = 16;
            this.lblSquareS.Text = "s: ";
            this.lblSquareS.Visible = false;
            // 
            // lblRectW
            // 
            this.lblRectW.AutoSize = true;
            this.lblRectW.Location = new System.Drawing.Point(17, 78);
            this.lblRectW.Name = "lblRectW";
            this.lblRectW.Size = new System.Drawing.Size(21, 13);
            this.lblRectW.TabIndex = 15;
            this.lblRectW.Text = "w: ";
            this.lblRectW.Visible = false;
            // 
            // rdoSquare
            // 
            this.rdoSquare.AutoSize = true;
            this.rdoSquare.Location = new System.Drawing.Point(100, 30);
            this.rdoSquare.Name = "rdoSquare";
            this.rdoSquare.Size = new System.Drawing.Size(59, 17);
            this.rdoSquare.TabIndex = 1;
            this.rdoSquare.TabStop = true;
            this.rdoSquare.Text = "Square";
            this.rdoSquare.UseVisualStyleBackColor = true;
            this.rdoSquare.CheckedChanged += new System.EventHandler(this.rdoSquare_CheckedChanged);
            // 
            // lblRectL
            // 
            this.lblRectL.AutoSize = true;
            this.lblRectL.Location = new System.Drawing.Point(17, 55);
            this.lblRectL.Name = "lblRectL";
            this.lblRectL.Size = new System.Drawing.Size(15, 13);
            this.lblRectL.TabIndex = 14;
            this.lblRectL.Text = "l: ";
            this.lblRectL.Visible = false;
            this.lblRectL.Click += new System.EventHandler(this.label1_Click);
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
            this.rdoRectangle.CheckedChanged += new System.EventHandler(this.rdoRectangle_CheckedChanged);
            // 
            // txtRectW
            // 
            this.txtRectW.Location = new System.Drawing.Point(38, 75);
            this.txtRectW.Name = "txtRectW";
            this.txtRectW.Size = new System.Drawing.Size(37, 20);
            this.txtRectW.TabIndex = 13;
            this.txtRectW.Visible = false;
            // 
            // txtRectL
            // 
            this.txtRectL.Location = new System.Drawing.Point(38, 52);
            this.txtRectL.Name = "txtRectL";
            this.txtRectL.Size = new System.Drawing.Size(37, 20);
            this.txtRectL.TabIndex = 12;
            this.txtRectL.Visible = false;
            this.txtRectL.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(160, 383);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(269, 383);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Clea&r";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(305, 312);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(57, 13);
            this.lblPerimeter.TabIndex = 7;
            this.lblPerimeter.Text = "Perimeter: ";
            this.lblPerimeter.Visible = false;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(327, 340);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(35, 13);
            this.lblArea.TabIndex = 8;
            this.lblArea.Text = "Area: ";
            this.lblArea.Visible = false;
            // 
            // lblPerimeterAnswer
            // 
            this.lblPerimeterAnswer.AutoSize = true;
            this.lblPerimeterAnswer.Location = new System.Drawing.Point(369, 312);
            this.lblPerimeterAnswer.Name = "lblPerimeterAnswer";
            this.lblPerimeterAnswer.Size = new System.Drawing.Size(79, 13);
            this.lblPerimeterAnswer.TabIndex = 9;
            this.lblPerimeterAnswer.Text = "                        ";
            this.lblPerimeterAnswer.Visible = false;
            // 
            // lblAreaAnswer
            // 
            this.lblAreaAnswer.AutoSize = true;
            this.lblAreaAnswer.Location = new System.Drawing.Point(369, 340);
            this.lblAreaAnswer.Name = "lblAreaAnswer";
            this.lblAreaAnswer.Size = new System.Drawing.Size(61, 13);
            this.lblAreaAnswer.TabIndex = 10;
            this.lblAreaAnswer.Text = "                  ";
            this.lblAreaAnswer.Visible = false;
            // 
            // picboxShape
            // 
            this.picboxShape.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picboxShape.Location = new System.Drawing.Point(20, 126);
            this.picboxShape.Name = "picboxShape";
            this.picboxShape.Size = new System.Drawing.Size(312, 156);
            this.picboxShape.TabIndex = 51;
            this.picboxShape.TabStop = false;
            // 
            // lblRhombusB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 646);
            this.Controls.Add(this.lblAreaAnswer);
            this.Controls.Add(this.lblPerimeterAnswer);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpShape);
            this.Controls.Add(this.grpAP);
            this.Name = "lblRhombusB";
            this.Text = "b: ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAP.ResumeLayout(false);
            this.grpAP.PerformLayout();
            this.grpShape.ResumeLayout(false);
            this.grpShape.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxShape)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeterAnswer;
        private System.Windows.Forms.Label lblAreaAnswer;
        private System.Windows.Forms.TextBox txtRectL;
        private System.Windows.Forms.TextBox txtRectW;
        private System.Windows.Forms.Label lblRectL;
        private System.Windows.Forms.Label lblRectW;
        private System.Windows.Forms.TextBox txtSquareS;
        private System.Windows.Forms.Label lblSquareS;
        private System.Windows.Forms.RadioButton rdoSquare;
        private System.Windows.Forms.RadioButton rdoRhombus;
        private System.Windows.Forms.RadioButton rdoParallelogram;
        private System.Windows.Forms.Label lblParallelogramH;
        private System.Windows.Forms.Label lblParallelogramB;
        private System.Windows.Forms.Label lblParallelogramA;
        private System.Windows.Forms.RadioButton rdoCircle;
        private System.Windows.Forms.RadioButton rdoTrapezoid;
        private System.Windows.Forms.RadioButton rdoTriangle;
        private System.Windows.Forms.Label lblRhombusH;
        private System.Windows.Forms.Label lblRhombusBase;
        private System.Windows.Forms.TextBox txtRhombusH;
        private System.Windows.Forms.TextBox txtRhombusB;
        private System.Windows.Forms.TextBox txtParallelogramH;
        private System.Windows.Forms.TextBox txtParallelogramB;
        private System.Windows.Forms.TextBox txtParallelogramA;
        private System.Windows.Forms.TextBox txtTrapezoidH;
        private System.Windows.Forms.TextBox txtTrapezoidB;
        private System.Windows.Forms.TextBox txtTrapezoidA;
        private System.Windows.Forms.Label lblTrapezoidH;
        private System.Windows.Forms.Label lblTrapezoidB;
        private System.Windows.Forms.Label lblTrapezoidA;
        private System.Windows.Forms.Label lblTrapezoidD;
        private System.Windows.Forms.Label lblTrapezoidC;
        private System.Windows.Forms.TextBox txtTrapezoidD;
        private System.Windows.Forms.TextBox txtTrapezoidC;
        private System.Windows.Forms.TextBox txtCircleR;
        private System.Windows.Forms.Label lblCircleR;
        private System.Windows.Forms.Label lblTriangleH;
        private System.Windows.Forms.Label lblTriangleB;
        private System.Windows.Forms.TextBox txtTriangleH;
        private System.Windows.Forms.TextBox txtTriangleB;
        private System.Windows.Forms.PictureBox picboxShape;
    }
}

