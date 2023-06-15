using System;
using System.Windows.Forms;
using WindowsFormsAppTaskFinal.DataModels;
/*using System.Collections.Generic;
using WindowsFormsAppTaskFinal.DataModels.Persons;
using WindowsFormsAppTaskFinal.DataModels.Persons.Lecturers;
using WindowsFormsAppTaskFinal.DataModels.Persons.Students;*/

namespace WindowsFormsAppTaskFinal
{
    [Serializable]
    public static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //=========================================================================================================
            //------------------------------ Objects in the system and their credentials ------------------------------
            //----------------- Make sure to uncomment imports above when trying to save objects to file --------------
            /*var course1 = new Course("1223480", "Column Design", "The course will teach" +
                                                                 "you more about the development of column styles " +
                                                                 "throughout history",
                new DateTime(2015, 12, 22), new DateTime(2016, 2, 24));
            var course2 = new Course("2341232", "Interior Decor", "The course will give you an artistic vision of how" +
                                                                  "interior decor is done",
                new DateTime(2016, 4, 17), new DateTime(2016, 7, 2));
            var course3 = new Course("321823", "Kotlin", "The course will give you useful tools in practical coding" +
                                                                  "experience when using Kotlin",
                new DateTime(2015, 10, 27), new DateTime(2015, 12, 28));
            var course4 = new Course("3247324", "Python Scripting", "The course will give you practical experience on" +
                                                                  "writing Python scripts",
                new DateTime(2015, 10, 16), new DateTime(2016, 1, 4));
            var course5 = new Course("546542", "Bass and Equalization", "The course will give you an insight on the importance" +
                                                                  "of bass and equalization balance",
                new DateTime(2017, 11, 17), new DateTime(2018, 4, 4));
            var course6 = new Course("546542", "Audio Equipment Setup", "The course will give you practical experience on" +
                                                                        "how to set up audio equipment",
                new DateTime(2017, 11, 17), new DateTime(2018, 4, 4));
            var course7 = new Course("3243243", "Social Engineering", "The course will give you practical experience on" +
                                                                  "how to convince and persuade others",
                new DateTime(2018, 1, 16), new DateTime(2019, 1, 5));
            var course8 = new Course("8372812", "Negotiation", "The course will give you practical experience on" +
                "how to negotiate to please both sides",
                new DateTime(2018, 1, 27), new DateTime(2019, 1, 12));
            var course9 = new Course("1228321", "Leadership Skills", "The course will give you practical experience on" +
                "how to use develop leadership pack traits",
                new DateTime(2018, 2, 3), new DateTime(2019, 1, 24));
            var academicTrack1 = new Track("Architectural Design");
            var academicTrack2 = new Track("Cyber Security");
            var academicTrack3 = new Track("Binaural Shape Waves");
            var academicTrack4 = new Track("Structural Management");
            academicTrack1.IncludedCourses = new List<Course> {course1, course2 };
            academicTrack2.IncludedCourses = new List<Course> {course3, course4 };
            academicTrack3.IncludedCourses = new List<Course> {course5, course6 };
            academicTrack4.IncludedCourses = new List<Course> {course7, course8, course9 };
            var student1 = new Student(123123123, "Avi", "Cohen", 22,
                "0528129321", "avicohen@gmail.com", "122344566", 238, "Architecture", academicTrack1,
                20500, 9500, 25000);
            var student2 = new Student(322564323, "Ibrahim", "Azam", 21,
                "0592837123", "ibrahimaz@gmail.com", "233455677", 612, "Exterior Blueprinting", academicTrack1,
                18760, 10500, 31230);
            var student3 = new Student(384728182, "Benjamin", "Jacobs", 31,
                "0527182732", "benjamin123@gmail.com", "344566788", 704, "Floor Tiling", academicTrack1,
                29320, 12900, 38535);
            var student4 = new Student(829382912, "James", "Wellington", 39,
                "0291829321", "jamiewells@gmail.com", "455677899", 732, "Computer Science", academicTrack2,
                28392, 12220, 37623);
            var student5 = new Student(273849212, "Richard", "Sutherland", 28,
                "0392817238", "richardsuth2@gmail.com", "566788900", 877, "Software Engineering", academicTrack2,
                27382, 12839, 52123);
            var student6 = new Student(201928374, "Tommy", "Hartman", 40,
                "0592819231", "tomharty@gmail.com", "677899011", 862, "Data Science", academicTrack2,
                26352, 21212, 74623);
            var student7 = new Student(285736273, "Jackson", "L. Rowling", 27,
                "0598273645", "jackyrowl33@gmail.com", "788900122", 912, "Sound Engineering", academicTrack3,
                25423, 12121, 87232);
            var student8 = new Student(283928123, "Roger", "Edwards", 42,
                "0512341231", "rogedwas232@gmail.com", "899011233", 361, "Sound Design", academicTrack3,
                28252, 18293, 67382);
            var student9 = new Student(292837212, "Casper", "Browning", 23,
                "0523452345", "casperbrown988@gmail.com", "900122344", 226, "Audio Hardware Engineering", academicTrack3,
                28392, 12821, 49281);
            Person personExerciser1 = new Exerciser(283993211, "Reynolds", "Wayne", 48,
                "059928312", "reynoldswayne@gmail.com", "011233455", 382, "Social Science", academicTrack4,
                87212, 82371, 105231);
            Person personExerciser2 = new Exerciser(28392777, "Josef", "Haskell", 19,
                "058277321", "josefhask2122@gmail.com", "029374821", 449, "Political Science", academicTrack4,
                32123, 45345, 67653);
            Person personExerciser3 = new Exerciser(233847721, "Arnold", "Hagar", 18,
                "059998892", "arnoldhagar872@gmail.com", "827182732", 661, "Psychology", academicTrack4,
                67643, 34523, 12321);
            Person personLecturer1 = new Lecturer(288327312, "Johanne", "Aster", 55, "0522324444", "johanster@gmail.com",
                "293821777", 659, "Architecture", 105);
            Person personLecturer2 = new Lecturer(293928123, "Abraham", "Wilkins", 67, "0599298832", "abrakins@gmail.com",
                "0928192392", 193, "Machine Learning", 226);
            var trackDirector1 = new TrackDirector(854273212, "Jacob", "Murphy", 75, "03992837421",
                    "jacbosmurph266@gmail.com",
                "abc0135246", 998, "Business Management", 1083);
            var exerciser1 = (Exerciser)personExerciser1;
            var exerciser2 = (Exerciser)personExerciser2;
            var exerciser3 = (Exerciser)personExerciser3;
            var lecturer1 = (Lecturer)personLecturer1;
            var lecturer2 = (Lecturer)personLecturer2;
            course1.EnrolledStudents = new List<Student>{ student1, student2, student3 };
            course2.EnrolledStudents = new List<Student>{ student1, student2, student3 };
            course3.EnrolledStudents = new List<Student>{ student4, student5, student6 };
            course4.EnrolledStudents = new List<Student>{ student4, student5, student6 };
            course5.EnrolledStudents = new List<Student>{ student7, student8, student9 };
            course6.EnrolledStudents = new List<Student>{ student7, student8, student9 };
            exerciser1.CoursesForExercising = new List<Course> {course1 };
            exerciser2.CoursesForExercising = new List<Course> {course2 };
            course7.EnrolledStudents = new List<Student>{ exerciser1};
            course8.EnrolledStudents = new List<Student> { exerciser2 };
            course9.EnrolledStudents = new List<Student> { exerciser3 };
            lecturer1.CoursesTaught = new List<Course> { course1, course2, course3};
            lecturer2.CoursesTaught = new List<Course> { course4, course5, course6 };
            trackDirector1.CoursesTaught = new List<Course> { course7, course8, course9 };
            academicTrack1.EnrolledStudents = new List<Student> { student1, student2, student3 };
            academicTrack2.EnrolledStudents = new List<Student> { student4, student5, student6 };
            academicTrack3.EnrolledStudents = new List<Student> { student7, student8, student9 };
            academicTrack4.EnrolledStudents = new List<Student> { exerciser1, exerciser2, exerciser3 };
            trackDirector1.ResponsibleTracks = new List<Track>
                { academicTrack1, academicTrack2, academicTrack3, academicTrack4 };
            trackDirector1.Students = new List<Student>
            {
                student1, student2, student3, student4, student5, student7, student8, student9
            };
            trackDirector1.Persons = new List<Person>
            {
                personLecturer1, personLecturer2, personExerciser1, personExerciser2, personExerciser3
            };*/
            //=========================================================================================================
            // Turn line 139 into comment and uncomment line 140, and then run the program in order to save objects to file
            var trackDirector1 = FileHandler.LoadTrackDirector();
            //FileHandler.SaveTrackDirector(trackDirector1);
            Application.Run(new Form1(trackDirector1));
        }
    }
}