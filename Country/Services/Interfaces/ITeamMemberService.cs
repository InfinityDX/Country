using Country.Models;

namespace Country.Services.Interfaces
{
    public interface ITeamMemberService
    {
        BaseResponse<List<TeamMember>> GetTeamMember();
    }
}
