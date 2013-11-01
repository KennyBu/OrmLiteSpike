using ServiceStack.OrmLite;
using ServiceStack.OrmLite.SqlServer;

namespace OrmLiteLibrary
{
    public class Repo
    {
        private readonly OrmLiteConnectionFactory _dbFactory;

        public Repo(string connectionString)
        {
            _dbFactory = new OrmLiteConnectionFactory(connectionString, SqlServerOrmLiteDialectProvider.Instance);
            
        }

        public void Insert(Person person)
        {
            using (var db = _dbFactory.OpenDbConnection())
            {
                db.Insert(person);    
            }
            
        }
    }
}