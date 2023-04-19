using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeToTheClinic
{
    public class Patient
    {
        internal string PatientName;
        internal IlnessType PatientIlness;

        public Patient(string patientName, IlnessType patientIlness)
        {
            PatientName = patientName;
            PatientIlness = patientIlness;
        }
    }
}
