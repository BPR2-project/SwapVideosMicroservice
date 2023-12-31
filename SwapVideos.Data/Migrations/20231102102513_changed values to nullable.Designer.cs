﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SwapVideos.Data;

#nullable disable

namespace SwapVideos.Data.Migrations
{
    [DbContext(typeof(SwapVideosContext))]
    [Migration("20231102102513_changed values to nullable")]
    partial class changedvaluestonullable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SwapVideos.Data.Models.SwapVideoEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AMSJobName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AMSLocatorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AMSOutputAssetName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionFormattedString")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionHtmlCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("DestroyedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("DestroyedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExternalId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InternalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsCountingInAsWeeklyWatch")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsInternallyModified")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsLearningMaterial")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsUploadedTowardsAMS")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderInCategory")
                        .HasColumnType("int");

                    b.Property<string>("ThumbnailUri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TotalClicks")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VideoLength")
                        .HasColumnType("int");

                    b.Property<string>("VideoLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SwapVideoEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
