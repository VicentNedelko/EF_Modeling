using EF_Modeling.Models;
using System;

namespace EF_Modeling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start creating DB...");
            AppContext db = new AppContext();
            Doctor doctor = new Doctor
            {
                FName = "Tom",
                LName = "Bradly",
                Age = 35,
                Position = "Common",
                HireDate = DateTime.Now,
                Area = null,
                Department = new Department
                {
                    Name = "First dep.",
                    Category = 1,
                }
            };

            db.Doctors.Add(doctor);
            Console.WriteLine("Add item to DB.");
        }
    }
}
