using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PruebaTecnica.Models;

public partial class PruebaTecnicaDbContext : DbContext
{
    public PruebaTecnicaDbContext()
    {
    }

    public PruebaTecnicaDbContext(DbContextOptions<PruebaTecnicaDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Activity> Activities { get; set; }
    public virtual DbSet<Availability> Availabilities { get; set; }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<Reservation> Reservations { get; set; }

    public virtual DbSet<User> Users { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Activity>(entity =>
        {
            entity.HasKey(e => e.ActivityId).HasName("PK__Activiti__482FBD6384C2E3A1");

            entity.Property(e => e.ActivityId).HasColumnName("activity_id");
            entity.Property(e => e.ActivityCategory)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("activity_category");
            entity.Property(e => e.ActivityDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("activity_description");
            entity.Property(e => e.ActivityLocation)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("activity_location");
            entity.Property(e => e.ActivityPrice).HasColumnName("activity_price");
            entity.Property(e => e.ActivityTitle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("activity_title");
        });

        modelBuilder.Entity<Availability>(entity =>
        {
            entity.HasKey(e => e.AvailabilityId).HasName("PK__Availabi__86E3A801B90F01E5");

            entity.ToTable("Availability");

            entity.Property(e => e.AvailabilityId).HasColumnName("availability_id");
            entity.Property(e => e.ActivityId).HasColumnName("activity_id");
            entity.Property(e => e.AvailabilityDate)
                .HasColumnType("date")
                .HasColumnName("availability_date");

            entity.HasOne(d => d.Activity).WithMany(p => p.Availabilities)
                .HasForeignKey(d => d.ActivityId)
                .HasConstraintName("FK__Availabil__activ__3A81B327");
        });

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasKey(e => e.CommentId).HasName("PK__Comments__E795768717DD964E");

            entity.Property(e => e.CommentId).HasColumnName("comment_id");
            entity.Property(e => e.ActivityId).HasColumnName("activity_id");
            entity.Property(e => e.CommentContent)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("comment_content");
            entity.Property(e => e.CommentRating).HasColumnName("comment_rating");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Activity).WithMany(p => p.Comments)
                .HasForeignKey(d => d.ActivityId)
                .HasConstraintName("FK__Comments__activi__3E52440B");

            entity.HasOne(d => d.User).WithMany(p => p.Comments)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Comments__user_i__3D5E1FD2");
        });

        modelBuilder.Entity<Reservation>(entity =>
        {
            entity.HasKey(e => e.ReservationId).HasName("PK__Reservat__31384C296B446A11");

            entity.Property(e => e.ReservationId).HasColumnName("reservation_id");
            entity.Property(e => e.ActivityId).HasColumnName("activity_id");
            entity.Property(e => e.ReservationDate)
                .HasColumnType("date")
                .HasColumnName("reservation_date");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Activity).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.ActivityId)
                .HasConstraintName("FK__Reservati__activ__4222D4EF");

            entity.HasOne(d => d.User).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Reservati__user___412EB0B6");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__B9BE370F48B43AF1");

            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.UserEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("user_email");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("user_name");
            entity.Property(e => e.UserPassword)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("user_password");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
