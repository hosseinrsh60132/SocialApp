using Application.Services.Interfaces;
using Domain.Entities.User;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementation
{
    public class ActivitiesServices : IActivitiesServices
    {

        private readonly IActivitiesRepository _activitiesRepository;

        public ActivitiesServices(IActivitiesRepository activitiesRepository)
        {
            _activitiesRepository = activitiesRepository;
        }

        #region Activities

        public async Task<List<Activity>> GetAllActivitiesAsync()
        {

            //var x = _Db.Activities.ToList();

            return await _activitiesRepository.GetAllActivitiesAsync();
        }
        #endregion
    }
}
