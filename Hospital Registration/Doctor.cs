﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Registration
{
    class Doctor : Human
    {
        public short WorkExperience { get; set; }
        public bool Time1 { get; set; } = false;
        public bool Time2 { get; set; } = false;
        public bool Time3 { get; set; } = false;

        public void ShowDoctor()
        {
            Console.WriteLine($"Name:{Name} - Surname:{Surname} - Work Experience:{WorkExperience}");
        }

    }
}
