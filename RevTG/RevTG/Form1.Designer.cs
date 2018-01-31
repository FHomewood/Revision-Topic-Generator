namespace RevTG
{
    partial class RevTG_Form1
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
            this.btnFind = new System.Windows.Forms.Button();
            this.txbDay = new System.Windows.Forms.TextBox();
            this.txbMonth = new System.Windows.Forms.TextBox();
            this.rbOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(143, 9);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(53, 23);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txbDay
            // 
            this.txbDay.AccessibleDescription = "";
            this.txbDay.Location = new System.Drawing.Point(13, 9);
            this.txbDay.Name = "txbDay";
            this.txbDay.Size = new System.Drawing.Size(59, 20);
            this.txbDay.TabIndex = 1;
            this.txbDay.Tag = "";
            // 
            // txbMonth
            // 
            this.txbMonth.Location = new System.Drawing.Point(78, 9);
            this.txbMonth.Name = "txbMonth";
            this.txbMonth.Size = new System.Drawing.Size(59, 20);
            this.txbMonth.TabIndex = 2;
            // 
            // rbOutput
            // 
            this.rbOutput.BackColor = System.Drawing.SystemColors.Control;
            this.rbOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rbOutput.Location = new System.Drawing.Point(13, 39);
            this.rbOutput.Name = "rbOutput";
            this.rbOutput.Size = new System.Drawing.Size(183, 226);
            this.rbOutput.TabIndex = 3;
            this.rbOutput.Text = "";
            // 
            // RevTG_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(211, 277);
            this.Controls.Add(this.rbOutput);
            this.Controls.Add(this.txbMonth);
            this.Controls.Add(this.txbDay);
            this.Controls.Add(this.btnFind);
            this.Name = "RevTG_Form1";
            this.Text = "RevTG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txbDay;
        private System.Windows.Forms.TextBox txbMonth;
        private System.Windows.Forms.RichTextBox rbOutput;
    }
}

