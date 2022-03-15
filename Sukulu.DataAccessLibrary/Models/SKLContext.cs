using Microsoft.Data.SqlClient;
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


            //Local Machine Connection for Update-Database purposes
            //optionsBuilder.UseSqlServer("server = (localdb)\\MSSQLLocalDB; Database = SukuluDB; Trusted_Connection = true");
            //Azure DB connection for Update_database purposes
            //optionsBuilder.UseSqlServer("Data Source=tamonga.database.windows.net;Initial Catalog=SukuluDB;User ID=desflags;Password=ugimaD3d!;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


            // Application connection
            SqlConnectionStringBuilder bldr = new SqlConnectionStringBuilder();
            bldr.DataSource = Properties.Resources.DataSource;
            bldr.DataSource = Properties.Resources.DataSource;
            bldr.InitialCatalog = Properties.Resources.InitialCatalog;
            bldr.UserID = Global.UserID;
            bldr.Password = Global.Password;
            bldr.ConnectTimeout = Convert.ToInt32(Properties.Resources.ConnectTimeOut);
            bldr.Encrypt = true;
            bldr.TrustServerCertificate = false;
            bldr.ApplicationIntent = ApplicationIntent.ReadWrite;
            bldr.MultiSubnetFailover = false;
            optionsBuilder.UseSqlServer(bldr.ConnectionString);

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

        public DbSet<CoursPrevu> CoursPrevus { get; set; }

        public DbSet<Presence> Presences { get; set; }

        public DbSet<SKLConfig> SKLConfigs { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }

        public DbSet<AdministrationEvaluation> AdministrationEvaluations { get; set; }

        public DbSet<SKLUser> SKLUsers { get; set; }

         public DbSet<SKLClient> SKLClients { get; set; }
        public DbSet<SKLUserResource> SKLUserResources { get; set; }


        public DbSet<SKLClientEcole> SKLClientEcoles { get; set; }


        public DbSet<SKLClientEcoleUser> SKLClientEcoleUsers { get; set; }



    }
}
