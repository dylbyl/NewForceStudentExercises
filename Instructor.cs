using System;
using System.Collections.Generic;

namespace students
{
    class Instructor
    {

        public string FirstName {get; set;}
        public string LastName{get; set;}

        public string SlackHandle{get; set;}
        public Cohort InstructorCohort{get; set;}
        public string Specialty{get; set;}
        public void AssignExercise(Student student, Exercise exercise){
            student.StudentExercises.Add(exercise);
        }
    }
}