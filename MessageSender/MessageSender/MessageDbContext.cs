using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace MessageSender
{
    public class MessageDbContext :DbContext
    {
        public DbSet<MessageModel>? Messages { get; set; }
        public MessageDbContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.AppSettings["connectionString"]);
        }
    }
}
