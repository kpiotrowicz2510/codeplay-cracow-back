using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace codeplayhackhatonback
{
    public class Rachunek
    {
        public string Image
        {
            get;
            set;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Status { get; set; }
    }


    public class RachunekContext : DbContext
    {
        public DbSet<Rachunek> Rachunki { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=rachunki.db");
        }
    }
}
