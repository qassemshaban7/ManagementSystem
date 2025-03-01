using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_System.Models
{
    internal class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }


        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<TaskItem> TaskItems { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseSqlServer("Server=.;Database=ManagementSystemProject;Trusted_Connection=True;Encrypt=False");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
