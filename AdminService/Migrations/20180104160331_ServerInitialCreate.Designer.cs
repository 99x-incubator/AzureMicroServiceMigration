using AdminService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AdminService.Migrations
{
    [DbContext(typeof(AdminDBContext))]
    [Migration("20180104160331_ServerInitialCreate")]
    partial class ServerInitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdminService.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerName");

                    b.Property<int?>("SystemUserUserID");

                    b.HasKey("CustomerId");

                    b.HasIndex("SystemUserUserID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("AdminService.Models.SystemUser", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("Password");

                    b.Property<int>("UserName");

                    b.HasKey("UserID");

                    b.ToTable("SystemUsers");
                });

            modelBuilder.Entity("AdminService.Models.Customer", b =>
                {
                    b.HasOne("AdminService.Models.SystemUser")
                        .WithMany("Customers")
                        .HasForeignKey("SystemUserUserID");
                });
#pragma warning restore 612, 618
        }
    }
}
