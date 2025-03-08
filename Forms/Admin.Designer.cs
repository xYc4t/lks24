namespace lks24.Forms
{
    partial class Admin
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
            pnlLog = new Panel();
            dgvLog = new DataGridView();
            btnLogTanggal = new Button();
            dtpLogTanggal = new DateTimePicker();
            lblLogTanggal = new Label();
            lblTitle = new Label();
            pnlLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLog).BeginInit();
            SuspendLayout();
            // 
            // pnlLog
            // 
            pnlLog.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlLog.Controls.Add(dgvLog);
            pnlLog.Controls.Add(btnLogTanggal);
            pnlLog.Controls.Add(dtpLogTanggal);
            pnlLog.Controls.Add(lblLogTanggal);
            pnlLog.Location = new Point(206, 49);
            pnlLog.Name = "pnlLog";
            pnlLog.Size = new Size(582, 389);
            pnlLog.TabIndex = 0;
            // 
            // dgvLog
            // 
            dgvLog.AllowUserToAddRows = false;
            dgvLog.AllowUserToDeleteRows = false;
            dgvLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLog.EnableHeadersVisualStyles = false;
            dgvLog.Location = new Point(16, 85);
            dgvLog.Name = "dgvLog";
            dgvLog.ReadOnly = true;
            dgvLog.RowHeadersVisible = false;
            dgvLog.ShowCellErrors = false;
            dgvLog.ShowCellToolTips = false;
            dgvLog.ShowEditingIcon = false;
            dgvLog.ShowRowErrors = false;
            dgvLog.Size = new Size(563, 301);
            dgvLog.TabIndex = 3;
            // 
            // btnLogTanggal
            // 
            btnLogTanggal.Location = new Point(152, 46);
            btnLogTanggal.Name = "btnLogTanggal";
            btnLogTanggal.Size = new Size(52, 23);
            btnLogTanggal.TabIndex = 2;
            btnLogTanggal.Text = "Filter";
            btnLogTanggal.UseVisualStyleBackColor = true;
            btnLogTanggal.Click += btnLogTanggal_Click;
            // 
            // dtpLogTanggal
            // 
            dtpLogTanggal.Checked = false;
            dtpLogTanggal.Format = DateTimePickerFormat.Short;
            dtpLogTanggal.Location = new Point(16, 46);
            dtpLogTanggal.Name = "dtpLogTanggal";
            dtpLogTanggal.Size = new Size(120, 23);
            dtpLogTanggal.TabIndex = 1;
            // 
            // lblLogTanggal
            // 
            lblLogTanggal.AutoSize = true;
            lblLogTanggal.Location = new Point(16, 19);
            lblLogTanggal.Name = "lblLogTanggal";
            lblLogTanggal.Size = new Size(74, 15);
            lblLogTanggal.TabIndex = 0;
            lblLogTanggal.Text = "Pilih Tanggal";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(489, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(0, 15);
            lblTitle.TabIndex = 0;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitle);
            Controls.Add(pnlLog);
            Name = "Admin";
            Text = "Admin";
            pnlLog.ResumeLayout(false);
            pnlLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlLog;
        private Button btnLogTanggal;
        private DateTimePicker dtpLogTanggal;
        private Label lblLogTanggal;
        private Label lblTitle;
        private DataGridView dgvLog;
    }
}