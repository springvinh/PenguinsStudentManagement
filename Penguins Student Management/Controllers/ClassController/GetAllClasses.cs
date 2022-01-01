﻿using Penguins_Student_Management.JsonDatabase.Entity.Document;
using Penguins_Student_Management.StateManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penguins_Student_Management.Controllers.ClassController
{
    partial class ClassController
    {
        public List<Class> GetAllClasses()
        {
            return Global.Database.Collections.Classes.Values.ToList();
        }
    }
}