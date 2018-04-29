﻿// <auto-generated />
using App.Models.Domain;
using App.Models.Domain.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace App.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("App.Models.Domain.AppOwner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("LastMonthlyDigestTimestamp");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("AppOwner");
                });

            modelBuilder.Entity("App.Models.Domain.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<decimal?>("MonthlyBudget");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int>("OwnerId");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("App.Models.Domain.Identity.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("App.Models.Domain.Identity.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<int>("GroupId");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("App.Models.Domain.Identity.AppUserLoginEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("IPAddress")
                        .IsRequired();

                    b.Property<DateTime>("Timestamp");

                    b.Property<string>("UserAgent")
                        .HasMaxLength(4096);

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AppUserLoginEvent");
                });

            modelBuilder.Entity("App.Models.Domain.Identity.AppUserTrustedUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("SourceUserId");

                    b.Property<int?>("TargetUserId");

                    b.HasKey("Id");

                    b.HasIndex("SourceUserId");

                    b.HasIndex("TargetUserId");

                    b.ToTable("AppUserTrustedUsers");
                });

            modelBuilder.Entity("App.Models.Domain.RecurringSheetEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Account");

                    b.Property<int>("CategoryId");

                    b.Property<decimal>("Delta");

                    b.Property<int>("OwnerId");

                    b.Property<string>("Remark");

                    b.Property<int>("SortOrder");

                    b.Property<string>("Source")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("OwnerId");

                    b.ToTable("RecurringSheetEntry");
                });

            modelBuilder.Entity("App.Models.Domain.Sheet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTimestamp");

                    b.Property<string>("Name")
                        .HasMaxLength(250);

                    b.Property<int>("OwnerId");

                    b.Property<DateTime>("Subject");

                    b.Property<DateTime>("UpdateTimestamp");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Sheet");
                });

            modelBuilder.Entity("App.Models.Domain.SheetEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Account");

                    b.Property<int>("CategoryId");

                    b.Property<DateTime>("CreateTimestamp");

                    b.Property<decimal>("Delta");

                    b.Property<string>("Remark");

                    b.Property<int>("SheetId");

                    b.Property<int>("SortOrder");

                    b.Property<string>("Source")
                        .HasMaxLength(250);

                    b.Property<int?>("TemplateId");

                    b.Property<DateTime>("UpdateTimestamp");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SheetId");

                    b.HasIndex("TemplateId");

                    b.ToTable("SheetEntry");
                });

            modelBuilder.Entity("App.Models.Domain.SheetEntryTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("SheetEntryId");

                    b.Property<int>("TagId");

                    b.HasKey("Id");

                    b.HasIndex("SheetEntryId");

                    b.HasIndex("TagId", "SheetEntryId")
                        .IsUnique();

                    b.ToTable("SheetEntryTag");
                });

            modelBuilder.Entity("App.Models.Domain.SheetRecurringSheetEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("SheetId");

                    b.Property<int>("TemplateId");

                    b.HasKey("Id");

                    b.HasIndex("SheetId");

                    b.HasIndex("TemplateId");

                    b.ToTable("SheetRecurringSheetEntry");
                });

            modelBuilder.Entity("App.Models.Domain.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("HexColorCode")
                        .HasMaxLength(6);

                    b.Property<bool>("IsInactive");

                    b.Property<string>("Name");

                    b.Property<int>("OwnerId");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("App.Models.Domain.Category", b =>
                {
                    b.HasOne("App.Models.Domain.AppOwner", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("App.Models.Domain.Identity.AppUser", b =>
                {
                    b.HasOne("App.Models.Domain.AppOwner", "Group")
                        .WithMany("Users")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.OwnsOne("App.Models.Domain.Identity.AppUserPreferences", "Preferences", b1 =>
                        {
                            b1.Property<int>("AppUserId");

                            b1.Property<bool>("EnableLoginNotifications");

                            b1.Property<bool>("EnableMonthlyDigest");

                            b1.ToTable("AspNetUsers");

                            b1.HasOne("App.Models.Domain.Identity.AppUser")
                                .WithOne("Preferences")
                                .HasForeignKey("App.Models.Domain.Identity.AppUserPreferences", "AppUserId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("App.Models.Domain.Identity.AppUserLoginEvent", b =>
                {
                    b.HasOne("App.Models.Domain.Identity.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("App.Models.Domain.Identity.AppUserTrustedUser", b =>
                {
                    b.HasOne("App.Models.Domain.Identity.AppUser", "SourceUser")
                        .WithMany("TrustedUsers")
                        .HasForeignKey("SourceUserId");

                    b.HasOne("App.Models.Domain.Identity.AppUser", "TargetUser")
                        .WithMany()
                        .HasForeignKey("TargetUserId");
                });

            modelBuilder.Entity("App.Models.Domain.RecurringSheetEntry", b =>
                {
                    b.HasOne("App.Models.Domain.Category", "Category")
                        .WithMany("RecurringSheetEntries")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("App.Models.Domain.AppOwner", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("App.Models.Domain.Sheet", b =>
                {
                    b.HasOne("App.Models.Domain.AppOwner", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.OwnsOne("App.Models.Domain.CalculationOptions", "CalculationOptions", b1 =>
                        {
                            b1.Property<int>("SheetId");

                            b1.Property<decimal?>("BankAccountOffset");

                            b1.Property<decimal?>("SavingsAccountOffset");

                            b1.ToTable("Sheet");

                            b1.HasOne("App.Models.Domain.Sheet")
                                .WithOne("CalculationOptions")
                                .HasForeignKey("App.Models.Domain.CalculationOptions", "SheetId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("App.Models.Domain.SheetEntry", b =>
                {
                    b.HasOne("App.Models.Domain.Category", "Category")
                        .WithMany("SheetEntries")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("App.Models.Domain.Sheet", "Sheet")
                        .WithMany("Entries")
                        .HasForeignKey("SheetId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("App.Models.Domain.RecurringSheetEntry", "Template")
                        .WithMany()
                        .HasForeignKey("TemplateId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("App.Models.Domain.SheetEntryTag", b =>
                {
                    b.HasOne("App.Models.Domain.SheetEntry", "SheetEntry")
                        .WithMany("Tags")
                        .HasForeignKey("SheetEntryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("App.Models.Domain.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("App.Models.Domain.SheetRecurringSheetEntry", b =>
                {
                    b.HasOne("App.Models.Domain.Sheet", "Sheet")
                        .WithMany("ApplicableTemplates")
                        .HasForeignKey("SheetId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("App.Models.Domain.RecurringSheetEntry", "Template")
                        .WithMany()
                        .HasForeignKey("TemplateId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("App.Models.Domain.Tag", b =>
                {
                    b.HasOne("App.Models.Domain.AppOwner", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("App.Models.Domain.Identity.AppRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("App.Models.Domain.Identity.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("App.Models.Domain.Identity.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("App.Models.Domain.Identity.AppRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("App.Models.Domain.Identity.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("App.Models.Domain.Identity.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
