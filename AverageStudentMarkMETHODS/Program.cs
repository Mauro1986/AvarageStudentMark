using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AverageStudentMarkMETHODS     //zelfde als vorige oefening maar Cleaner gemaakt door methods te gebruiken
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfStudents = GetNumberOfStudents();       // = 10; GetNumbersOfStudents(); 
            ProcessAllData(amountOfStudents);
        }

        static int GetNumberOfStudents()
        {
            Console.WriteLine("Enter the number of students");
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
                Console.WriteLine($"Enter the student number{i + 1} name");
                string name = Console.ReadLine();
                studentNames[i] = name;
                Console.WriteLine($"Enter the grade for student number {i + 1}");
                double grade = double.Parse(Console.ReadLine());
                grades[i] = grade;
                averageGrade += grade;

                //**********************************
                if (FindHighestGrade(grade, highestGrade))
                {
                    highestGrade = grade;
                    highestGradeName = name;
                }
                //**********************************
            }
            averageGrade = averageGrade / amountOfStudents;

            PrintToScreen(averageGrade, highestGrade, highestGradeName);

         }
        static void PrintToScreen(double averageGrade, double highestGrade, string highestGradeName)
        {
            Console.WriteLine($"The avarage grade of the class = {string.Format("{0:0.00}", averageGrade)}");
            Console.WriteLine($"The highest grade of the class is from = {highestGradeName}");
            Console.WriteLine($"The highest grade of the class = {highestGrade}"); ;
        }

        static bool FindHighestGrade(double grade, double highestGrade)
        {
            if (grade > highestGrade)

                return true;
            return false;
        }
       
    }
}

