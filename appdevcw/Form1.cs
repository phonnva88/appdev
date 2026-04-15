using System.Data;
using Microsoft.Data.SqlClient;

namespace appdevcw
{
	internal partial class Form1 : Form
	{
		PersonManager manager = new PersonManager();
		int selectedId = -1;
		public Form1()
		{
			InitializeComponent();
		}
		private void HideAllPanelsRole()
		{
			panelTeacher.Visible = false;
			panelAdmin.Visible = false;
			panelStudent.Visible = false;

			tbSalary.Visible = false;
			lbSalary.Visible = false;
		}
		private void ShowTbSalary()
		{
			tbSalary.Visible = true;
			lbSalary.Visible = true;
		}
		private void ClearAllTextBox()
		{
			tbName.Clear();
			tbTelephone.Clear();
			tbEmail.Clear();
			tbSalary.Clear();
			tbSub1.Clear();
			tbSub2.Clear();
			tbSub3.Clear();
			cbRole.SelectedIndex = -1;
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			HideAllPanelsRole();

			dataGridView1.DataBindingComplete += RowNumbers;
			dataGridView1.Sorted += RowNumbers;

			cbViewRole.SelectedIndex = 0;

			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.MultiSelect = false;

			cbRole.DataSource = Enum.GetValues(typeof(RoleType));
			//cbViewRole.DataSource = Enum.GetValues(typeof(RoleType)); //cmt.Do i need load this line first
			cbViewRole.Items.Clear();
			cbViewRole.Items.Add("All");

			foreach (var role in Enum.GetValues(typeof(RoleType)))
			{
				cbViewRole.Items.Add(role);
			}

			cbViewRole.SelectedIndex = 0;

			cbType.DataSource = Enum.GetValues(typeof(EmploymentType));
			cbEditType.DataSource = Enum.GetValues(typeof(EmploymentType));
		}
		private bool ValidateInputs(Control control, string message)
		{
			if (string.IsNullOrWhiteSpace(control.Text))
			{
				MessageBox.Show(message);
				control.Focus();
				return false;
			}
			return true;
		}
		private void RowNumbers(object? sender, EventArgs e)
		{
			for (int i = 0; i < dataGridView1.Rows.Count; i++)
			{
				if (!dataGridView1.Rows[i].IsNewRow)
				{
					dataGridView1.Rows[i].Cells["no"].Value = i + 1;
				}
			}
		}

		// ADD DATA FEATURE
		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				// Get input values from form
				string name = tbName.Text.Trim();
				string telephone = tbTelephone.Text.Trim();
				string email = tbEmail.Text.Trim();
				if (!Enum.TryParse(cbRole.Text, out RoleType role))
				{
					MessageBox.Show("Invalid role!");
					return;
				}

				// Validate required fields
				if (string.IsNullOrEmpty(name) ||
					string.IsNullOrEmpty(telephone) ||
					string.IsNullOrEmpty(email))
				{
					MessageBox.Show("Please fill in all required fields!");
					return;
				}

				if (role == RoleType.Teacher)
				{
					if (!ValidateInputs(tbSalary, "Please enter salary!")) return; // cmt.OOP
					if (!decimal.TryParse(tbSalary.Text, out decimal salary)) // cmt.OOP
					{
						MessageBox.Show("Invalid salary!");
						tbSalary.Focus();
						return;
					}
					if (!ValidateInputs(tbSub1, "Please enter subject 1!")) return;
					if (!ValidateInputs(tbSub2, "Please enter subject 2!")) return;

					Teacher t = new Teacher(name, telephone, email, salary, tbSub1.Text, tbSub2.Text);
					manager.AddPerson(t);
				}

				else if (role == RoleType.Admin)
				{
					if (!ValidateInputs(tbSalary, "Please enter salary!")) return;
					if (!decimal.TryParse(tbSalary.Text, out decimal salary))
					{
						MessageBox.Show("Invalid salary!");
						tbSalary.Focus();
						return;
					}
					if (cbType.SelectedItem == null)
					{
						MessageBox.Show("Please select employment type!");
						return;
					}
					if (!ValidateInputs(tbHours, "Please enter hours!")) return;
					if (!int.TryParse(tbHours.Text, out int hours))
					{
						MessageBox.Show("Invalid hours!");
						return;
					}

					EmploymentType type = (EmploymentType)cbType.SelectedItem;

					Admin a = new Admin(name, telephone, email, salary, type, hours);
					manager.AddPerson(a);
				}

				else if (role == RoleType.Student)
				{
					if (!ValidateInputs(tbSub1, "Please enter subject 1!")) return;
					if (!ValidateInputs(tbSub2, "Please enter subject 2!")) return;
					if (!ValidateInputs(tbSub3, "Please enter subject 3!")) return;

					List<string> subjects = new List<string>
					{
						tbSub1.Text,
						tbSub2.Text,
						tbSub3.Text
					};

					Student s = new Student(name, telephone, email, subjects);
					manager.AddPerson(s);
				}

				else
				{
					throw new InvalidOperationException("Invalid role!");
				}

				MessageBox.Show("Data added successfully!");
				ClearAllTextBox();
				tbName.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		// VIEW DATA FEATURE
		private void btnView_Click(object sender, EventArgs e)
		{
			try
			{
				if (cbViewRole.Text == "All")
				{
					dataGridView1.DataSource = manager.ViewAll();
				}
				else if (Enum.TryParse(cbViewRole.Text, out RoleType role))
				{
					dataGridView1.DataSource = manager.ViewByRole(role);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		// EDIT DATA FEATURE
		private void btnEdit_Click(object sender, EventArgs e)
		{
			var row = dataGridView1.CurrentRow;

			if (row == null)
			{
				MessageBox.Show("Please select a row to edit!");
				return;
			}

			selectedId = Convert.ToInt32(row.Cells["id"].Value);

			// Fill data into edit controls
			tbEditName.Text = row.Cells["name"].Value?.ToString(); //cmt.Ques: why don't extract data from database instead of dataGridView1
			tbEditPhone.Text = row.Cells["telephone"].Value?.ToString();
			tbEditEmail.Text = row.Cells["email"].Value?.ToString();

			if (!Enum.TryParse(row.Cells["role"].Value?.ToString(), true, out RoleType role))
			{
				MessageBox.Show("Invalid role!");
				return;
			}

			if (role == RoleType.Teacher)
			{
				tbEditSalary.Text = row.Cells["salary"].Value?.ToString();

				var parts = (row.Cells["subjects"].Value?.ToString() ?? "").Split('|').Select(x => x.Trim()).ToArray();

				if (parts.Length > 0) tbEditSub1.Text = parts[0]; // check to fit with required subject fields
				if (parts.Length > 1) tbEditSub2.Text = parts[1];
			}
			else if (role == RoleType.Student)
			{
				var parts = (row.Cells["subjects"].Value?.ToString() ?? "").Split('|').Select(x => x.Trim()).ToArray();

				if (parts.Length > 0) tbEditSub1.Text = parts[0];
				if (parts.Length > 1) tbEditSub2.Text = parts[1];
				if (parts.Length > 2) tbEditSub3.Text = parts[2];
			}
			else if (role == RoleType.Admin)
			{
				tbEditSalary.Text = row.Cells["salary"].Value?.ToString();
				Enum.TryParse(row.Cells["worktype"].Value?.ToString(), out EmploymentType type);
				cbEditType.SelectedItem = type;
				tbEditHours.Text = row.Cells["workhours"].Value?.ToString();
			}

			panelEdit.Visible = true;
			panelEdit.BringToFront();
			//panelEdit.Left = (this.ClientSize.Width - panelEdit.Width) / 2;
			//panelEdit.Top = (this.ClientSize.Height - panelEdit.Height) / 2;
		}

		// DELETE DATA FEATURE
		private void btnDelete_Click(object sender, EventArgs e)
		{
			// Check if user selected a row
			var row = dataGridView1.CurrentRow;

			if (row == null)
			{
				MessageBox.Show("Please select a row!");
				return;
			}

			// Get ID + Role
			int id = Convert.ToInt32(row.Cells["id"].Value);
			if (!Enum.TryParse(row.Cells["role"].Value?.ToString(), true, out RoleType role))
			{
				MessageBox.Show("Invalid role!");
				return;
			}

			// Confirm before delete
			var confirm = MessageBox.Show($"Delete {role} with ID = {id}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (confirm == DialogResult.Yes)
			{
				try
				{
					manager.DeletePerson(id, role);
					MessageBox.Show("Deleted successfully!");
					dataGridView1.DataSource = manager.ViewAll();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message);
				}
			}
		}
		private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
		private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!Enum.TryParse(cbRole.Text, out RoleType role))
				return;

			HideAllPanelsRole();

			if (role == RoleType.Teacher)
			{
				ShowTbSalary();
				panelTeacher.Visible = true;
			}
			else if (role == RoleType.Admin)
			{
				ShowTbSalary();
				panelAdmin.Visible = true;
			}
			else if (role == RoleType.Student)
			{
				panelTeacher.Visible = true;
				panelStudent.Visible = true;
			}
		}
		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void tabDelete_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				var row = dataGridView1.CurrentRow;

				if (row == null)
				{
					MessageBox.Show("Invalid role!");
					return;
				}

				if (!Enum.TryParse(row.Cells["role"].Value?.ToString(), true, out RoleType role))
				{
					MessageBox.Show("Invalid role!");
					return;
				}

				if (role == RoleType.Teacher)
				{
					if (!decimal.TryParse(tbEditSalary.Text, out decimal salary))
					{
						MessageBox.Show("Invalid salary!");
						return;
					}

					//cmt.Ques: If only update changed fields is faster than updating all fields
					Teacher t = new Teacher(tbEditName.Text, tbEditPhone.Text, tbEditEmail.Text, salary, tbEditSub1.Text, tbEditSub2.Text);

					manager.UpdatePerson(selectedId, role, t);
				}
				else if (role == RoleType.Student)
				{
					var subjects = new List<string>();

					if (!string.IsNullOrWhiteSpace(tbEditSub1.Text)) subjects.Add(tbEditSub1.Text);
					//cmt.Missing logic for handling null or space values
					if (!string.IsNullOrWhiteSpace(tbEditSub2.Text)) subjects.Add(tbEditSub2.Text);
					//cmt.Missing logic for handling null or space values
					if (!string.IsNullOrWhiteSpace(tbEditSub3.Text)) subjects.Add(tbEditSub3.Text);
					//cmt.Missing logic for handling null or space values

					if (subjects.Count != 3)
					{
						MessageBox.Show("Student must have exactly 3 subjects!");
						return;
					}

					Student s = new Student(tbEditName.Text, tbEditPhone.Text, tbEditEmail.Text, subjects);

					manager.UpdatePerson(selectedId, role, s);
				}
				else if (role == RoleType.Admin)
				{
					if (!decimal.TryParse(tbEditSalary.Text, out decimal salary))
					{
						MessageBox.Show("Invalid salary!");
						return;
					}

					if (!int.TryParse(tbEditHours.Text, out int hours))
					{
						MessageBox.Show("Invalid hours!");
						return;
					}

					if (cbEditType.SelectedItem is not EmploymentType type)
					{
						MessageBox.Show("Please select employment type!");
						return;
					}

					Admin a = new Admin(tbEditName.Text, tbEditPhone.Text, tbEditEmail.Text, salary, type, hours);
					manager.UpdatePerson(selectedId, role, a);
				}

				MessageBox.Show("Data updated successfully!");

				panelEdit.Visible = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			panelEdit.Visible = false;
		}

		private void tbEditName_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
