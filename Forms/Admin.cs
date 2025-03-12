using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace lks24.Forms
{
	public partial class Admin : Form
	{
		// Class-level fields
		private Form _previousForm;
		private DataTable dtLog = new DataTable();
		private DataTable dtUser = new DataTable();
		private DataTable dtReport = new DataTable();

		public Admin(Form previous)
		{
			_previousForm = previous;
			InitializeComponent();
			LoadLogs();
			cmbUserTipe.DataSource = new List<string> { "Admin", "Kasir", "Gudang" };
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			_previousForm.Show();
			this.Close();
		}

		// =====================
		// Log-related Methods
		// =====================

		private void LoadLogs()
		{
			try
			{
				dtLog.Clear();

				using var con = Database.Connection();
				con.Open();

				string query = "SELECT l.id_log, u.username, l.waktu, l.aktivitas " +
							   "FROM tbl_log l INNER JOIN tbl_user u ON l.id_user = u.id_user";

				using var adapter = new MySqlDataAdapter(query, con);
				adapter.Fill(dtLog);
				dgvLog.DataSource = dtLog;

				ClearInputFields(pnlLog);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Exception: " + ex.Message);
			}
		}

		private void btnLog_Click(object sender, EventArgs e)
		{
			lblTitle.Text = "Log Activity";
			pnlLog.Visible = true;
			pnlUser.Visible = false;
			pnlReport.Visible = false;
			LoadLogs();
		}

		private void btnLogFilter_Click(object sender, EventArgs e)
		{
			dtLog.DefaultView.RowFilter = $"waktu >= #{dtpLogFilter.Value: MM/dd/yyyy 00:00:00}# AND waktu < #{dtpLogFilter.Value: MM/dd/yyyy 23:59:59}#";
		}

		// =====================
		// User-related Methods
		// =====================

		private void LoadUsers()
		{
			try
			{
				dtUser.Clear();

				using var con = Database.Connection();
				con.Open();

				string query = "SELECT * FROM tbl_user";

				using var adapter = new MySqlDataAdapter(query, con);
				adapter.Fill(dtUser);
				dgvUser.DataSource = dtUser;

				ClearInputFields(pnlUser, lblUserID);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Exception: " + ex.Message);
			}
		}

		private void btnUser_Click(object sender, EventArgs e)
		{
			lblTitle.Text = "Kelola User";
			pnlUser.Visible = true;
			pnlLog.Visible = false;
			pnlReport.Visible = false;
			LoadUsers();
		}

		private void btnUserTambah_Click(object sender, EventArgs e)
		{
			using (var con = Database.Connection())
			{
				try
				{
					con.Open();
					string query = $"INSERT INTO tbl_user(tipe_user, nama, alamat, telpon, username, password) " +
								   $"VALUES ('{cmbUserTipe.SelectedValue}', '{txtUserNama.Text}', '{txtUserAlamat.Text}', '{txtUserTelpon.Text}', '{txtUserUsername.Text}', '{txtUserPassword.Text}')";

					MessageBox.Show(query);
					using var cmd = new MySqlCommand(query, con);
					if (cmd.ExecuteNonQuery() > 0)
					{
						MessageBox.Show("Success!");
					}
					else
					{
						MessageBox.Show("Failed.");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Exception: " + ex.Message);
				}
			}
			LoadUsers();
		}

		private void btnUserEdit_Click(object sender, EventArgs e)
		{
			using (var con = Database.Connection())
			{
				try
				{
					con.Open();
					string query = $"UPDATE tbl_user SET " +
								   $"tipe_user = '{cmbUserTipe.SelectedValue}', nama = '{txtUserNama.Text}', alamat = '{txtUserAlamat.Text}', telpon = '{txtUserTelpon.Text}', username = '{txtUserUsername.Text}', password = '{txtUserPassword.Text}' " +
								   $"WHERE id_user = {lblUserID.Text}";

					MessageBox.Show(query);
					using var cmd = new MySqlCommand(query, con);
					if (cmd.ExecuteNonQuery() > 0)
					{
						MessageBox.Show("Success!");
					}
					else
					{
						MessageBox.Show("Failed.");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Exception: " + ex.Message);
				}
			}
			LoadUsers();
		}

		private void btnUserHapus_Click(object sender, EventArgs e)
		{
			using (var con = Database.Connection())
			{
				try
				{
					con.Open();
					string query = $"DELETE FROM tbl_user WHERE id_user = '{lblUserID.Text}'";

					MessageBox.Show(query);
					using var cmd = new MySqlCommand(query, con);
					if (cmd.ExecuteNonQuery() > 0)
					{
						MessageBox.Show("Success!");
					}
					else
					{
						MessageBox.Show("Failed.");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Exception: " + ex.Message);
				}
			}
			LoadUsers();
		}

		private void txtUserFilter_TextChanged(object sender, EventArgs e)
		{
			dtUser.DefaultView.RowFilter = $"nama LIKE '%{txtUserFilter.Text}%'";
		}

		private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0 || e.ColumnIndex < 0)
				return;

			TextBox[] rowHeader = { txtUserNama, txtUserAlamat, txtUserTelpon, txtUserUsername, txtUserPassword };

			string[] rowData = dgvUser.Rows[e.RowIndex].Cells.Cast<DataGridViewCell>()
								  .Select(cell => cell.Value?.ToString() ?? "")
								  .ToArray();

			lblUserID.Text = rowData[0];
			cmbUserTipe.SelectedItem = rowData[1];
			for (int i = 0; i < rowHeader.Length; i++)
			{
				rowHeader[i].Text = rowData[i + 2];
			}

			MessageBox.Show(string.Join(", ", rowData) + $"Index: {e.RowIndex}");
		}

		// =====================
		// Report-related Methods
		// =====================

		private void LoadReports()
		{
			try
			{
				dtReport.Clear();

				using (var con = Database.Connection())
				{

					con.Open();

					string query = "SELECT t.no_transaksi, t.tgl_transaksi, t.total_bayar, u.nama " +
									"FROM tbl_transaksi t INNER JOIN tbl_user u ON t.id_user = u.id_user";

					using var adapter = new MySqlDataAdapter(query, con);
					adapter.Fill(dtReport);
					dgvReport.DataSource = dtReport;

					ClearInputFields(pnlUser, lblUserID);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Exception: " + ex.Message);
			}
		}

		private void btnReport_Click(object sender, EventArgs e)
		{
			lblTitle.Text = "Kelola Laporan";
			pnlReport.Visible = true;
			pnlUser.Visible = false;
			pnlLog.Visible = false;
			LoadReports();
		}

		private void btnReportFilter_Click(object sender, EventArgs e)
		{
			dtReport.DefaultView.RowFilter = $"tgl_transaksi >= #{dtpReportFilterAwal.Value: MM/dd/yyyy 00:00:00}# AND tgl_transaksi <= #{dtpReportFilterAkhir.Value: MM/dd/yyyy 00:00:00}#";
		}

		private void btnReportOmset_Click(object sender, EventArgs e)
		{
			chtReportOmset.Series.Clear();
			chtReportOmset.ChartAreas.Clear();
			chtReportOmset.ChartAreas.Add(new ChartArea());

			var series = new Series("Omset") { ChartType = SeriesChartType.Column };

			var data = dgvReport.Rows.Cast<DataGridViewRow>()
				.Where(r => r.Cells["tgl_transaksi"].Value != null && r.Cells["total_bayar"].Value != null)
				.GroupBy(r => r.Cells["tgl_transaksi"].Value.ToString())
				.Select(g => new { Date = g.Key, Total = g.Sum(r => Convert.ToDouble(r.Cells["total_bayar"].Value)) });

			foreach (var item in data) series.Points.AddXY(item.Date, item.Total);

			chtReportOmset.Series.Add(series);
		}

		// =====================
		// Utility Methods
		// =====================

		private void ClearInputFields(Control container, params Label[] labels)
		{
			foreach (Control ctrl in container.Controls)
			{
				if (ctrl is TextBox textBox)
					textBox.Text = "";
				else if (ctrl is ComboBox comboBox)
					comboBox.SelectedIndex = -1;
			}

			foreach (Label lbl in labels)
			{
				lbl.Text = "";
			}
		}
	}
}