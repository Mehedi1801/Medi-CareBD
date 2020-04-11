﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using madicare.Data;

namespace medi_CareBDAPI.Migrations
{
    [DbContext(typeof(medicareDBContext))]
    partial class medicareDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("medi_CareBDAPI.Controllers.Admin", b =>
                {
                    b.Property<int>("aid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("aaddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("adate_of_brith")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aemail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("agender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("apassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aphone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("aid");

                    b.ToTable("admin");
                });

            modelBuilder.Entity("medi_CareBDAPI.Controllers.AdminMediCare", b =>
                {
                    b.Property<int>("aid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("aaddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("adate_of_brith")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aemail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("agender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("apassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aphone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("aid");

                    b.ToTable("admin_medi_care");
                });

            modelBuilder.Entity("medi_CareBDAPI.Models.Doctor", b =>
                {
                    b.Property<int>("did")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("VillageId")
                        .HasColumnType("int");

                    b.Property<string>("daddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ddate_of_brith")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("demail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dgender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dpassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dphone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dqualification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("did");

                    b.HasIndex("VillageId");

                    b.ToTable("doctors");
                });

            modelBuilder.Entity("medi_CareBDAPI.Models.Patient", b =>
                {
                    b.Property<int>("pid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("mid")
                        .HasColumnType("int");

                    b.Property<string>("paddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pbmi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pbmr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pbp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pdate_of_brith")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pdisease")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pdiseaseSlove")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pgender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phight")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ppassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pphone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pweight")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("pid");

                    b.HasIndex("mid");

                    b.ToTable("patient");
                });

            modelBuilder.Entity("medi_CareBDAPI.Models.VillageDetails", b =>
                {
                    b.Property<int>("VillageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VillageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VillageId");

                    b.ToTable("VillageDetails");
                });

            modelBuilder.Entity("medi_CareBDAPI.Models.medicine", b =>
                {
                    b.Property<int>("MedicineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MedicineName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medicineinfo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MedicineId");

                    b.ToTable("medicines");
                });

            modelBuilder.Entity("medi_CareBDAPI.Models.test", b =>
                {
                    b.Property<int>("mid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("minfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("mid");

                    b.ToTable("tests");
                });

            modelBuilder.Entity("medi_CareBDAPI.Models.Doctor", b =>
                {
                    b.HasOne("medi_CareBDAPI.Models.VillageDetails", "villageDetails")
                        .WithMany("doctor")
                        .HasForeignKey("VillageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("medi_CareBDAPI.Models.Patient", b =>
                {
                    b.HasOne("medi_CareBDAPI.Models.test", "tests")
                        .WithMany("patients")
                        .HasForeignKey("mid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
