using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Data.Models;

public partial class TicketContext : DbContext
{
    public TicketContext()
    {
    }

    public TicketContext(DbContextOptions<TicketContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Route> Routes { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-H56BTO6;Initial Catalog=Ticket;Integrated Security=True;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Route>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Routes__3214EC078055B70C");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Destinations).HasMaxLength(50);
            entity.Property(e => e.Origin).HasMaxLength(50);
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Routes__3214EC07CFA5D47D");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Arrival).HasColumnType("datetime");
            entity.Property(e => e.BookedBy).HasColumnName("BOOKED_BY");
            entity.Property(e => e.Departure).HasColumnType("datetime");
            entity.Property(e => e.Destination).HasMaxLength(50);
            entity.Property(e => e.Origin).HasMaxLength(50);
            entity.Property(e => e.TravlerName)
                .HasMaxLength(50)
                .HasColumnName("TRAVLER_NAME");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Table__206D917062309AD1");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("User_Id");
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("Creation_Date");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("Expiry_Date");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .HasColumnName("User_Name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
