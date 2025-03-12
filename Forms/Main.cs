using lks24.Forms;
using MySql.Data.MySqlClient;

namespace lks24
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void Login_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtUsername.Text)) txtUsername.BackColor = Color.IndianRed;

			using var con = Database.Connection();
			try
			{
				string query = $"SELECT * FROM tbl_user WHERE username = '{txtUsername.Text}' AND password = '{txtPassword.Text}'";

				using var com = new MySqlCommand(query, con);

				con.Open();

				using var reader = com.ExecuteReader();
				if (reader.Read())
				{
					var type = reader["tipe_user"].ToString();

					switch (type)
					{
						case "Admin":
							new Admin().Show();
							this.Hide();
							break;
							// TO BE ADDED
					}
				}
				else
				{
					MessageBox.Show("Nope, fu!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Exception: " + ex.Message);
			}
		}

		private void btnReset_Click(object sender, EventArgs e)
		{

		}
	}
}
