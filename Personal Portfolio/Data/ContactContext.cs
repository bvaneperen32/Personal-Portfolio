﻿using Microsoft.EntityFrameworkCore;
using Personal_Portfolio.Models;

namespace Personal_Portfolio.Data
{
	public class ContactContext : DbContext
	{
		public ContactContext(DbContextOptions<ContactContext> options) : base(options)
			{ }

		public DbSet<Personal_Portfolio.Models.ContactInfo> Contacts { get; set; }

	}
}
