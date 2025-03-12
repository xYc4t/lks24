using System.Data;
using MySql.Data.MySqlClient;

namespace lks24.Forms
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            LoadLogs();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Log Activity";
            pnlLog.Visible = true;

            pnlUser.Visible = false;
        }

        private DataTable dtLog = new DataTable();
        private void LoadLogs()
        {
            try
            {
                using var con = Database.Connection();
                con.Open();

                string query = "SELECT l.id_log, u.username, l.waktu, l.aktivitas " +
                               "FROM tbl_log l INNER JOIN tbl_user u ON l.id_user = u.id_user";

                using var adapter = new MySqlDataAdapter(query, con);
                
                adapter.Fill(dtLog);
                dgvLog.DataSource = dtLog;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void btnLogFilter_Click(object sender, EventArgs e)
        {
            dtLog.DefaultView.RowFilter = $"waktu >= #{dtpLogFilter.Value: MM/dd/yyyy 00:00:00}# AND waktu < #{dtpLogFilter.Value: MM/dd/yyyy 23:59:59}#";
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Kelola User";
            pnlUser.Visible = true;

            pnlLog.Visible = false;
            LoadUsers();
        }

        private void btnUserTambah_Click(object sender, EventArgs e)
        {

        }

        private void btnUserEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnUserHapus_Click(object sender, EventArgs e)
        {

        }

        private DataTable dtUser = new DataTable();
        private void LoadUsers()
        {
            try
            {
                using var con = Database.Connection();
                con.Open();

                string query = "SELECT * FROM tbl_user";

                using var adapter = new MySqlDataAdapter(query, con);
                adapter.Fill(dtUser);
                dgvUser.DataSource = dtUser;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void txtUserFilter_TextChanged(object sender, EventArgs e)
        {
            dtUser.DefaultView.RowFilter = $"nama LIKE '%{txtUserFilter.Text}%'";
        }
    }
}