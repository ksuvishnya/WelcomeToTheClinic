﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeToTheClinic
{
    public class Dentist : Doctor
    {
        public static void Treat()
        {
            Console.WriteLine("You've been treated by Dentist");
        }
    }
}
