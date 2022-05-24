﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetShopApp.DataAccessLayer;

#nullable disable

namespace PetShopApp.DataAccessLayer.Migrations
{
    [DbContext(typeof(PetShopDbContext))]
    partial class PetShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PetShopApp.Core.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("tblCategories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("0a96abdd-7174-4c2a-8539-67a18b877045"),
                            CreatedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5341),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5352),
                            Name = "Kedi"
                        },
                        new
                        {
                            Id = new Guid("433bc24f-d187-4d80-a38b-d88db8bd359e"),
                            CreatedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5356),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5357),
                            Name = "Köpek"
                        },
                        new
                        {
                            Id = new Guid("52c5da72-afc7-4c11-80de-0adabe9aaff9"),
                            CreatedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5359),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5360),
                            Name = "Kuş"
                        });
                });

            modelBuilder.Entity("PetShopApp.Core.Models.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ProductID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductID");

                    b.HasIndex("UserID");

                    b.ToTable("tblComments", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("bb0708c5-807b-40bd-b313-eddb132cd2aa"),
                            CreatedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6374),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6376),
                            ProductID = new Guid("7dd39a36-b5b0-4c7d-b40f-edf270513842"),
                            Text = "Yorummmmm",
                            UserID = new Guid("a546a1b2-703e-4d32-aff0-c664d9526bfe")
                        },
                        new
                        {
                            Id = new Guid("eb75510a-d3e2-4e4d-8fe3-8f518ae48c11"),
                            CreatedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6382),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6383),
                            ProductID = new Guid("ae10f3d1-8a7d-4af5-a062-b63d2b5bd8fb"),
                            Text = "Yorummmmm",
                            UserID = new Guid("a546a1b2-703e-4d32-aff0-c664d9526bfe")
                        },
                        new
                        {
                            Id = new Guid("a9b758fa-c4b8-40cb-8764-2a720e6aa85b"),
                            CreatedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6390),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6391),
                            ProductID = new Guid("ae10f3d1-8a7d-4af5-a062-b63d2b5bd8fb"),
                            Text = "Yorummmmm",
                            UserID = new Guid("97649960-1851-4ae8-a047-c64f0fba3e56")
                        });
                });

            modelBuilder.Entity("PetShopApp.Core.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ProductID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductID");

                    b.HasIndex("UserID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PetShopApp.Core.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Barcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<Guid>("SubCategoryID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SubCategoryID");

                    b.ToTable("tblProducts", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("ae10f3d1-8a7d-4af5-a062-b63d2b5bd8fb"),
                            Barcode = "155855578",
                            Brand = "Nutri",
                            CreatedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5906),
                            ExpirationDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5908),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5910),
                            Name = "Tahılsız Kedi Maması",
                            Price = 250m,
                            Stock = 10,
                            SubCategoryID = new Guid("7c4be645-86d3-4c19-ba18-0c7424525fe4")
                        },
                        new
                        {
                            Id = new Guid("7dd39a36-b5b0-4c7d-b40f-edf270513842"),
                            Barcode = "155855579",
                            Brand = "Nutri",
                            CreatedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5928),
                            ExpirationDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5928),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5929),
                            Name = "Tahılsız Köpek Maması",
                            Price = 150m,
                            Stock = 10,
                            SubCategoryID = new Guid("acff3fbc-0995-4d27-8536-d49583bbbf60")
                        },
                        new
                        {
                            Id = new Guid("36c8e3f7-d932-461d-ae99-e0a3630b51cd"),
                            Barcode = "155955579",
                            Brand = "Nutri",
                            CreatedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5937),
                            ExpirationDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5938),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5939),
                            Name = "Tahılsız Kuş Yemi",
                            Price = 100m,
                            Stock = 10,
                            SubCategoryID = new Guid("b5cea59b-c9a9-403c-90f4-3f939270e462")
                        });
                });

            modelBuilder.Entity("PetShopApp.Core.Models.ProductFeature", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Feature")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ProductID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductID");

                    b.ToTable("tblProductFeatures", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("6c2e5c45-539d-4555-9171-22b5bd3d5d66"),
                            CreatedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6061),
                            Feature = "Açıklama 1",
                            ModifiedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6062),
                            ProductID = new Guid("ae10f3d1-8a7d-4af5-a062-b63d2b5bd8fb")
                        },
                        new
                        {
                            Id = new Guid("b4c3909e-4b70-4071-8e77-a68c78af746c"),
                            CreatedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6065),
                            Feature = "Açıklama 2",
                            ModifiedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6066),
                            ProductID = new Guid("ae10f3d1-8a7d-4af5-a062-b63d2b5bd8fb")
                        },
                        new
                        {
                            Id = new Guid("f6a202a6-973c-42f3-a61b-e2391a7f9d67"),
                            CreatedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6068),
                            Feature = "Açıklama 1",
                            ModifiedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6069),
                            ProductID = new Guid("7dd39a36-b5b0-4c7d-b40f-edf270513842")
                        },
                        new
                        {
                            Id = new Guid("6033240b-5807-49d9-ada8-645385b87fad"),
                            CreatedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6071),
                            Feature = "Açıklama 2",
                            ModifiedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6073),
                            ProductID = new Guid("7dd39a36-b5b0-4c7d-b40f-edf270513842")
                        },
                        new
                        {
                            Id = new Guid("232d8dae-8891-4e41-bcee-a70d89d01b25"),
                            CreatedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6075),
                            Feature = "Açıklama 1",
                            ModifiedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6076),
                            ProductID = new Guid("36c8e3f7-d932-461d-ae99-e0a3630b51cd")
                        },
                        new
                        {
                            Id = new Guid("70d3f463-ef01-4bd9-ac6e-2846a63dd04d"),
                            CreatedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6078),
                            Feature = "Açıklama 2",
                            ModifiedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6079),
                            ProductID = new Guid("36c8e3f7-d932-461d-ae99-e0a3630b51cd")
                        });
                });

            modelBuilder.Entity("PetShopApp.Core.Models.SubCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryID");

                    b.ToTable("tblSubCategories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("7c4be645-86d3-4c19-ba18-0c7424525fe4"),
                            CategoryID = new Guid("0a96abdd-7174-4c2a-8539-67a18b877045"),
                            CreatedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5716),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5721),
                            Name = "Kedi Maması"
                        },
                        new
                        {
                            Id = new Guid("369f5122-8721-4225-b397-dc443dc7b623"),
                            CategoryID = new Guid("0a96abdd-7174-4c2a-8539-67a18b877045"),
                            CreatedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5724),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5725),
                            Name = "Kedi Kumu"
                        },
                        new
                        {
                            Id = new Guid("a6539c11-3188-44ee-abae-3053ac1a3e3e"),
                            CategoryID = new Guid("0a96abdd-7174-4c2a-8539-67a18b877045"),
                            CreatedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5727),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5729),
                            Name = "Kedi Oyuncakları"
                        },
                        new
                        {
                            Id = new Guid("acff3fbc-0995-4d27-8536-d49583bbbf60"),
                            CategoryID = new Guid("433bc24f-d187-4d80-a38b-d88db8bd359e"),
                            CreatedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5731),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5732),
                            Name = "Köpek Maması"
                        },
                        new
                        {
                            Id = new Guid("67eb800d-7c06-4b25-9e52-2ea894492197"),
                            CategoryID = new Guid("433bc24f-d187-4d80-a38b-d88db8bd359e"),
                            CreatedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5734),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5735),
                            Name = "Köpek Kıyafetleri"
                        },
                        new
                        {
                            Id = new Guid("d1e97a85-b4d5-4f9a-b79e-a1bbfa67a1dd"),
                            CategoryID = new Guid("433bc24f-d187-4d80-a38b-d88db8bd359e"),
                            CreatedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5737),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5740),
                            Name = "Köpek Oyuncakları"
                        },
                        new
                        {
                            Id = new Guid("b5cea59b-c9a9-403c-90f4-3f939270e462"),
                            CategoryID = new Guid("52c5da72-afc7-4c11-80de-0adabe9aaff9"),
                            CreatedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5743),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5744),
                            Name = "Kuş Yemi"
                        },
                        new
                        {
                            Id = new Guid("5e5efebe-5ec5-4eed-ad45-6becc1962fba"),
                            CategoryID = new Guid("52c5da72-afc7-4c11-80de-0adabe9aaff9"),
                            CreatedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5746),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5747),
                            Name = "Kuş Suluğu"
                        },
                        new
                        {
                            Id = new Guid("433bc24f-d187-4d80-a38b-d88db8bd359e"),
                            CategoryID = new Guid("52c5da72-afc7-4c11-80de-0adabe9aaff9"),
                            CreatedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5749),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5749),
                            Name = "Kuş Vitamini"
                        });
                });

            modelBuilder.Entity("PetShopApp.Core.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("Id");

                    b.ToTable("tblUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("a546a1b2-703e-4d32-aff0-c664d9526bfe"),
                            Email = "kbrkskn@gmail.com",
                            IsActive = true,
                            IsAdmin = false,
                            LastName = "Keskin",
                            Name = "Kübra",
                            Password = "123456",
                            Phone = "05362879963"
                        },
                        new
                        {
                            Id = new Guid("97649960-1851-4ae8-a047-c64f0fba3e56"),
                            Email = "eymen@gmail.com",
                            IsActive = true,
                            IsAdmin = false,
                            LastName = "Keskin",
                            Name = "Eymen",
                            Password = "123456",
                            Phone = "05362879963"
                        },
                        new
                        {
                            Id = new Guid("d43ecbfe-2136-478e-b367-ab5ab5a40c68"),
                            Email = "bhrkskn@gmail.com",
                            IsActive = true,
                            IsAdmin = false,
                            LastName = "Keskin",
                            Name = "Bahar",
                            Password = "123456",
                            Phone = "05362879963"
                        });
                });

            modelBuilder.Entity("PetShopApp.Core.Models.Comment", b =>
                {
                    b.HasOne("PetShopApp.Core.Models.Product", "Product")
                        .WithMany("Comments")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetShopApp.Core.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PetShopApp.Core.Models.Order", b =>
                {
                    b.HasOne("PetShopApp.Core.Models.Product", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetShopApp.Core.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PetShopApp.Core.Models.Product", b =>
                {
                    b.HasOne("PetShopApp.Core.Models.SubCategory", "SubCategory")
                        .WithMany("Products")
                        .HasForeignKey("SubCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("PetShopApp.Core.Models.ProductFeature", b =>
                {
                    b.HasOne("PetShopApp.Core.Models.Product", "Product")
                        .WithMany("ProductFeatures")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("PetShopApp.Core.Models.SubCategory", b =>
                {
                    b.HasOne("PetShopApp.Core.Models.Category", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("PetShopApp.Core.Models.Category", b =>
                {
                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("PetShopApp.Core.Models.Product", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Orders");

                    b.Navigation("ProductFeatures");
                });

            modelBuilder.Entity("PetShopApp.Core.Models.SubCategory", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("PetShopApp.Core.Models.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
