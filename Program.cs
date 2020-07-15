using System;

namespace students
{
    class Program
    {

        static void AssignStudentCohort(Student student, Cohort cohort){
            student.StudentCohort = cohort;
            cohort.StudentList.Add(student);
        }

        static void AssignInstructorCohort(Instructor instructor, Cohort cohort){
            instructor.InstructorCohort = cohort;
            cohort.InstructorList.Add(instructor);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Exercise students = new Exercise(){
                Name = "Students Exercise",
                Language = "C#"
            };
            Exercise library = new Exercise(){
                Name = "Library",
                Language = "React"
            };
            Exercise kennel = new Exercise(){
                Name = "Kennel",
                Language = "React"
            };
            Exercise weather = new Exercise(){
                Name = "Weather Tracker",
                Language = "JavaScript"
            };

            Cohort cohortOne = new Cohort(){
                Name = "Cohort One"
            };
            Cohort cohortTwo = new Cohort(){
                Name = "Cohort Two"
            };
            Cohort cohortThree = new Cohort(){
                Name = "Cohort Three"
            };

            Student studentOne = new Student(){
                FirstName = "Student",
                LastName = "One",
                SlackHandle = "studentone"
            };
            AssignStudentCohort(studentOne, cohortOne);

            Student studentTwo = new Student(){
                FirstName = "Student",
                LastName = "Two",
                SlackHandle = "studentTwo"
            };
            AssignStudentCohort(studentTwo, cohortTwo);

            Student studentThree = new Student(){
                FirstName = "Student",
                LastName = "Three",
                SlackHandle = "studentThree"
            };
            AssignStudentCohort(studentThree, cohortThree);

            Student studentFour = new Student(){
                FirstName = "Student",
                LastName = "Four",
                SlackHandle = "studentFour"
            };
            AssignStudentCohort(studentFour, cohortOne);

            Instructor instructorOne = new Instructor(){
                FirstName = "Instructor",
                LastName = "One",
                SlackHandle = "instructorone"
            };
            AssignInstructorCohort(instructorOne, cohortOne);

            Instructor instructorTwo = new Instructor(){
                FirstName = "Instructor",
                LastName = "Two",
                SlackHandle = "instructorTwo"
            };
            AssignInstructorCohort(instructorTwo, cohortTwo);

            Instructor instructorThree = new Instructor(){
                FirstName = "Instructor",
                LastName = "Three",
                SlackHandle = "instructorThree"
            };
            AssignInstructorCohort(instructorThree, cohortThree);

            instructorOne.AssignExercise(studentOne, students);
            instructorOne.AssignExercise(studentOne, kennel);
            instructorOne.AssignExercise(studentFour, library);
            instructorOne.AssignExercise(studentFour, weather);
            instructorTwo.AssignExercise(studentTwo, weather);
            instructorTwo.AssignExercise(studentTwo, kennel);
            instructorThree.AssignExercise(studentThree, library);
            instructorThree.AssignExercise(studentThree, students);

            Console.WriteLine();

        }
    }
}
