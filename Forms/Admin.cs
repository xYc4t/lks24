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
    }
}