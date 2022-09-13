namespace Country.Models
{
    public class TeamMember
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public TeamMember(string name, string gender, int age, string address, string email)
        {
            Name = name;
            Gender = gender;
            Age = age;
            Address = address;
            Email = email;
        }
    }
}
