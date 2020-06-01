using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Clases;
using Clases.Clases;
using Clases.FileReader;

namespace Training_5
{
    class Program
    {
        public static JsonFileReader<StudentJson> fileReader;
        static void Main(string[] args)
        {
            fileReader = new JsonFileReader<StudentJson>();
            StringBuilder menu = new StringBuilder();
            menu.AppendLine("1. MapCollection");
            menu.AppendLine("2. JsonFileReading");
            menu.AppendLine("3. Exit");

            string cont = "Y";
            do
            {
                Console.WriteLine(menu.ToString());
                var o = Console.ReadLine();
                switch (o)
                {
                    case "1":
                        CollectionMapper();
                        break;
                    case "2":
                        JsonFileReading(fileReader);
                        break;
                    case "3":
                        cont = "N";
                        break;
                }


            } while (cont != "N");
        }

        private static void JsonFileReading(JsonFileReader<StudentJson> fileReader)
        {
            var path = @"C:\Users\Franco-PC\OneDrive\Desktop\java2net-Lesson05_DelegatesEvents_Extension_LinQ\Globant.Java2Net.Demos.Classes\Json\Students.json";
            //Agregar todas las funciones al evento
            fileReader.OnFileRead += (students) => { Console.WriteLine("Executing Filter Elements count"); Console.WriteLine($"There are {students.Count} Students"); };
            fileReader.OnFileRead += FilterClass;
            fileReader.OnFileRead += FilterSocialSit;
            fileReader.OnFileRead += FilterLockSizeAvg;

            try
            {
                fileReader.ReadJsonFile(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static List<Student> GenerateStudentList(int studentsCount)
        {
            List<Student> students = new List<Student>();
            for(int i = 0; i < studentsCount; i++)
            {
                students.Add(new Student
                {
                    name = $"Number {i}",
                    dni = 40000000 + i,
                    legajo = 20000 + i
                });
            }
            return students;
        }

        private static void CollectionMapper()
        {
            List<Student> students = GenerateStudentList(5);
            Console.WriteLine($"There are {students.Count} students");
            foreach (var student in students)
            {
                Console.WriteLine($"Student's name: {student.name} Student's dni: {student.dni}");
            }
            Console.WriteLine("Mapping Student Colletion");
            var persons = students.MapColletion((student) => {
                return new Person()
                {
                    name = student.name,
                    dni = student.dni
                };
            });
            foreach(var person in persons)
            {
                Console.WriteLine($"Person's name: {person.name} Person's dni: {person.dni}");
            }
        }

        private static void FilterClass(List<StudentJson> students)
        {
            Console.WriteLine("Executing Filter Class 12");
            List<StudentJson> class12 = students.Where(s => s.Class == "12").ToList();
            foreach(var student in class12)
            {
                Console.WriteLine($"Student: {student.Name} with seat: {student.Seat}");
            }
        }

        private static void FilterSocialSit(List<StudentJson> students)
        {
            Console.WriteLine("Executing Filter SocialSit");
            var list = from student in students
                       where student.ScheduleAction.Contains("_SocialSit_")
                       orderby student.Class, student.Name
                       select student; 
            foreach (var student in list)
            {
                Console.WriteLine($"Student's Class: {student.Class}, Name: {student.Name} and Schedule Action: {student.ScheduleAction}");
            }
        }

        private static void FilterLockSizeAvg(List<StudentJson> students)
        {
            Console.WriteLine("Executing Filte LockerSize AVG");
            decimal size = 0;
            var avg = students.Average(s => decimal.TryParse(s.LockerSize, out size) ? size : 0);
            var list = from student in students
                       where (decimal.TryParse(student.LockerSize, out size) ? size : 0) > avg
                       orderby student.LockerSize descending
                       select new { Name = student.Name, LockerSize = student.LockerSize };
            //No hay "Take()" en esta sintaxis
            foreach(var student in list)
            {
                Console.WriteLine($"Name: {student.Name} Locker Size: {student.LockerSize}");
            }
        }
    }
}
