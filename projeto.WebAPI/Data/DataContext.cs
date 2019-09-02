using Microsoft.EntityFrameworkCore;
using projeto.WebAPI.Models;

namespace projeto.WebAPI.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options){}
        public DbSet<GameAccount> GameAccounts{get;set;}
    }
}