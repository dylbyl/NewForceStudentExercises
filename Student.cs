using System;
using System.Collections.Generic;

namespace students
{
    class Student
    {

        public string FirstName {get; set;}
        public string LastName{get; set;}

        public string SlackHandle{get; set;}
        public Cohort StudentCohort{get; set;}
        public List<Exercise> StudentExercises{get; set;} = new List<Exercise>();
    }
}
