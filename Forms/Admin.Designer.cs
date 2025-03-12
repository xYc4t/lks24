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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			pnlLog = new Panel();
			dgvLog = new DataGridView();
			btnLogFilter = new Button();
			dtpLogFilter = new DateTimePicker();
			lblLogFilter = new Label();
			pnlUser = new Panel();
			lblUserID = new Label();
			dgvUser = new DataGridView();
			txtUserFilter = new TextBox();
			btnUserHapus = new Button();
			btnUserEdit = new Button();
			btnUserTambah = new Button();
			txtUserPassword = new TextBox();
			txtUserTelpon = new TextBox();
			txtUserUsername = new TextBox();
			txtUserNama = new TextBox();
			txtUserAlamat = new TextBox();
			lblUserPassword = new Label();
			lblUserTelpon = new Label();
			lblUserUsername = new Label();
			lblUserNama = new Label();
			lblUserAlamat = new Label();
			cmbUserTipe = new ComboBox();
			lblUserTipe = new Label();
			lblTitle = new Label();
			btnLog = new Button();
			btnUser = new Button();
			pnlReport = new Panel();
			btnReportFilter = new Button();
			dtpReportFilterAkhir = new DateTimePicker();
			dtpReportFilterAwal = new DateTimePicker();
			lblReportFilterAkhir = new Label();
			lblReportFilterAwal = new Label();
			dgvReport = new DataGridView();
			btnReportOmset = new Button();
			chtReportOmset = new System.Windows.Forms.DataVisualization.Charting.Chart();
			btnReport = new Button();
			btnLogout = new Button();
			lblAdmin = new Label();
			pnlLog.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvLog).BeginInit();
			pnlUser.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
			pnlReport.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
			((System.ComponentModel.ISupportInitialize)chtReportOmset).BeginInit();
			SuspendLayout();
			// 
			// pnlLog
			// 
			pnlLog.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			pnlLog.Controls.Add(dgvLog);
			pnlLog.Controls.Add(btnLogFilter);
			pnlLog.Controls.Add(dtpLogFilter);
			pnlLog.Controls.Add(lblLogFilter);
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
			// btnLogFilter
			// 
			btnLogFilter.Location = new Point(152, 46);
			btnLogFilter.Name = "btnLogFilter";
			btnLogFilter.Size = new Size(52, 23);
			btnLogFilter.TabIndex = 2;
			btnLogFilter.Text = "Filter";
			btnLogFilter.UseVisualStyleBackColor = true;
			btnLogFilter.Click += btnLogFilter_Click;
			// 
			// dtpLogFilter
			// 
			dtpLogFilter.Checked = false;
			dtpLogFilter.Location = new Point(16, 46);
			dtpLogFilter.Name = "dtpLogFilter";
			dtpLogFilter.Size = new Size(120, 23);
			dtpLogFilter.TabIndex = 1;
			// 
			// lblLogFilter
			// 
			lblLogFilter.AutoSize = true;
			lblLogFilter.Location = new Point(16, 19);
			lblLogFilter.Name = "lblLogFilter";
			lblLogFilter.Size = new Size(74, 15);
			lblLogFilter.TabIndex = 0;
			lblLogFilter.Text = "Pilih Tanggal";
			// 
			// pnlUser
			// 
			pnlUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			pnlUser.Controls.Add(lblUserID);
			pnlUser.Controls.Add(dgvUser);
			pnlUser.Controls.Add(txtUserFilter);
			pnlUser.Controls.Add(btnUserHapus);
			pnlUser.Controls.Add(btnUserEdit);
			pnlUser.Controls.Add(btnUserTambah);
			pnlUser.Controls.Add(txtUserPassword);
			pnlUser.Controls.Add(txtUserTelpon);
			pnlUser.Controls.Add(txtUserUsername);
			pnlUser.Controls.Add(txtUserNama);
			pnlUser.Controls.Add(txtUserAlamat);
			pnlUser.Controls.Add(lblUserPassword);
			pnlUser.Controls.Add(lblUserTelpon);
			pnlUser.Controls.Add(lblUserUsername);
			pnlUser.Controls.Add(lblUserNama);
			pnlUser.Controls.Add(lblUserAlamat);
			pnlUser.Controls.Add(cmbUserTipe);
			pnlUser.Controls.Add(lblUserTipe);
			pnlUser.Location = new Point(206, 49);
			pnlUser.Name = "pnlUser";
			pnlUser.Size = new Size(582, 389);
			pnlUser.TabIndex = 4;
			pnlUser.Visible = false;
			// 
			// lblUserID
			// 
			lblUserID.AutoSize = true;
			lblUserID.Location = new Point(249, 19);
			lblUserID.Name = "lblUserID";
			lblUserID.Size = new Size(0, 15);
			lblUserID.TabIndex = 17;
			// 
			// dgvUser
			// 
			dgvUser.AllowUserToAddRows = false;
			dgvUser.AllowUserToDeleteRows = false;
			dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvUser.EnableHeadersVisualStyles = false;
			dgvUser.Location = new Point(16, 243);
			dgvUser.Name = "dgvUser";
			dgvUser.ReadOnly = true;
			dgvUser.RowHeadersVisible = false;
			dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvUser.Size = new Size(553, 129);
			dgvUser.TabIndex = 16;
			dgvUser.CellClick += dgvUser_CellClick;
			// 
			// txtUserFilter
			// 
			txtUserFilter.Location = new Point(16, 214);
			txtUserFilter.Name = "txtUserFilter";
			txtUserFilter.Size = new Size(100, 23);
			txtUserFilter.TabIndex = 15;
			txtUserFilter.TextChanged += txtUserFilter_TextChanged;
			// 
			// btnUserHapus
			// 
			btnUserHapus.Location = new Point(244, 179);
			btnUserHapus.Name = "btnUserHapus";
			btnUserHapus.Size = new Size(75, 23);
			btnUserHapus.TabIndex = 14;
			btnUserHapus.Text = "Hapus";
			btnUserHapus.UseVisualStyleBackColor = true;
			btnUserHapus.Click += btnUserHapus_Click;
			// 
			// btnUserEdit
			// 
			btnUserEdit.Location = new Point(129, 179);
			btnUserEdit.Name = "btnUserEdit";
			btnUserEdit.Size = new Size(75, 23);
			btnUserEdit.TabIndex = 13;
			btnUserEdit.Text = "Edit";
			btnUserEdit.UseVisualStyleBackColor = true;
			btnUserEdit.Click += btnUserEdit_Click;
			// 
			// btnUserTambah
			// 
			btnUserTambah.Location = new Point(16, 179);
			btnUserTambah.Name = "btnUserTambah";
			btnUserTambah.Size = new Size(75, 23);
			btnUserTambah.TabIndex = 12;
			btnUserTambah.Text = "Tambah";
			btnUserTambah.UseVisualStyleBackColor = true;
			btnUserTambah.Click += btnUserTambah_Click;
			// 
			// txtUserPassword
			// 
			txtUserPassword.Location = new Point(394, 140);
			txtUserPassword.Name = "txtUserPassword";
			txtUserPassword.Size = new Size(100, 23);
			txtUserPassword.TabIndex = 11;
			// 
			// txtUserTelpon
			// 
			txtUserTelpon.Location = new Point(16, 140);
			txtUserTelpon.Name = "txtUserTelpon";
			txtUserTelpon.Size = new Size(100, 23);
			txtUserTelpon.TabIndex = 10;
			// 
			// txtUserUsername
			// 
			txtUserUsername.Location = new Point(394, 85);
			txtUserUsername.Name = "txtUserUsername";
			txtUserUsername.Size = new Size(100, 23);
			txtUserUsername.TabIndex = 9;
			// 
			// txtUserNama
			// 
			txtUserNama.Location = new Point(16, 85);
			txtUserNama.Name = "txtUserNama";
			txtUserNama.Size = new Size(100, 23);
			txtUserNama.TabIndex = 8;
			// 
			// txtUserAlamat
			// 
			txtUserAlamat.Location = new Point(394, 37);
			txtUserAlamat.Name = "txtUserAlamat";
			txtUserAlamat.Size = new Size(100, 23);
			txtUserAlamat.TabIndex = 7;
			// 
			// lblUserPassword
			// 
			lblUserPassword.AutoSize = true;
			lblUserPassword.Location = new Point(394, 122);
			lblUserPassword.Name = "lblUserPassword";
			lblUserPassword.Size = new Size(57, 15);
			lblUserPassword.TabIndex = 6;
			lblUserPassword.Text = "Password";
			// 
			// lblUserTelpon
			// 
			lblUserTelpon.AutoSize = true;
			lblUserTelpon.Location = new Point(16, 122);
			lblUserTelpon.Name = "lblUserTelpon";
			lblUserTelpon.Size = new Size(42, 15);
			lblUserTelpon.TabIndex = 5;
			lblUserTelpon.Text = "Telpon";
			// 
			// lblUserUsername
			// 
			lblUserUsername.AutoSize = true;
			lblUserUsername.Location = new Point(394, 67);
			lblUserUsername.Name = "lblUserUsername";
			lblUserUsername.Size = new Size(60, 15);
			lblUserUsername.TabIndex = 4;
			lblUserUsername.Text = "Username";
			// 
			// lblUserNama
			// 
			lblUserNama.AutoSize = true;
			lblUserNama.Location = new Point(16, 67);
			lblUserNama.Name = "lblUserNama";
			lblUserNama.Size = new Size(39, 15);
			lblUserNama.TabIndex = 3;
			lblUserNama.Text = "Nama";
			// 
			// lblUserAlamat
			// 
			lblUserAlamat.AutoSize = true;
			lblUserAlamat.Location = new Point(394, 19);
			lblUserAlamat.Name = "lblUserAlamat";
			lblUserAlamat.Size = new Size(45, 15);
			lblUserAlamat.TabIndex = 2;
			lblUserAlamat.Text = "Alamat";
			// 
			// cmbUserTipe
			// 
			cmbUserTipe.FormattingEnabled = true;
			cmbUserTipe.Location = new Point(16, 37);
			cmbUserTipe.Name = "cmbUserTipe";
			cmbUserTipe.Size = new Size(121, 23);
			cmbUserTipe.TabIndex = 1;
			// 
			// lblUserTipe
			// 
			lblUserTipe.AutoSize = true;
			lblUserTipe.Location = new Point(16, 19);
			lblUserTipe.Name = "lblUserTipe";
			lblUserTipe.Size = new Size(55, 15);
			lblUserTipe.TabIndex = 0;
			lblUserTipe.Text = "Tipe User";
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.Location = new Point(455, 9);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(70, 15);
			lblTitle.TabIndex = 0;
			lblTitle.Text = "Log Activity";
			lblTitle.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btnLog
			// 
			btnLog.Location = new Point(62, 301);
			btnLog.Name = "btnLog";
			btnLog.Size = new Size(83, 23);
			btnLog.TabIndex = 4;
			btnLog.Text = "Log Activity";
			btnLog.UseVisualStyleBackColor = true;
			btnLog.Click += btnLog_Click;
			// 
			// btnUser
			// 
			btnUser.Location = new Point(62, 247);
			btnUser.Name = "btnUser";
			btnUser.Size = new Size(75, 23);
			btnUser.TabIndex = 5;
			btnUser.Text = "Kelola User";
			btnUser.UseVisualStyleBackColor = true;
			btnUser.Click += btnUser_Click;
			// 
			// pnlReport
			// 
			pnlReport.Controls.Add(btnReportFilter);
			pnlReport.Controls.Add(dtpReportFilterAkhir);
			pnlReport.Controls.Add(dtpReportFilterAwal);
			pnlReport.Controls.Add(lblReportFilterAkhir);
			pnlReport.Controls.Add(lblReportFilterAwal);
			pnlReport.Controls.Add(dgvReport);
			pnlReport.Controls.Add(btnReportOmset);
			pnlReport.Controls.Add(chtReportOmset);
			pnlReport.Location = new Point(206, 49);
			pnlReport.Name = "pnlReport";
			pnlReport.Size = new Size(582, 389);
			pnlReport.TabIndex = 6;
			pnlReport.Visible = false;
			// 
			// btnReportFilter
			// 
			btnReportFilter.Location = new Point(355, 22);
			btnReportFilter.Name = "btnReportFilter";
			btnReportFilter.Size = new Size(75, 23);
			btnReportFilter.TabIndex = 7;
			btnReportFilter.Text = "Filter";
			btnReportFilter.UseVisualStyleBackColor = true;
			btnReportFilter.Click += btnReportFilter_Click;
			// 
			// dtpReportFilterAkhir
			// 
			dtpReportFilterAkhir.Location = new Point(170, 22);
			dtpReportFilterAkhir.Name = "dtpReportFilterAkhir";
			dtpReportFilterAkhir.Size = new Size(135, 23);
			dtpReportFilterAkhir.TabIndex = 6;
			// 
			// dtpReportFilterAwal
			// 
			dtpReportFilterAwal.Location = new Point(20, 22);
			dtpReportFilterAwal.Name = "dtpReportFilterAwal";
			dtpReportFilterAwal.Size = new Size(135, 23);
			dtpReportFilterAwal.TabIndex = 5;
			// 
			// lblReportFilterAkhir
			// 
			lblReportFilterAkhir.AutoSize = true;
			lblReportFilterAkhir.Location = new Point(170, 4);
			lblReportFilterAkhir.Name = "lblReportFilterAkhir";
			lblReportFilterAkhir.Size = new Size(79, 15);
			lblReportFilterAkhir.TabIndex = 4;
			lblReportFilterAkhir.Text = "Tanggal Akhir";
			// 
			// lblReportFilterAwal
			// 
			lblReportFilterAwal.AutoSize = true;
			lblReportFilterAwal.Location = new Point(20, 4);
			lblReportFilterAwal.Name = "lblReportFilterAwal";
			lblReportFilterAwal.Size = new Size(77, 15);
			lblReportFilterAwal.TabIndex = 3;
			lblReportFilterAwal.Text = "Tanggal Awal";
			// 
			// dgvReport
			// 
			dgvReport.AllowUserToAddRows = false;
			dgvReport.AllowUserToDeleteRows = false;
			dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvReport.EnableHeadersVisualStyles = false;
			dgvReport.Location = new Point(16, 71);
			dgvReport.Name = "dgvReport";
			dgvReport.ReadOnly = true;
			dgvReport.Size = new Size(553, 150);
			dgvReport.TabIndex = 2;
			// 
			// btnReportOmset
			// 
			btnReportOmset.Location = new Point(355, 286);
			btnReportOmset.Name = "btnReportOmset";
			btnReportOmset.Size = new Size(75, 23);
			btnReportOmset.TabIndex = 1;
			btnReportOmset.Text = "Generate";
			btnReportOmset.UseVisualStyleBackColor = true;
			btnReportOmset.Click += btnReportOmset_Click;
			// 
			// chtReportOmset
			// 
			chartArea1.Name = "ChartArea1";
			chtReportOmset.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			chtReportOmset.Legends.Add(legend1);
			chtReportOmset.Location = new Point(16, 243);
			chtReportOmset.Name = "chtReportOmset";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			chtReportOmset.Series.Add(series1);
			chtReportOmset.Size = new Size(438, 129);
			chtReportOmset.TabIndex = 0;
			chtReportOmset.Text = "chart1";
			// 
			// btnReport
			// 
			btnReport.Location = new Point(62, 203);
			btnReport.Name = "btnReport";
			btnReport.Size = new Size(95, 23);
			btnReport.TabIndex = 0;
			btnReport.Text = "Kelola Laporan";
			btnReport.UseVisualStyleBackColor = true;
			btnReport.Click += btnReport_Click;
			// 
			// btnLogout
			// 
			btnLogout.Location = new Point(62, 354);
			btnLogout.Name = "btnLogout";
			btnLogout.Size = new Size(75, 23);
			btnLogout.TabIndex = 7;
			btnLogout.Text = "Logout";
			btnLogout.UseVisualStyleBackColor = true;
			btnLogout.Click += btnLogout_Click;
			// 
			// lblAdmin
			// 
			lblAdmin.AutoSize = true;
			lblAdmin.Location = new Point(78, 49);
			lblAdmin.Name = "lblAdmin";
			lblAdmin.Size = new Size(43, 15);
			lblAdmin.TabIndex = 8;
			lblAdmin.Text = "Admin";
			// 
			// Admin
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(lblAdmin);
			Controls.Add(btnLogout);
			Controls.Add(btnReport);
			Controls.Add(pnlReport);
			Controls.Add(pnlUser);
			Controls.Add(btnUser);
			Controls.Add(btnLog);
			Controls.Add(lblTitle);
			Controls.Add(pnlLog);
			Name = "Admin";
			Text = "Admin";
			pnlLog.ResumeLayout(false);
			pnlLog.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvLog).EndInit();
			pnlUser.ResumeLayout(false);
			pnlUser.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
			pnlReport.ResumeLayout(false);
			pnlReport.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
			((System.ComponentModel.ISupportInitialize)chtReportOmset).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel pnlLog;
        private Button btnLogFilter;
        private DateTimePicker dtpLogFilter;
        private Label lblLogFilter;
        private Label lblTitle;
        private DataGridView dgvLog;
        private Button btnLog;
        private Button btnUser;
        private Panel pnlUser;
        private ComboBox cmbUserTipe;
        private Label lblUserTipe;
        private TextBox txtUserPassword;
        private TextBox txtUserTelpon;
        private TextBox txtUserUsername;
        private TextBox txtUserNama;
        private TextBox txtUserAlamat;
        private Label lblUserPassword;
        private Label lblUserTelpon;
        private Label lblUserUsername;
        private Label lblUserNama;
        private Label lblUserAlamat;
        private DataGridView dgvUser;
        private TextBox txtUserFilter;
        private Button btnUserHapus;
        private Button btnUserEdit;
        private Button btnUserTambah;
        private Label lblUserID;
        private Panel pnlReport;
        private Button btnReport;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtReportOmset;
        private Button btnReportOmset;
        private DataGridView dgvReport;
        private Button btnReportFilter;
        private DateTimePicker dtpReportFilterAkhir;
        private DateTimePicker dtpReportFilterAwal;
        private Label lblReportFilterAkhir;
        private Label lblReportFilterAwal;
		private Button btnLogout;
		private Label lblAdmin;
	}
}