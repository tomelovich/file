using System;
using System.IO;

namespace _3_Z
{
    class Program
    {
        static int MaxStr(string[] array)
        {
            int max = array[0].Length;
            for (int i = 0; i < 5; i++)
            {
                if (array[i].Length >= max)
                {
                    max = array[i].Length;
                }
            }
            return max;
        }
        static void RowsFromFange(string[] array, int s1, int s2)
        {
            Console.WriteLine("Строки из диапазона от {0} до {1}:", s1, s2);
            for (int i = s1 - 1; i <= s2 - 1; i++)
            {                
                Console.WriteLine(array[i]);
            }
        }
        static void Simv(string[] array, string simv)
        {
            for (int i = 0; i < 5; i++)
            {
                if (simv == array[i].Substring(0, 1))
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 5 строк:");
            string[] array = new string[5];
            for (int i = 0; i < 5; i++)
            {
                array[i] = Console.ReadLine();
            }
            StreamWriter str = new StreamWriter("f.txt");
            
            for (int i = 0; i < 5; i++)
            {
                str.WriteLine(array[i]);
            }
            str.Close();
            string firsrtFile = File.ReadAllText("f.txt");
            for (int i = 0; i < 5; i++)
            {
                if (array[i].Length == MaxStr(array))
                {
                    Console.WriteLine("Самая длинная строка -  {0}", array[i]);
                }
            }
            //удаление строки и запись в новый файл
            Console.WriteLine("Кол-во строк = {0}", array.Length);
            string path1 = @"f1.txt";
            string[] readText = File.ReadAllLines("f.txt");
            string[] writeText = new string[readText.Length - 1];
            Array.Copy(readText, 0, writeText, 0, readText.Length - 1);
            File.WriteAllLines(path1, writeText);
            //вывод строк из диапазона
            Console.WriteLine("Введите s1:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите s2:");
            int s2 = Convert.ToInt32(Console.ReadLine());
            RowsFromFange(array, s1, s2);
            //вывод строк начинающихся с заданной буквы
            Console.WriteLine("Введите символ: ");
            string simv = Console.ReadLine();
            Simv(array, simv);
            //запись содержимого файла в обратном порядке
            StreamWriter SW = new StreamWriter(new FileStream("3.txt", FileMode.Create, FileAccess.Write));
            for (int i = firsrtFile.Length; i > 0; i--)
                SW.WriteLine(firsrtFile[i - 1]);
            SW.Close();
            Console.ReadKey();
        }
    }
}
