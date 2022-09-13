using Country.Models;
using Country.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Country.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeamMemberController : ControllerBase
    {
        private readonly ILogger<TeamMemberController> _logger;
        private readonly ITeamMemberService _teamMemberService;

        public TeamMemberController(ILogger<TeamMemberController> logger, ITeamMemberService teamMemberService)
        {
            _teamMemberService = teamMemberService;
            _logger = logger;
        }

        [HttpGet]
        [Route("GetTeamMember")]
        public BaseResponse<List<TeamMember>> GetTeamMember()
        {
            return _teamMemberService.GetTeamMember();
        }
    }

}