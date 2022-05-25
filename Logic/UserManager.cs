using System;
using System.Collections.Generic;

namespace Logic
{
    public class UserManager : IUserManager
    {
        public List<User> Users { get; set; }
        public UserManager()
        {
            Users = new List<User>()
            {
                new User() { Id = 1, Name = "Juan"},
                new User() { Id = 2,Name = "Pepe"},
            };
        }
        public List<User> GetUsers()
        {
            return Users;

        }

        public User PostUser(User user)
        {
            Users.Add(user);
            return user;
        }

        public User DeleteUser(int userId)
        {
            User userFound = Users.Find(u => u.Id == userId);
            if (userFound != null)
            {
                Users.Remove(userFound);
                return userFound;
            }
            else
            {
                return null;
            }
        }

        public User PutUser(User user)
        {
            User userUpdate = Users.Find(u => u.Id == user.Id);
            if (userUpdate == null)
            {
                return null;
            }
            else
            {
                userUpdate.Name = user.Name;
                userUpdate.Id = user.Id;
                return user;
            }
        }
    }
}
