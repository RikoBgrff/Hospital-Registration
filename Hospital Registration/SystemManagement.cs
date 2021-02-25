using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Registration
{
    class SystemManagement

    {
        public void Start()
        {
            Console.Write("Name:"); string name = Console.ReadLine();
            Console.Write("Surname:"); string surname = Console.ReadLine();
            Console.Write("Email:"); string email = Console.ReadLine();
            Console.Write("Telephone:"); string phone = Console.ReadLine();
            Console.WriteLine("Select department:");
            Console.WriteLine("Pediatrics:1");
            Console.WriteLine("Traumatology:2");
            Console.WriteLine("Dentistry:3");
            Console.Write("Your Choice:"); string choice = Console.ReadLine();
            Patient patient = new Patient
            {
                Name = name,
                Surname = surname,
                Email = email,
                Phone = phone
            };
            Hospital hospital = new Hospital();
            hospital.SelectDepartment("1");
        }
    }
}
