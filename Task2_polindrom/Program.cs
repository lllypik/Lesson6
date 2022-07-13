using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_polindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            //string userString = "А роза упала на лапу Азора";  //проверка без ввода с клавиатуры
            Console.WriteLine("Введите предложение для проверки на полиндром");
            string userString = Console.ReadLine();


            //создаем дубликат строки без пробелов и в одном регистре
            string userStringN = userString.Replace(" ","");
            userStringN = userStringN.ToLower();

            //переворачиваем строку
            string turnUserString = "";
            foreach (char c in userStringN)
            { 
               turnUserString = c + turnUserString;
            }

            //Вывод результата
            //Console.WriteLine(turnUserString);
            if (Equals(userStringN, turnUserString))
                 Console.WriteLine("Предложение является полиндромом");
            else Console.WriteLine("Предложение не является полиндромом");
            Console.ReadKey();
        }
    }
}
