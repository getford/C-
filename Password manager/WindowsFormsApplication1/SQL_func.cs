using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class SQL_func
    {
        static public SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Database.mdf;Integrated Security=True");

        public static void Insert(string _userlogin, string _userpassword, string _reuserpassword, string _useremail, string _userfirstname, string _userlastname, string _userfirstqst, string _userfirstansw, string _usersecoundqsr, string _usersecoungansw)
        {
            try
            {
                //open symmetric key SYMMETRIC_KEY decryption by asymmetric key ASYMMETRIC_KEY with password = '%(wbwgoo$';
                connect.Open();
                string sql_query = string.Format("open symmetric key SYMMETRIC_KEY decryption by asymmetric key ASYMMETRIC_KEY with password = '%(wbwgoo$'; declare @Symmetric_key_GUID as [uniqueidentifier] set @Symmetric_key_GUID = KEY_GUID('SYMMETRIC_KEY') if (@Symmetric_key_GUID is not null) begin INSERT INTO [dbo].[introduce] VALUES (@user_login, ENCRYPTBYKEY(@Symmetric_key_GUID, @user_password), ENCRYPTBYKEY(@Symmetric_key_GUID, @user_re_password), @user_e_mail, @user_first_name, @user_last_name, @user_first_question, ENCRYPTBYKEY(@Symmetric_key_GUID, @user_first_answer), @user_secound_question, ENCRYPTBYKEY(@Symmetric_key_GUID, @user_secound_answer)) end");
                SqlCommand commandInsert = new SqlCommand(sql_query, connect);
                commandInsert.Parameters.AddWithValue(@"user_login", _userlogin);
                commandInsert.Parameters.AddWithValue(@"user_password", _userpassword);
                commandInsert.Parameters.AddWithValue(@"user_re_password", _reuserpassword);
                commandInsert.Parameters.AddWithValue(@"user_e_mail", _useremail);
                commandInsert.Parameters.AddWithValue(@"user_first_name", _userfirstname);
                commandInsert.Parameters.AddWithValue(@"user_last_name", _userlastname);
                commandInsert.Parameters.AddWithValue(@"user_first_question", _userfirstqst);
                commandInsert.Parameters.AddWithValue(@"user_first_answer", _userfirstansw);
                commandInsert.Parameters.AddWithValue(@"user_secound_question", _usersecoundqsr);
                commandInsert.Parameters.AddWithValue(@"user_secound_answer", _usersecoungansw);
                commandInsert.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connect.Close();
            }
        }
    }
}
