using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebNadianSoft.DataBase.Entities;

namespace WebNadinSoft.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
{
    public virtual DbSet<Product> Product { get; set; }
}
