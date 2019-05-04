using _01_Weather.Core.User;
using System.Data.Entity;

namespace EfRipositpry.Common
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext() : base("name=ConnectionMain")
        {

        }
        public virtual DbSet<UserEntity> Users { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;

        }
    }
}
