using EntityFrameworkRepoDbCombination.Cachers;
using Microsoft.Data.SqlClient;
using RepoDb;

namespace EntityFrameworkRepoDbCombination.Repositories
{
    public class DatabaseRepository : DbRepository<SqlConnection>
    {
        public DatabaseRepository() :
            base("Server=localhost;Database=sakila;Integrated Security=SSPI;TrustServerCertificate=true;", cache: CacheFactory.Create())
        { }
    }
}
