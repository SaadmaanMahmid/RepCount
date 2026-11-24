using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WorkoutLog.Data.Models;

namespace WorkoutLog.Data.Context;

public partial class WorkoutLogDbContext : DbContext
{
    public WorkoutLogDbContext(DbContextOptions<WorkoutLogDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ExerciseEntry> ExerciseEntries { get; set; }

    public virtual DbSet<Workout> Workouts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ExerciseEntry>(entity =>
        {
            entity.Property(e => e.ExerciseName).HasMaxLength(150);
            entity.Property(e => e.Weight).HasColumnType("decimal(7, 2)");

            entity.HasOne(d => d.Workout).WithMany(p => p.ExerciseEntries)
                .HasForeignKey(d => d.WorkoutId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExerciseEntries_Workouts");
        });

        modelBuilder.Entity<Workout>(entity =>
        {
            entity.Property(e => e.Notes).IsUnicode(false);
            entity.Property(e => e.WorkoutName)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
