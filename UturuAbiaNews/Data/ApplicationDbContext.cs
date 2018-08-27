using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UturuAbiaNews.Models;

namespace UturuAbiaNews.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<UturuAbiaNews.Models.Category> Category { get; set; }
        public DbSet<UturuAbiaNews.Models.Content> Content { get; set; }
    }
}
