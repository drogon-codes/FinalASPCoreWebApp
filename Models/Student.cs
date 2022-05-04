using System;
using System.Collections.Generic;

namespace PracticeCoreApp.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Gender { get; set; }
        public string Contact { get; set; }
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
