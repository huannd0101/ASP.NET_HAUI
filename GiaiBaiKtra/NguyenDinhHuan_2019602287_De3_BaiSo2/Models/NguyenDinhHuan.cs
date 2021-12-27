using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NguyenDinhHuan_2019602287_De3.Models
{
    public partial class NguyenDinhHuan : DbContext
    {
        public NguyenDinhHuan()
            : base("name=NguyenDinhHuan")
        {
        }

        public virtual DbSet<Hang> Hangs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hang>()
                .Property(e => e.Mahang)
                .IsFixedLength();
        }
    }
}
