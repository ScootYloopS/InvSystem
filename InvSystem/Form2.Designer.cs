namespace InvSystem
{
    partial class Form2
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
            this.BorrowButt = new System.Windows.Forms.Button();
            this.ReturnButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BorrowButt
            // 
            this.BorrowButt.Location = new System.Drawing.Point(150, 250);
            this.BorrowButt.Name = "BorrowButt";
            this.BorrowButt.Size = new System.Drawing.Size(250, 250);
            this.BorrowButt.TabIndex = 0;
            this.BorrowButt.Text = "Brw";
            this.BorrowButt.UseVisualStyleBackColor = true;
            this.BorrowButt.Click += new System.EventHandler(this.BorrowButt_Click);
            // 
            // ReturnButt
            // 
            this.ReturnButt.Location = new System.Drawing.Point(550, 250);
            this.ReturnButt.Name = "ReturnButt";
            this.ReturnButt.Size = new System.Drawing.Size(250, 250);
            this.ReturnButt.TabIndex = 1;
            this.ReturnButt.Text = "Rtn";
            this.ReturnButt.UseVisualStyleBackColor = true;
            this.ReturnButt.Click += new System.EventHandler(this.ReturnButt_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.ReturnButt);
            this.Controls.Add(this.BorrowButt);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button BorrowButt;
        private Button ReturnButt;
    }
}