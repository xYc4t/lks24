using System.Data;
using Google.Protobuf.WellKnownTypes;
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

        private void btnLogTanggal_Click(object sender, EventArgs e)
        {
            LoadLogs(dtpLogTanggal.Value);
        }

        private void LoadLogs(DateTime? filter = null)
        {
            try
            {
                using var con = Database.Connection();
                con.Open();

                string query = "SELECT l.id_log, u.username, l.waktu, l.aktivitas " +
                               "FROM tbl_log l INNER JOIN tbl_user u ON l.id_user = u.id_user ";

                if (filter.HasValue)
                {
                    string dateFilter = filter.Value.ToString("yyyy-MM-dd");
                    query += $"WHERE DATE(l.waktu) = '{dateFilter}'";
                }

                using var adapter = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvLog.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Kelola User";
            pnlUser.Visible = true;

            pnlLog.Visible = false;
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

        private void LoadUsers(String filter)
        {
            try
            {
                using var con = Database.Connection();
                con.Open();

                string query = "SELECT * FROM tbl_user";

                if (string.IsNullOrEmpty(filter))
                {
                    //I think I'm gonna go different way for filtering... Filter form dtv, not directly on SQL. Later. Pusing sumpah OOP. 0803251748
                }

                using var adapter = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvLog.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
    }
}