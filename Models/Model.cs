using Microsoft.EntityFrameworkCore;


namespace HexGame.AspNetCoreApp.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public string ConnectionString { get; }

        public DatabaseContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            options.UseSqlServer(this.ConnectionString);
        }

    }
    public class User
    {
        public int UserID { get; set; }
        public string Email { get; set; }
        public string _Password { get; set; }
        public string NickName { get; set; }
        public string Avatar { get; set; }

    }
}
