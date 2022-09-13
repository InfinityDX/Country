using Country.Models;
using Country.Services.Interfaces;

namespace Country.Services
{
    public class TeamMemberService : ITeamMemberService
    {
        List<TeamMember> TeamMembers = new List<TeamMember>() 
        {
            new TeamMember("Guy 1", "M", 21, "PP", "guy.1@gmail.com"),
            new TeamMember("Guy 2", "M", 22, "PP", "guy.2@gmail.com"),
            new TeamMember("Not Guy 1", "F", 23, "SR", "notguy.1@gmail.com"),
            new TeamMember("Guy 3", "M", 24, "PP", "guy.3@gmail.com"),
            new TeamMember("Guy 4", "M", 25, "PP", "guy.4@gmail.com"),
        };
        public BaseResponse<List<TeamMember>> GetTeamMember()
        {
            return new BaseResponse<List<TeamMember>>(0, "Success", TeamMembers);
        }
    }
}
