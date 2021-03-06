// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sukulu.DataAccessLibrary.Models;

namespace Sukulu.DataAccessLibrary.Migrations
{
    [DbContext(typeof(SKLContext))]
    [Migration("20220111172421_AddClasseNiveauSerie")]
    partial class AddClasseNiveauSerie
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sukulu.DataAccessLibrary.Models.Classe", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("NiveauId")
                        .HasColumnType("bigint");

                    b.Property<long?>("SerieId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("NiveauId");

                    b.HasIndex("SerieId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("Sukulu.DataAccessLibrary.Models.Enseignement", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("SystemeScolaireId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("SystemeScolaireId");

                    b.ToTable("Enseignement");
                });

            modelBuilder.Entity("Sukulu.DataAccessLibrary.Models.Niveau", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("EnseignementId")
                        .HasColumnType("bigint");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ranking")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EnseignementId");

                    b.ToTable("Niveaus");
                });

            modelBuilder.Entity("Sukulu.DataAccessLibrary.Models.Serie", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("EnseignementId")
                        .HasColumnType("bigint");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EnseignementId");

                    b.ToTable("Series");
                });

            modelBuilder.Entity("Sukulu.DataAccessLibrary.Models.SystemeScolaire", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimaryOwner")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondaryOwner")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SystemeScolaires");
                });

            modelBuilder.Entity("Sukulu.DataAccessLibrary.Models.Classe", b =>
                {
                    b.HasOne("Sukulu.DataAccessLibrary.Models.Niveau", "Niveau")
                        .WithMany()
                        .HasForeignKey("NiveauId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sukulu.DataAccessLibrary.Models.Serie", "Serie")
                        .WithMany()
                        .HasForeignKey("SerieId");

                    b.Navigation("Niveau");

                    b.Navigation("Serie");
                });

            modelBuilder.Entity("Sukulu.DataAccessLibrary.Models.Enseignement", b =>
                {
                    b.HasOne("Sukulu.DataAccessLibrary.Models.SystemeScolaire", "SystemeScolaire")
                        .WithMany()
                        .HasForeignKey("SystemeScolaireId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SystemeScolaire");
                });

            modelBuilder.Entity("Sukulu.DataAccessLibrary.Models.Niveau", b =>
                {
                    b.HasOne("Sukulu.DataAccessLibrary.Models.Enseignement", "Enseignement")
                        .WithMany()
                        .HasForeignKey("EnseignementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enseignement");
                });

            modelBuilder.Entity("Sukulu.DataAccessLibrary.Models.Serie", b =>
                {
                    b.HasOne("Sukulu.DataAccessLibrary.Models.Enseignement", "Enseignement")
                        .WithMany()
                        .HasForeignKey("EnseignementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enseignement");
                });
#pragma warning restore 612, 618
        }
    }
}
