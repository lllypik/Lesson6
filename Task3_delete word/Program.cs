using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_delete_word
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите предложение. Для исключения слов заключите их в скобки {}");
            string userString = Console.ReadLine();

            //int index = userString.IndexOf("{", 0);
            int indexBegin = -1;
            int indexEnd = -1;
            for (int i = 0; i < userString.Length-1; i++)
            {
                if (userString[i] == '{')
                {
                    indexBegin = i;
                    for (int j = i + 1; j < userString.Length - 1; j++)
                    {
                        if (userString[j] == '}')
                        {
                            indexEnd = j;
                            userString = userString.Remove(i, j - i+1);
                            Console.WriteLine(userString);
                        }
                    }
                        
                }

            }
            Console.ReadKey();
        }
    }
}
