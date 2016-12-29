using Diplom.Domain;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base("DefaultConnection", throwIfV1Schema: false)
        {
            Configuration.ProxyCreationEnabled = false;
            Database.SetInitializer<ApplicationDbContext>(null);// Remove default initializer
        }

        public ApplicationDbContext(string connectionString) : base(connectionString, throwIfV1Schema: false)
        {
            Configuration.ProxyCreationEnabled = false;
        }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>()
                .HasMany(c => c.ReadUserMessages)
                .WithRequired(o => o.Message);
            base.OnModelCreating(modelBuilder);
        }
        public override IDbSet<ApplicationUser> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<TeacherProfile> TeacherProfiles { get; set; }
        public DbSet<ReadUserMessage> ReadUserMessages { get; set; }

    }
}
