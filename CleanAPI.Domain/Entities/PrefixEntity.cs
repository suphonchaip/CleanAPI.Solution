using CleanAPI.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanAPI.Domain.Entities
{
	public class PrefixEntity : BaseEntity<Guid>
	{
		public string Name { get; set; } = string.Empty;
	}
}
