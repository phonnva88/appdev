namespace appdevcw
{
	public partial class Form1 : Form
	{
		List<Person> people = new List<Person>();
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
			tbPhone.Clear();
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
		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				string name = tbName.Text;
				string phone = tbPhone.Text;
				string email = tbEmail.Text;
				string role = cbRole.Text.ToLower();

				if (string.IsNullOrEmpty(name) ||
					string.IsNullOrEmpty(phone) ||
					string.IsNullOrEmpty(email) ||
					string.IsNullOrEmpty(role))
				{
					MessageBox.Show("Please fill in all required fields!");
					return;
				}

				if (role == "teacher")
				{
					if (!ValidateInputs(tbSalary, "Please enter salary!")) return;

					if (!int.TryParse(tbSalary.Text, out int salary))
					{
						MessageBox.Show("Invalid salary!");
						tbSalary.Focus();
						return;
					}

					if (!ValidateInputs(tbSub1, "Please enter subject 1!")) return;

					if (!ValidateInputs(tbSub2, "Please enter subject 2!")) return;

					people.Add(new Teacher(name, phone, email, salary, tbSub1.Text, tbSub2.Text));
				}
				else if (role == "admin")
				{
					if (!ValidateInputs(tbSalary, "Please enter salary!")) return;

					if (!int.TryParse(tbSalary.Text, out int salary))
					{
						MessageBox.Show("Invalid salary!");
						tbSalary.Focus();
						return;
					}

					if (!ValidateInputs(cbType, "Please enter admin type!")) return;

					if (!ValidateInputs(tbHours, "Please enter hours!")) return;

					if (!int.TryParse(tbHours.Text, out int hours))
					{
						MessageBox.Show("Invalid hours!");
						return;
					}

					people.Add(new Admin(name, phone, email, salary, cbType.Text, hours));
				}
				else if (role == "student")
				{
					if (!ValidateInputs(tbSub1, "Please enter subject 1!")) return;

					if (!ValidateInputs(tbSub2, "Please enter subject 2!")) return;

					if (!ValidateInputs(tbSub3, "Please enter subject 3!")) return;

					List<string> subjects = new List<string>()
					{
						tbSub1.Text,
						tbSub2.Text,
						tbSub3.Text
					};

					people.Add(new Student(name, phone, email, subjects));
				}

				MessageBox.Show("Data added successfully!");
				ClearAllTextBox();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}
		private void btnView_Click(object sender, EventArgs e)
		{
			//dataGridView1.Rows.Clear();

			//foreach (var p in people)
			//{
			//	dataGridView1.Rows.Add(
			//		p.Name,
			//		p.Phone,
			//		p.Email,
			//		p.Role
			//	);
			//}
		}
		private void btnDelete_Click(object sender, EventArgs e)
		{
			//string name = tbName.Text;

			//for (int i = 0; i < people.Count; i++)
			//{
			//	if (people[i].Name == name)
			//	{
			//		people.RemoveAt(i);
			//		MessageBox.Show("Deleted!");
			//		return;
			//	}
			//}

			//MessageBox.Show("Not found!");
		}
		private void btnEdit_Click(object sender, EventArgs e)
		{
			//string name = tbName.Text;

			//foreach (var p in people)
			//{
			//	if (p.Name == name)
			//	{
			//		p.Name = tbName.Text;
			//		p.Phone = tbPhone.Text;
			//		p.Email = tbEmail.Text;

			//		MessageBox.Show("Updated!");
			//		return;
			//	}
			//}

			//MessageBox.Show("Not found!");
		}
		private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
		private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
		{
			string role = cbRole.Text.ToLower();

			HideAllPanelsRole();

			if (role == "teacher")
			{
				ShowTbSalary();
				panelTeacher.Visible = true;
			}
			else if (role == "admin")
			{
				ShowTbSalary();
				panelAdmin.Visible = true;
			}
			else if (role == "student")
			{
				panelTeacher.Visible = true;
				panelStudent.Visible = true;
			}
		}
		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
