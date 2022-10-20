using System;
using System.Collections;

namespace Odev2_3// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.     
                  
            string s=Console.ReadLine();
            ArrayList Kelimeler=new ArrayList();
            ArrayList sesliHarfler=new ArrayList();

            foreach (var item in s.ToCharArray())
            {
             Kelimeler.Add(item);
            }
            foreach (char item in Kelimeler)
            {
                if ((item=='a') ||(item=='e')||(item=='ı')||(item=='i')||(item=='o')||(item=='ö')||(item=='u')||(item=='ü'))
                {
                    sesliHarfler.Add(item);
                }
            }
            sesliHarfler.Sort();
            foreach (var item in sesliHarfler)
            {
                Console.Write(item+" ");
            }
        }
    }   
}

