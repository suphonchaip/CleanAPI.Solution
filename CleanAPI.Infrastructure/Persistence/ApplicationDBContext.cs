using CleanAPI.Application.Common.Interfaces;
using CleanAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanAPI.Infrastructure.Persistence
{
	public class ApplicationDBContext : DbContext, IApplicationDBContext
	{
		public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
		 : base(options)
		{
		}

		public DbSet<PrefixEntity> Prefixes { get; set; }

		public Task<int> SaveChangesAsync()
		{
			return base.SaveChangesAsync();
		}
	}
}
