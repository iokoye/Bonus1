using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus1
{
    public class GradeConverter
    {
        public void StartConverter()
        {
            string answer;
            Console.WriteLine("Welcome to the Letter Grade Converter!");
            do
            {
                Console.WriteLine("Enter a numerical grade:");
                Int32.TryParse(Console.ReadLine(), out int gradeNum);

                GradeConverter grade = new GradeConverter();

                Console.WriteLine(grade.LetterGrade(gradeNum));

                Console.WriteLine("Continue? (y/n):");
                answer = Console.ReadLine();

            } while (answer == "y");

            if (answer == "n")
            {
                Console.WriteLine("Have a good day!");
            }
        }
        public string LetterGrade(int gradeNum)
        { 
            if (gradeNum <= 100 && gradeNum >= 88)
            {
                return "Letter Grade: A";
            }
            else if (gradeNum <= 87 && gradeNum >= 80)
            {
                return "Letter Grade: B";
            }
            else if (gradeNum <= 79 && gradeNum >= 67)
            {
                return "Letter Grade: C";
            }
            else if (gradeNum <= 66 && gradeNum >= 61)
            {
                return "Letter Grade: D";
            }
            else if (gradeNum <= 60 && gradeNum >= 0)
            {
                return "Letter Grade: F";
            }
            return null;
        }
    }
}
