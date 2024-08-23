namespace web_api_users.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required int Age { get; set; }
    }
}
