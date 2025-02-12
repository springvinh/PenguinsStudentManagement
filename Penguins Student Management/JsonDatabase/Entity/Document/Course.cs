﻿using System.Collections.Generic;

namespace Penguins_Student_Management.JsonDatabase.Entity.Document
{
    public class Course : IDocument
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Owner { get; set; }
        public List<string> Users { get; set; }
        public List<Section> Sections { get; set; }
    }
}
