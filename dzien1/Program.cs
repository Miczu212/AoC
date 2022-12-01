using System;
using System.Linq;

namespace adventocode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int j = 0, suma = 0;
            string[] line = System.IO.File.ReadAllLines(@"C:\Users\pc\Desktop\Studia\inne\adventocode\a.txt");
            int[] sumaelfow = new int[line.Length];
            for (int i = 0; i < line.Length; i++)
            {


                if (int.TryParse(line[i], out int value))

                {
                    suma += int.Parse(line[i]);
                }
                else
                {
                    sumaelfow[j] = suma;
                    j++;
                    suma = 0;
                }

            }
            var sum = sumaelfow.ToList();
            int g = j;
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine(sum.Max());
                for(j=0;j<g;j++)
                {
                    if (sum[j] ==sum.Max())
                    {
                        sum.Remove(sum[j]);
                        break;

                    }
                }
            }

        }
    }
}
