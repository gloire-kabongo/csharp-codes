using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerialisationExemple
{
    class Program
    {
        static void Main(string[] args)
        {
            // var course = new Course
            // {
            //     Id = 1,
            //     Title = "Science, foi et philosophie"
            // };
            // BinarySerialisation(course);
            var course = BinaryDeserialisation<Course>();

            Console.WriteLine(course.Title);
        }

        static T BinaryDeserialisation<T>()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream =
                new FileStream(@"C:\Dev\Course.dat",
                    FileMode.Open, FileAccess.Read);
            var newCourse = (T)formatter.Deserialize(stream);

            return newCourse;
        }

        static void BinarySerialisation(object obj)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream =
                new FileStream(@"C:\Dev\Course.dat",
                    FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, obj);
            stream.Close();

        }
    }



    [Serializable]
    public class Course
    {
        public int Id { get;set; }
        public string Title { get;set; }
    }

}
