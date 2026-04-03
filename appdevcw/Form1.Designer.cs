namespace appdevcw
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.TextBox tbPhone;
		private System.Windows.Forms.TextBox tbSub1;
		private System.Windows.Forms.TextBox tbSub2;
		private void InitializeComponent()
		{
			cbRole = new ComboBox();
			tbName = new TextBox();
			tbPhone = new TextBox();
			tbEmail = new TextBox();
			btnAdd = new Button();
			btnView = new Button();
			btnEdit = new Button();
			btnDelete = new Button();
			dataGridView1 = new DataGridView();
			Column1 = new DataGridViewTextBoxColumn();
			Column2 = new DataGridViewTextBoxColumn();
			Column3 = new DataGridViewTextBoxColumn();
			Column4 = new DataGridViewTextBoxColumn();
			tbSalary = new TextBox();
			tbSub1 = new TextBox();
			tbSub2 = new TextBox();
			tbHours = new TextBox();
			tbSub3 = new TextBox();
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			lbSalary = new Label();
			panelStudent = new Panel();
			label9 = new Label();
			panelAdmin = new Panel();
			cbType = new ComboBox();
			label10 = new Label();
			label5 = new Label();
			panelTeacher = new Panel();
			label7 = new Label();
			label8 = new Label();
			label6 = new Label();
			label1 = new Label();
			label3 = new Label();
			label2 = new Label();
			tabPage2 = new TabPage();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			panelStudent.SuspendLayout();
			panelAdmin.SuspendLayout();
			panelTeacher.SuspendLayout();
			SuspendLayout();
			// 
			// cbRole
			// 
			cbRole.FormattingEnabled = true;
			cbRole.Items.AddRange(new object[] { "Teacher", "Admin", "Student" });
			cbRole.Location = new Point(148, 263);
			cbRole.Name = "cbRole";
			cbRole.Size = new Size(242, 40);
			cbRole.TabIndex = 0;
			cbRole.SelectedIndexChanged += cbRole_SelectedIndexChanged;
			// 
			// tbName
			// 
			tbName.Location = new Point(158, 40);
			tbName.Name = "tbName";
			tbName.Size = new Size(200, 39);
			tbName.TabIndex = 1;
			// 
			// tbPhone
			// 
			tbPhone.Location = new Point(250, 112);
			tbPhone.Name = "tbPhone";
			tbPhone.Size = new Size(200, 39);
			tbPhone.TabIndex = 2;
			// 
			// tbEmail
			// 
			tbEmail.Location = new Point(148, 189);
			tbEmail.Name = "tbEmail";
			tbEmail.Size = new Size(200, 39);
			tbEmail.TabIndex = 3;
			// 
			// btnAdd
			// 
			btnAdd.Location = new Point(470, 622);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(150, 46);
			btnAdd.TabIndex = 4;
			btnAdd.Text = "button1";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// btnView
			// 
			btnView.Location = new Point(1711, 460);
			btnView.Name = "btnView";
			btnView.Size = new Size(150, 46);
			btnView.TabIndex = 5;
			btnView.Text = "button2";
			btnView.UseVisualStyleBackColor = true;
			btnView.Click += btnView_Click;
			// 
			// btnEdit
			// 
			btnEdit.Location = new Point(1890, 460);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(150, 46);
			btnEdit.TabIndex = 6;
			btnEdit.Text = "button3";
			btnEdit.UseVisualStyleBackColor = true;
			btnEdit.Click += btnEdit_Click;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(2075, 460);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(150, 46);
			btnDelete.TabIndex = 7;
			btnDelete.Text = "button4";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
			dataGridView1.Location = new Point(1536, 526);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 82;
			dataGridView1.Size = new Size(895, 300);
			dataGridView1.TabIndex = 8;
			// 
			// Column1
			// 
			Column1.HeaderText = "Name";
			Column1.MinimumWidth = 10;
			Column1.Name = "Column1";
			Column1.Width = 200;
			// 
			// Column2
			// 
			Column2.HeaderText = "Phone";
			Column2.MinimumWidth = 10;
			Column2.Name = "Column2";
			Column2.Width = 200;
			// 
			// Column3
			// 
			Column3.HeaderText = "Email";
			Column3.MinimumWidth = 10;
			Column3.Name = "Column3";
			Column3.Width = 200;
			// 
			// Column4
			// 
			Column4.HeaderText = "Role";
			Column4.MinimumWidth = 10;
			Column4.Name = "Column4";
			Column4.Width = 200;
			// 
			// tbSalary
			// 
			tbSalary.Location = new Point(172, 560);
			tbSalary.Name = "tbSalary";
			tbSalary.Size = new Size(200, 39);
			tbSalary.TabIndex = 9;
			// 
			// tbSub1
			// 
			tbSub1.Location = new Point(137, 85);
			tbSub1.Name = "tbSub1";
			tbSub1.Size = new Size(200, 39);
			tbSub1.TabIndex = 10;
			// 
			// tbSub2
			// 
			tbSub2.Location = new Point(137, 146);
			tbSub2.Name = "tbSub2";
			tbSub2.Size = new Size(200, 39);
			tbSub2.TabIndex = 11;
			// 
			// tbHours
			// 
			tbHours.Location = new Point(151, 80);
			tbHours.Name = "tbHours";
			tbHours.Size = new Size(200, 39);
			tbHours.TabIndex = 13;
			// 
			// tbSub3
			// 
			tbSub3.Location = new Point(144, 27);
			tbSub3.Name = "tbSub3";
			tbSub3.Size = new Size(200, 39);
			tbSub3.TabIndex = 14;
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Location = new Point(43, 41);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(1223, 785);
			tabControl1.TabIndex = 15;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(lbSalary);
			tabPage1.Controls.Add(tbSalary);
			tabPage1.Controls.Add(panelStudent);
			tabPage1.Controls.Add(panelAdmin);
			tabPage1.Controls.Add(panelTeacher);
			tabPage1.Controls.Add(tbPhone);
			tabPage1.Controls.Add(btnAdd);
			tabPage1.Controls.Add(tbEmail);
			tabPage1.Controls.Add(label6);
			tabPage1.Controls.Add(label1);
			tabPage1.Controls.Add(cbRole);
			tabPage1.Controls.Add(label3);
			tabPage1.Controls.Add(tbName);
			tabPage1.Controls.Add(label2);
			tabPage1.Location = new Point(8, 46);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(1207, 731);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Add data";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// lbSalary
			// 
			lbSalary.AutoSize = true;
			lbSalary.Location = new Point(70, 560);
			lbSalary.Name = "lbSalary";
			lbSalary.Size = new Size(77, 32);
			lbSalary.TabIndex = 18;
			lbSalary.Text = "Salary";
			// 
			// panelStudent
			// 
			panelStudent.Controls.Add(tbSub3);
			panelStudent.Controls.Add(label9);
			panelStudent.Location = new Point(440, 392);
			panelStudent.Name = "panelStudent";
			panelStudent.Size = new Size(400, 200);
			panelStudent.TabIndex = 23;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(25, 34);
			label9.Name = "label9";
			label9.Size = new Size(113, 32);
			label9.TabIndex = 23;
			label9.Text = "Subject 3";
			// 
			// panelAdmin
			// 
			panelAdmin.Controls.Add(cbType);
			panelAdmin.Controls.Add(label10);
			panelAdmin.Controls.Add(tbHours);
			panelAdmin.Controls.Add(label5);
			panelAdmin.Location = new Point(34, 331);
			panelAdmin.Name = "panelAdmin";
			panelAdmin.Size = new Size(400, 200);
			panelAdmin.TabIndex = 22;
			// 
			// cbType
			// 
			cbType.FormattingEnabled = true;
			cbType.Items.AddRange(new object[] { "Full-Time", "Part-Time" });
			cbType.Location = new Point(127, 14);
			cbType.Name = "cbType";
			cbType.Size = new Size(242, 40);
			cbType.TabIndex = 24;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(49, 80);
			label10.Name = "label10";
			label10.Size = new Size(77, 32);
			label10.TabIndex = 24;
			label10.Text = "Hours";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(49, 14);
			label5.Name = "label5";
			label5.Size = new Size(65, 32);
			label5.TabIndex = 19;
			label5.Text = "Type";
			// 
			// panelTeacher
			// 
			panelTeacher.Controls.Add(tbSub2);
			panelTeacher.Controls.Add(label7);
			panelTeacher.Controls.Add(label8);
			panelTeacher.Controls.Add(tbSub1);
			panelTeacher.Location = new Point(34, 331);
			panelTeacher.Name = "panelTeacher";
			panelTeacher.Size = new Size(400, 200);
			panelTeacher.TabIndex = 21;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(18, 85);
			label7.Name = "label7";
			label7.Size = new Size(113, 32);
			label7.TabIndex = 21;
			label7.Text = "Subject 1";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(18, 149);
			label8.Name = "label8";
			label8.Size = new Size(113, 32);
			label8.TabIndex = 22;
			label8.Text = "Subject 2";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(57, 263);
			label6.Name = "label6";
			label6.Size = new Size(60, 32);
			label6.TabIndex = 20;
			label6.Text = "Role";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(56, 43);
			label1.Name = "label1";
			label1.Size = new Size(78, 32);
			label1.TabIndex = 15;
			label1.Text = "Name";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(56, 189);
			label3.Name = "label3";
			label3.Size = new Size(71, 32);
			label3.TabIndex = 17;
			label3.Text = "Email";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(56, 115);
			label2.Name = "label2";
			label2.Size = new Size(177, 32);
			label2.TabIndex = 16;
			label2.Text = "Phone Number";
			label2.Click += label2_Click;
			// 
			// tabPage2
			// 
			tabPage2.Location = new Point(8, 46);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(1207, 731);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "View data";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(2443, 852);
			Controls.Add(tabControl1);
			Controls.Add(dataGridView1);
			Controls.Add(btnDelete);
			Controls.Add(btnEdit);
			Controls.Add(btnView);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			tabPage1.PerformLayout();
			panelStudent.ResumeLayout(false);
			panelStudent.PerformLayout();
			panelAdmin.ResumeLayout(false);
			panelAdmin.PerformLayout();
			panelTeacher.ResumeLayout(false);
			panelTeacher.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private ComboBox cbRole;
		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox tbEmail;
		private Button btnAdd;
		private Button btnView;
		private Button btnEdit;
		private Button btnDelete;
		private DataGridView dataGridView1;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column4;
		private TextBox tbSalary;
		private TextBox tbHours;
		private TextBox tbSub3;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem addDataToolStripMenuItem;
		private ToolStripMenuItem viewToolStripMenuItem;
		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private Label label6;
		private Label label5;
		private Label lbSalary;
		private Label label3;
		private Label label2;
		private Label label1;
		private Label label10;
		private Label label9;
		private Label label8;
		private Label label7;
		private Panel panelStudent;
		private Panel panelAdmin;
		private Panel panelTeacher;
		private ComboBox cbType;
	}
}
