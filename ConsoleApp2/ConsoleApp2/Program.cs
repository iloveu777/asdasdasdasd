using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace ConsoleApp2
{
    
    
    internal class Program
    {
        
        static void Main(string[] args)
        {

            /*
            Title = "Программа #1";
            WriteLine("введите первое слово");
            string word1 = ReadLine();
            WriteLine("введите второе слово");
            string word2= ReadLine();
            WriteLine("введите третье слово");
            string word3 = ReadLine();
            WriteLine("введите четвертое слово");
            string word4 = ReadLine();
            WriteLine("введите пятое слово");
            string word5 = ReadLine();
            char x = '!';
            WriteLine($"{word1}\n{x}");
            WriteLine($"{word3}\n{x}");
            WriteLine($"{word5}\n{x}");
            for (int i = 0; i < 3; i++)
            {
                WriteLine($"{word2}\n{x}");
            }
            for (int i = 0; i < 3; i++)
            {
                WriteLine($"{word4}\n{x}");
            }
            */
            //zadaniye 2
            /*
            Title = "Программа #2";
            WriteLine("введите первое слово");
            string word1 = ReadLine();
            WriteLine("введите второе слово");
            string word2 = ReadLine();
            WriteLine("введите третье слово");
            string word3 = ReadLine();
            WriteLine("введите четвертое слово");
            string word4 = ReadLine();
            WriteLine("введите пятое слово");
            string word5 = ReadLine();
            Clear();
            WriteLine($"{word1} \n{word2} \n{word3} ");
            WriteLine($"{word4} ");
            WriteLine($"{word5}");
            */
            /*
            CursorVisible = false;
            ForegroundColor = ConsoleColor.Black;
            BackgroundColor = ConsoleColor.White;
            SetWindowSize(50,50);
            Write("Введите имя: ");
            string name = ReadLine();
            WriteLine("Здравствуй," + name);
            Title = name;
           //Clear();
           
            if (CapsLock == true)
            {
                WriteLine("включен");
                
            }
            else {
                WriteLine("выключен");
            }
            if (NumberLock == true)
            {
                WriteLine("включен");

            }
            else
            {
                WriteLine("выключен");
            }*/
            /*
            WriteLine("Введите координату точки A(x):");
            double x1 = Convert.ToDouble(Console.ReadLine());
            WriteLine("Введите координату точки A(y):");
            double y1 = Convert.ToDouble(Console.ReadLine());
            WriteLine("Введите координату точки B(x):");
            double x2 = Convert.ToDouble(Console.ReadLine());
            WriteLine("Введите координату точки B(y):");
            double y2 = Convert.ToDouble(Console.ReadLine());
            WriteLine("Введите координату точки C(x):");
            double x3 = Convert.ToDouble(Console.ReadLine());
            WriteLine("Введите координату точки C(y):");
            double y3 = Convert.ToDouble(Console.ReadLine());

            double dlina1 = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            double dlina2 = Math.Sqrt((Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2)));
            double dlina3 = Math.Sqrt((Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2)));
            WriteLine($"Длина 1 - {dlina1:f1}, длина 2 - {dlina2:f1}, длина 3 - {dlina3:f1}");
            double p = 0;
            p += dlina1;
            p += dlina2;
            p += dlina3;
            WriteLine($"Периметр = {p:f2}");
            double p2 = p / 2;
            double s = Math.Sqrt(p2 * (p2 - dlina1) * (p2 - dlina2) * (p2 - dlina3 ));
            WriteLine($"Площадь = {s}");
            */
            WriteLine("Введите координату точки A(x):");
            double x1 = Convert.ToDouble(Console.ReadLine());
            WriteLine("Введите координату точки A(y):");
            double y1 = Convert.ToDouble(Console.ReadLine());
            WriteLine("Введите координату точки B(x):");
            double x2 = Convert.ToDouble(Console.ReadLine());
            WriteLine("Введите координату точки B(y):");
            double y2 = Convert.ToDouble(Console.ReadLine());
            WriteLine("Введите координату точки C(x):");
            double x3 = Convert.ToDouble(Console.ReadLine());
            WriteLine("Введите координату точки C(y):");
            double y3 = Convert.ToDouble(Console.ReadLine());
            WriteLine("Введите координату точки D(x):");
            double x4 = Convert.ToDouble(Console.ReadLine());
            WriteLine("Введите координату точки D(y):");
            double y4 = Convert.ToDouble(Console.ReadLine());
            double dlina1 = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            double dlina2 = Math.Sqrt((Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2)));
            double dlina3 = Math.Sqrt((Math.Pow(x4 - x2, 2) + Math.Pow(y4 - y2, 2)));
            double dlina4 = Math.Sqrt((Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2)));
            double p = dlina1 + dlina4 + dlina3 + dlina2;
            WriteLine($"Периметр = {p:f1}");
            double d = Math.Sqrt(Math.Pow(dlina1 + dlina4, 2));
            double p1 = dlina2 + dlina1 + d;
            double p2 = dlina3 + dlina4 + d;
            WriteLine($"Периметр 1 треуг. = {p1:f1} , Периметр 2 трег. = {p2:f1}\t Сумма периметров треуг. = {p1 + p2:f1} ");


               
            


            ReadKey();
        }
    }
}
