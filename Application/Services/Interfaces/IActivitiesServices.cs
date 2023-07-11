using Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IActivitiesServices
    {

        #region Activities

        Task<List<Activity>> GetAllActivitiesAsync();

        #endregion
    }
}
