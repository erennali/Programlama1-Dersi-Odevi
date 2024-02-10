using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Değerleri Aralarında Boşluk Olacak Şekilde Giriniz: ");
            string giris=Console.ReadLine();
            string[] degerler= giris.Split(' ');
            int elmaSayisi = Convert.ToInt32(degerler[4]), portakalSayisi = Convert.ToInt32(degerler[5]);
            int elmaKoordinat = Convert.ToInt32(degerler[2]), portakalKoordinat = Convert.ToInt32(degerler[3]);
            int mustafaEvBas= Convert.ToInt32(degerler[0]), mustafaEvBit = Convert.ToInt32(degerler[1]);
            int[] elmaDegerleri = new int[elmaSayisi];
            int[]portakalDegerleri= new int[portakalSayisi];
            int dusenElma=0, dusenPortakal=0;
            for (int i = 0; i < elmaSayisi; i++)
            {
                elmaDegerleri[i] =Convert.ToInt32(degerler[i + 6]);
                if ((elmaDegerleri[i] + elmaKoordinat) >= mustafaEvBas && (elmaDegerleri[i] + elmaKoordinat) <= mustafaEvBit)
                    dusenElma++;
            }
            for (int i = 0; i < portakalSayisi; i++)
            {
                portakalDegerleri[i] = Convert.ToInt32(degerler[i + 6+elmaSayisi]);
                if ((portakalDegerleri[i] + portakalKoordinat) >= mustafaEvBas && (portakalDegerleri[i] + portakalKoordinat) <= mustafaEvBit)
                   dusenPortakal++;
            }

            Console.WriteLine($"\nMustafa'nın Evinin İçine Düşen\n\nElma Sayısı= {dusenElma}\nPortakal Sayısı = {dusenPortakal}");


            Console.ReadKey();
        }
    }
}
