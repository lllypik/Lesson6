using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение без знаков препинания");
            string userStrig = Console.ReadLine();
            string[] userStringArray = userStrig.Split();
            string maxUserString = "";
            foreach (var s in userStringArray)
            {
                if (s.Length > maxUserString.Length) maxUserString = s;
            }
            Console.WriteLine("Самое длинное слово в предложении - "+maxUserString);
            Console.ReadKey();
        }
    }
}
