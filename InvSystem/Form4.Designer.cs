namespace InvSystem
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NamecCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacilityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnedCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RtnBack = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NamecCol,
            this.FacilityCol,
            this.ItemCol,
            this.QuantityCol,
            this.TimeCol,
            this.ReturnCol,
            this.ReturnedCol});
            this.dataGridView1.Location = new System.Drawing.Point(12, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1296, 587);
            this.dataGridView1.TabIndex = 0;
            // 
            // NamecCol
            // 
            this.NamecCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NamecCol.HeaderText = "Name";
            this.NamecCol.Name = "NamecCol";
            // 
            // FacilityCol
            // 
            this.FacilityCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FacilityCol.HeaderText = "Facility";
            this.FacilityCol.Name = "FacilityCol";
            // 
            // ItemCol
            // 
            this.ItemCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemCol.HeaderText = "Item";
            this.ItemCol.Name = "ItemCol";
            // 
            // QuantityCol
            // 
            this.QuantityCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QuantityCol.HeaderText = "Quantity";
            this.QuantityCol.Name = "QuantityCol";
            // 
            // TimeCol
            // 
            this.TimeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TimeCol.HeaderText = "Time Borrowed";
            this.TimeCol.Name = "TimeCol";
            // 
            // ReturnCol
            // 
            this.ReturnCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReturnCol.HeaderText = "Return Date";
            this.ReturnCol.Name = "ReturnCol";
            // 
            // ReturnedCol
            // 
            this.ReturnedCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReturnedCol.HeaderText = "Returned";
            this.ReturnedCol.Name = "ReturnedCol";
            this.ReturnedCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ReturnedCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // RtnBack
            // 
            this.RtnBack.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RtnBack.Location = new System.Drawing.Point(12, 40);
            this.RtnBack.Name = "RtnBack";
            this.RtnBack.Size = new System.Drawing.Size(128, 33);
            this.RtnBack.TabIndex = 1;
            this.RtnBack.Text = "Back to menu";
            this.RtnBack.UseVisualStyleBackColor = true;
            this.RtnBack.Click += new System.EventHandler(this.RtnBack_Click);
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_search.Location = new System.Drawing.Point(1051, 76);
            this.tb_search.Multiline = true;
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(257, 33);
            this.tb_search.TabIndex = 3;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 747);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.RtnBack);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NamecCol;
        private DataGridViewTextBoxColumn FacilityCol;
        private DataGridViewTextBoxColumn ItemCol;
        private DataGridViewTextBoxColumn QuantityCol;
        private DataGridViewTextBoxColumn TimeCol;
        private DataGridViewTextBoxColumn ReturnCol;
        private DataGridViewCheckBoxColumn ReturnedCol;
        private Button RtnBack;
        private TextBox tb_search;
    }
}