using System;

namespace AdmissionModularized
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your GPA: ");
            double.TryParse(Console.ReadLine(), out double enteredGPA);
            Console.Write("Enter your admission test score: ");
            int.TryParse(Console.ReadLine(), out int enteredScore);
            Console.WriteLine(Admission(enteredGPA, enteredScore));
        }
        static string Admission(double enteredGPA, int enteredScore)
        {
            string admission = "";
            if ((enteredGPA < 3.0D && enteredScore >= 80) || (enteredGPA >= 3.0D && enteredScore >= 60))
            {
                admission = "Accept";
            } else
            {
                admission = "Reject";
            }
            return admission;
        }
    }
}
