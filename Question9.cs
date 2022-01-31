using System;
namespace Capter12
{
    class Question9
    {
        public static void Answer()
        {
              try
            {
                using (StreamReader read = new StreamReader("textFile.txt"))
                {
                string file = "C:\\Users\\USER\\Desktop\\textbook fundermental programing\\files\textfile.txt";
                    string line = read.ReadToEnd();
                    Console.WriteLine(line);
                }

            }
                catch(Exception e)
                {
                    Console.WriteLine("The file cannot be read:");
                    Console.WriteLine(e.Message);
                }





 

        }
    }
}