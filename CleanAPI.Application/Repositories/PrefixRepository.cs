using CleanAPI.Application.Common.Interfaces;
using CleanAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanAPI.Application.Repositories
{
	public class PrefixRepository : IGenericRepository<Guid, PrefixEntity>
	{
		private readonly IApplicationDBContext _dbContext;

		public PrefixRepository(IApplicationDBContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<IReadOnlyList<PrefixEntity>> GetAllAsync()
		{
			return await _dbContext.Prefixes.ToListAsync();
		}

		public async Task<PrefixEntity?> GetByIdAsync(Guid id)
		{
			return await _dbContext.Prefixes.FirstOrDefaultAsync(x => x.Id == id);
		}
	}
}
