using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VisualStudioLauncher.WPF.Model
{
    public class VSLContext : DbContext
    {
        public string DbPath { get; }

        public DbSet<Settings> Settings { get; set; }
        public DbSet<LaunchItem> LaunchItems { get; set; }
        public DbSet<ProgramItem> ProgramItems { get; set; }
        public DbSet<LaunchList> LaunchLists { get; set; }

        public VSLContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "VSL.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LaunchList>()
                .HasMany(p => p.LaunchItems)
                .WithMany(b => b.LaunchLists)
                .UsingEntity(e => e.ToTable("LaunchItemLaunchList"));
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
