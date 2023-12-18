using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        var orders = new List<Order>()
        {
            new Order(){Id = 1, ProductName = "Mars",Date = new DateTime(2023, 12, 6)},
            new Order(){Id = 2, ProductName = "Alpengod",Date = new DateTime(2023, 12, 6)},
            new Order(){Id = 3, ProductName = "Non kolobok", Date = new DateTime(2023, 11, 6)},
            new Order(){Id = 4, ProductName = "Masla",Date = new DateTime(2023, 12, 16)},
        };

        var filteredDate = new DateTime(2023, 12, 6); 

        var filteredDate = orders
            .Where(o=>o.Date == filteredDate)


        foreach(var item in filteredOrders)
        {
            Console.WriteLine(item);
        }

        List<Student>students = new ()
        {
            new Student(1, "Aziza", "Saidova", 23),
            new Student(2, "Ali", "Saidov", 21),
            new Student(3, "Aziz", "Sulaymonov", 22),
            new Student(4, "Anna", "Akramova", 20),
            
        };
        List<string>studentInfo = students
                    .Select(s=> ${s.})
        public class Student
        {
            public int Id{get;set;}
            public string Name{get;set;}
            public string FirstName{get;set;}
            public int age{get;set;}
        }
        public class Order
        {
            public int Id{get; set;}
            public string ProductName{get;set;}

            public DateTime Date { get; set; }
        }
    }
}
