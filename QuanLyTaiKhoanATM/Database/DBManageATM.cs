using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyTaiKhoanATM.Database
{
    public partial class DBManageATM : DbContext
    {
        public DBManageATM()
            : base("name=DBManageATM")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<History> Histories { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .HasMany(e => e.Histories)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);
        }
    }
}
