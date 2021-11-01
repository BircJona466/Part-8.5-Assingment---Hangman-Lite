namespace Part_8._5_Assingment___Hangman_Lite
{
    partial class HangManLite
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
            this.lstUsedLetters = new System.Windows.Forms.ListBox();
            this.lblGuessedLetters = new System.Windows.Forms.Label();
            this.lblLivesLeft = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblWord = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSecretWord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstUsedLetters
            // 
            this.lstUsedLetters.FormattingEnabled = true;
            this.lstUsedLetters.Location = new System.Drawing.Point(12, 274);
            this.lstUsedLetters.Name = "lstUsedLetters";
            this.lstUsedLetters.Size = new System.Drawing.Size(113, 147);
            this.lstUsedLetters.TabIndex = 0;
            // 
            // lblGuessedLetters
            // 
            this.lblGuessedLetters.AutoSize = true;
            this.lblGuessedLetters.BackColor = System.Drawing.Color.Transparent;
            this.lblGuessedLetters.Font = new System.Drawing.Font("Wide Latin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessedLetters.Location = new System.Drawing.Point(-3, 257);
            this.lblGuessedLetters.Name = "lblGuessedLetters";
            this.lblGuessedLetters.Size = new System.Drawing.Size(158, 14);
            this.lblGuessedLetters.TabIndex = 1;
            this.lblGuessedLetters.Text = "Guessed Letters";
            // 
            // lblLivesLeft
            // 
            this.lblLivesLeft.AutoSize = true;
            this.lblLivesLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblLivesLeft.Font = new System.Drawing.Font("Wide Latin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivesLeft.Location = new System.Drawing.Point(118, 98);
            this.lblLivesLeft.Name = "lblLivesLeft";
            this.lblLivesLeft.Size = new System.Drawing.Size(115, 14);
            this.lblLivesLeft.TabIndex = 3;
            this.lblLivesLeft.Text = "Lives Left : ";
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(144, 146);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(40, 20);
            this.txtGuess.TabIndex = 4;
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(196, 146);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(48, 20);
            this.btnGuess.TabIndex = 5;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.BackColor = System.Drawing.Color.Transparent;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(60, 41);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(0, 39);
            this.lblWord.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(132, 115);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 82);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSecretWord
            // 
            this.lblSecretWord.AutoSize = true;
            this.lblSecretWord.BackColor = System.Drawing.Color.Transparent;
            this.lblSecretWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecretWord.Location = new System.Drawing.Point(111, 43);
            this.lblSecretWord.Name = "lblSecretWord";
            this.lblSecretWord.Size = new System.Drawing.Size(232, 55);
            this.lblSecretWord.TabIndex = 8;
            this.lblSecretWord.Text = "________";
            // 
            // HangManLite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Part_8._5_Assingment___Hangman_Lite.Properties.Resources.Hangman0_copy;
            this.ClientSize = new System.Drawing.Size(404, 480);
            this.Controls.Add(this.lblSecretWord);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblLivesLeft);
            this.Controls.Add(this.lblGuessedLetters);
            this.Controls.Add(this.lstUsedLetters);
            this.Name = "HangManLite";
            this.Text = "HangMan Lite";
            this.Load += new System.EventHandler(this.HangManLite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUsedLetters;
        private System.Windows.Forms.Label lblGuessedLetters;
        private System.Windows.Forms.Label lblLivesLeft;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSecretWord;
    }
}

