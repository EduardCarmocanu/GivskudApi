using GivskudApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GivskudApi.Data
{
	public class ApplicationDataContext : DbContext
	{
		public DbSet<Marker> Markers { get; set; }
		public DbSet<MarkerType> MarkerTypes{ get; set; }
		public DbSet<Description> Descriptions { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Marker>(entity => 
			{
				entity.Property(m => m.Lat).HasColumnType("decimal(18, 15)");
				entity.Property(m => m.Lng).HasColumnType("decimal(18, 15)");
			});
		}

		public ApplicationDataContext(DbContextOptions options) : base(options)
		{
			Database.EnsureCreated();
		}
	}
}
