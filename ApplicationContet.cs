using System;
using System.Collections.Generic;
using System.Text;
using LibaryV1._0.Modules;
using Microsoft.EntityFrameworkCore;

public class ApplicationContext : DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Reader> Readers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasKey(u => new { u.ID });
        modelBuilder.Entity<Author>().HasKey(u => new { u.name, u.surname, u.middleName });
        //modelBuilder.Entity<Reader>().HasKey(u => new { u.user, u.book, u.page });
        //modelBuilder.Entity<Book>().HasKey(u => new { u.name, u.author });

        modelBuilder.Entity<Book>().HasNoKey();
        modelBuilder.Entity<Reader>().HasNoKey();

        modelBuilder.Entity<Book>().Ignore(c => c.author);
        modelBuilder.Entity<Reader>().Ignore(c => c.user);
        modelBuilder.Entity<Reader>().Ignore(c => c.book);
    }
    public ApplicationContext()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=FreeLibary;Trusted_Connection=True;");
    }
}