﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SözlükForum.Models;

namespace SözlükForum.Migrations
{
    [DbContext(typeof(Contex))]
    [Migration("20210101141528_deneme14")]
    partial class deneme14
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("SözlükForum.Models.ForumSoru", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("eklemeTarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("icerik")
                        .HasColumnType("Varchar(1000)");

                    b.Property<int>("katego")
                        .HasColumnType("int");

                    b.Property<int?>("kullaniciid")
                        .HasColumnType("int");

                    b.Property<string>("soru")
                        .IsRequired()
                        .HasColumnType("Varchar(500)");

                    b.HasKey("Id");

                    b.HasIndex("kullaniciid");

                    b.ToTable("ForumSorus");
                });

            modelBuilder.Entity("SözlükForum.Models.Kullanici", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("admin")
                        .HasColumnType("bit");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kullanıcıAd")
                        .IsRequired()
                        .HasColumnType("Varchar(20)");

                    b.Property<string>("sifre")
                        .IsRequired()
                        .HasColumnType("Varchar(10)");

                    b.HasKey("id");

                    b.ToTable("Kullanicis");
                });

            modelBuilder.Entity("SözlükForum.Models.Yorum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Icerik")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("Zaman")
                        .HasColumnType("datetime2");

                    b.Property<int?>("forumsoruId")
                        .HasColumnType("int");

                    b.Property<int>("kullaniciid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("forumsoruId");

                    b.HasIndex("kullaniciid");

                    b.ToTable("Yorums");
                });

            modelBuilder.Entity("SözlükForum.Models.ForumSoru", b =>
                {
                    b.HasOne("SözlükForum.Models.Kullanici", "kullanici")
                        .WithMany("forumSorus")
                        .HasForeignKey("kullaniciid");

                    b.Navigation("kullanici");
                });

            modelBuilder.Entity("SözlükForum.Models.Yorum", b =>
                {
                    b.HasOne("SözlükForum.Models.ForumSoru", "forumsoru")
                        .WithMany("yorums")
                        .HasForeignKey("forumsoruId");

                    b.HasOne("SözlükForum.Models.Kullanici", "kullanici")
                        .WithMany("yorums")
                        .HasForeignKey("kullaniciid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("forumsoru");

                    b.Navigation("kullanici");
                });

            modelBuilder.Entity("SözlükForum.Models.ForumSoru", b =>
                {
                    b.Navigation("yorums");
                });

            modelBuilder.Entity("SözlükForum.Models.Kullanici", b =>
                {
                    b.Navigation("forumSorus");

                    b.Navigation("yorums");
                });
#pragma warning restore 612, 618
        }
    }
}
