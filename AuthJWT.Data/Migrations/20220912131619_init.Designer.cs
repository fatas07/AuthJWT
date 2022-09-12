﻿// <auto-generated />
using System;
using AuthJWT.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AuthJWT.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220912131619_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AuthJWT.Entites.Identity.UserEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .HasColumnType("character varying(256)");

                    b.Property<string>("Language")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("text");

                    b.Property<DateTime?>("RefreshTokenEndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<string>("Timezone")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "581d4a5c-dd43-49c0-9e1a-7960bc24de5c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c2415976-679f-4048-a0e2-522bb9a2ce09",
                            Email = "firatatas@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Fırat",
                            Language = "tr-TR",
                            LastName = "Ataş",
                            LockoutEnabled = true,
                            NormalizedEmail = "FIRATATAS@GMAIL.COM",
                            NormalizedUserName = "FIRATATAS@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEB4oZXj4+JkmwLOp2ftFLHs5qr3f8jI2LuuYrtYIq0sW1T7ZAOk44ksurZK4WjriOA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2993f893-af17-45de-a375-5523ce2dfd89",
                            Timezone = "Turkey Standard Time",
                            TwoFactorEnabled = false,
                            UserName = "firatatas@gmail.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "915f3c44-8a59-45ae-8903-aa49a44847e4",
                            ConcurrencyStamp = "ae88a6fd-66dc-4e2f-8e2c-511dca1aa94d",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "760e5cdf-fc52-4557-80e2-217a323e61ce",
                            ConcurrencyStamp = "c2405fc3-4e1b-4846-87e9-0e21882737b9",
                            Name = "Superuser",
                            NormalizedName = "SUPERUSER"
                        },
                        new
                        {
                            Id = "80f66454-27e9-4e77-ac71-c8800861c330",
                            ConcurrencyStamp = "dab67f3a-4518-4762-8088-869532686e38",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "f4075620-9a38-48c5-8cef-a677e98dfa9e",
                            ConcurrencyStamp = "db5419d2-f39a-46d4-b855-583357da8493",
                            Name = "Viewer",
                            NormalizedName = "VIEWER"
                        },
                        new
                        {
                            Id = "f36854dd-aaa8-4e2d-aa88-17e9e6809ebb",
                            ConcurrencyStamp = "4ffae83f-00fb-4a26-9fae-da64da217a5b",
                            Name = "Guest",
                            NormalizedName = "GUEST"
                        },
                        new
                        {
                            Id = "df881f83-11a3-4f2c-9171-5cd1a51a29ee",
                            ConcurrencyStamp = "b8de2b44-3324-4386-b89c-1a037959d215",
                            Name = "Producer",
                            NormalizedName = "PRODUCER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "581d4a5c-dd43-49c0-9e1a-7960bc24de5c",
                            RoleId = "915f3c44-8a59-45ae-8903-aa49a44847e4"
                        },
                        new
                        {
                            UserId = "581d4a5c-dd43-49c0-9e1a-7960bc24de5c",
                            RoleId = "760e5cdf-fc52-4557-80e2-217a323e61ce"
                        },
                        new
                        {
                            UserId = "581d4a5c-dd43-49c0-9e1a-7960bc24de5c",
                            RoleId = "80f66454-27e9-4e77-ac71-c8800861c330"
                        },
                        new
                        {
                            UserId = "581d4a5c-dd43-49c0-9e1a-7960bc24de5c",
                            RoleId = "f4075620-9a38-48c5-8cef-a677e98dfa9e"
                        },
                        new
                        {
                            UserId = "581d4a5c-dd43-49c0-9e1a-7960bc24de5c",
                            RoleId = "f36854dd-aaa8-4e2d-aa88-17e9e6809ebb"
                        },
                        new
                        {
                            UserId = "581d4a5c-dd43-49c0-9e1a-7960bc24de5c",
                            RoleId = "df881f83-11a3-4f2c-9171-5cd1a51a29ee"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AuthJWT.Entites.Identity.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AuthJWT.Entites.Identity.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AuthJWT.Entites.Identity.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AuthJWT.Entites.Identity.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
