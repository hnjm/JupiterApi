using Jupiter.DataLayer.Entities.Access;
using Jupiter.DataLayer.Entities.Account;
using Jupiter.DataLayer.Entities.Message;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Jupiter.DataLayer.Context
{
    public class AppDbContext : DbContext
    {

        #region constructor

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        #endregion

        #region Db Sets

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<Message> Messages { get; set; }
        public DbSet<MessageCategory> MessageCategories { get; set; }
        public DbSet<MessageComment> MessageComments { get; set; }
        public DbSet<MessageSelectedCategory> MessageSelectedCategories { get; set; }
        public DbSet<MessageVisit> MessageVisits { get; set; }

        #endregion

        #region disable cascading delete in database

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            var cascades = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascades)
            {
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            }

            #region Seed Data Category

            modelBuilder.Entity<Role>().HasData(
                new Role()
                {
                    Id = 1,
                    Name = "Admin",
                    Title = "ادمین",
                    IsDelete = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Role()
                {
                    Id = 2,
                    Name = "Professor",
                    Title = "استاد",
                    IsDelete = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                },
                new Role()
                {
                    Id = 3,
                    Name = "Student",
                    Title = "دانشجو",
                    IsDelete = false,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                }
             );

            #endregion


            base.OnModelCreating(modelBuilder);
        }

        #endregion


    }
}
