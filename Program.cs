using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskontohesap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bu program ürünün iskonto oranına göre yeni etiket fiyatını belirler.");
            Console.Write("Ürünün satış fiyatını giriniz: ");
            int urunfiyati=Convert.ToInt32(Console.ReadLine());
            int iskonto = (urunfiyati * 20) / 100;
            int etiketfiyati=urunfiyati-iskonto;
            Console.WriteLine("Ürünün yeni etiket fiyatı: "+" " + etiketfiyati +" "+ "Türk Lirası'dır.");
            Console.WriteLine("Bu ürün için bu ayki iskonto oranı % 20'dir.");
            Console.ReadLine(); 

           
        }
    }
}
