using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Prak
{
    public class ConnectBD
    {
        private MongoClient client;
        private IMongoDatabase db;
        private IMongoCollection<Users> collection;

        public ConnectBD() // Конструктор создания подключения к БД
        {
            // Создаем клиента и получаем доступ к БД и коллекции
            client = new MongoClient("mongodb://localhost:27017");
            db = client.GetDatabase("DB");
            collection = db.GetCollection<Users>("Users");
        }

        public Users FindUser(string login) // Метод авторизации
        {
            // Ищем пользователя с заданным логином
            var filter = Builders<Users>.Filter.Eq("Login", login);
            var result = collection.Find(filter).FirstOrDefault();
            return result;
        }

        public bool AddUser(Users user) // Метод регистрации
        {
            // Проверяем, что пользователь с таким логином еще не зарегистрирован
            if (FindUser(user.Login) != null)
            {
                return false; // Если пользователь уже существует, возвращаем false
            }

            // Добавляем нового пользователя
            collection.InsertOne(user);
            return true; // Возвращаем true в случае успешной регистрации
        }
    }
}
