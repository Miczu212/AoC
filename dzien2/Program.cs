   using System;
   using System.Linq;
namespace dzien2 { 
        internal class Program
        {
            static void Main(string[] args)
            {
            int spr = 0;
                string[] plik = System.IO.File.ReadAllLines(@"C:\Users\pc\Desktop\Studia\inne\adventocode\a.txt");
            foreach(var p in plik)
            {
                spr++;
            }
                char[] wróg = new char[spr];
                char[] ja = new char[spr];
                int j = 0, i = 0,punkty=0;
            foreach (var i1 in plik)
            {
                foreach (var i2 in i1)
                {

                    if (i2.Equals('A') || i2.Equals('B') || i2.Equals('C'))
                    {
                        wróg[j] = i2;
                        j++;
                    }
                    else if (i2.Equals('X') || i2.Equals('Y') || i2.Equals('Z'))
                    {
                        ja[i] = i2;
                        i++;


                    }
               }
                }
                for (int o = 0; o < spr; o++)
                {
                    if (ja[o] == 'X')
                    {
                        
                        if (wróg[o] == 'A')
                        {
                            punkty += 3;
                        }
                        else if (wróg[o] == 'C')
                        {
                            punkty += 2;
                        }
                         else
                         {
                             punkty += 1;
                          }
                      }
                    else if (ja[o] == 'Y')
                        {
                    punkty += 3;
                         if (wróg[o] == 'A')
                         {
                                punkty += 1;
                         }
                          else if (wróg[o] == 'C')
                         {
                             punkty += 3;
                          }
                    else
                    {
                        punkty += 2;
                    }
                }
                    else if (ja[o] == 'Z')
                    {
                    punkty += 6;

                    if (wróg[o] == 'A')
                    {
                        punkty += 2;
                    }
                    else if (wróg[o] == 'C')
                    {
                        punkty += 1;
                    }
                    else
                    {
                        punkty += 3;
                    }
                }
                }
                
            Console.WriteLine(punkty);

            }

        }
    }
