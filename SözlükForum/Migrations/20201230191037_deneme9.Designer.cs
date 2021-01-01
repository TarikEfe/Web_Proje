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
    [Migration("20201230191037_deneme9")]
    partial class deneme9
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("SözlükForum.Models.Admin", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kullaniciAdi")
                        .IsRequired()
                        .HasColumnType("Varchar(30)");

                    b.Property<string>("sifre")
                        .IsRequired()
                        .HasColumnType("Varchar(10)");

                    b.HasKey("id");

                    b.ToTable("Admins");
                });

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

            modelBuilder.Entity("SözlükForum.Models.ForumSoru", b =>
                {
                    b.HasOne("SözlükForum.Models.Kullanici", "kullanici")
                        .WithMany("forumSorus")
                        .HasForeignKey("kullaniciid");

                    b.Navigation("kullanici");
                });

            modelBuilder.Entity("SözlükForum.Models.Kullanici", b =>
                {
                    b.Navigation("forumSorus");
                });
#pragma warning restore 612, 618
        }
    }
}
