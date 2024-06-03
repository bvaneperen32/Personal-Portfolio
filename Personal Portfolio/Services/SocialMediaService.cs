using Microsoft.EntityFrameworkCore;
using Personal_Portfolio.Data;
using Personal_Portfolio.Models;
using System.Threading.Tasks;
using System.Collections.Generic; 

namespace Personal_Portfolio.Services
{
	public class SocialMediaService
	{
		private readonly ContactContext _contactContext;

		public SocialMediaService (ContactContext contactContext)
		{
			_contactContext = contactContext;
		}

		public async Task<List<SocialMediaInfo>> GetSocialMediaLinksAsync()
		{
			return await _contactContext.SocialMediaInfos.ToListAsync();
		}
	}
}
