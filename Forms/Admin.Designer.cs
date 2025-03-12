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
            btnLogFilter = new Button();
            dtpLogFilter = new DateTimePicker();
            lblLogFilter = new Label();
            pnlUser = new Panel();
            dgvUser = new DataGridView();
            txtUserFilter = new TextBox();
            btnUserHapus = new Button();
            btnUserEdit = new Button();
            btnUserTambah = new Button();
            txtUserPassword = new TextBox();
            txtUserTelepon = new TextBox();
            txtUserUsername = new TextBox();
            txtUserNama = new TextBox();
            txtUserAlamat = new TextBox();
            lblUserPassword = new Label();
            lblUserTelepon = new Label();
            lblUserUsername = new Label();
            lblUserNama = new Label();
            lblUserAlamat = new Label();
            cmbUserTipe = new ComboBox();
            lblUserTipe = new Label();
            lblTitle = new Label();
            btnLog = new Button();
            lblUser = new Button();
            pnlLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLog).BeginInit();
            pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
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
            pnlUser.Controls.Add(dgvUser);
            pnlUser.Controls.Add(txtUserFilter);
            pnlUser.Controls.Add(btnUserHapus);
            pnlUser.Controls.Add(btnUserEdit);
            pnlUser.Controls.Add(btnUserTambah);
            pnlUser.Controls.Add(txtUserPassword);
            pnlUser.Controls.Add(txtUserTelepon);
            pnlUser.Controls.Add(txtUserUsername);
            pnlUser.Controls.Add(txtUserNama);
            pnlUser.Controls.Add(txtUserAlamat);
            pnlUser.Controls.Add(lblUserPassword);
            pnlUser.Controls.Add(lblUserTelepon);
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
            // dgvUser
            // 
            dgvUser.AllowUserToAddRows = false;
            dgvUser.AllowUserToDeleteRows = false;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(16, 243);
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.Size = new Size(553, 129);
            dgvUser.TabIndex = 16;
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
            // txtUserTelepon
            // 
            txtUserTelepon.Location = new Point(16, 140);
            txtUserTelepon.Name = "txtUserTelepon";
            txtUserTelepon.Size = new Size(100, 23);
            txtUserTelepon.TabIndex = 10;
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
            // lblUserTelepon
            // 
            lblUserTelepon.AutoSize = true;
            lblUserTelepon.Location = new Point(16, 122);
            lblUserTelepon.Name = "lblUserTelepon";
            lblUserTelepon.Size = new Size(48, 15);
            lblUserTelepon.TabIndex = 5;
            lblUserTelepon.Text = "Telepon";
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
            // lblUser
            // 
            lblUser.Location = new Point(62, 247);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(75, 23);
            lblUser.TabIndex = 5;
            lblUser.Text = "Kelola User";
            lblUser.UseVisualStyleBackColor = true;
            lblUser.Click += lblUser_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlUser);
            Controls.Add(lblUser);
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
        private Button lblUser;
        private Panel pnlUser;
        private ComboBox cmbUserTipe;
        private Label lblUserTipe;
        private TextBox txtUserPassword;
        private TextBox txtUserTelepon;
        private TextBox txtUserUsername;
        private TextBox txtUserNama;
        private TextBox txtUserAlamat;
        private Label lblUserPassword;
        private Label lblUserTelepon;
        private Label lblUserUsername;
        private Label lblUserNama;
        private Label lblUserAlamat;
        private DataGridView dgvUser;
        private TextBox txtUserFilter;
        private Button btnUserHapus;
        private Button btnUserEdit;
        private Button btnUserTambah;
    }
}