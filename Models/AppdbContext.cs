using Microsoft.EntityFrameworkCore;

namespace PhenProyect.Context;
public class AppDbContext : DbContext
{   
 public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}
}