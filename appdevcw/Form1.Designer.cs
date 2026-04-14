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
		private System.Windows.Forms.TextBox tbTelephone;
		private System.Windows.Forms.TextBox tbSub1;
		private System.Windows.Forms.TextBox tbSub2;
		private void InitializeComponent()
		{
			cbRole = new ComboBox();
			tbName = new TextBox();
			tbTelephone = new TextBox();
			tbEmail = new TextBox();
			btnAdd = new Button();
			btnView = new Button();
			btnEdit = new Button();
			btnDelete = new Button();
			dataGridView1 = new DataGridView();
			no = new DataGridViewTextBoxColumn();
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
			panelEdit = new Panel();
			btnCancel = new Button();
			panel3 = new Panel();
			tbEditSub2 = new TextBox();
			label18 = new Label();
			label19 = new Label();
			tbEditSub1 = new TextBox();
			btnSave = new Button();
			label11 = new Label();
			tbEditSalary = new TextBox();
			panel1 = new Panel();
			tbEditSub3 = new TextBox();
			label4 = new Label();
			panel2 = new Panel();
			cbEditType = new ComboBox();
			label12 = new Label();
			tbEditHours = new TextBox();
			label13 = new Label();
			tbEditPhone = new TextBox();
			tbEditEmail = new TextBox();
			label15 = new Label();
			label16 = new Label();
			tbEditName = new TextBox();
			label17 = new Label();
			cbViewRole = new ComboBox();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			panelStudent.SuspendLayout();
			panelAdmin.SuspendLayout();
			panelTeacher.SuspendLayout();
			tabPage2.SuspendLayout();
			panelEdit.SuspendLayout();
			panel3.SuspendLayout();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
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
			// tbTelephone
			// 
			tbTelephone.Location = new Point(250, 112);
			tbTelephone.Name = "tbTelephone";
			tbTelephone.Size = new Size(200, 39);
			tbTelephone.TabIndex = 2;
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
			btnView.Location = new Point(46, 48);
			btnView.Name = "btnView";
			btnView.Size = new Size(150, 46);
			btnView.TabIndex = 5;
			btnView.Text = "View";
			btnView.UseVisualStyleBackColor = true;
			btnView.Click += btnView_Click;
			// 
			// btnEdit
			// 
			btnEdit.Location = new Point(219, 48);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(150, 46);
			btnEdit.TabIndex = 6;
			btnEdit.Text = "Edit";
			btnEdit.UseVisualStyleBackColor = true;
			btnEdit.Click += btnEdit_Click;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(393, 48);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(150, 46);
			btnDelete.TabIndex = 7;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { no });
			dataGridView1.Location = new Point(22, 110);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 82;
			dataGridView1.Size = new Size(2263, 599);
			dataGridView1.TabIndex = 8;
			dataGridView1.CellClick += dataGridView1_CellClick;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// no
			// 
			no.HeaderText = "no.";
			no.MinimumWidth = 10;
			no.Name = "no";
			no.Width = 200;
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
			tabControl1.Size = new Size(2348, 969);
			tabControl1.TabIndex = 15;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(lbSalary);
			tabPage1.Controls.Add(tbSalary);
			tabPage1.Controls.Add(panelStudent);
			tabPage1.Controls.Add(panelAdmin);
			tabPage1.Controls.Add(panelTeacher);
			tabPage1.Controls.Add(tbTelephone);
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
			tabPage1.Size = new Size(2332, 915);
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
			panelStudent.Location = new Point(455, 331);
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
			panelAdmin.Location = new Point(470, 115);
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
			tabPage2.Controls.Add(panelEdit);
			tabPage2.Controls.Add(btnEdit);
			tabPage2.Controls.Add(btnDelete);
			tabPage2.Controls.Add(cbViewRole);
			tabPage2.Controls.Add(dataGridView1);
			tabPage2.Controls.Add(btnView);
			tabPage2.Location = new Point(8, 46);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(2332, 915);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "View data";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// panelEdit
			// 
			panelEdit.Controls.Add(btnCancel);
			panelEdit.Controls.Add(panel3);
			panelEdit.Controls.Add(btnSave);
			panelEdit.Controls.Add(label11);
			panelEdit.Controls.Add(tbEditSalary);
			panelEdit.Controls.Add(panel1);
			panelEdit.Controls.Add(panel2);
			panelEdit.Controls.Add(tbEditPhone);
			panelEdit.Controls.Add(tbEditEmail);
			panelEdit.Controls.Add(label15);
			panelEdit.Controls.Add(label16);
			panelEdit.Controls.Add(tbEditName);
			panelEdit.Controls.Add(label17);
			panelEdit.Location = new Point(1339, 19);
			panelEdit.Name = "panelEdit";
			panelEdit.Size = new Size(971, 819);
			panelEdit.TabIndex = 10;
			panelEdit.Visible = false;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(359, 728);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(150, 46);
			btnCancel.TabIndex = 38;
			btnCancel.Text = "  ";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click;
			// 
			// panel3
			// 
			panel3.Controls.Add(tbEditSub2);
			panel3.Controls.Add(label18);
			panel3.Controls.Add(label19);
			panel3.Controls.Add(tbEditSub1);
			panel3.Location = new Point(134, 424);
			panel3.Name = "panel3";
			panel3.Size = new Size(400, 200);
			panel3.TabIndex = 37;
			// 
			// tbEditSub2
			// 
			tbEditSub2.Location = new Point(137, 146);
			tbEditSub2.Name = "tbEditSub2";
			tbEditSub2.Size = new Size(200, 39);
			tbEditSub2.TabIndex = 11;
			// 
			// label18
			// 
			label18.AutoSize = true;
			label18.Location = new Point(18, 85);
			label18.Name = "label18";
			label18.Size = new Size(113, 32);
			label18.TabIndex = 21;
			label18.Text = "Subject 1";
			// 
			// label19
			// 
			label19.AutoSize = true;
			label19.Location = new Point(18, 149);
			label19.Name = "label19";
			label19.Size = new Size(113, 32);
			label19.TabIndex = 22;
			label19.Text = "Subject 2";
			// 
			// tbEditSub1
			// 
			tbEditSub1.Location = new Point(137, 85);
			tbEditSub1.Name = "tbEditSub1";
			tbEditSub1.Size = new Size(200, 39);
			tbEditSub1.TabIndex = 10;
			// 
			// btnSave
			// 
			btnSave.Location = new Point(553, 728);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(150, 46);
			btnSave.TabIndex = 28;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(183, 648);
			label11.Name = "label11";
			label11.Size = new Size(77, 32);
			label11.TabIndex = 33;
			label11.Text = "Salary";
			// 
			// tbEditSalary
			// 
			tbEditSalary.Location = new Point(285, 648);
			tbEditSalary.Name = "tbEditSalary";
			tbEditSalary.Size = new Size(200, 39);
			tbEditSalary.TabIndex = 29;
			// 
			// panel1
			// 
			panel1.Controls.Add(tbEditSub3);
			panel1.Controls.Add(label4);
			panel1.Location = new Point(553, 480);
			panel1.Name = "panel1";
			panel1.Size = new Size(400, 200);
			panel1.TabIndex = 36;
			// 
			// tbEditSub3
			// 
			tbEditSub3.Location = new Point(144, 27);
			tbEditSub3.Name = "tbEditSub3";
			tbEditSub3.Size = new Size(200, 39);
			tbEditSub3.TabIndex = 14;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(25, 34);
			label4.Name = "label4";
			label4.Size = new Size(113, 32);
			label4.TabIndex = 23;
			label4.Text = "Subject 3";
			// 
			// panel2
			// 
			panel2.Controls.Add(cbEditType);
			panel2.Controls.Add(label12);
			panel2.Controls.Add(tbEditHours);
			panel2.Controls.Add(label13);
			panel2.Location = new Point(553, 260);
			panel2.Name = "panel2";
			panel2.Size = new Size(400, 200);
			panel2.TabIndex = 35;
			// 
			// cbEditType
			// 
			cbEditType.FormattingEnabled = true;
			cbEditType.Items.AddRange(new object[] { "Full-Time", "Part-Time" });
			cbEditType.Location = new Point(127, 14);
			cbEditType.Name = "cbEditType";
			cbEditType.Size = new Size(242, 40);
			cbEditType.TabIndex = 24;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(49, 80);
			label12.Name = "label12";
			label12.Size = new Size(77, 32);
			label12.TabIndex = 24;
			label12.Text = "Hours";
			// 
			// tbEditHours
			// 
			tbEditHours.Location = new Point(151, 80);
			tbEditHours.Name = "tbEditHours";
			tbEditHours.Size = new Size(200, 39);
			tbEditHours.TabIndex = 13;
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(49, 14);
			label13.Name = "label13";
			label13.Size = new Size(65, 32);
			label13.TabIndex = 19;
			label13.Text = "Type";
			// 
			// tbEditPhone
			// 
			tbEditPhone.Location = new Point(363, 200);
			tbEditPhone.Name = "tbEditPhone";
			tbEditPhone.Size = new Size(200, 39);
			tbEditPhone.TabIndex = 26;
			// 
			// tbEditEmail
			// 
			tbEditEmail.Location = new Point(261, 277);
			tbEditEmail.Name = "tbEditEmail";
			tbEditEmail.Size = new Size(200, 39);
			tbEditEmail.TabIndex = 27;
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Location = new Point(169, 131);
			label15.Name = "label15";
			label15.Size = new Size(78, 32);
			label15.TabIndex = 30;
			label15.Text = "Name";
			// 
			// label16
			// 
			label16.AutoSize = true;
			label16.Location = new Point(169, 277);
			label16.Name = "label16";
			label16.Size = new Size(71, 32);
			label16.TabIndex = 32;
			label16.Text = "Email";
			// 
			// tbEditName
			// 
			tbEditName.Location = new Point(271, 128);
			tbEditName.Name = "tbEditName";
			tbEditName.Size = new Size(200, 39);
			tbEditName.TabIndex = 25;
			tbEditName.TextChanged += tbEditName_TextChanged;
			// 
			// label17
			// 
			label17.AutoSize = true;
			label17.Location = new Point(169, 203);
			label17.Name = "label17";
			label17.Size = new Size(177, 32);
			label17.TabIndex = 31;
			label17.Text = "Phone Number";
			// 
			// cbViewRole
			// 
			cbViewRole.FormattingEnabled = true;
			cbViewRole.Items.AddRange(new object[] { "All", "Teacher", "Admin", "Student" });
			cbViewRole.Location = new Point(967, 48);
			cbViewRole.Name = "cbViewRole";
			cbViewRole.Size = new Size(242, 40);
			cbViewRole.TabIndex = 9;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(2443, 1022);
			Controls.Add(tabControl1);
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
			tabPage2.ResumeLayout(false);
			panelEdit.ResumeLayout(false);
			panelEdit.PerformLayout();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private ComboBox cbRole;
		private TextBox tbEmail;
		private Button btnAdd;
		private Button btnView;
		private Button btnEdit;
		private Button btnDelete;
		private DataGridView dataGridView1;
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
		private DataGridViewTextBoxColumn no;
		private ComboBox cbViewRole;
		private Panel panelEdit;
		private Button btnCancel;
		private Panel panel3;
		private TextBox tbEditSub2;
		private Label label18;
		private Label label19;
		private TextBox tbEditSub1;
		private Button btnSave;
		private Label label11;
		private TextBox tbEditSalary;
		private Panel panel1;
		private TextBox tbEditSub3;
		private Label label4;
		private Panel panel2;
		private ComboBox cbEditType;
		private Label label12;
		private TextBox tbEditHours;
		private Label label13;
		private Label label15;
		private Label label16;
		private Label label17;
		private TextBox tbEditEmail;
		private TextBox tbEditPhone;
		private TextBox tbEditName;
	}
}
