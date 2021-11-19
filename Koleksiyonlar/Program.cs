using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //Console.WriteLine("-----------------------------------------------");

            //isimler = new string[5];  ---> //Aslında burada 5 elemanlı içi boş yeni bir isimler arrayi oluşturduk yukarıdaki isimler arrayi ile ilgisi yok.
            //isimler[4] = "ilker";  ---> //Yeni isimler arrayinin 5. elemanını İlker yaptık
            //Console.WriteLine(isimler[4]);  ---> //Yeni isimler arrayinin 5 elemanını yazdırdık
            //Console.WriteLine(isimler[0]);  ---> //Yeni arrayin ilk elemanını yazdırıyoruz ama bir şey yazmayacak çünkü ilk eleman boş

            /*Koleksiyonları kullanmamızın bir sebebi arraylere sonradan ekleme yapacak olursak array aralığının dışına çıkmış olabiliriz bu nedenle eklemez,
            ama koleksiyonlar ile bunu yapabiliyoruz*/

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
