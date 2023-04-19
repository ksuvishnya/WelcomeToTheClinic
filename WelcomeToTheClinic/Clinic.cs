namespace WelcomeToTheClinic
{
    public class Clinic
    {
        private static void Main(string[] args)
        {
            Patient p1 = new Patient("Alice", IlnessType.Eyes);
            Patient p2 = new Patient("Bob", IlnessType.Teeth);
            Patient p3 = new Patient("Clara", IlnessType.Other);

            Doctor doctor = new Doctor();
            doctor.Treat(p1);
            doctor.Treat(p2);
            doctor.Treat(p3);

            Console.ReadLine();
        }
    }
}
