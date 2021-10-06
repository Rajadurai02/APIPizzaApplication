﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToppingDetailsAPI.Models;

namespace ToppingDetailsAPI.Migrations
{
    [DbContext(typeof(CompanyContext))]
    partial class CompanyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ToppingDetailsAPI.Models.Topping", b =>
                {
                    b.Property<int>("ToppingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ToppingName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ToppingPrice")
                        .HasColumnType("int");

                    b.HasKey("ToppingID");

                    b.ToTable("Toppings");

                    b.HasData(
                        new
                        {
                            ToppingID = 1,
                            ToppingName = "Olives",
                            ToppingPrice = 2
                        },
                        new
                        {
                            ToppingID = 2,
                            ToppingName = "Tomato",
                            ToppingPrice = 5
                        },
                        new
                        {
                            ToppingID = 3,
                            ToppingName = "Onion",
                            ToppingPrice = 4
                        },
                        new
                        {
                            ToppingID = 4,
                            ToppingName = "Cheese",
                            ToppingPrice = 6
                        });
                });
#pragma warning restore 612, 618
        }
    }
}