using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

using FinalProjectWorkspace.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace FinalProjectWorkspace.DAL

{
    public class AppDbContext: IdentityDbContext<AppUser>
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        //public DbSet<Product> Products { get; set; }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Showing> Showings { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<FinalProjectWorkspace.Models.Order> Order { get; set; }
        public DbSet<FinalProjectWorkspace.Models.Ticket> Ticket { get; set; }
        public DbSet<FinalProjectWorkspace.Models.MovieReview> MovieReview { get; set; }

    }
}
