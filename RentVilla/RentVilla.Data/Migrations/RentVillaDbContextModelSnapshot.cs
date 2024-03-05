﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RentVilla.Data.Concrete.Contexts;

#nullable disable

namespace RentVilla.Data.Migrations
{
    [DbContext(typeof(RentVillaDbContext))]
    partial class RentVillaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("RentVilla.Entity.Concrete.AttributeDesc", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AttributeTypeId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AttributeTypeId");

                    b.ToTable("AttributeDescs");
                });

            modelBuilder.Entity("RentVilla.Entity.Concrete.AttributeType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AttributeTypes");
                });

            modelBuilder.Entity("RentVilla.Entity.Concrete.Identity.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("RentVilla.Entity.Concrete.ItemAttribute", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AttId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("AttTypeId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("AttributeDescId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("AttributeTypeId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("AttributeDescId");

                    b.HasIndex("AttributeTypeId");

                    b.HasIndex("ProductId");

                    b.ToTable("ItemAttributes");
                });

            modelBuilder.Entity("RentVilla.Entity.Concrete.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("Deposit")
                        .HasColumnType("numeric");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<List<string>>("ImageUrl")
                        .HasColumnType("text[]");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("MapId")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("Properties")
                        .HasColumnType("text");

                    b.Property<string>("Rating")
                        .HasColumnType("text");

                    b.Property<int>("ShortestRentPeriod")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("RentVilla.Entity.Concrete.Reservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal>("AddServiceCost")
                        .HasColumnType("numeric");

                    b.Property<int>("AdditionalServices")
                        .HasColumnType("integer");

                    b.Property<string>("ConversationId")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("PaymentId")
                        .HasColumnType("text");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("integer");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<decimal>("TotalCost")
                        .HasColumnType("numeric");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("UserId1")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId1");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("RentVilla.Entity.Concrete.AttributeDesc", b =>
                {
                    b.HasOne("RentVilla.Entity.Concrete.AttributeType", "AttributeType")
                        .WithMany()
                        .HasForeignKey("AttributeTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AttributeType");
                });

            modelBuilder.Entity("RentVilla.Entity.Concrete.ItemAttribute", b =>
                {
                    b.HasOne("RentVilla.Entity.Concrete.AttributeDesc", "AttributeDesc")
                        .WithMany()
                        .HasForeignKey("AttributeDescId");

                    b.HasOne("RentVilla.Entity.Concrete.AttributeType", "AttributeType")
                        .WithMany()
                        .HasForeignKey("AttributeTypeId");

                    b.HasOne("RentVilla.Entity.Concrete.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AttributeDesc");

                    b.Navigation("AttributeType");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("RentVilla.Entity.Concrete.Reservation", b =>
                {
                    b.HasOne("RentVilla.Entity.Concrete.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentVilla.Entity.Concrete.Identity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId1");

                    b.Navigation("Product");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
