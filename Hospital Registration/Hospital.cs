using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Hospital_Registration
{
    class Hospital
    {
        public void showDoctors(List<Doctor> doctorsList)
        {
            foreach (var item in doctorsList)
            {
                item.ShowDoctor();
            }
        }
        public string Department { get; set; }
        public List<Doctor> Pediatricians = new List<Doctor>();
        public List<Doctor> Traumatologists = new List<Doctor>();
        public List<Doctor> Dentists = new List<Doctor>();
        Doctor pediatrician = new Doctor
        {
            Name = "Qilman",
            Surname = "Qilmanov",
            WorkExperience = 10
        };
        Doctor pediatrician2 = new Doctor
        {
            Name = "Qurban",
            Surname = "Qurbanov",
            WorkExperience = 9
        };
        Doctor traumatologist = new Doctor
        {
            Name = "Mehdi",
            Surname = "Huseynov",
            WorkExperience = 15
        };
        Doctor traumatologist2 = new Doctor
        {
            Name = "Suleyman",
            Surname = "Meherremli",
            WorkExperience = 11
        };
        Doctor traumatologist3 = new Doctor
        {
            Name = "Mehriban",
            Surname = "Necefli",
            WorkExperience = 14
        };
        Doctor dentist = new Doctor
        {
            Name = "Ilqar",
            Surname = "Mehdi",
            WorkExperience = 18
        };
        Doctor dentist2 = new Doctor
        {
            Name = "Musa",
            Surname = "Ismayilov",
            WorkExperience = 21
        };
        Doctor dentist3 = new Doctor
        {
            Name = "Mustafa",
            Surname = "Rasim",
            WorkExperience = 10
        };
        Doctor dentist4 = new Doctor
        {
            Name = "Azer",
            Surname = "Suleyman",
            WorkExperience = 5
        };
        public string time { get; set; } = "09:00-11:00";
        public string time2 { get; set; } = "12:00-14:00";
        public string time3 { get; set; } = "15:00-17:00";

        public SystemManagement management = new SystemManagement();
        public void FillPediators()
        {
            Pediatricians.Add(pediatrician);
            Pediatricians.Add(pediatrician2);
        }
        public void FillTraumatologists()
        {
            Traumatologists.Add(traumatologist);
            Traumatologists.Add(traumatologist2);
            Traumatologists.Add(traumatologist3);
        }
        public void FillDentists()
        {
            Dentists.Add(dentist);
            Dentists.Add(dentist2);
            Dentists.Add(dentist3);
            Dentists.Add(dentist4);
        }
        public void ShowDoctorsTime(Doctor doctor)
        {
            if (doctor.Time1 != false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(time);
                Console.ResetColor();

            }
            if (doctor.Time2 != false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(time2);
                Console.ResetColor();

            }
            if (doctor.Time3 != false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(time3);
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(time);
            Console.WriteLine(time2);
            Console.WriteLine(time3);
            Console.ResetColor();
            Console.Write("Select Time to meet with Doctor:");
            string timeChoice = Console.ReadLine();
            if (timeChoice == "1")
            {
                if (doctor.Time1 == false)
                {
                    Console.WriteLine($"You arranged '09:00 - 11:00' for meet with Doctor{doctor.Name}");
                    Thread.Sleep(2000);
                    Console.Clear();
                    management.Start();
                    doctor.Time1 = true;
                }
                if(doctor.Time1 != false)
                {
                    Console.WriteLine("you can not arrange this time");
                }
                if (doctor.Time2 == false)
                {
                    Console.WriteLine($"You arranged '12:00 - 14:00' for meet with Doctor{doctor.Name}");
                    Thread.Sleep(2000);
                    Console.Clear();
                    management.Start();
                    doctor.Time2 = true;
                }
                if (doctor.Time3 == false)
                {
                    Console.WriteLine($"You arranged '15:00 - 17:00' for meet with Doctor{doctor.Name}");
                    Thread.Sleep(2000);
                    Console.Clear();
                    management.Start();
                    doctor.Time3 = true;
                }
            }
        }
        public string SelectDoctor()
        {
            Console.WriteLine("Select Doctor:"); string doctorChoice = Console.ReadLine();
            return doctorChoice;
        }
        public void SelectDepartment(string department)
        {

            //pediartic
            if (department == "1")
            {
                FillPediators();
                showDoctors(Pediatricians);
                if (SelectDoctor() == "1")
                {
                    ShowDoctorsTime(pediatrician);
                }
                if (SelectDoctor() == "2")
                {
                    ShowDoctorsTime(pediatrician);
                }

            }
            //tramatologiya
            if (department == "2")
            {
                FillTraumatologists();
                showDoctors(Traumatologists);
            }
            //dentist
            if (department == "3")
            {
                FillDentists();
                showDoctors(Dentists);
            }
        }
    }
}
