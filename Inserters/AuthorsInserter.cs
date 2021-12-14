using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseTemplate.Inserters
{
    internal class AuthorsInserter : Inserter
    {
        public AuthorsInserter(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        internal int Id { get; }
        internal string FirstName { get;  }
        internal string LastName { get;  }

        public override string GenerateQueryInsert()
        {
            string query = $"INSERT INTO Authors (Id, FirstName, LastName) VALUES ({Id}, '{FirstName}', '{LastName}') ";
            return query;
        }
    }
}
