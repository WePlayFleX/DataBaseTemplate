using System;
using System.Data.SqlClient;

namespace DataBaseTemplate.Selecters
{
    class AuthorsSelecter : Selecter
    {
        public override string GenerateQuerySelect()
        {
            return "Select * From Authors";
        }

        public override void Print(SqlDataReader reader)
        {
            while (reader.Read())
            {
                var id = reader.GetInt32(0);
                var firstName = reader.GetString(1);
                var lastName = reader.GetString(2);
                var printText = $"{id}\t{firstName}\t{lastName}";
                Console.WriteLine(printText);
            }
        }
        
    }
}
