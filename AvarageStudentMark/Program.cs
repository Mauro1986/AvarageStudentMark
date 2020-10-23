using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvarageStudentMark
{
    class Program
    {
        static void Main(string[] args)     //Get Avarage and highest grade from x amount of students
        {
            Console.WriteLine("Enter the number of student");
            int amountOfStudents = int.Parse(Console.ReadLine());

            double averageGarde = 0;
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
                averageGarde += grade;
                if (grade > highestGrade)
                {
                    highestGrade = grade;
                    highestGradeName = name;
                }
            }
            averageGarde /= amountOfStudents;
            Console.WriteLine($"The avarage grade of the class = {averageGarde}");
            Console.WriteLine($"The highest grade of the class is from = {highestGradeName}");
            Console.WriteLine($"The highest grade of the class = {highestGrade}"); ;
        }
    }
}
