using System;
using System.Collections.Generic;
using System.Linq;

namespace test0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>()
           {
               new Student(){Age=18,Name="amir",StudentId=1},
               new Student(){Age=15,Name="ali",StudentId=2},
               new Student(){Age=13,Name="reza",StudentId=3},
               new Student(){Age=6,Name="sina",StudentId=4},
               new Student(){Age=6,Name="mina",StudentId=5}
           };

            //where
            List<Student> filter1= studentList.Where(a => a.Age > 6).ToList();
            List<Student> filter2= studentList.Where(a => a.Age > 6 && a.Name.StartsWith("a")).ToList();

            var orderList = studentList.OrderBy(a => a.Age).ToList();
            var orderList1 = studentList.OrderByDescending(a => a.Age).ToList();
            var orderListWithFilter = studentList.Where(a=>a.Age>12).OrderByDescending(a => a.Age).ToList();

            var orderList3 = studentList.OrderBy(a => a.Age).ThenBy(a=>a.Name).ToList();

            var filter3 = studentList.Take(3).ToList();
            var filter4 = studentList.Where(a=>a.Age>14).OrderBy(a=>a.Age).Take(2).ToList();
            var filter5 = studentList.Skip(2).ToList();
            var filter6 = studentList.Skip(2).Take(2).ToList();


            var filter7 = studentList.First(a => a.Age > 15);


            var filter8 = studentList.FirstOrDefault(a => a.Age > 150);

            //var filter9 = studentList.Single(a => a.Age >13);
            //var filter10 = studentList.SingleOrDefault(a => a.Age >15);
            //if (filter10!=null)
            //{
            //    printStudent(filter10);

            //}
            //else
            //{
            //    Console.WriteLine("not found");
            //}

            int index = studentList.FindIndex(a => a.StudentId == 3);
            Console.WriteLine(index);


            Console.WriteLine(studentList.Sum(a => a.Age));;


            var filter10 =studentList.Where(a=>a.Age>10).Select(a => a.StudentId);
            foreach (var item in filter10)
            {
                Console.WriteLine(item);
            }


            //printStudents(filter6);
            Console.Clear();

            List<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Five","Five" };
            List<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight" };

            var result = strList1.Union(strList2);
            var result1 = strList1.Intersect(strList2);
            var result2 = strList1.Except(strList2);
            var result3 = strList1.Distinct();




            foreach (string str in result3)
                Console.WriteLine(str);


            Console.WriteLine(studentList.All(a => a.Age > 20)); ;
            Console.WriteLine(studentList.Any(a => a.Name.StartsWith("a"))); ;


        }

        private static void printStudent(Student student)
        {
            Console.WriteLine("Id => " + student.StudentId);
            Console.WriteLine("Name => " + student.Name);
            Console.WriteLine("Age => " + student.Age);
            Console.WriteLine("******************************");

        }
        private static void printStudents(List<Student> students)
        {
            foreach (var item in students)
            {
                Console.WriteLine("Id => "+item.StudentId);
                Console.WriteLine("Name => "+item.Name);
                Console.WriteLine("Age => "+item.Age);
                Console.WriteLine("******************************");
            }
        }
        private static void IEnumrableDemo()
        {
            List<string> data = new List<string>();
            Students students = new Students();
            Teachers teachers = new Teachers();
            foreach (var item in teachers)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }
}
