using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using App.Models.Domain;

namespace App.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("App.Models.Domain.AppOwner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");
                });

            modelBuilder.Entity("App.Models.Domain.CalculationOptions", b =>
                {
                    b.Property<int>("SheetId");

                    b.Property<decimal?>("BankAccountOffset");

                    b.Property<decimal?>("SavingsAccountOffset");

                    b.HasKey("SheetId");
                });

            modelBuilder.Entity("App.Models.Domain.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 250);

                    b.Property<int?>("OwnerId")
                        .IsRequired();

                    b.HasKey("Id");
                });

            modelBuilder.Entity("App.Models.Domain.Identity.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasAnnotation("Relational:Name", "RoleNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetRoles");
                });

            modelBuilder.Entity("App.Models.Domain.Identity.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<int?>("GroupId")
                        .IsRequired();

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasAnnotation("Relational:Name", "EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .HasAnnotation("Relational:Name", "UserNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetUsers");
                });

            modelBuilder.Entity("App.Models.Domain.Identity.AppUserTrustedUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("SourceUserId");

                    b.Property<int?>("TargetUserId");

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AppUserTrustedUsers");
                });

            modelBuilder.Entity("App.Models.Domain.Sheet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTimestamp");

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 250);

                    b.Property<int?>("OwnerId")
                        .IsRequired();

                    b.Property<DateTime>("Subject");

                    b.Property<DateTime>("UpdateTimestamp");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("App.Models.Domain.SheetEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Account");

                    b.Property<int?>("CategoryId")
                        .IsRequired();

                    b.Property<DateTime>("CreateTimestamp");

                    b.Property<decimal>("Delta");

                    b.Property<string>("Remark");

                    b.Property<int?>("SheetId")
                        .IsRequired();

                    b.Property<int>("SortOrder");

                    b.Property<string>("Source")
                        .HasAnnotation("MaxLength", 250);

                    b.Property<DateTime>("UpdateTimestamp");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasAnnotation("Relational:TableName", "AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasAnnotation("Relational:TableName", "AspNetUserRoles");
                });

            modelBuilder.Entity("App.Models.Domain.CalculationOptions", b =>
                {
                    b.HasOne("App.Models.Domain.Sheet")
                        .WithOne()
                        .HasForeignKey("App.Models.Domain.CalculationOptions", "SheetId");
                });

            modelBuilder.Entity("App.Models.Domain.Category", b =>
                {
                    b.HasOne("App.Models.Domain.AppOwner")
                        .WithMany()
                        .HasForeignKey("OwnerId");
                });

            modelBuilder.Entity("App.Models.Domain.Identity.AppUser", b =>
                {
                    b.HasOne("App.Models.Domain.AppOwner")
                        .WithMany()
                        .HasForeignKey("GroupId");
                });

            modelBuilder.Entity("App.Models.Domain.Identity.AppUserTrustedUser", b =>
                {
                    b.HasOne("App.Models.Domain.Identity.AppUser")
                        .WithMany()
                        .HasForeignKey("SourceUserId");

                    b.HasOne("App.Models.Domain.Identity.AppUser")
                        .WithMany()
                        .HasForeignKey("TargetUserId");
                });

            modelBuilder.Entity("App.Models.Domain.Sheet", b =>
                {
                    b.HasOne("App.Models.Domain.AppOwner")
                        .WithMany()
                        .HasForeignKey("OwnerId");
                });

            modelBuilder.Entity("App.Models.Domain.SheetEntry", b =>
                {
                    b.HasOne("App.Models.Domain.Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("App.Models.Domain.Sheet")
                        .WithMany()
                        .HasForeignKey("SheetId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("App.Models.Domain.Identity.AppRole")
                        .WithMany()
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("App.Models.Domain.Identity.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("App.Models.Domain.Identity.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<int>", b =>
                {
                    b.HasOne("App.Models.Domain.Identity.AppRole")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("App.Models.Domain.Identity.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
        }
    }
}
