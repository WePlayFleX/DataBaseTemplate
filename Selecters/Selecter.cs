using System;
using System.Data;
using System.Data.SqlClient;

namespace DataBaseTemplate.Selecters
{
    abstract class Selecter : BaseItem
    {
        public abstract string GenerateQuerySelect();

        public abstract void Print(SqlDataReader reader);
        public void Select()
        {
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                try
                {
                    sqlConnection.ConnectionString = conString;
                    sqlConnection.Open();


                    var command = sqlConnection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = GenerateQuerySelect();
                    var sql = command.ExecuteNonQuery();


                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
