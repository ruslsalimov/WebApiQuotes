﻿using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Quotes.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<QuoteOnVerification> QuotesOnVerification { get; set; }
        public DbSet<ThemeOnVerification> ThemesOnVerification { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
