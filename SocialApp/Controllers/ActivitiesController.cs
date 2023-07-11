using Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace SocialApp.Api.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        private readonly IActivitiesServices _activitiesServices;

        public ActivitiesController(IActivitiesServices activitiesServices)
        {
            _activitiesServices = activitiesServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllActivity()
        {

            var activity = _activitiesServices.GetAllActivitiesAsync();
            return new JsonResult(activity);
        }
    }
}
