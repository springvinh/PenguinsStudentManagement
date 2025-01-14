﻿using Penguins_Student_Management.JsonDatabase.Entity.Document;
using System.Collections.Generic;
using System.Linq;

namespace Penguins_Student_Management.Controllers.UserController
{
    partial class UserController
    {
        public List<User> GetAllStudent()
        {
            List<User> students = new List<User>();

            Global.Database.Collections.Users.Values.ToList().ForEach(user =>
            {
                if (user.Type == User.AccountType.Student)
                {
                    User clone = new User()
                    {
                        ID = user.ID,
                        Name = user.Name,
                        Gender = user.Gender,
                        Birthday = user.Birthday,
                        Ethnic = user.Ethnic,
                        Hometown = user.Hometown,
                        Nationality = user.Nationality,
                        Class = Global.Database.Collections.Classes[user.Class].Name,
                        Password = user.Password,
                        Courses = user.Courses,
                        Type = user.Type
                    };

                    students.Add(clone);
                }
            });

            return students;
        }

    }
}
