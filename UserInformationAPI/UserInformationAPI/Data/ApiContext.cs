using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using UserInformationAPI.Models;

namespace UserInformationAPI.Data
{
    public class ApiContext: DbContext
    {
        public DbSet<Users> Info { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options) : base(options) 
        {

        }
    }
}
