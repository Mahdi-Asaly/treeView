using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Mahdi_Abd_Asali.Models
{
    public partial class DBModel : DbContext
    {
        public DBModel()
            : base("name=DBModel")
        {
        }

        public virtual DbSet<CommodityChapters> CommodityChapters { get; set; }
        public virtual DbSet<CommodityRoots> CommodityRoots { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CommodityChapters>()
                .HasMany(e => e.CommodityRoots)
                .WithRequired(e => e.CommodityChapters)
                .HasForeignKey(e => e.CommodityChapterId)
                .WillCascadeOnDelete(false);
        }
    }
}
