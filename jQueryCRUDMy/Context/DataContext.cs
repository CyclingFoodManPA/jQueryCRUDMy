using System.Data.Entity;

namespace jQueryCRUDMy.Context {
    public class DataContext : DbContext {
        public DataContext()
            : base("DefaultConnection") {

        }

        public DbSet<User> User {
            get; set;
        }
    }
}