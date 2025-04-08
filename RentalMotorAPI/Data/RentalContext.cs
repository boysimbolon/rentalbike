using Microsoft.EntityFrameworkCore;
using RentalMotorAPI.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace RentalMotorAPI.Data;

public class RentalContext : DbContext
{
    public RentalContext(DbContextOptions<RentalContext> options) : base(options) { }

    public DbSet<Motor> Motors => Set<Motor>();
    public DbSet<DataBooking> DataBookings => Set<DataBooking>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Motor>()
            .HasMany(m => m.DataBookings)
            .WithOne(b => b.Motor!)
            .HasForeignKey(b => b.MotorId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<DataBooking>()
            .Property(b => b.RentalStatus)
            .HasConversion<string>();
    }
}
