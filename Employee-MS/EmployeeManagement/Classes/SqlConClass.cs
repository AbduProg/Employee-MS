

using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeManagement.Properties;

namespace EmployeeManagement
{

   
    class SqlConClass
    {

        public static string sqlQuery;
        public static bool msgException;

        SqlConnection con;

        public SqlConClass()
        {
           
            con = new SqlConnection($"Data Source={Settings.Default.Server};Initial Catalog= {Settings.Default.Database}; Integrated Security=False;User ID= {Settings.Default.SQLLogin}; Password= {Settings.Default.SQLPassword};");
        }

        public  DataSet selectData(string command, int type, SqlParameter[] parameters)
        {


            SqlDataAdapter da;
            DataSet ds = new DataSet();

            SqlCommand cmd = new SqlCommand(command, con);

            if (!(parameters == null))
                cmd.Parameters.AddRange(parameters);

            if (type == 1)
                cmd.CommandType = CommandType.StoredProcedure;


            try
            {
                con.Open();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                if (VariablesClass.isMessageBoxOpen == false)
                {
                    VariablesClass.isMessageBoxOpen = true;
                    MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    VariablesClass.isMessageBoxOpen = false;
                }
            }
            return ds;
        }

        

        public int cmdExecute(string command, int type, SqlParameter[] parameters)
        {
            int saveState = -1;
            int rowsAffected = 0;

            var cmd = new SqlCommand(command, con);

            if (type == 1)
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@saveState", SqlDbType.Int).Direction = ParameterDirection.Output;
            }

            if (!(parameters == null))
            {
                foreach (SqlParameter p in parameters)
                    if (p.Value == null)
                    {
                        p.SqlDbType = SqlDbType.VarBinary;
                        p.Value = DBNull.Value;
                    }

                cmd.Parameters.AddRange(parameters);
            }

            try
            {
                con.Open();
                rowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (type == 1)
                {
                    saveState = Convert.ToInt32(cmd.Parameters["@saveState"].Value.ToString());

                    switch (saveState)
                    {
                        case 1: // if
                            {
                                FunctionsClass.MsgTool("تم الحفظ بنجاح", 1);
                                break;
                            }
                        case 2:  // else if
                            {
                                FunctionsClass.MsgTool("لم يتم الحفظ، تكرار في البيانات، أو قيد الاستخدام", 2);
                                break;
                            }
                        case 3:
                            {
                                FunctionsClass.MsgTool("تم ارسال البيانات الى سلة المحذوفات ", 2);
                                break;
                            }
                        case 4:
                            {
                                FunctionsClass.MsgTool("تم الحذف بنجاح ", 1);
                                break;
                            }
                        case 0:
                            {
                                FunctionsClass.MsgTool("لم يتم الحفظ، خطأ في تنفيذ العملية", 0);
                                break;
                            }

                    }
                }

                else if (type == 0)
                {
                    saveState = rowsAffected;

                    switch (saveState)
                    {
                        case var @case when @case > 0:  // if
                            {
                                if (msgException == true)
                                    msgException = false;
                                else
                                    FunctionsClass.MsgTool("تم الحفظ بنجاح", 1);
                                break;
                            }

                        default: // else
                            {
                                FunctionsClass.MsgTool("لم يتم الحفظ، تكرار في البيانات ", 0);
                                break;
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                con.Close();
                if (VariablesClass.isMessageBoxOpen == false)
                {
                    VariablesClass.isMessageBoxOpen = true;
                    MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    VariablesClass.isMessageBoxOpen = false;
                }
            }

            return saveState;
        }
        public DataSet cmdExecute(string command, SqlParameter[] parameters)
        {
            VariablesClass.Save = -1;
            SqlDataAdapter da;
            var ds = new DataSet();

            var cmd = new SqlCommand(command, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@saveState", SqlDbType.Int).Direction = ParameterDirection.Output;

            if (!(parameters == null))
            {
                foreach (SqlParameter p in parameters)
                    if (p.Value == null)
                    {
                        p.SqlDbType = SqlDbType.VarBinary;
                        p.Value = DBNull.Value;
                    }
                cmd.Parameters.AddRange(parameters);
            }

            try
            {
                con.Open();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);                  // int RowsCount  = da.Fill(ds);
                con.Close();

                VariablesClass.Save = Convert.ToInt32(cmd.Parameters["@saveState"].Value.ToString());
                switch (VariablesClass.Save)
                {
                    case 1:
                        {
                            FunctionsClass.MsgTool("تم الحفظ بنجاح", 1);
                            break;
                        }
                    case 2:
                        {
                            FunctionsClass.MsgTool("لم يتم الحفظ، تكرار في البيانات  ", 0);
                            break;
                        }
                    case 3:
                        {
                            FunctionsClass.MsgTool("تم ارسال البيانات الى سلة المحذوفات ", 2);
                            break;
                        }
                    case 4:
                        {
                            FunctionsClass.MsgTool("تم الحذف بنجاح ", 1);
                            break;
                        }
                    case 0:
                        {
                            FunctionsClass.MsgTool("لم يتم الحفظ، خطأ في تنفيذ العملية", 0);
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                con.Close();
                if (VariablesClass.isMessageBoxOpen == false)
                {
                    VariablesClass.isMessageBoxOpen = true;
                    MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    VariablesClass.isMessageBoxOpen = false;
                }
            }

            return ds;

        }
        public void TestCon(string command, SqlParameter[] parameters, string server, string sqlUser, string sqlPassword)
        {
            SqlDataAdapter da;
            var ds = new DataSet();

            SqlConnection testCon = new SqlConnection("Data Source=" + server +
             ";Initial Catalog=master;Integrated Security=False;User Id=" + sqlUser + ";Password=" + sqlPassword + ";");

            SqlCommand cmd = new SqlCommand(command, testCon);
            if (!(parameters == null))
                cmd.Parameters.AddRange(parameters);
            try
            {
                testCon.Open();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                testCon.Close();

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Database Name is not found", "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("The Connection Is True", "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                testCon.Close();
                MessageBox.Show("Error in Settings Of System Conncetion" + Environment.NewLine + Environment.NewLine + ex.Message, "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public int BackupDatabase(string command)
        {
            int saveState = 0;
            var cmd = new SqlCommand(command, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                saveState = 1;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("فشل في عمل نسخة احتياطية من قاعدة البيانات" + Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return saveState;
        }


        


    }
}
