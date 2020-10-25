using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tryout_cleaning_up_with_methods
{
    class Program
    {
        static void Main(string[] args)     //Get Avarage and highest grade from x amount of students
        {
            int amountOfStudents = GetNumberOfStudents();
            ProcessAllData(amountOfStudents);

        }

        static int GetNumberOfStudents()
        {
            Console.WriteLine("Enter the number of student");
            int amountOfStudents = int.Parse(Console.ReadLine());
            return amountOfStudents;
        }

        static void ProcessAllData(int amountOfStudents)
        {
            double averageGrade = 0;
            double highestGrade = 0;
            string highestGradeName = "";

            string[] studentNames = new string[amountOfStudents];
            double[] grades = new double[amountOfStudents];

            for (int i = 0; i < amountOfStudents; i++)
            {            
                Console.WriteLine($"Enter the student # {i + 1} name");
                string name = Console.ReadLine();
                studentNames[i] = name;
                Console.WriteLine($"Enter de grade for student number {i + 1}");
                double grade = double.Parse(Console.ReadLine());
                grades[i] = grade;
                averageGrade += grade;
                if (FindHighestGrade(grade, highestGrade))
                {
                    highestGrade = grade;
                    highestGradeName = name;
                }
            }
                averageGrade /= amountOfStudents;
            PrintToScreen(averageGrade, highestGradeName, highestGrade);
        }
        static void PrintToScreen(double highestGrade, string highestGradeName, double averageGrade)
        {
            Console.WriteLine($"The avarage grade of the class = {averageGrade}");
            Console.WriteLine($"The highest grade of the class is from = {highestGradeName}");
            Console.WriteLine($"The highest grade of the class = {highestGrade}"); ;
        }

        static bool FindHighestGrade(double highestGrade, double grade)
        {
            if (grade > highestGrade)
                return true;
            return false;
        }
            



 
    }
}
