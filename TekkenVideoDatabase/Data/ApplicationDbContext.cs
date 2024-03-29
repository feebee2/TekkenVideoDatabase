using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TekkenVideoDatabase.Models;
using System;

namespace TekkenVideoDatabase.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        :base(options)
    {
    }

    public DbSet<VideoLink> Videos { get; set; }

}
