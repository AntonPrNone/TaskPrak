using MongoDB.Bson;

namespace Task2Prak
{
    public class Users
    {
        public ObjectId Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
