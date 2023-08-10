using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Real.models;

namespace Real.data;
public class BloggingContext : DbContext
{
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Post> Posts { get; set; }

    public string ConnectionString { get; }

    public BloggingContext()
    {
        // Replace the connection string values with your actual PostgreSQL connection details
        var server = "localhost";
        var port = "5432";
        var database = "net2";
        var username = "postgres";
        var password = "password";

        ConnectionString = $"Server={server};Port={port};Database={database};User Id={username};Password={password};";
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(ConnectionString);
    }
}