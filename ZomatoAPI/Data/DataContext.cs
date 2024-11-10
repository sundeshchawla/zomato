using System;
using Microsoft.EntityFrameworkCore;
using ZomatoAPI.Entities;

namespace ZomatoAPI.Data;

public class DataContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<AppUser> Users { get; set; }
}
