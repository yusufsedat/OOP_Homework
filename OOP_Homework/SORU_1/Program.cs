/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2023 YAZ DÖNEMİ
**
** ÖDEV NUMARASI..........: 1.Ödev - SORU_1
** ÖĞRENCİ ADI............: Yusuf Sedat Sağaltıcı
** ÖĞRENCİ NUMARASI.......: B201210031
** DERSİN ALINDIĞI GRUP...: 1-A 
****************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int indeks = 0;
            int indeks2 = 0;
            int kucukIndeks = 0;
            int buyukIndeks = 0;

            int ilkToplam = 0 , ikinciToplam=0 , sonToplam=0;


            Console.Write("Dizinin boyutunu giriniz: ");
            int diziBoyutu = Convert.ToInt32(Console.ReadLine());

            int[] dizi = new int[diziBoyutu];

            Random rnd = new Random();

            for (int i = 0; i < diziBoyutu; i++)
            {
                dizi[i] = rnd.Next(1, 10); 
            }


            Console.Write("Sayılar:  ");
            foreach (var eleman in dizi)
            {
                Console.Write( eleman + "   ");

            }

            Console.WriteLine();

            do
            {
                Console.Write("Bir indis giriniz: ");

                indeks = Convert.ToInt32(Console.ReadLine());

                Console.Write("İkinci indisi giriniz: ");

                indeks2 = Convert.ToInt32(Console.ReadLine());

                if (indeks < 0 || indeks >= diziBoyutu || indeks2 < 0 || indeks2 >= diziBoyutu)
                {
                    Console.WriteLine("Girilen indis degeri veya degerleri uygun degil.Tekrar deneyin.");
                }

            } while (indeks < 0 || indeks >= diziBoyutu || indeks2 < 0 || indeks2 >= diziBoyutu);

            if (indeks < indeks2)
            {
                kucukIndeks= indeks;
                buyukIndeks = indeks2;
            }
            else if (indeks>indeks2)
            {
                kucukIndeks = indeks2;
                buyukIndeks = indeks;
            }
            else
            {
                kucukIndeks = indeks; //Eşit olması durumunda herhangi birine atıyorum.
                buyukIndeks = indeks2;
            }

           for (int i=0;i<kucukIndeks;i++)
            {
                ilkToplam += dizi[i];
            }
           
           for(int i= kucukIndeks; i <= buyukIndeks; i++)
            {
                ikinciToplam += dizi[i];

            }

           for (int i= buyukIndeks + 1; i< diziBoyutu; i++)
            {
                sonToplam += dizi[i];

            }

            Console.WriteLine("İlk Toplam:" + ilkToplam);
            Console.WriteLine("İndisler Arası Toplam:" + ikinciToplam);
            Console.WriteLine("Son Toplam:" + sonToplam);

            
           
            Console.ReadKey();
        }
    }
}
