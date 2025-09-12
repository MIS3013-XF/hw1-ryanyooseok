// HW1b Grade

// Your Name:Ryan McCarthy
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstname= Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastname=Console.ReadLine();
            Console.WriteLine("What is your student ID?");
            string studentid= Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for homework? (0-100)");
            double homework= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for participation? (0-100)");
            double participation = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for quizzes? (0-100)");
            double quiz= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for midterms? (0-100)");
            double midterm= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for the final? (0-100)");
            double final=Convert.ToDouble(Console.ReadLine());

            double homeworkp = .20; 
            double participationp = .15;
            double quizp = .0;
            double midtermp = .4;
            double finalp = .25;

            

            double finalgrade = (homework*homeworkp) + (participationp*participation) + 
            (midtermp*midterm) + (quizp*quiz) + (finalp*final);

            string name = $"{firstname} {lastname}";
            Console.WriteLine( name + studentid + " , your final grade is " + finalgrade);
            Console.ReadKey();







        }
    }
}
