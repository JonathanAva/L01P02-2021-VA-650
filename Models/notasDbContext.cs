using Microsoft.EntityFrameworkCore;

namespace L01P02_2021_VA_650.Models
{
    public class notasDbContext : DbContext
    {
        public notasDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
