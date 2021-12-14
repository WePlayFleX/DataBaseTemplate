using System;
using System.Data.SqlClient;
using System.Data;

namespace DataBaseTemplate.Inserters
{
    internal abstract class Inserter
    {
        const string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = DataBaseTemplateOne; 
                                   Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;
                                    ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public abstract string GenerateQueryInsert();

        internal void Insert()
        {
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                try
                {
                    sqlConnection.ConnectionString = conString;
                    sqlConnection.Open();

                    
                    var command = sqlConnection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = GenerateQueryInsert();
                    var count = command.ExecuteNonQuery();

                    if (count > 0)
                    {
                        Console.WriteLine("Ok!");
                    }
                    

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
