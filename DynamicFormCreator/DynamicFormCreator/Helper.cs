using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace DynamicFormCreator
{
    public class Helper
    {
        public static bool IsFormNameExist(string formName)
        {
            try
            {
                SqlConnection cnn;
                bool isFormExist = false;

                cnn = new SqlConnection(Global.ConnectionString);
                cnn.Open();

                SqlCommand command;
                SqlDataReader dataReader;
                String sql;

                sql = string.Format(@"
                         SELECT *
            FROM FormDirectory
            WHERE FormName = N'{0}';", formName);

                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    isFormExist = true;
                }

                cnn.Close();
                return isFormExist;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
        }

        public static void AddToFormDirectory(string formName, string controlName, string controlType, string controlOptions, string controlValueLimit)
        {
            try
            {
                SqlConnection cnn;

                cnn = new SqlConnection(Global.ConnectionString);
                cnn.Open();

                SqlCommand command;
                SqlDataReader dataReader;
                String sql;

                sql = string.Format(@"
                         INSERT INTO FormDirectory(FormName, ControlName, ControlType, ControlOptions, DBName, ControlValueLimit)
                            VALUES ('{0}', '{1}', '{2}', '{3}', '{0}', '{4}');", formName, controlName, controlType, controlOptions, controlValueLimit);

                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    // do something
                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }


        public static void CreateNewTable(string formName, CheckedListBox.ObjectCollection controlsAdded)
        {
            try
            {
                SqlConnection cnn;

                cnn = new SqlConnection(Global.ConnectionString);
                cnn.Open();

                SqlCommand command;
                SqlDataReader dataReader;
                String sql;

                sql = string.Format("CREATE TABLE {0}(", formName);
                int itr = 0;
                foreach (string item in controlsAdded)
                {
                    itr++;

                    string dataType = "";
                    string[] data = item.Split('|');

                    string controlName = data[0].Trim();
                    string controlType = data[1].Trim();
                    string controlOption = data[2].Trim();
                    string controlValLimit = data[3].Trim();

                    if (data[1].Trim() == "TextBox-FreeText")
                        dataType = "varchar(100)";
                    else if (data[1].Trim() == "TextBox-Numeric")
                        dataType = "int";
                    else if (data[1].Trim() == "DatePicker")
                        dataType = "varchar(150)";
                    else if (data[1].Trim() == "ComboBox")
                        dataType = "varchar(150)";
                    else if (data[1].Trim() == "RadioButton")
                        dataType = "varchar(150)";


                    sql += string.Format("{0} {1}", controlName, dataType);
                    if (itr != controlsAdded.Count) // not last item
                    {
                        sql += ",";
                    }
                }
                sql += ");";



                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    // do something
                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        public static List<string> GetListOfForms()
        {
            try
            {
                List<string> formList = new List<string>();
                SqlConnection cnn;

                cnn = new SqlConnection(Global.ConnectionString);
                cnn.Open();

                SqlCommand command;
                SqlDataReader dataReader;
                String sql;

                sql = @"SELECT DISTINCT FormName FROM FormDirectory";

                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    var formName = dataReader.GetValue(0);
                    formList.Add(formName.ToString());
                }

                cnn.Close();

                return formList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new List<string>();
            }
        }

        public static List<FormDirectory> GetFormControls(string formName)
        {
            try
            {
                List<FormDirectory> formControls = new List<FormDirectory>();
                SqlConnection cnn;

                cnn = new SqlConnection(Global.ConnectionString);
                cnn.Open();

                SqlCommand command;
                SqlDataReader dataReader;
                String sql;

                sql = string.Format(@"select * from FormDirectory where FormName = '{0}'", formName);

                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    formControls.Add(new FormDirectory()
                    {
                        FormName = dataReader["FormName"].ToString(),
                        ControlName = dataReader["ControlName"].ToString(),
                        ControlType = dataReader["ControlType"].ToString(),
                        ControlOptions = dataReader["ControlOptions"].ToString(),
                        DBName = dataReader["DBName"].ToString(),
                        ControlValueLimit = dataReader["ControlValueLimit"].ToString()
                    });
                }

                cnn.Close();
                return formControls;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new List<FormDirectory>();
            }
        }

        public static void InsertFormData(string formName, string columns, string values)
        {
            try
            {
                SqlConnection cnn;

                cnn = new SqlConnection(Global.ConnectionString);
                cnn.Open();

                SqlCommand command;
                SqlDataReader dataReader;
                String sql;

                sql = string.Format(@"
                         INSERT INTO {0}({1})
                            VALUES ({2})", formName, columns, values);

                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    // do something
                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        public static DataTable GetFormData(string formName)
        {
            try
            {

                SqlConnection cnn;
                DataTable dt = new DataTable();

                cnn = new SqlConnection(Global.ConnectionString);
                cnn.Open();

                SqlCommand command;
                SqlDataReader dataReader;
                String sql;

                sql = string.Format(@"
                         SELECT * FROM {0}", formName);

                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();

                dt.Load(dataReader);

                //while (dataReader.Read())
                //{
                //    // do something
                //}

                cnn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new DataTable();
            }
        }

        public static void DeleteFormData(string formName)
        {
            try
            {
                SqlConnection cnn;

                cnn = new SqlConnection(Global.ConnectionString);
                cnn.Open();

                SqlCommand command;
                SqlDataReader dataReader;
                String sql;

                sql = string.Format(@"
                         DELETE FROM FormDirectory WHERE FormName='{0}';", formName);

                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    // do something
                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }


        public static void DropTable(string formName)
        {
            try
            {
                SqlConnection cnn;

                cnn = new SqlConnection(Global.ConnectionString);
                cnn.Open();

                SqlCommand command;
                SqlDataReader dataReader;
                String sql;

                sql = string.Format(@"
                         DROP TABLE {0};", formName);

                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    // do something
                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        public static void Connect(string connectionString)
        {
            try
            {
                SqlConnection cnn;

                cnn = new SqlConnection(Global.ConnectionString);
                cnn.Open();

                MessageBox.Show("Successfully Connected!");

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Connection Failed: {0}", ex.Message));
                return;
            }
        }

        public static void CreateFormBuilderDB()
        {
            try
            {
                SqlConnection cnn;

                cnn = new SqlConnection("Server=.;Integrated security=SSPI;database=master");
                cnn.Open();

                SqlCommand command;
                SqlDataReader dataReader;
                String sql;

                sql = @"CREATE DATABASE FormBuilder;";

                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();

                MessageBox.Show("FormBuilder DB has been Successfully Created");

                while (dataReader.Read())
                {
                    // do something
                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        public static void CreateFormDirectoryTable()
        {
            try
            {
                SqlConnection cnn;

                cnn = new SqlConnection(Global.ConnectionString);
                cnn.Open();

                SqlCommand command;
                SqlDataReader dataReader;
                String sql;

                sql = @"CREATE TABLE FormDirectory(
                        FormName varchar(100) NOT NULL,
                        ControlName varchar(100) NOT NULL,
                        ControlType varchar(100) NOT NULL,
                        ControlOptions varchar(max) NOT NULL,
                        DBName varchar(100) NOT NULL,
                        ControlValueLimit varchar(100) NOT NULL
                        );";

                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();

                MessageBox.Show("FormDirectory Table has been Successfully Created");

                while (dataReader.Read())
                {
                    // do something
                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
