using Domain.Entities.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class SocialDbContext : DbContext
    {
        public SocialDbContext(DbContextOptions<SocialDbContext> dbContextOptions) : base(dbContextOptions) 
        {

        }

        #region User 
        public DbSet<Activity> Activities { get; set; }

        #endregion
    }
}
