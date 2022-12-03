//using System;
//using System.Linq;
//using System.Text;

//namespace dzien3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] plik = System.IO.File.ReadAllLines(@"C:\Users\pc\Desktop\Studia\inne\adventocode\a.txt");
//            string[] linie = new string[plik.Length];
//            int i = 0,punkty=0;
//            bool polowa=false;
//            char buff=' ';
//            foreach (var i1 in plik)
//                {
//                linie[i] = i1;
//                i++;
//                }
//            i = 0;

//            for (int o = 0; o < linie.Length; o++)
//            {
//                char[] temp = new char[linie[o].Length/2];
//                char[] temp2 = new char[linie[o].Length/2];
//                foreach (var i1 in linie[o])
//                {
//                    if (polowa == false)
//                    {
//                        temp[i] = i1;
//                        i++;
//                    }                       
//                    else
//                    {
//                        temp2[i] = i1;
//                        i++;
//                    }
//                    if (i == linie[o].Length / 2)
//                    {
//                        polowa = true;
//                        i = 0;
//                    }
//                }
//                polowa = false;
//                foreach (char a in temp)
//                {
//                    foreach (char b in temp2)
//                    {
//                        if (b.Equals(a))
//                        {
//                            buff = b;
                            
                            
//                        }
//                    }
//                }
                
//                if ((int)buff >= 65 && (int)buff <= 90)
//                {
//                    punkty += (int)buff - 38;
//                }
//                else if ((int)buff >= 97 && (int)buff <= 122)
//                {
//                    punkty += buff - 96;
//                }


//            }
//            Console.WriteLine(punkty);

//        }
//    }
//}
