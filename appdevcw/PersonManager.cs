using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;

namespace appdevcw
{
	internal class PersonManager
	{
		private string connStr = @"Data Source=LAPTOP-3B9MQHTP\SQLEXPRESS;Initial Catalog=EducationDB;Integrated Security=True;Encrypt=False";

		// ADD DATA FEATURE
		public void AddPerson(Person p)
		{
			using var conn = new SqlConnection(connStr);
			conn.Open();
			using var tran = conn.BeginTransaction();

			try
			{
				if (p is Teacher t)
					AddTeacher(t, conn, tran);
				else if (p is Student s)
					AddStudent(s, conn, tran);
				else if (p is Admin a)
					AddAdmin(a, conn, tran);
				else
					throw new InvalidOperationException("Unknown person type");

				tran.Commit();
			}
			catch
			{
				tran.Rollback();
				throw;
			}
		}
		private void AddTeacher(Teacher t, SqlConnection conn, SqlTransaction tran)
		{
			string query = @"INSERT INTO Teacher (name, telephone, email, salary) OUTPUT INSERTED.teacherID VALUES (@name, @phone, @email, @salary)";
			using var cmd = new SqlCommand(query, conn, tran);

			cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = t.Name;
			cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = t.Phone;
			cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = t.Email;
			cmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = t.Salary;

			int teacherID = (int)cmd.ExecuteScalar();

			foreach (var s in new[] { t.Subject1, t.Subject2 })
			{
				int subID = GetOrCreateSubjectID(s, conn, tran);

				string insertQuery = "INSERT INTO TeacherSubject VALUES (@tID, @sID)";
				using var insertCmd = new SqlCommand(insertQuery, conn);
				insertCmd.Parameters.Add("@tID", SqlDbType.Int).Value = teacherID;
				insertCmd.Parameters.Add("@sID", SqlDbType.Int).Value = subID;

				insertCmd.ExecuteNonQuery();
			}
		}
		private void AddAdmin(Admin a, SqlConnection conn, SqlTransaction tran)
		{
			string query = @"INSERT INTO Admin (name, telephone, email, salary, worktype, workhours) VALUES (@name, @phone, @email, @salary, @type, @hours)";
			using var cmd = new SqlCommand(query, conn, tran);

			cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = a.Name;
			cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = a.Phone;
			cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = a.Email;
			cmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = a.Salary;
			cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = a.EmploymentType;
			cmd.Parameters.Add("@hours", SqlDbType.Int).Value = a.WorkingHours;

			cmd.ExecuteNonQuery();
		}
		private void AddStudent(Student s, SqlConnection conn, SqlTransaction tran)
		{
			string query = @"INSERT INTO Student (name, telephone, email) OUTPUT INSERTED.studentID VALUES (@name, @phone, @email)";
			using var cmd = new SqlCommand(query, conn, tran);

			cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = s.Name;
			cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = s.Phone;
			cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = s.Email;

			int studentID = (int)cmd.ExecuteScalar();

			foreach (var sub in s.Subjects)
			{
				int subID = GetOrCreateSubjectID(sub, conn, tran);

				string insert = "INSERT INTO StudentSubject VALUES (@sID, @subID)";
				using var cmd2 = new SqlCommand(insert, conn, tran);
				cmd2.Parameters.Add("@sID", SqlDbType.Int).Value = studentID;
				cmd2.Parameters.Add("@subID", SqlDbType.Int).Value = subID;

				cmd2.ExecuteNonQuery();
			}
		}
		private int GetOrCreateSubjectID(string name, SqlConnection conn, SqlTransaction tran)
		{
			string query = "SELECT subjectID FROM Subject WHERE subjectname = @name";
			using var cmd = new SqlCommand(query, conn, tran);
			cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;

			object result = cmd.ExecuteScalar();

			if (result != null)
				return (int)result;

			string insertQuery = @"INSERT INTO Subject (subjectname) OUTPUT INSERTED.subjectID VALUES (@name)";
			using var insertCmd = new SqlCommand(insertQuery, conn, tran);
			insertCmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;

			return (int)insertCmd.ExecuteScalar();
		}

		// VIEW DATA FEATURE
		public DataTable ViewAll()
		{
			using var conn = new SqlConnection(connStr);
			conn.Open();

			string query = @"SELECT * FROM (
			SELECT t.teacherID AS id, t.name, t.telephone, t.email, 'teacher' AS role, t.salary, STRING_AGG(s.subjectname, ' | ') AS subjects, 'N/A' AS worktype, 0 AS workhours FROM Teacher t
			LEFT JOIN TeacherSubject ts ON t.teacherID = ts.teacherID
			LEFT JOIN Subject s ON ts.subjectID = s.subjectID
			GROUP BY t.teacherID, t.name, t.telephone, t.email, t.salary
			UNION ALL

			SELECT adminID AS id, name, telephone, email, 'admin' AS role, salary, 'N/A' AS subjects, worktype, workhours FROM Admin UNION ALL

			SELECT st.studentID AS id, st.name, st.telephone, st.email, 'student' AS role, 0 AS salary, STRING_AGG(s.subjectname, ' | ') AS subjects, 'N/A' AS worktype, 0 AS workhours FROM Student st
			LEFT JOIN StudentSubject ss ON st.studentID = ss.studentID
			LEFT JOIN Subject s ON ss.subjectID = s.subjectID
			GROUP BY st.studentID, st.name, st.telephone, st.email
			) AS AllUsers ORDER BY name;";

			using var cmd = new SqlCommand(query, conn);
			using var reader = cmd.ExecuteReader();

			DataTable dt = new DataTable();
			dt.Load(reader);

			return dt;
		}
		public DataTable ViewByRole(string role)
		{
			using var conn = new SqlConnection(connStr);
			conn.Open();

			string query = "";

			if (role == "teacher")
			{
				query = @"SELECT t.teacherID AS id, t.name, t.telephone, t.email, t.salary, STRING_AGG(s.subjectname, ' | ') AS subjects, 'N/A' AS worktype, 0 AS workhours, 'teacher' AS role FROM Teacher t
				LEFT JOIN TeacherSubject ts ON t.teacherID = ts.teacherID
				LEFT JOIN Subject s ON ts.subjectID = s.subjectID
				GROUP BY t.teacherID, t.name, t.telephone, t.email, t.salary";
			}
			else if (role == "student")
			{
				query = @"SELECT st.studentID AS id, st.name, st.telephone, st.email, 0 AS salary, STRING_AGG(s.subjectname, ' | ') AS subjects, 'N/A' AS worktype, 0 AS workhours, 'student' AS role FROM Student st
					LEFT JOIN StudentSubject ss ON st.studentID = ss.studentID
					LEFT JOIN Subject s ON ss.subjectID = s.subjectID
					GROUP BY st.studentID, st.name, st.telephone, st.email";
			}
			else if (role == "admin")
			{
				query = @"SELECT adminID AS id, name, telephone, email, salary, 'N/A' AS subjects, worktype, workhours, 'admin' AS role FROM Admin";
			}

			using var cmd = new SqlCommand(query, conn);
			using var reader = cmd.ExecuteReader();

			DataTable dt = new DataTable();
			dt.Load(reader);

			return dt;
		}

		// EDIT DATA FEATURE
		public void UpdatePerson(int id, string role, Person p)
		{
			using var conn = new SqlConnection(connStr);
			conn.Open();

			using var tran = conn.BeginTransaction();

			try
			{
				if (role == "teacher" && p is Teacher t)
				{
					string query = @"UPDATE Teacher SET name=@name, telephone=@phone, email=@email, salary=@salary WHERE teacherID=@id";
					using var cmd = new SqlCommand(query, conn, tran);
					
					cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = t.Name;
					cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = t.Phone;
					cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = t.Email;
					cmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = t.Salary;
					cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

					cmd.ExecuteNonQuery();

					// Delete old subjects
					string query2 = @"DELETE FROM TeacherSubject WHERE teacherID=@id";
					using var cmd2 = new SqlCommand(query2, conn, tran);

					cmd2.Parameters.Add("@id", SqlDbType.Int).Value = id;
					
					cmd2.ExecuteNonQuery();

					// Insert new subjects
					foreach (var s in new[] { t.Subject1, t.Subject2 })
					{
						int subID = GetOrCreateSubjectID(s, conn, tran);

						string query3 = @"INSERT INTO TeacherSubject VALUES (@tID,@sID)"; //cmt.cmd, cm2, cm3, it's okay?
						using var cmd3 = new SqlCommand(query3, conn, tran);

						cmd3.Parameters.Add("@tID", SqlDbType.Int).Value = id;
						cmd3.Parameters.Add("@sID", SqlDbType.Int).Value = subID;

						cmd3.ExecuteNonQuery();
					}
				}

				else if (role == "student" && p is Student s)
				{
					string query = @"UPDATE Student SET name=@name, telephone=@phone, email=@email WHERE studentID=@id";
					using var cmd = new SqlCommand(query, conn, tran);

					cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = s.Name;
					cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = s.Phone;
					cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = s.Email;
					cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

					cmd.ExecuteNonQuery();

					string query2 = @"DELETE FROM StudentSubject WHERE studentID=@id";
					using var cmd2 = new SqlCommand(query2, conn, tran);

					cmd2.Parameters.Add("@id", SqlDbType.Int).Value = id;

					cmd2.ExecuteNonQuery();

					foreach (var sub in s.Subjects)
					{
						int subID = GetOrCreateSubjectID(sub, conn, tran);

						string query3 = @"INSERT INTO StudentSubject VALUES (@sID,@subID)";
						using var cmd3 = new SqlCommand(query3, conn, tran);

						cmd3.Parameters.Add("@sID", SqlDbType.Int).Value = id;
						cmd3.Parameters.Add("@subID", SqlDbType.Int).Value = subID;

						cmd3.ExecuteNonQuery();
					}
				}

				else if (role == "admin" && p is Admin a)
				{
					string query = @"UPDATE Admin SET name=@name, telephone=@phone, email=@email, salary=@salary, worktype=@type, workhours=@hours WHERE adminID=@id";
					using var cmd = new SqlCommand(query, conn, tran);

					cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = a.Name;
					cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = a.Phone;
					cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = a.Email;
					cmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = a.Salary;
					cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = a.EmploymentType;
					cmd.Parameters.Add("@hours", SqlDbType.VarChar).Value = a.WorkingHours;
					cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

					cmd.ExecuteNonQuery();
				}

				tran.Commit();
			}
			catch
			{
				tran.Rollback();
				throw;
			}
		}

		// DELETE DATA FEATURE
		public void DeletePerson(int id, string role)
		{
			using var conn = new SqlConnection(connStr);
			conn.Open();

			using var tran = conn.BeginTransaction();

			try
			{
				if (role == "teacher")
				{
					// delete subjects (no need to check)
					using var cmd = new SqlCommand(
						"DELETE FROM TeacherSubject WHERE teacherID = @id", conn, tran);
					cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
					cmd.ExecuteNonQuery();

					// delete teacher (MUST check)
					using var cmd2 = new SqlCommand(
						"DELETE FROM Teacher WHERE teacherID = @id", conn, tran);
					cmd2.Parameters.Add("@id", SqlDbType.Int).Value = id;

					int rows = cmd2.ExecuteNonQuery();

					if (rows == 0)
						throw new Exception("Delete failed: Teacher not found.");
				}
				else if (role == "student")
				{
					using var cmd = new SqlCommand(
						"DELETE FROM StudentSubject WHERE studentID = @id", conn, tran);
					cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
					cmd.ExecuteNonQuery();

					using var cmd2 = new SqlCommand(
						"DELETE FROM Student WHERE studentID = @id", conn, tran);
					cmd2.Parameters.Add("@id", SqlDbType.Int).Value = id;

					int rows = cmd2.ExecuteNonQuery();

					if (rows == 0)
						throw new Exception("Delete failed: Student not found.");
				}
				else if (role == "admin")
				{
					using var cmd = new SqlCommand(
						"DELETE FROM Admin WHERE adminID = @id", conn, tran);
					cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

					int rows = cmd.ExecuteNonQuery();

					if (rows == 0)
						throw new Exception("Delete failed: Admin not found.");
				}
				else
				{
					throw new InvalidOperationException("Invalid role!");
				}

				tran.Commit();
			}
			catch
			{
				tran.Rollback();
				throw;
			}
		}
	}
}
