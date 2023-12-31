﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebDers.Service.Data;

#nullable disable

namespace WebDers.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230611110828_mig1")]
    partial class mig1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebDers.Service.Models.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminID"));

                    b.Property<string>("AdminPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("WebDers.Service.Models.ArabaMarka", b =>
                {
                    b.Property<int>("ArabaMarkaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArabaMarkaID"));

                    b.Property<string>("ArabaMarkaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArabaMarkaID");

                    b.ToTable("ArabaMarkas");
                });

            modelBuilder.Entity("WebDers.Service.Models.Brand", b =>
                {
                    b.Property<int>("BrandID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BrandID"));

                    b.Property<int>("ArabaMarkaID")
                        .HasColumnType("int");

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BrandPrice")
                        .HasColumnType("int");

                    b.Property<int>("BrandYear")
                        .HasColumnType("int");

                    b.HasKey("BrandID");

                    b.HasIndex("ArabaMarkaID");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("WebDers.Service.Models.CarBlog", b =>
                {
                    b.Property<int>("CarBlogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarBlogID"));

                    b.Property<DateTime>("CarBlogDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CarBlogDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarBlogImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarBlogTittle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarBlogID");

                    b.ToTable("CarBlogs");
                });

            modelBuilder.Entity("WebDers.Service.Models.Hakkimizda", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FotoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Hakkimizdas");
                });

            modelBuilder.Entity("WebDers.Service.Models.Iletisim", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("AdSoyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Konu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mesaj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Iletisims");
                });

            modelBuilder.Entity("WebDers.Service.Models.Siparis", b =>
                {
                    b.Property<int>("SiparisID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SiparisID"));

                    b.Property<int>("BrandID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("SiparisID");

                    b.HasIndex("BrandID");

                    b.HasIndex("UserID");

                    b.ToTable("Sipariss");
                });

            modelBuilder.Entity("WebDers.Service.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserTel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebDers.Service.Models.Yorumlar", b =>
                {
                    b.Property<int>("YorumID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YorumID"));

                    b.Property<int>("CarBlogid")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Yorum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YorumKullaniciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YorumMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YorumID");

                    b.HasIndex("CarBlogid");

                    b.ToTable("Yorumlars");
                });

            modelBuilder.Entity("WebDers.Service.Models.Brand", b =>
                {
                    b.HasOne("WebDers.Service.Models.ArabaMarka", "ArabaMarka")
                        .WithMany("Brands")
                        .HasForeignKey("ArabaMarkaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ArabaMarka");
                });

            modelBuilder.Entity("WebDers.Service.Models.Siparis", b =>
                {
                    b.HasOne("WebDers.Service.Models.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebDers.Service.Models.User", "User")
                        .WithMany("Sipariss")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebDers.Service.Models.Yorumlar", b =>
                {
                    b.HasOne("WebDers.Service.Models.CarBlog", "CarBlog")
                        .WithMany("Yorumlars")
                        .HasForeignKey("CarBlogid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarBlog");
                });

            modelBuilder.Entity("WebDers.Service.Models.ArabaMarka", b =>
                {
                    b.Navigation("Brands");
                });

            modelBuilder.Entity("WebDers.Service.Models.CarBlog", b =>
                {
                    b.Navigation("Yorumlars");
                });

            modelBuilder.Entity("WebDers.Service.Models.User", b =>
                {
                    b.Navigation("Sipariss");
                });
#pragma warning restore 612, 618
        }
    }
}
