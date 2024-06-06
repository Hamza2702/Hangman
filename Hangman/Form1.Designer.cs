namespace Hangman
{
    partial class Hangman
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.hangMan5 = new System.Windows.Forms.Label();
            this.hangMan4 = new System.Windows.Forms.Label();
            this.hangMan3 = new System.Windows.Forms.Label();
            this.hangMan2 = new System.Windows.Forms.Label();
            this.hangMan1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGuesses = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHangman = new System.Windows.Forms.Label();
            this.txtboxGuess = new System.Windows.Forms.TextBox();
            this.hangMan6 = new System.Windows.Forms.Label();
            this.hangMan7 = new System.Windows.Forms.Label();
            this.hangMan8 = new System.Windows.Forms.Label();
            this.hangMan9 = new System.Windows.Forms.Label();
            this.hangMan11 = new System.Windows.Forms.Label();
            this.hangMan10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(357, 431);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(141, 54);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hangMan10);
            this.groupBox1.Controls.Add(this.hangMan11);
            this.groupBox1.Controls.Add(this.hangMan9);
            this.groupBox1.Controls.Add(this.hangMan8);
            this.groupBox1.Controls.Add(this.hangMan7);
            this.groupBox1.Controls.Add(this.hangMan6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.hangMan5);
            this.groupBox1.Controls.Add(this.hangMan4);
            this.groupBox1.Controls.Add(this.hangMan3);
            this.groupBox1.Controls.Add(this.hangMan2);
            this.groupBox1.Controls.Add(this.hangMan1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblGuesses);
            this.groupBox1.Controls.Add(this.lblWord);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblHangman);
            this.groupBox1.Controls.Add(this.txtboxGuess);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 507);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(295, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 48);
            this.label7.TabIndex = 12;
            // 
            // hangMan5
            // 
            this.hangMan5.AutoSize = true;
            this.hangMan5.BackColor = System.Drawing.Color.Transparent;
            this.hangMan5.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hangMan5.Location = new System.Drawing.Point(328, 158);
            this.hangMan5.Name = "hangMan5";
            this.hangMan5.Size = new System.Drawing.Size(41, 48);
            this.hangMan5.TabIndex = 11;
            this.hangMan5.Text = "_";
            // 
            // hangMan4
            // 
            this.hangMan4.AutoSize = true;
            this.hangMan4.BackColor = System.Drawing.Color.Transparent;
            this.hangMan4.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hangMan4.Location = new System.Drawing.Point(362, 185);
            this.hangMan4.Name = "hangMan4";
            this.hangMan4.Size = new System.Drawing.Size(28, 48);
            this.hangMan4.TabIndex = 10;
            this.hangMan4.Text = "|";
            // 
            // hangMan3
            // 
            this.hangMan3.AutoSize = true;
            this.hangMan3.BackColor = System.Drawing.Color.Transparent;
            this.hangMan3.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hangMan3.Location = new System.Drawing.Point(362, 233);
            this.hangMan3.Name = "hangMan3";
            this.hangMan3.Size = new System.Drawing.Size(28, 48);
            this.hangMan3.TabIndex = 9;
            this.hangMan3.Text = "|";
            // 
            // hangMan2
            // 
            this.hangMan2.AutoSize = true;
            this.hangMan2.BackColor = System.Drawing.Color.Transparent;
            this.hangMan2.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hangMan2.Location = new System.Drawing.Point(362, 272);
            this.hangMan2.Name = "hangMan2";
            this.hangMan2.Size = new System.Drawing.Size(28, 48);
            this.hangMan2.TabIndex = 8;
            this.hangMan2.Text = "|";
            // 
            // hangMan1
            // 
            this.hangMan1.AutoSize = true;
            this.hangMan1.BackColor = System.Drawing.Color.Transparent;
            this.hangMan1.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hangMan1.Location = new System.Drawing.Point(352, 293);
            this.hangMan1.Name = "hangMan1";
            this.hangMan1.Size = new System.Drawing.Size(41, 48);
            this.hangMan1.TabIndex = 7;
            this.hangMan1.Text = "_";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 48);
            this.label2.TabIndex = 6;
            this.label2.Text = "Attempts left:";
            // 
            // lblGuesses
            // 
            this.lblGuesses.AutoSize = true;
            this.lblGuesses.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuesses.Location = new System.Drawing.Point(214, 370);
            this.lblGuesses.Name = "lblGuesses";
            this.lblGuesses.Size = new System.Drawing.Size(38, 48);
            this.lblGuesses.TabIndex = 5;
            this.lblGuesses.Text = "0";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(142, 35);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(146, 48);
            this.lblWord.TabIndex = 4;
            this.lblWord.Text = "______";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Word:";
            // 
            // lblHangman
            // 
            this.lblHangman.AutoSize = true;
            this.lblHangman.Font = new System.Drawing.Font("Poppins Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHangman.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHangman.Location = new System.Drawing.Point(-8, -13);
            this.lblHangman.Name = "lblHangman";
            this.lblHangman.Size = new System.Drawing.Size(161, 48);
            this.lblHangman.TabIndex = 2;
            this.lblHangman.Text = "Hangman";
            // 
            // txtboxGuess
            // 
            this.txtboxGuess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxGuess.Location = new System.Drawing.Point(133, 449);
            this.txtboxGuess.MaxLength = 1;
            this.txtboxGuess.Name = "txtboxGuess";
            this.txtboxGuess.Size = new System.Drawing.Size(199, 20);
            this.txtboxGuess.TabIndex = 1;
            // 
            // hangMan6
            // 
            this.hangMan6.AutoSize = true;
            this.hangMan6.BackColor = System.Drawing.Color.Transparent;
            this.hangMan6.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hangMan6.Location = new System.Drawing.Point(295, 183);
            this.hangMan6.Name = "hangMan6";
            this.hangMan6.Size = new System.Drawing.Size(38, 48);
            this.hangMan6.TabIndex = 13;
            this.hangMan6.Text = "0";
            // 
            // hangMan7
            // 
            this.hangMan7.AutoSize = true;
            this.hangMan7.BackColor = System.Drawing.Color.Transparent;
            this.hangMan7.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hangMan7.Location = new System.Drawing.Point(300, 214);
            this.hangMan7.Name = "hangMan7";
            this.hangMan7.Size = new System.Drawing.Size(28, 48);
            this.hangMan7.TabIndex = 14;
            this.hangMan7.Text = "|";
            // 
            // hangMan8
            // 
            this.hangMan8.AutoSize = true;
            this.hangMan8.BackColor = System.Drawing.Color.Transparent;
            this.hangMan8.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hangMan8.Location = new System.Drawing.Point(276, 220);
            this.hangMan8.Name = "hangMan8";
            this.hangMan8.Size = new System.Drawing.Size(32, 48);
            this.hangMan8.TabIndex = 15;
            this.hangMan8.Text = "/";
            // 
            // hangMan9
            // 
            this.hangMan9.AutoSize = true;
            this.hangMan9.BackColor = System.Drawing.Color.Transparent;
            this.hangMan9.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hangMan9.Location = new System.Drawing.Point(314, 220);
            this.hangMan9.Name = "hangMan9";
            this.hangMan9.Size = new System.Drawing.Size(42, 48);
            this.hangMan9.TabIndex = 16;
            this.hangMan9.Text = "\\";
            // 
            // hangMan11
            // 
            this.hangMan11.AutoSize = true;
            this.hangMan11.BackColor = System.Drawing.Color.Transparent;
            this.hangMan11.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hangMan11.Location = new System.Drawing.Point(304, 257);
            this.hangMan11.Name = "hangMan11";
            this.hangMan11.Size = new System.Drawing.Size(42, 48);
            this.hangMan11.TabIndex = 17;
            this.hangMan11.Text = "\\";
            // 
            // hangMan10
            // 
            this.hangMan10.AutoSize = true;
            this.hangMan10.BackColor = System.Drawing.Color.Transparent;
            this.hangMan10.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hangMan10.Location = new System.Drawing.Point(285, 256);
            this.hangMan10.Name = "hangMan10";
            this.hangMan10.Size = new System.Drawing.Size(32, 48);
            this.hangMan10.TabIndex = 18;
            this.hangMan10.Text = "/";
            // 
            // Hangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(568, 531);
            this.Controls.Add(this.groupBox1);
            this.Name = "Hangman";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtboxGuess;
        private System.Windows.Forms.Label lblHangman;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGuesses;
        private System.Windows.Forms.Label hangMan2;
        private System.Windows.Forms.Label hangMan1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label hangMan5;
        private System.Windows.Forms.Label hangMan4;
        private System.Windows.Forms.Label hangMan3;
        private System.Windows.Forms.Label hangMan7;
        private System.Windows.Forms.Label hangMan6;
        private System.Windows.Forms.Label hangMan10;
        private System.Windows.Forms.Label hangMan11;
        private System.Windows.Forms.Label hangMan9;
        private System.Windows.Forms.Label hangMan8;
    }
}

