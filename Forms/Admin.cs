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
			cmbUserTipe.DataSource = new List<string> { "Admin", "Kasir", "Gudang" };
		}

		private void btnLog_Click(object sender, EventArgs e)
		{
			lblTitle.Text = "Log Activity";
			pnlLog.Visible = true;

			pnlUser.Visible = false;
			LoadLogs();
		}

		private DataTable dtLog = new DataTable();
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
					} else
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
					} else
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
					} else
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

		private DataTable dtUser = new DataTable();
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