using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeToTheClinic
{
    public class Therapist : Doctor
    {
        public static void Treat() 
        {
            Console.WriteLine("You've been treated by Therapist");
        }
    }
}
