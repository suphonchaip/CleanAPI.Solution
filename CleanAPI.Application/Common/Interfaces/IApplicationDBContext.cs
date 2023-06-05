using CleanAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanAPI.Application.Common.Interfaces
{
	public interface IApplicationDBContext
	{
		DbSet<PrefixEntity> Prefixes { get; set; }
		Task<int> SaveChangesAsync();
	}
}
