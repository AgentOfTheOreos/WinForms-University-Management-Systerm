using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using WindowsFormsAppTaskFinal.DataModels.Persons;
using WindowsFormsAppTaskFinal.DataModels.Persons.Lecturers;
using WindowsFormsAppTaskFinal.DataModels.Persons.Students;
using WindowsFormsAppTaskFinal.Exceptions;

namespace WindowsFormsAppTaskFinal.DataModels
{
    public static class FileHandler
    {
        private static readonly string BaseDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        private const string ProjectFolderName = "RiderProjects";
        private const string SolutionFolderName = "WindowsFormsAppTaskFinal";

        private static readonly string PersonsPath = Path.Combine(BaseDirectory, ProjectFolderName,
            SolutionFolderName, SolutionFolderName, "ObjectFiles", "Persons");
        private static readonly string ExercisersPath = Path.Combine(BaseDirectory, ProjectFolderName,
            SolutionFolderName, SolutionFolderName, "ObjectFiles", "Exercisers");
        private static readonly string TrackDirectorFilePath = Path.Combine(BaseDirectory, ProjectFolderName,
            SolutionFolderName, SolutionFolderName, "ObjectFiles", "TrackDirector");
        private static readonly string LecturersFilePath = Path.Combine(BaseDirectory, ProjectFolderName,
            SolutionFolderName, SolutionFolderName, "ObjectFiles", "Lecturers");
        private static readonly string StudentsFilePath = Path.Combine(BaseDirectory, ProjectFolderName,
            SolutionFolderName, SolutionFolderName, "ObjectFiles", "Students");
        private static readonly string CoursesFilePath = Path.Combine(BaseDirectory, ProjectFolderName,
            SolutionFolderName, SolutionFolderName, "ObjectFiles", "Courses");
        private static readonly string TracksFilePath = Path.Combine(BaseDirectory, ProjectFolderName,
            SolutionFolderName, SolutionFolderName, "ObjectFiles", "Tracks");

        public static void SaveCourses(List<Course> courses)
        {
            try
            {
                using (var fileStream = new FileStream(CoursesFilePath, FileMode.Create))
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, courses);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(@"Error saving courses: " + ex.Message);
            }
        }
        public static void SaveTracks(List<Track> tracks)
        {
            try
            {
                using (var fileStream = new FileStream(TracksFilePath, FileMode.Create))
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, tracks);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(@"Error saving tracks: " + ex.Message);
            }
        }
        public static void SavePersons(List<Person> persons)
        {
            try
            {
                using (var fileStream = new FileStream(PersonsPath, FileMode.Create))
                {
                    var formatter = new BinaryFormatter();

                    foreach (var person in persons)
                    {
                        person.SubclassIdentifier = person.GetType().Name;
                    }

                    formatter.Serialize(fileStream, persons);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(@"Error saving persons: " + ex.Message);
            }
        }

        public static void SaveExercisers(List<Exerciser> exercisers)
        {
            try
            {
                using (var fileStream = new FileStream(ExercisersPath, FileMode.Create))
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, exercisers);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(@"Error saving exercisers: " + ex.Message);
            }
        }

        public static void SaveTrackDirector(TrackDirector trackDirector)
        {
            try
            {
                using (var fileStream = new FileStream(TrackDirectorFilePath, FileMode.Create))
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, trackDirector);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(@"Error saving track director: " + ex.Message);
            }
        }

        public static void SaveStudents(List<Student> students)
        {
            try
            {
                using (var fileStream = new FileStream(StudentsFilePath, FileMode.Create))
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, students);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(@"Error saving students: " + ex.Message);
            }
        }

        public static void SaveLecturers(List<Lecturer> lecturers)
        {
            try
            {
                using (var fileStream = new FileStream(LecturersFilePath, FileMode.Create))
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, lecturers);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(@"Error saving lecturers: " + ex.Message);
            }
        }
        public static List<Course> LoadCourses()
        {
            try
            {
                using (var fileStream = new FileStream(CoursesFilePath, FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    return (List<Course>)formatter.Deserialize(fileStream);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(@"Error loading courses: " + ex.Message);
                return null;
            }
            catch (SerializationException ex)
            {
                Console.WriteLine(@"Error deserializing courses: " + ex.Message);
                return null;
            }
        }
        public static List<Track> LoadTracks()
        {
            try
            {
                using (var fileStream = new FileStream(TracksFilePath, FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    return (List<Track>)formatter.Deserialize(fileStream);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(@"Error loading tracks: " + ex.Message);
                return null;
            }
            catch (SerializationException ex)
            {
                Console.WriteLine(@"Error deserializing tracks: " + ex.Message);
                return null;
            }
        }
        
        public static List<Person> LoadPersons()
        {
            try
            {
                using (var fileStream = new FileStream(PersonsPath, FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    var persons = (List<Person>)formatter.Deserialize(fileStream);

                    foreach (var person in persons)
                    {
                        switch (person.SubclassIdentifier)
                        {
                            case "Student":
                                var memberInfo = person.GetType().BaseType;
                                memberInfo?.GetProperty("SubclassIdentifier")?.SetValue(person, null);
                                break;

                            case "Exerciser":
                                var baseType = person.GetType().BaseType;
                                baseType?.GetProperty("SubclassIdentifier")?.SetValue(person, null);
                                break;

                            case "Lecturer":
                                var type = person.GetType().BaseType;
                                type?.GetProperty("SubclassIdentifier")?.SetValue(person, null);
                                break;
                            
                            case "TrackDirector":
                                var info = person.GetType().BaseType;
                                info?.GetProperty("SubclassIdentifier")?.SetValue(person, null);
                                break;

                            default:
                                throw new UnrecognizedSubclassType($"Invalid subclass identifier: {person.SubclassIdentifier}");
                        }
                    }

                    return persons;
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(@"Error loading persons: " + ex.Message);
                return null;
            }
            catch (SerializationException ex)
            {
                Console.WriteLine(@"Error deserializing persons: " + ex.Message);
                return null;
            }
        }

        public static List<Exerciser> LoadExercisers()
        {
            try
            {
                using (var fileStream = new FileStream(ExercisersPath, FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    return (List<Exerciser>)formatter.Deserialize(fileStream);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(@"Error loading exercisers: " + ex.Message);
                return null;
            }
            catch (SerializationException ex)
            {
                Console.WriteLine(@"Error deserializing exercisers: " + ex.Message);
                return null;
            }
        }

        public static TrackDirector LoadTrackDirector()
        {
            try
            {
                using (var fileStream = new FileStream(TrackDirectorFilePath, FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    return (TrackDirector)formatter.Deserialize(fileStream);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(@"Error loading track director: " + ex.Message);
                return null;
            }
            catch (SerializationException ex)
            {
                Console.WriteLine(@"Error deserializing track director: " + ex.Message);
                return null;
            }
        }

        public static List<Student> LoadStudents()
        {
            try
            {
                using (var fileStream = new FileStream(StudentsFilePath, FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    return (List<Student>)formatter.Deserialize(fileStream);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(@"Error loading students: " + ex.Message);
                return null;
            }
            catch (SerializationException ex)
            {
                Console.WriteLine(@"Error deserializing students: " + ex.Message);
                return null;
            }
        }

        public static List<Lecturer> LoadLecturers()
        {
            try
            {
                using (var fileStream = new FileStream(LecturersFilePath, FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    return (List<Lecturer>)formatter.Deserialize(fileStream);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(@"Error loading lecturers: " + ex.Message);
                return null;
            }
            catch (SerializationException ex)
            {
                Console.WriteLine(@"Error deserializing lecturers: " + ex.Message);
                return null;
            }
        }
    }
}
