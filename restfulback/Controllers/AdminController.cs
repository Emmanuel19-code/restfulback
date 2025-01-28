using Microsoft.AspNetCore.Mvc;
using restfulback.Domain;
using restfulback.Domain.Contracts;
using restfulback.Services;

namespace restfulback.Controllers
{
    [Route("/api/admin")]
    [ApiController]
    public class AdminContoller : ControllerBase
    {
        private readonly IAdminService _adminService;
        public AdminContoller(IAdminService adminService)
        {
            _adminService = adminService;
        }
        [HttpPost("register_deceased")]
        public async Task<ActionResult<ApiResponse>> RegisterDeceasedPerson([FromBody] AddDeceasedData request)
        {
            var response = await _adminService.RegisterDeceased(request);
            if(response.StatusCode !=200)
            {
                return response;
            }
            return response;
        }

        [HttpGet("profile_data/{Id}")]
        public async Task<ActionResult<ApiDataResponse<DeceasedData>>> GetDeceasedProfile(Guid Id)
        {
            var response = await _adminService.GetDeceasedInfo(Id);
            return response;
        }

        [HttpGet("all_profile")]
        public async Task<ActionResult<ApiDataResponse<List<DeceasedData>>>> AllDataProfiles()
        {
            var response = await _adminService.AllRegisteredData();
            return response;
        }

        [HttpPost("user_access")]
        public async Task<ActionResult<ApiDataResponse<string>>> UserAccess(AccessDto request)
        {
            var response = await _adminService.Login(request);
            
             return response;
        }
    }
}