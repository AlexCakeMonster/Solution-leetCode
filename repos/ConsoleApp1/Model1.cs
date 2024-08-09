using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ConsoleApp1
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=GrandSlamdbcon")
        {
        }

        public virtual DbSet<Courts> Courts { get; set; }
        public virtual DbSet<Matches> Matches { get; set; }
        public virtual DbSet<PlayerInfos> PlayerInfos { get; set; }
        public virtual DbSet<Players> Players { get; set; }
        public virtual DbSet<PlayerStats> PlayerStats { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tournaments> Tournaments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Courts>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Courts>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Courts>()
                .Property(e => e.Surface)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Courts>()
                .HasMany(e => e.Matches)
                .WithOptional(e => e.Courts)
                .HasForeignKey(e => e.CourtId);

            modelBuilder.Entity<Matches>()
                .Property(e => e.Round)
                .IsUnicode(false);

            modelBuilder.Entity<Matches>()
                .Property(e => e.Time)
                .HasPrecision(0);

            modelBuilder.Entity<Matches>()
                .HasMany(e => e.PlayerStats)
                .WithOptional(e => e.Matches)
                .HasForeignKey(e => e.MatcId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<PlayerInfos>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<PlayerInfos>()
                .Property(e => e.BirthPlace)
                .IsUnicode(false);

            modelBuilder.Entity<PlayerInfos>()
                .Property(e => e.Residence)
                .IsUnicode(false);

            modelBuilder.Entity<Players>()
                .Property(e => e.FName)
                .IsUnicode(false);

            modelBuilder.Entity<Players>()
                .Property(e => e.LName)
                .IsUnicode(false);

            modelBuilder.Entity<Players>()
                .HasMany(e => e.PlayerInfos)
                .WithOptional(e => e.Players)
                .HasForeignKey(e => e.PlayerId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Players>()
                .HasMany(e => e.PlayerStats)
                .WithOptional(e => e.Players)
                .HasForeignKey(e => e.PlayerId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Tournaments>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Tournaments>()
                .HasMany(e => e.Matches)
                .WithOptional(e => e.Tournaments)
                .HasForeignKey(e => e.TournamentId);
        }
    }
}
