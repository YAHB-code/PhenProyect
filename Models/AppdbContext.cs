using Microsoft.EntityFrameworkCore;
using PhenProyect.Models;
namespace PhenProyect.Context;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}
    
     public DbSet<UserData>Userdatas{get;set;}
     public DbSet<Phone>Phones{get;set;}
     public DbSet<Picture>Pictures{get;set;}
     public DbSet<Message>Messages{get;set;}
}