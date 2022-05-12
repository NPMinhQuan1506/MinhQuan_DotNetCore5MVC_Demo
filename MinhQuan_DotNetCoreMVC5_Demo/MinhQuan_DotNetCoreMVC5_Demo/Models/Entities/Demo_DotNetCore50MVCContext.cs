using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MinhQuan_DotNetCoreMVC5_Demo.Models;

#nullable disable

namespace MinhQuan_DotNetCoreMVC5_Demo.Models.Entities
{
    public partial class Demo_DotNetCore50MVCContext : DbContext
    {
        public Demo_DotNetCore50MVCContext()
        {
        }

        public Demo_DotNetCore50MVCContext(DbContextOptions<Demo_DotNetCore50MVCContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DemoUser> DemoUsers { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Data Source=MOU\\NPMINHQUAN;Initial Catalog=Demo_DotNetCore5.0MVC;Persist Security Info=True;User ID=sa;Password=15062000");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<DemoUser>(entity =>
            {
                entity.ToTable("DemoUser");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Phone)
                    .HasMaxLength(14)
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<MinhQuan_DotNetCoreMVC5_Demo.Models.Contact> Contact { get; set; }
    }
}
