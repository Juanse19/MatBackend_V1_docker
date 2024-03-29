﻿/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using System;
using IoT.DataAccess.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IoT.DataAccess.EFCore.Migrations
{
    [DbContext(typeof(IoTDataContext))]
    partial class IoTDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("iot_core")
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Common.Entities.BaseRole", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy",
                        SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Discriminator")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Roles");

                b.HasDiscriminator<string>("Discriminator").HasValue("BaseRole");
            });

            modelBuilder.Entity("Common.Entities.BaseUser", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy",
                        SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("AddressCity")
                    .HasColumnName("City")
                    .HasColumnType("nvarchar(max)");

                b.Property<double?>("AddressLat")
                    .HasColumnName("Lat")
                    .HasColumnType("float");

                b.Property<double?>("AddressLng")
                    .HasColumnName("Lng")
                    .HasColumnType("float");

                b.Property<string>("AddressStreet")
                    .HasColumnName("Street")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("AddressZipCode")
                    .HasColumnName("ZipCode")
                    .HasColumnType("nvarchar(max)");

                b.Property<int?>("Age")
                    .HasColumnType("int");

                b.Property<string>("Discriminator")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Email")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("FirstName")
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("IsDeleted")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bit")
                    .HasDefaultValue(false);

                b.Property<string>("LastName")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Login")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Password")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Users");

                b.HasDiscriminator<string>("Discriminator").HasValue("BaseUser");
            });

            modelBuilder.Entity("Common.Entities.BaseUserClaim", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy",
                        SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("ClaimType")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("ClaimValue")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Discriminator")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("UserId")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("UserId");

                b.ToTable("UserClaims");

                b.HasDiscriminator<string>("Discriminator").HasValue("BaseUserClaim");
            });

            modelBuilder.Entity("Common.Entities.BaseUserRole", b =>
            {
                b.Property<int>("UserId")
                    .HasColumnType("int");

                b.Property<int>("RoleId")
                    .HasColumnType("int");

                b.Property<string>("Discriminator")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("UserId", "RoleId");

                b.HasIndex("RoleId");

                b.ToTable("UserRoles");

                b.HasDiscriminator<string>("Discriminator").HasValue("BaseUserRole");
            });

            modelBuilder.Entity("Common.Entities.Settings", b =>
            {
                b.Property<int>("Id")
                    .HasColumnType("int");

                b.Property<string>("ThemeName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Settings");
            });

            modelBuilder.Entity("Common.Entities.UserPhoto", b =>
            {
                b.Property<int>("Id")
                    .HasColumnType("int");

                b.Property<byte[]>("Image")
                    .IsRequired()
                    .HasColumnType("varbinary(max)");

                b.HasKey("Id");

                b.ToTable("UserPhotos");
            });

            modelBuilder.Entity("IoT.Entities.Contact", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy",
                        SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("CreatedByUserId")
                    .HasColumnType("int");

                b.Property<DateTime>("CreatedDate")
                    .HasColumnType("datetime2");

                b.Property<string>("FirstName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("LastName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("NumberType")
                    .HasColumnType("int");

                b.Property<string>("PhoneNumber")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("UpdatedByUserId")
                    .HasColumnType("int");

                b.Property<DateTime>("UpdatedDate")
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.ToTable("Contacts");
            });

            modelBuilder.Entity("IoT.Entities.ContactPhoto", b =>
            {
                b.Property<int>("Id")
                    .HasColumnType("int");

                b.Property<byte[]>("Image")
                    .IsRequired()
                    .HasColumnType("varbinary(max)");

                b.HasKey("Id");

                b.ToTable("ContactPhotos");
            });

            modelBuilder.Entity("IoT.Entities.Device", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy",
                        SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("CreatedByUserId")
                    .HasColumnType("int");

                b.Property<DateTime>("CreatedDate")
                    .HasColumnType("datetime2");

                b.Property<bool>("IsOn")
                    .HasColumnType("bit");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("Type")
                    .HasColumnType("int");

                b.Property<int>("UpdatedByUserId")
                    .HasColumnType("int");

                b.Property<DateTime>("UpdatedDate")
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.HasIndex("CreatedByUserId");

                b.HasIndex("UpdatedByUserId");

                b.ToTable("Devices");
            });

            modelBuilder.Entity("IoT.Entities.DeviceParameter", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy",
                        SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("CreatedByUserId")
                    .HasColumnType("int");

                b.Property<DateTime>("CreatedDate")
                    .HasColumnType("datetime2");

                b.Property<int>("DeviceId")
                    .HasColumnType("int");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("UpdatedByUserId")
                    .HasColumnType("int");

                b.Property<DateTime>("UpdatedDate")
                    .HasColumnType("datetime2");

                b.Property<string>("Value")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.HasIndex("CreatedByUserId");

                b.HasIndex("DeviceId");

                b.HasIndex("UpdatedByUserId");

                b.ToTable("DeviceParameters");
            });

            modelBuilder.Entity("IoT.Entities.ElectricityConsumption", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy",
                        SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("ConsumedValue")
                    .HasColumnType("int");

                b.Property<DateTime>("Date")
                    .HasColumnType("datetime2");

                b.Property<int>("SpentMoneyValue")
                    .HasColumnType("int");

                b.Property<int>("Type")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("ElectricityConsumptions");
            });

            modelBuilder.Entity("IoT.Entities.PhoneCall", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy",
                        SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("ContactId")
                    .HasColumnType("int");

                b.Property<DateTime>("DateOfCall")
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.HasIndex("ContactId");

                b.ToTable("PhoneCalls");
            });

            modelBuilder.Entity("IoT.Entities.TrafficConsumption", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy",
                        SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("ConsumedValue")
                    .HasColumnType("int");

                b.Property<DateTime>("Date")
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.ToTable("TrafficConsumptions");
            });

            modelBuilder.Entity("IoT.Entities.System.Role", b =>
            {
                b.HasBaseType("Common.Entities.BaseRole");

                b.HasDiscriminator().HasValue("Role");
            });

            modelBuilder.Entity("IoT.Entities.System.User", b =>
            {
                b.HasBaseType("Common.Entities.BaseUser");

                b.HasDiscriminator().HasValue("User");
            });

            modelBuilder.Entity("IoT.Entities.System.UserClaim", b =>
            {
                b.HasBaseType("Common.Entities.BaseUserClaim");

                b.HasDiscriminator().HasValue("UserClaim");
            });

            modelBuilder.Entity("IoT.Entities.System.UserRole", b =>
            {
                b.HasBaseType("Common.Entities.BaseUserRole");

                b.HasDiscriminator().HasValue("UserRole");
            });

            modelBuilder.Entity("Common.Entities.BaseUserClaim", b =>
            {
                b.HasOne("Common.Entities.BaseUser", null)
                    .WithMany("Claims")
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("Common.Entities.BaseUserRole", b =>
            {
                b.HasOne("Common.Entities.BaseRole", "Role")
                    .WithMany("UserRoles")
                    .HasForeignKey("RoleId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Common.Entities.BaseUser", null)
                    .WithMany("UserRoles")
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("Common.Entities.Settings", b =>
            {
                b.HasOne("Common.Entities.BaseUser", "User")
                    .WithOne("Settings")
                    .HasForeignKey("Common.Entities.Settings", "Id")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("Common.Entities.UserPhoto", b =>
            {
                b.HasOne("Common.Entities.BaseUser", "User")
                    .WithOne("Photo")
                    .HasForeignKey("Common.Entities.UserPhoto", "Id")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("IoT.Entities.ContactPhoto", b =>
            {
                b.HasOne("IoT.Entities.Contact", "Contact")
                    .WithOne("Photo")
                    .HasForeignKey("IoT.Entities.ContactPhoto", "Id")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("IoT.Entities.Device", b =>
            {
                b.HasOne("IoT.Entities.System.User", "CreatedByUser")
                    .WithMany("DevicesCreatedBy")
                    .HasForeignKey("CreatedByUserId")
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();

                b.HasOne("IoT.Entities.System.User", "UpdatedByUser")
                    .WithMany("DevicesUpdatedBy")
                    .HasForeignKey("UpdatedByUserId")
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();
            });

            modelBuilder.Entity("IoT.Entities.DeviceParameter", b =>
            {
                b.HasOne("IoT.Entities.System.User", "CreatedByUser")
                    .WithMany("ParametersCreatedBy")
                    .HasForeignKey("CreatedByUserId")
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();

                b.HasOne("IoT.Entities.Device", "Device")
                    .WithMany("Parameters")
                    .HasForeignKey("DeviceId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("IoT.Entities.System.User", "UpdatedByUser")
                    .WithMany("ParametersUpdatedBy")
                    .HasForeignKey("UpdatedByUserId")
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();
            });

            modelBuilder.Entity("IoT.Entities.PhoneCall", b =>
            {
                b.HasOne("IoT.Entities.Contact", "Contact")
                    .WithMany("Calls")
                    .HasForeignKey("ContactId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });
#pragma warning restore 612, 618
        }
    }
}