using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseTemplate.Inserters;
using DataBaseTemplate.Selecters;

namespace DataBaseTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Inserter inserterAuthors = new AuthorsInserter(
                1,
                "Fill",
                "Baxly");
            //inserterAuthors.FirstName = "One";
            //inserterAuthors.LastName = "Two";
            //inserterAuthors.Id = 0;

            inserterAuthors.Insert();

            //AuthorsSelecter authorsSelecter = new AuthorsSelecter();
            //authorsSelecter.Select();
        }
    }
}
