using System;
namespace Capter12
{
    class Question7
    {
        public void Answer()
        {
               Console.WriteLine("Enter number");
            string num = Console.ReadLine();

            int nums = -1;
            bool check = false;

            try
            {
                nums = int.Parse(nums);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Invalid Number!");
                check = true;
            }

            finally
            {
                if(nums<0)
                {
                    if(!invalidNumber)
                    {
                        Console.WriteLine("Invalid Number!");
                    }
                    else
                    {
                        Console.WriteLine(Math.Sqrt(nums));
                    }
                    Console.WriteLine("Good Bye!");
                }
            }
        }
    }
}