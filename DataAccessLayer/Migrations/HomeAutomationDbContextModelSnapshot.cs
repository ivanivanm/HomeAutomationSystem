﻿// <auto-generated />
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(HomeAutomationDbContext))]
    partial class HomeAutomationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccessLayer.BuilderModels.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("HomeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("On")
                        .HasColumnType("bit");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HomeId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("DataAccessLayer.MainModel.Home", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Home");
                });

            modelBuilder.Entity("DataAccessLayer.Models.AirConditioner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ACMode")
                        .HasColumnType("int");

                    b.Property<int>("AirDir")
                        .HasColumnType("int");

                    b.Property<int>("AirSpeed")
                        .HasColumnType("int");

                    b.Property<bool>("IsOn")
                        .HasColumnType("bit");

                    b.Property<int>("LateStart")
                        .HasColumnType("int");

                    b.Property<int>("LateStop")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<bool>("SelfCleaning")
                        .HasColumnType("bit");

                    b.Property<double>("Temperature")
                        .HasColumnType("float");

                    b.Property<bool>("Turbo")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Conditioners");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Fridge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("EnergyEffectiveness")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOn")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<bool>("SmartCooling")
                        .HasColumnType("bit");

                    b.Property<int>("Temperature")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Fridges");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Lamp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsOn")
                        .HasColumnType("bit");

                    b.Property<int>("LightnessFactor")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Lamps");
                });

            modelBuilder.Entity("DataAccessLayer.Models.TV", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsOn")
                        .HasColumnType("bit");

                    b.Property<int>("LightnessFactor")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("NightMode")
                        .HasColumnType("bit");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<int>("Volume")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("TVs");
                });

            modelBuilder.Entity("DataAccessLayer.BuilderModels.Room", b =>
                {
                    b.HasOne("DataAccessLayer.MainModel.Home", "Home")
                        .WithMany("Rooms")
                        .HasForeignKey("HomeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Home");
                });

            modelBuilder.Entity("DataAccessLayer.Models.AirConditioner", b =>
                {
                    b.HasOne("DataAccessLayer.BuilderModels.Room", "Room")
                        .WithMany("AirConditioners")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Fridge", b =>
                {
                    b.HasOne("DataAccessLayer.BuilderModels.Room", "Room")
                        .WithMany("Fridges")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Lamp", b =>
                {
                    b.HasOne("DataAccessLayer.BuilderModels.Room", "Room")
                        .WithMany("Lamps")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("DataAccessLayer.Models.TV", b =>
                {
                    b.HasOne("DataAccessLayer.BuilderModels.Room", "Room")
                        .WithMany("TVs")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("DataAccessLayer.BuilderModels.Room", b =>
                {
                    b.Navigation("AirConditioners");

                    b.Navigation("Fridges");

                    b.Navigation("Lamps");

                    b.Navigation("TVs");
                });

            modelBuilder.Entity("DataAccessLayer.MainModel.Home", b =>
                {
                    b.Navigation("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
