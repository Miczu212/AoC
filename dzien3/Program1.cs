using System;
using System.Linq;
using System.Text;

namespace dzien3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] plik = System.IO.File.ReadAllLines(@"C:\Users\pc\Desktop\Studia\inne\adventocode\a.txt");
            string[] linie = new string[plik.Length];
            int i = 0, punkty = 0;
            char buff;
            bool isdone=false;
            foreach (var i1 in plik)
            {
                linie[i] = i1;
                i++;
            }

            for (int o = 0; o < linie.Length; o = o + 3)
            {
                foreach (char c in linie[o])
                {
                    foreach (char b in linie[o + 1])
                    {
                        foreach (char a in linie[o + 2])
                        {
                            if (a.Equals(b) && a.Equals(c))
                            {
                                buff = a;
                                if (isdone == false)
                                {
                                    if ((int)buff >= 65 && (int)buff <= 90)
                                    {
                                        punkty += (int)buff - 38;
                                    }
                                    else if ((int)buff >= 97 && (int)buff <= 122)
                                    {
                                        punkty += (int)buff - 96;
                                    }
                                    isdone = true;   
                                }
                                
                            }
                        }
                    }
                }
                isdone = false;
            }
            Console.WriteLine(punkty);
        }
    }
}
