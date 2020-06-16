namespace AssignmentTwo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtHistory = new System.Windows.Forms.RichTextBox();
            this.btnBksp = new System.Windows.Forms.Button();
            this.showOpLabel = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnLn = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnAbs = new System.Windows.Forms.Button();
            this.btnFac = new System.Windows.Forms.Button();
            this.btnNX = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnMemRe = new System.Windows.Forms.Button();
            this.btnMemAdd = new System.Windows.Forms.Button();
            this.btnMemClr = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btn1x = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.hiddenLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHistory
            // 
            this.txtHistory.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtHistory.Location = new System.Drawing.Point(18, 12);
            this.txtHistory.Name = "txtHistory";
            this.txtHistory.ReadOnly = true;
            this.txtHistory.Size = new System.Drawing.Size(349, 133);
            this.txtHistory.TabIndex = 73;
            this.txtHistory.TabStop = false;
            this.txtHistory.Text = "";
            this.txtHistory.Click += new System.EventHandler(this.TxtHistory_Click);
            // 
            // btnBksp
            // 
            this.btnBksp.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBksp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBksp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBksp.Location = new System.Drawing.Point(315, 256);
            this.btnBksp.Name = "btnBksp";
            this.btnBksp.Size = new System.Drawing.Size(52, 52);
            this.btnBksp.TabIndex = 72;
            this.btnBksp.TabStop = false;
            this.btnBksp.Text = "Bksp";
            this.btnBksp.UseVisualStyleBackColor = false;
            this.btnBksp.Click += new System.EventHandler(this.BackSpaceBtn_Click);
            // 
            // showOpLabel
            // 
            this.showOpLabel.AutoSize = true;
            this.showOpLabel.BackColor = System.Drawing.Color.Transparent;
            this.showOpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showOpLabel.Location = new System.Drawing.Point(189, 162);
            this.showOpLabel.Name = "showOpLabel";
            this.showOpLabel.Size = new System.Drawing.Size(0, 16);
            this.showOpLabel.TabIndex = 71;
            this.showOpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(17, 200);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(352, 48);
            this.txtResult.TabIndex = 70;
            this.txtResult.TabStop = false;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnLn
            // 
            this.btnLn.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLn.Location = new System.Drawing.Point(315, 493);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(52, 52);
            this.btnLn.TabIndex = 69;
            this.btnLn.TabStop = false;
            this.btnLn.Text = "ln";
            this.btnLn.UseVisualStyleBackColor = false;
            this.btnLn.Click += new System.EventHandler(this.OperatorBtn_Click);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(315, 433);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(52, 52);
            this.btnLog.TabIndex = 68;
            this.btnLog.TabStop = false;
            this.btnLog.Text = "log";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.OperatorBtn_Click);
            // 
            // btnAbs
            // 
            this.btnAbs.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAbs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbs.Location = new System.Drawing.Point(255, 314);
            this.btnAbs.Name = "btnAbs";
            this.btnAbs.Size = new System.Drawing.Size(52, 52);
            this.btnAbs.TabIndex = 67;
            this.btnAbs.TabStop = false;
            this.btnAbs.Text = "|n|";
            this.btnAbs.UseVisualStyleBackColor = false;
            this.btnAbs.Click += new System.EventHandler(this.OperatorBtn_Click);
            // 
            // btnFac
            // 
            this.btnFac.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFac.Location = new System.Drawing.Point(255, 374);
            this.btnFac.Name = "btnFac";
            this.btnFac.Size = new System.Drawing.Size(52, 52);
            this.btnFac.TabIndex = 66;
            this.btnFac.TabStop = false;
            this.btnFac.Text = "n!";
            this.btnFac.UseVisualStyleBackColor = false;
            this.btnFac.Click += new System.EventHandler(this.OperatorBtn_Click);
            // 
            // btnNX
            // 
            this.btnNX.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNX.Location = new System.Drawing.Point(315, 315);
            this.btnNX.Name = "btnNX";
            this.btnNX.Size = new System.Drawing.Size(52, 52);
            this.btnNX.TabIndex = 65;
            this.btnNX.TabStop = false;
            this.btnNX.Text = "n^x";
            this.btnNX.UseVisualStyleBackColor = false;
            this.btnNX.Click += new System.EventHandler(this.OperatorBtn_Click);
            // 
            // btnExp
            // 
            this.btnExp.BackColor = System.Drawing.Color.SteelBlue;
            this.btnExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExp.Location = new System.Drawing.Point(255, 433);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(52, 52);
            this.btnExp.TabIndex = 64;
            this.btnExp.TabStop = false;
            this.btnExp.Text = "exp";
            this.btnExp.UseVisualStyleBackColor = false;
            this.btnExp.Click += new System.EventHandler(this.OperatorBtn_Click);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.Location = new System.Drawing.Point(196, 256);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(52, 52);
            this.btnMod.TabIndex = 0;
            this.btnMod.TabStop = false;
            this.btnMod.Text = "MOD";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.OperatorBtn_Click);
            // 
            // btnMemRe
            // 
            this.btnMemRe.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMemRe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemRe.Location = new System.Drawing.Point(136, 255);
            this.btnMemRe.Name = "btnMemRe";
            this.btnMemRe.Size = new System.Drawing.Size(52, 52);
            this.btnMemRe.TabIndex = 0;
            this.btnMemRe.TabStop = false;
            this.btnMemRe.Text = "MR";
            this.btnMemRe.UseVisualStyleBackColor = false;
            this.btnMemRe.Click += new System.EventHandler(this.BtnMem_Click);
            // 
            // btnMemAdd
            // 
            this.btnMemAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMemAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemAdd.Location = new System.Drawing.Point(77, 255);
            this.btnMemAdd.Name = "btnMemAdd";
            this.btnMemAdd.Size = new System.Drawing.Size(52, 52);
            this.btnMemAdd.TabIndex = 0;
            this.btnMemAdd.TabStop = false;
            this.btnMemAdd.Text = "M+";
            this.btnMemAdd.UseVisualStyleBackColor = false;
            this.btnMemAdd.Click += new System.EventHandler(this.BtnMem_Click);
            // 
            // btnMemClr
            // 
            this.btnMemClr.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMemClr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemClr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemClr.Location = new System.Drawing.Point(17, 255);
            this.btnMemClr.Name = "btnMemClr";
            this.btnMemClr.Size = new System.Drawing.Size(52, 52);
            this.btnMemClr.TabIndex = 0;
            this.btnMemClr.TabStop = false;
            this.btnMemClr.Text = "MC";
            this.btnMemClr.UseVisualStyleBackColor = false;
            this.btnMemClr.Click += new System.EventHandler(this.BtnMem_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(255, 256);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(52, 52);
            this.btnClear.TabIndex = 59;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrt.Location = new System.Drawing.Point(315, 375);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(52, 52);
            this.btnSqrt.TabIndex = 58;
            this.btnSqrt.TabStop = false;
            this.btnSqrt.Text = "√";
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Click += new System.EventHandler(this.OperatorBtn_Click);
            // 
            // btn1x
            // 
            this.btn1x.BackColor = System.Drawing.Color.SteelBlue;
            this.btn1x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1x.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1x.Location = new System.Drawing.Point(255, 492);
            this.btn1x.Name = "btn1x";
            this.btn1x.Size = new System.Drawing.Size(52, 52);
            this.btn1x.TabIndex = 57;
            this.btn1x.TabStop = false;
            this.btn1x.Text = "1/x";
            this.btn1x.UseVisualStyleBackColor = false;
            this.btn1x.Click += new System.EventHandler(this.OperatorBtn_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(196, 374);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(52, 52);
            this.btnMultiply.TabIndex = 56;
            this.btnMultiply.TabStop = false;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.OperatorBtn_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(196, 315);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(52, 52);
            this.btnDivide.TabIndex = 55;
            this.btnDivide.TabStop = false;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.OperatorBtn_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.Location = new System.Drawing.Point(77, 492);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(52, 52);
            this.btnDecimal.TabIndex = 54;
            this.btnDecimal.TabStop = false;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = false;
            this.btnDecimal.Click += new System.EventHandler(this.Numbers_Only);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(17, 492);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(52, 52);
            this.btn0.TabIndex = 53;
            this.btn0.TabStop = false;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.Numbers_Only);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.Khaki;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(136, 492);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(52, 52);
            this.btnEqual.TabIndex = 52;
            this.btnEqual.TabStop = false;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.BtnEqual_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(136, 433);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(52, 52);
            this.btn3.TabIndex = 51;
            this.btn3.TabStop = false;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.Numbers_Only);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(77, 433);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(52, 52);
            this.btn2.TabIndex = 50;
            this.btn2.TabStop = false;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.Numbers_Only);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(17, 433);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(52, 52);
            this.btn1.TabIndex = 49;
            this.btn1.TabStop = false;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.Numbers_Only);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(196, 492);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(52, 52);
            this.btnAdd.TabIndex = 48;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.OperatorBtn_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(136, 374);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(52, 52);
            this.btn6.TabIndex = 47;
            this.btn6.TabStop = false;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.Numbers_Only);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(77, 374);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(52, 52);
            this.btn5.TabIndex = 46;
            this.btn5.TabStop = false;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.Numbers_Only);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(17, 374);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(52, 52);
            this.btn4.TabIndex = 45;
            this.btn4.TabStop = false;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.Numbers_Only);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(196, 433);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(52, 52);
            this.btnMinus.TabIndex = 44;
            this.btnMinus.TabStop = false;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.OperatorBtn_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(136, 315);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(52, 52);
            this.btn9.TabIndex = 43;
            this.btn9.TabStop = false;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.Numbers_Only);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(77, 315);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(52, 52);
            this.btn8.TabIndex = 42;
            this.btn8.TabStop = false;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.Numbers_Only);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(17, 315);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(52, 52);
            this.btn7.TabIndex = 41;
            this.btn7.TabStop = false;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.Numbers_Only);
            // 
            // hiddenLabel
            // 
            this.hiddenLabel.AutoSize = true;
            this.hiddenLabel.Location = new System.Drawing.Point(278, 121);
            this.hiddenLabel.Name = "hiddenLabel";
            this.hiddenLabel.Size = new System.Drawing.Size(76, 15);
            this.hiddenLabel.TabIndex = 74;
            this.hiddenLabel.Text = "hiddenLabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(388, 556);
            this.Controls.Add(this.txtHistory);
            this.Controls.Add(this.btnBksp);
            this.Controls.Add(this.showOpLabel);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnLn);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnAbs);
            this.Controls.Add(this.btnFac);
            this.Controls.Add(this.btnNX);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnMemRe);
            this.Controls.Add(this.btnMemAdd);
            this.Controls.Add(this.btnMemClr);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btn1x);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.hiddenLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtHistory;
        private System.Windows.Forms.Button btnBksp;
        private System.Windows.Forms.Label showOpLabel;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnLn;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnAbs;
        private System.Windows.Forms.Button btnFac;
        private System.Windows.Forms.Button btnNX;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnMemRe;
        private System.Windows.Forms.Button btnMemAdd;
        private System.Windows.Forms.Button btnMemClr;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btn1x;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Label hiddenLabel;
    }
}

