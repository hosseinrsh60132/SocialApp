using Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain.Interfaces
{
    public interface IActivitiesRepository
    {

        #region Activities

        Task<List<Activity>> GetAllActivitiesAsync();
        
        #endregion
    }
}
