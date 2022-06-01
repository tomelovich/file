using System;
using System.IO;
using System.Linq;

namespace _1_Z
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа:");
            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            StreamWriter str = new StreamWriter("f.txt");
            for (int i = 0; i < 10; i++)
            {
                str.WriteLine(array[i]);
            }
            str.Close();
            FileStream file = new FileStream(@"f.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            string s;
            int n = 0;
            while ((s = reader.ReadLine()) != null)
            {
                n++;
            }
            reader.Close();
            int[] mas = new int[n];
            int kol = 0;
            int min = mas[0];
            FileStream file1 = new FileStream(@"f.txt", FileMode.Open);
            StreamReader reader1 = new StreamReader(file1);
            for (int i = 0; i < n; i++)
            {
                mas[i] = Convert.ToInt32(reader1.ReadLine());
                if (mas[i] > 0)
                {
                    kol += 1;
                }
                if( mas[i]< min)
                {
                    min = mas[i];
                }
            }    
            Console.WriteLine("Количество полжительных чисел = {0}", kol);
            Console.WriteLine("Минимум = {0}", min);
            Console.ReadLine();
        }
    }
}
