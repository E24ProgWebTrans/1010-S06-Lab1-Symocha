﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZombieParty.Models.Data;

#nullable disable

namespace ZombieParty.Migrations
{
    [DbContext(typeof(ZombiePartyDbContext))]
    [Migration("20230602004231_SeedZombieZombieTypeWeapon")]
    partial class SeedZombieZombieTypeWeapon
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HuntingLogZombie", b =>
                {
                    b.Property<int>("HuntingLogsId")
                        .HasColumnType("int");

                    b.Property<int>("ZombiesId")
                        .HasColumnType("int");

                    b.HasKey("HuntingLogsId", "ZombiesId");

                    b.HasIndex("ZombiesId");

                    b.ToTable("HuntingLogZombie");
                });

            modelBuilder.Entity("ZombieParty.Models.HuntingLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("HuntingLogs");
                });

            modelBuilder.Entity("ZombieParty.Models.Weapon", b =>
                {
                    b.Property<int>("WeaponId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WeaponId"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(2500)
                        .HasColumnType("nvarchar(2500)");

                    b.Property<decimal>("Force")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<int>("QtyBought")
                        .HasColumnType("int");

                    b.HasKey("WeaponId");

                    b.ToTable("Weapons");

                    b.HasData(
                        new
                        {
                            WeaponId = 1,
                            CreatedDate = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This is to cut your friendly zombies",
                            Force = 200m,
                            Image = "https://i.ibb.co/y5nCnXT/dagger-gfce31e967-1920.png",
                            Name = "Leopold",
                            Price = 421m,
                            Qty = 21,
                            QtyBought = 3
                        },
                        new
                        {
                            WeaponId = 2,
                            CreatedDate = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "An awesome Stainless Steel Shield",
                            Force = 10m,
                            Image = "https://publicdomainvectors.org/photos/Shield-ClassicMedieval1.png",
                            Name = "Master Shield",
                            Price = 500m,
                            Qty = 30,
                            QtyBought = 1
                        });
                });

            modelBuilder.Entity("ZombieParty.Models.Zombie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Point")
                        .HasColumnType("int");

                    b.Property<string>("ShortDesc")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("ZombieTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ZombieTypeId");

                    b.ToTable("Zombies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "LeChuck",
                            Point = 5,
                            ShortDesc = "Pirate des Caraibes",
                            ZombieTypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Lenore",
                            Point = 4,
                            ShortDesc = "Cute Little Dead Girl",
                            ZombieTypeId = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Baron Samedi",
                            Point = 8,
                            ShortDesc = "En costume de soirée, avec un chapeau haut de forme blanc et des lunettes soleil",
                            ZombieTypeId = 2
                        },
                        new
                        {
                            Id = 4,
                            Name = "Draugr",
                            Point = 2,
                            ShortDesc = "Vivant dans sa tombe grandant son trésor",
                            ZombieTypeId = 3
                        },
                        new
                        {
                            Id = 5,
                            Name = "Ragamuffin ",
                            Point = 5,
                            ShortDesc = "Ancien vampire transformé en poupée de chiffon, ami de Lenore",
                            ZombieTypeId = 2
                        },
                        new
                        {
                            Id = 6,
                            Name = "Mr Gosh",
                            Point = 6,
                            ShortDesc = "Tête de sac avec yeux en boutons, amoureux de Lenore",
                            ZombieTypeId = 1
                        },
                        new
                        {
                            Id = 7,
                            Name = "Taxidermy ",
                            Point = 1,
                            ShortDesc = "Tête de cerf empaillé, voisin de Lenore",
                            ZombieTypeId = 3
                        },
                        new
                        {
                            Id = 8,
                            Name = "Kitty",
                            Point = 3,
                            ShortDesc = "Chat mort de Lenore",
                            ZombieTypeId = 1
                        },
                        new
                        {
                            Id = 9,
                            Name = "Singe zombie",
                            Point = 2,
                            ShortDesc = "Voleur très rapide",
                            ZombieTypeId = 3
                        },
                        new
                        {
                            Id = 10,
                            Name = "chien de l'enfer",
                            Point = 7,
                            ShortDesc = "chien très rapide, pouvant être enflammé",
                            ZombieTypeId = 3
                        },
                        new
                        {
                            Id = 11,
                            Name = "Avogadro",
                            Point = 9,
                            ShortDesc = "Attaque avec des éclairs suite à un orage",
                            ZombieTypeId = 3
                        },
                        new
                        {
                            Id = 12,
                            Name = "Lady Rose",
                            Point = 6,
                            ShortDesc = "",
                            ZombieTypeId = 3
                        },
                        new
                        {
                            Id = 13,
                            Name = "Matbeth",
                            Point = 2,
                            ShortDesc = "Jeune étudiante qui cherche son professeur pour se venger",
                            ZombieTypeId = 2
                        },
                        new
                        {
                            Id = 14,
                            Name = "The Clown",
                            Point = 5,
                            ShortDesc = "Le clown malheureux qui court après les enfants",
                            ZombieTypeId = 3
                        },
                        new
                        {
                            Id = 15,
                            Name = "Clicker",
                            Point = 4,
                            ShortDesc = "Le comptable mécontent qui cherche les failles",
                            ZombieTypeId = 2
                        },
                        new
                        {
                            Id = 16,
                            Name = "TeamsZombie",
                            Point = 10,
                            ShortDesc = "L'étudiant happé par Teams. Trop d'heures de vidéos ont transformé cet étudiant en zombie",
                            ZombieTypeId = 3
                        },
                        new
                        {
                            Id = 17,
                            Name = "Mathilde",
                            Point = 4,
                            ShortDesc = "La fêtarde du samedi soir qui cherche les fêtes et les bars en vogue",
                            ZombieTypeId = 3
                        });
                });

            modelBuilder.Entity("ZombieParty.Models.ZombieType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Point")
                        .HasColumnType("int");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("ZombieTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Point = 0,
                            TypeName = "Contact"
                        },
                        new
                        {
                            Id = 2,
                            Point = 0,
                            TypeName = "Virus"
                        },
                        new
                        {
                            Id = 3,
                            Point = 0,
                            TypeName = "Chimique"
                        },
                        new
                        {
                            Id = 4,
                            Point = 0,
                            TypeName = "Morsure"
                        },
                        new
                        {
                            Id = 5,
                            Point = 0,
                            TypeName = "vampzombie"
                        });
                });

            modelBuilder.Entity("HuntingLogZombie", b =>
                {
                    b.HasOne("ZombieParty.Models.HuntingLog", null)
                        .WithMany()
                        .HasForeignKey("HuntingLogsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZombieParty.Models.Zombie", null)
                        .WithMany()
                        .HasForeignKey("ZombiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ZombieParty.Models.Zombie", b =>
                {
                    b.HasOne("ZombieParty.Models.ZombieType", "ZombieType")
                        .WithMany("Zombies")
                        .HasForeignKey("ZombieTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ZombieType");
                });

            modelBuilder.Entity("ZombieParty.Models.ZombieType", b =>
                {
                    b.Navigation("Zombies");
                });
#pragma warning restore 612, 618
        }
    }
}
