﻿// <auto-generated />
using System;
using CoursEntityFrameWorkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace netflixTestConsole.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("netflixTestConsole.database.classes.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("category");
                });

            modelBuilder.Entity("netflixTestConsole.database.classes.Faq", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Response")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("faq");
                });

            modelBuilder.Entity("netflixTestConsole.database.classes.ImageData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("RessourceId")
                        .HasColumnType("int")
                        .HasColumnName("ressource_id");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("RessourceId");

                    b.ToTable("imageData");
                });

            modelBuilder.Entity("netflixTestConsole.database.classes.Ressource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("NbEpisodes")
                        .HasColumnType("int")
                        .HasColumnName("nb_episodes");

                    b.Property<int>("NbSaisons")
                        .HasColumnType("int")
                        .HasColumnName("nb_saisons");

                    b.Property<int>("TagId")
                        .HasColumnType("int")
                        .HasColumnName("tag_id");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Trailer")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("ressource");
                });

            modelBuilder.Entity("netflixTestConsole.database.classes.Statut", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("statut");
                });

            modelBuilder.Entity("netflixTestConsole.database.classes.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TagId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TagId");

                    b.ToTable("tag");
                });

            modelBuilder.Entity("netflixTestConsole.database.classes.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("StatutId")
                        .HasColumnType("int")
                        .HasColumnName("statut_id");

                    b.HasKey("Id");

                    b.HasIndex("StatutId");

                    b.ToTable("user");
                });

            modelBuilder.Entity("netflixTestConsole.database.classes.ImageData", b =>
                {
                    b.HasOne("netflixTestConsole.database.classes.Ressource", "Ressource")
                        .WithMany()
                        .HasForeignKey("RessourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ressource");
                });

            modelBuilder.Entity("netflixTestConsole.database.classes.Ressource", b =>
                {
                    b.HasOne("netflixTestConsole.database.classes.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("netflixTestConsole.database.classes.Tag", b =>
                {
                    b.HasOne("netflixTestConsole.database.classes.Ressource", null)
                        .WithMany("Tags")
                        .HasForeignKey("TagId");
                });

            modelBuilder.Entity("netflixTestConsole.database.classes.User", b =>
                {
                    b.HasOne("netflixTestConsole.database.classes.Statut", "Statut")
                        .WithMany()
                        .HasForeignKey("StatutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Statut");
                });

            modelBuilder.Entity("netflixTestConsole.database.classes.Ressource", b =>
                {
                    b.Navigation("Tags");
                });
#pragma warning restore 612, 618
        }
    }
}
