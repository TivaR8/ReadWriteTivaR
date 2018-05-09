namespace ReadWriteTivaR
{
    partial class frmReadWrite
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblCaseNotMatterText = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblConfirmOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(31, 30);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(214, 13);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Compare strings on each line of input.txt file.";
            // 
            // lblCaseNotMatterText
            // 
            this.lblCaseNotMatterText.AutoSize = true;
            this.lblCaseNotMatterText.Font = new System.Drawing.Font("Minion Pro", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaseNotMatterText.Location = new System.Drawing.Point(63, 57);
            this.lblCaseNotMatterText.Name = "lblCaseNotMatterText";
            this.lblCaseNotMatterText.Size = new System.Drawing.Size(117, 16);
            this.lblCaseNotMatterText.TabIndex = 1;
            this.lblCaseNotMatterText.Text = "(Case does not matter)";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(84, 100);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblConfirmOutput
            // 
            this.lblConfirmOutput.AutoSize = true;
            this.lblConfirmOutput.Location = new System.Drawing.Point(31, 175);
            this.lblConfirmOutput.Name = "lblConfirmOutput";
            this.lblConfirmOutput.Size = new System.Drawing.Size(188, 13);
            this.lblConfirmOutput.TabIndex = 3;
            this.lblConfirmOutput.Text = "Output has been generated to text file.";
            // 
            // frmReadWrite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblConfirmOutput);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblCaseNotMatterText);
            this.Controls.Add(this.lblInstructions);
            this.Name = "frmReadWrite";
            this.Text = "Read & Write Text Files By Tiva Rait";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblCaseNotMatterText;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblConfirmOutput;
    }
}

