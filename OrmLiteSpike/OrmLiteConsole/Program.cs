using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using OrmLiteLibrary;

namespace OrmLiteConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["SimpleDataSpike"];
            var repo = new Repo(connectionString.ConnectionString);
            var person = new Person
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Han",
                    LastName = "Solo",
                    LastUpdated = DateTime.Now,
                    User = "user1"
                };

            repo.Insert(person);

        }
    }
}
