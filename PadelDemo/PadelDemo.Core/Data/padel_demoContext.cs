using Microsoft.EntityFrameworkCore;
using PadelDemo.Core.Data.Entities;
using PadelDemo.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadelDemo.Core.Data {
    public partial class padel_demoContext : DbContext {

        public padel_demoContext(DbContextOptions<padel_demoContext> options) : base(options)
        {

        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Club> Clubs { get; set; }
        public virtual DbSet<Court> Courts { get; set; }
        public virtual DbSet<Match> Matches { get; set; }
        public virtual DbSet<MatchPlayer> MatchPlayers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            #region User
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.FirstName).IsRequired();
                entity.Property(x => x.LastName).IsRequired();
                entity.Property(x => x.Email).IsRequired();
                entity.Property(x => x.DateOfBirth);
                entity.HasMany(x => x.Matches)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);
            });
            #endregion User

            #region Club
            modelBuilder.Entity<Club>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Name).IsRequired();
                entity.HasMany(x => x.Courts)
                .WithOne(x => x.Club)
                .HasForeignKey(x => x.ClubId);

            });
            #endregion Club

            #region Court
            modelBuilder.Entity<Court>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.ClubId).IsRequired();
                entity.Property(x => x.Name).IsRequired();
                entity.Property(x => x.IsCovered).IsRequired().HasDefaultValue(false);
                entity.Property(x => x.IsSingles).IsRequired().HasDefaultValue(false);
                entity.HasMany(x => x.Matches)
                .WithOne(x => x.Court)
                .HasForeignKey(x => x.CourtId);
            });
            #endregion Court

            #region Match
            modelBuilder.Entity<Match>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.ClubId).IsRequired();
                entity.Property(x => x.CourtId).IsRequired();
                entity.Property(x => x.Date).IsRequired();
                entity.HasMany(x => x.MatchPlayers)
                .WithOne(x => x.Match)
                .HasForeignKey(x => x.MatchId);
            });
            #endregion Match

            #region MatchPlayer
            modelBuilder.Entity<MatchPlayer>(entity =>
            {
                entity.HasKey(x => new { x.MatchId, x.UserId }); //composite key
                entity.Property(x => x.UserId).IsRequired();
                entity.Property(x => x.MatchId).IsRequired();
                entity.Property(x => x.IsWinner).IsRequired().HasDefaultValue(false);
            });
            #endregion MatchPlayer
        }
    }
}
