using Data.Context;
using Domain.Entities.User;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class ActivitiesRepository : IActivitiesRepository
    {
        private readonly SocialDbContext _Db;

        public ActivitiesRepository(SocialDbContext Db)
        {
            _Db = Db;
        }

        #region Activities

        public async Task<List<Activity>> GetAllActivitiesAsync()
        {
            var activities =  _Db.Database.GetDbConnection().Query<Activity>("SELECT * FROM dbo.Activities").ToList();

            //var x = _Db.Activities.ToList();

            return activities;
        }
        #endregion
    }
}
