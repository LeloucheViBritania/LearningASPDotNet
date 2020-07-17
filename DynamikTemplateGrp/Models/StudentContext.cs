using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DynamikTemplateGrp.Models
{
    public class StudentContext : DbContext
    {
        private DbSet<Categorie> _categorie;

        public StudentContext()
: base("name=StudentContext")
        {
        }

        public DbSet<Student> student { get; set; }
        public DbSet<Cours> cours { get; set; }
        public DbSet<Follow> follow { get; set; }
        public DbSet<Categorie> Categorie { get => _categorie; }
    }
}