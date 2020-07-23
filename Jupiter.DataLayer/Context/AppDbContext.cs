using Microsoft.EntityFrameworkCore;

namespace Jupiter.DataLayer.Context
{
    public class AppDbContext : DbContext
    {
        #region constructor

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        #endregion


     

    }
}
