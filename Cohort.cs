using System;
using System.Collections.Generic;

namespace students
{
    class Cohort
    {

        public string Name {get; set;}
        public List<Student> StudentList{get; set;} = new List<Student>();
        public List<Instructor> InstructorList{get; set;} = new List<Instructor>();
    }
}