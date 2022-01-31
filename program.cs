using System;

namespace Chapter12
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("enter 7 for question 7 \n enter 8 for question 8 \n enter 9 for question 9");
           var answer = int.Parse(Console.ReadLine());


            while (true)
           {
               Console.WriteLine("enter 7 for question 7 \n enter 8 for question 8 \n enter 9 for question 9");
                var answer = int.Parse(Console.ReadLine());
                if (answer == 7)
                {
                    Question7.Answer();
                }
                if (answer == 8)
                {
                    Question.Answer();
                }
                if (answer == 9)
                {
                    Question.Answer();
                }
            }
 
        }
    }
}
