using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using seiteAPI.Models;
using seiteAPI.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace seiteAPI.Services.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
        
    }

    public DbSet<UserModel> UserInfo {get; set;}
    public DbSet<StudentModel> StudentInfo {get; set;}
    public DbSet<GoalsModel> GoalInfo {get; set;}

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}