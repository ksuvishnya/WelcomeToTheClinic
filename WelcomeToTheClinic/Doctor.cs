using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeToTheClinic
{
    public class Doctor
    {
        public void Treat(Patient patient) 
        {
            switch (patient.PatientIlness) 
            {
                case IlnessType.Eyes:
                    Ophthalmologist.Treat();
                    break;
                case IlnessType.Teeth:
                    Dentist.Treat();
                    break;
                case IlnessType.Other:
                    Therapist.Treat();
                    break;
                default:
                    throw new Exception("Unfortunately patiend couldn't be treated and died :(");

            }
        }
    }
}
