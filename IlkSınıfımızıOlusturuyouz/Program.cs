using System;

namespace SchoolManagementSystem
{
    
    public class Person
    {
        // (Properties)
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        // 
        public void PrintInfo()
        {
            Console.WriteLine($"Ad: {FirstName}, Soyad: {LastName}, Doğum Tarihi: {BirthDate.ToShortDateString()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Öğrenci nesneleri oluşturma
            Person student1 = new Person { FirstName = "Ali", LastName = "Veli", BirthDate = new DateTime(2005, 4, 12) };
            Person student2 = new Person { FirstName = "Ayşe", LastName = "Yılmaz", BirthDate = new DateTime(2006, 8, 23) };

            // Öğretmen nesneleri oluşturma
            Person teacher1 = new Person { FirstName = "Mehmet", LastName = "Demir", BirthDate = new DateTime(1980, 2, 15) };
            Person teacher2 = new Person { FirstName = "Fatma", LastName = "Kara", BirthDate = new DateTime(1985, 6, 30) };

            // Bilgileri yazdırma
            student1.PrintInfo();
            student2.PrintInfo();
            teacher1.PrintInfo();
            teacher2.PrintInfo();
        }
    }
}