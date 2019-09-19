﻿// <auto-generated />
using System;
using JOKRStore.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<Guid>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Model.CPU", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("architect");

                    b.Property<long>("cache");

                    b.Property<long>("cores");

                    b.Property<long>("freqency");

                    b.Property<string>("name");

                    b.Property<DateTime>("release");

                    b.HasKey("Id");

                    b.ToTable("CPUs");
                });

            modelBuilder.Entity("Model.Comment", b =>
                {
                    b.Property<Guid>("CommentId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CommentDate");

                    b.Property<string>("Contain");

                    b.Property<Guid?>("ForumTopicId");

                    b.Property<Guid?>("GameId");

                    b.Property<Guid>("UserId");

                    b.HasKey("CommentId");

                    b.HasIndex("ForumTopicId");

                    b.HasIndex("GameId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Model.Config", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CPUId");

                    b.Property<Guid>("GPUId");

                    b.Property<int>("GPU_size");

                    b.Property<Guid>("OSId");

                    b.Property<int>("RAM");

                    b.Property<Guid>("UserId");

                    b.Property<string>("others");

                    b.HasKey("Id");

                    b.HasIndex("CPUId");

                    b.HasIndex("GPUId");

                    b.HasIndex("OSId");

                    b.ToTable("Configs");
                });

            modelBuilder.Entity("Model.ForumCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name");

                    b.HasKey("Id");

                    b.ToTable("ForumCategories");
                });

            modelBuilder.Entity("Model.ForumTopic", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ForumCategoryId");

                    b.Property<Guid>("UserId");

                    b.Property<string>("content");

                    b.Property<DateTime>("date");

                    b.Property<string>("title");

                    b.HasKey("Id");

                    b.HasIndex("ForumCategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("ForumTopics");
                });

            modelBuilder.Entity("Model.GPU", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("architect");

                    b.Property<long>("bandwidth");

                    b.Property<long>("buswidth");

                    b.Property<long>("core_frequency");

                    b.Property<float>("directx");

                    b.Property<long>("memory_freqency");

                    b.Property<long>("memory_size");

                    b.Property<string>("name");

                    b.Property<float>("opengl");

                    b.Property<long>("pixel_fillrate");

                    b.Property<DateTime>("release");

                    b.Property<float>("shader_model");

                    b.Property<long>("shaders");

                    b.Property<long>("texture_fillrate");

                    b.Property<float>("vulkan");

                    b.HasKey("Id");

                    b.ToTable("GPUs");
                });

            modelBuilder.Entity("Model.Game", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CoverArt");

                    b.Property<string>("DemoLink");

                    b.Property<string>("Description");

                    b.Property<string>("Developer");

                    b.Property<string>("DownloadLink");

                    b.Property<string>("GameName");

                    b.Property<Guid?>("MinSysReqId");

                    b.Property<int>("NumOfDownloads");

                    b.Property<decimal>("Price");

                    b.Property<double>("Rate");

                    b.Property<Guid?>("RecSysReqId");

                    b.Property<DateTime>("Release");

                    b.Property<string>("SysReqNotes");

                    b.HasKey("Id");

                    b.HasIndex("MinSysReqId");

                    b.HasIndex("RecSysReqId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Model.Media", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("GameId");

                    b.Property<string>("contain");

                    b.Property<int>("type");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Media");
                });

            modelBuilder.Entity("Model.OS", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("group");

                    b.Property<int>("major_ver");

                    b.Property<int>("minor_ver");

                    b.Property<string>("name");

                    b.HasKey("Id");

                    b.ToTable("OSes");
                });

            modelBuilder.Entity("Model.SysReq", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("directx");

                    b.Property<float>("opengl");

                    b.Property<long>("ram");

                    b.Property<long>("storage");

                    b.Property<float>("vulkan");

                    b.HasKey("Id");

                    b.ToTable("SysReq");
                });

            modelBuilder.Entity("Model.SysReqCPU", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CPUId");

                    b.Property<Guid>("SysReqId");

                    b.HasKey("Id");

                    b.HasIndex("CPUId");

                    b.HasIndex("SysReqId");

                    b.ToTable("SysReqCPU");
                });

            modelBuilder.Entity("Model.SysReqGPU", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("GPUId");

                    b.Property<Guid>("SysReqId");

                    b.HasKey("Id");

                    b.HasIndex("GPUId");

                    b.HasIndex("SysReqId");

                    b.ToTable("SysReqGPU");
                });

            modelBuilder.Entity("Model.SysReqOS", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("OSId");

                    b.Property<Guid>("SysReqId");

                    b.HasKey("Id");

                    b.HasIndex("OSId");

                    b.HasIndex("SysReqId");

                    b.ToTable("SysReqOS");
                });

            modelBuilder.Entity("Model.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("BankAccount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<Guid?>("ConfigId");

                    b.Property<Guid?>("ConfigId1");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("IsAdmin");

                    b.Property<DateTime>("LastLogin");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<DateTime>("Registration");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("ConfigId1");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Model.UserGames", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("GameId");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("UserId");

                    b.ToTable("UserGames");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Model.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Model.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Model.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Model.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Model.Comment", b =>
                {
                    b.HasOne("Model.ForumTopic", "ForumTopic")
                        .WithMany("Comments")
                        .HasForeignKey("ForumTopicId");

                    b.HasOne("Model.Game", "Game")
                        .WithMany("Comments")
                        .HasForeignKey("GameId");

                    b.HasOne("Model.User", "User")
                        .WithMany("comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Model.Config", b =>
                {
                    b.HasOne("Model.CPU", "CPU")
                        .WithMany()
                        .HasForeignKey("CPUId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Model.GPU", "GPU")
                        .WithMany()
                        .HasForeignKey("GPUId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Model.OS", "OS")
                        .WithMany()
                        .HasForeignKey("OSId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Model.ForumTopic", b =>
                {
                    b.HasOne("Model.ForumCategory", "ForumCategory")
                        .WithMany("topics")
                        .HasForeignKey("ForumCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Model.Game", b =>
                {
                    b.HasOne("Model.SysReq", "MinSysReq")
                        .WithMany()
                        .HasForeignKey("MinSysReqId");

                    b.HasOne("Model.SysReq", "RecSysReq")
                        .WithMany()
                        .HasForeignKey("RecSysReqId");
                });

            modelBuilder.Entity("Model.Media", b =>
                {
                    b.HasOne("Model.Game", "game")
                        .WithMany("Medias")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Model.SysReqCPU", b =>
                {
                    b.HasOne("Model.CPU", "CPU")
                        .WithMany()
                        .HasForeignKey("CPUId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Model.SysReq", "SysReq")
                        .WithMany("SysReqCPUs")
                        .HasForeignKey("SysReqId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Model.SysReqGPU", b =>
                {
                    b.HasOne("Model.GPU", "GPU")
                        .WithMany()
                        .HasForeignKey("GPUId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Model.SysReq", "SysReq")
                        .WithMany("SysReqGPUs")
                        .HasForeignKey("SysReqId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Model.SysReqOS", b =>
                {
                    b.HasOne("Model.OS", "OS")
                        .WithMany()
                        .HasForeignKey("OSId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Model.SysReq", "SysReq")
                        .WithMany("SysReqOSes")
                        .HasForeignKey("SysReqId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Model.User", b =>
                {
                    b.HasOne("Model.Config", "Config")
                        .WithMany()
                        .HasForeignKey("ConfigId1");
                });

            modelBuilder.Entity("Model.UserGames", b =>
                {
                    b.HasOne("Model.Game", "Game")
                        .WithMany("UserGames")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Model.User", "User")
                        .WithMany("UserGames")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
