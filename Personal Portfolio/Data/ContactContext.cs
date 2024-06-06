using Microsoft.EntityFrameworkCore;
using Personal_Portfolio.Models;

namespace Personal_Portfolio.Data
{
	public class ContactContext : DbContext
	{
		public ContactContext(DbContextOptions<ContactContext> options) : base(options)
			{ }

		public DbSet<ContactInfo> Contacts { get; set; }
		public DbSet<SocialMediaInfo> SocialMediaInfos { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<SocialMediaInfo>().HasData(
				new SocialMediaInfo { Id = 1, Platform = "Instagram", Url = "TODO", IconClass = "fa fa-instagram" },
				new SocialMediaInfo { Id = 2, Platform = "LinkedIn", Url = "TODO", IconClass = "fa fa-linkedin" },
				new SocialMediaInfo { Id = 3, Platform = "Twitter", Url = "TODO", IconClass = "fa fa-twitter" },
				new SocialMediaInfo { Id = 4, Platform = "GitHub", Url = "TODO", IconClass = "fa fa-github" }
				);
		}
	}
}
