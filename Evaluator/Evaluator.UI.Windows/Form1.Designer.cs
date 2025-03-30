namespace Evaluator.UI.Windows
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textDisplay = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnPow = new Button();
            btnOpenParenthesis = new Button();
            btnMinus = new Button();
            btnDivede = new Button();
            btnPlus = new Button();
            btnMultiplu = new Button();
            btnCloseParenthesis = new Button();
            btnResult = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // textDisplay
            // 
            textDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textDisplay.BackColor = Color.FromArgb(0, 192, 0);
            textDisplay.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textDisplay.Location = new Point(12, 12);
            textDisplay.Name = "textDisplay";
            textDisplay.Size = new Size(541, 39);
            textDisplay.TabIndex = 0;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.Location = new Point(12, 74);
            btn7.Name = "btn7";
            btn7.Size = new Size(71, 55);
            btn7.TabIndex = 1;
            btn7.Text = "7\r\n";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.Location = new Point(112, 74);
            btn8.Name = "btn8";
            btn8.Size = new Size(71, 55);
            btn8.TabIndex = 2;
            btn8.Text = "8\r\n";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.Location = new Point(210, 74);
            btn9.Name = "btn9";
            btn9.Size = new Size(71, 55);
            btn9.TabIndex = 3;
            btn9.Text = "9\r\n";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.Location = new Point(12, 144);
            btn4.Name = "btn4";
            btn4.Size = new Size(71, 55);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.Location = new Point(112, 144);
            btn5.Name = "btn5";
            btn5.Size = new Size(71, 55);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.Location = new Point(210, 144);
            btn6.Name = "btn6";
            btn6.Size = new Size(71, 55);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.Location = new Point(210, 205);
            btn3.Name = "btn3";
            btn3.Size = new Size(71, 55);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.Location = new Point(112, 205);
            btn2.Name = "btn2";
            btn2.Size = new Size(71, 55);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(12, 205);
            btn1.Name = "btn1";
            btn1.Size = new Size(71, 55);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn0.Location = new Point(12, 266);
            btn0.Name = "btn0";
            btn0.Size = new Size(171, 55);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDot.Location = new Point(210, 266);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(71, 55);
            btnDot.TabIndex = 11;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btnPow
            // 
            btnPow.BackColor = Color.FromArgb(255, 128, 0);
            btnPow.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPow.Location = new Point(455, 205);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(98, 55);
            btnPow.TabIndex = 15;
            btnPow.Text = "^";
            btnPow.UseVisualStyleBackColor = false;
            btnPow.Click += btnPow_Click;
            // 
            // btnOpenParenthesis
            // 
            btnOpenParenthesis.BackColor = Color.FromArgb(255, 128, 0);
            btnOpenParenthesis.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpenParenthesis.Location = new Point(301, 205);
            btnOpenParenthesis.Name = "btnOpenParenthesis";
            btnOpenParenthesis.Size = new Size(71, 55);
            btnOpenParenthesis.TabIndex = 14;
            btnOpenParenthesis.Text = "(";
            btnOpenParenthesis.UseVisualStyleBackColor = false;
            btnOpenParenthesis.Click += btnOpenParenthesis_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.FromArgb(255, 128, 0);
            btnMinus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(301, 144);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(71, 55);
            btnMinus.TabIndex = 13;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnDivede
            // 
            btnDivede.BackColor = Color.FromArgb(255, 128, 0);
            btnDivede.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivede.Location = new Point(301, 74);
            btnDivede.Name = "btnDivede";
            btnDivede.Size = new Size(71, 55);
            btnDivede.TabIndex = 12;
            btnDivede.Text = "/";
            btnDivede.UseVisualStyleBackColor = false;
            btnDivede.Click += btnDivede_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.FromArgb(255, 128, 0);
            btnPlus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(378, 144);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(71, 55);
            btnPlus.TabIndex = 17;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMultiplu
            // 
            btnMultiplu.BackColor = Color.FromArgb(255, 128, 0);
            btnMultiplu.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiplu.Location = new Point(378, 74);
            btnMultiplu.Name = "btnMultiplu";
            btnMultiplu.Size = new Size(71, 55);
            btnMultiplu.TabIndex = 16;
            btnMultiplu.Text = "*";
            btnMultiplu.UseVisualStyleBackColor = false;
            btnMultiplu.Click += button17_Click;
            // 
            // btnCloseParenthesis
            // 
            btnCloseParenthesis.BackColor = Color.FromArgb(255, 128, 0);
            btnCloseParenthesis.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCloseParenthesis.Location = new Point(378, 205);
            btnCloseParenthesis.Name = "btnCloseParenthesis";
            btnCloseParenthesis.Size = new Size(71, 55);
            btnCloseParenthesis.TabIndex = 18;
            btnCloseParenthesis.Text = ")";
            btnCloseParenthesis.UseVisualStyleBackColor = false;
            btnCloseParenthesis.Click += btnCloseParenthesis_Click;
            // 
            // btnResult
            // 
            btnResult.BackColor = Color.FromArgb(255, 128, 0);
            btnResult.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResult.Location = new Point(301, 266);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(252, 55);
            btnResult.TabIndex = 19;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += btnResult_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 128, 0);
            btnClear.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(455, 144);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(98, 55);
            btnClear.TabIndex = 21;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 0);
            btnDelete.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(455, 74);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 55);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 375);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnResult);
            Controls.Add(btnCloseParenthesis);
            Controls.Add(btnPlus);
            Controls.Add(btnMultiplu);
            Controls.Add(btnPow);
            Controls.Add(btnOpenParenthesis);
            Controls.Add(btnMinus);
            Controls.Add(btnDivede);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(textDisplay);
            Name = "Form1";
            Text = "funcion_evaluator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textDisplay;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btn0;
        private Button btnDot;
        private Button btnPow;
        private Button btnOpenParenthesis;
        private Button btnMinus;
        private Button btnDivede;
        private Button btnPlus;
        private Button btnMultiplu;
        private Button btnCloseParenthesis;
        private Button btnResult;
        private Button btnClear;
        private Button btnDelete;
    }
}
