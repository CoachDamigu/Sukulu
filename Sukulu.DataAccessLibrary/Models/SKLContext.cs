using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sukulu.DataAccessLibrary.Models
{
    public class SKLContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = (localdb)\\MSSQLLocalDB; Database = SukuluDB; Trusted_Connection = true");
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<SystemeScolaire> SystemeScolaires { get; set; }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<Niveau> Niveaus { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<Enseignement> Enseignements { get; set; }

        public DbSet<AnneeScolaire> AnneeScolaires { get; set; }
        public DbSet<Ecole> Ecoles { get; set; }

        public DbSet<SalleClasse> SalleClasses { get; set; }

        public DbSet<Eleve> Eleves { get; set; }

        public DbSet<Inscription> Inscriptions { get; set; }

        public DbSet<Matiere> Matieres { get; set; }
        public DbSet<SalleClasseMatiere> SalleClasseMatieres { get; set; }
        public DbSet<Enseignant> Enseignants { get; set; }
        public DbSet<PortfolioEnseignant> PortfolioEnseignants { get; set; }


    }
}
