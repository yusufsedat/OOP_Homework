/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2023 YAZ DÖNEMİ
**
** ÖDEV NUMARASI..........: 1.Ödev - SORU_2
** ÖĞRENCİ ADI............: Yusuf Sedat Sağaltıcı
** ÖĞRENCİ NUMARASI.......: B201210031
** DERSİN ALINDIĞI GRUP...: 1-A 
****************************************************************************/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string aranacakKelime;
            string karakterDizini;
            int secim ;
            
            

            do
            {
                Console.WriteLine(" \b  MENÜ");
                Console.WriteLine(" 1- String bir değişkende, string bir değişkeni substring() kullanmadan ara");
                Console.WriteLine(" 2- String bir değişkende, string bir değişkeni substring() kullanarak ara");
                Console.WriteLine(" 3- Alfabenin karakterlerini bir string'de ara, kaç adet geçiyor bul ve çiz");
                Console.WriteLine(" 4- Çıkış\b");

                Console.WriteLine("\bLütfen seçiniz\b");

                do
                {   
                    secim = Convert.ToInt32(Console.ReadLine());

                    

                    if (secim != 1 && secim != 2 && secim != 3 && secim !=4)
                    {
                        Console.WriteLine("Lütfen geçerli bir değer giriniz");
                    }
                      

                } while (secim != 1 && secim != 2 && secim != 3 && secim != 4);


                if (secim == 1)
                {   
                    Console.WriteLine("Ana metini giriniz: ");
                    


                    karakterDizini = Console.ReadLine();
                    Console.WriteLine("");


                    Console.WriteLine("Aranacak kelimeyi giriniz: ");
                   


                    aranacakKelime = Console.ReadLine();
                    Console.WriteLine("");

                    
                    

                    int index = 0;
                    bool kelimeVarmi = false;
                    while ((index = karakterDizini.IndexOf(aranacakKelime, index, StringComparison.OrdinalIgnoreCase)) != -1)
                    {

                        bool kelimeninSagindaBoslukVeyaNoktalamaVar = index + aranacakKelime.Length >= karakterDizini.Length || !Char.IsLetter(karakterDizini[index + aranacakKelime.Length]);
                        bool kelimeninSolundaBoslukVeyaNoktalamaVar = index == 0 || !Char.IsLetter(karakterDizini[index - 1]);

                        if (kelimeninSagindaBoslukVeyaNoktalamaVar && kelimeninSolundaBoslukVeyaNoktalamaVar)
                        {
                            Console.Write("Kelime  ");

                            Console.ForegroundColor = ConsoleColor.Green;

                            Console.Write( aranacakKelime );
                            kelimeVarmi = true;
                            Console.ResetColor();
                            Console.WriteLine("  İndis:  " + index);
                            Console.WriteLine("");


                        }


                        index = index + aranacakKelime.Length;
                    }

                    if (!kelimeVarmi)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Kelime Bulunamadı !!!");
                        Console.WriteLine("");
                        Console.ResetColor();
                    }

                }

                else if (secim == 2)
                {
                    Console.WriteLine("Ana metini giriniz: ");

                    karakterDizini = Console.ReadLine();

                    Console.WriteLine("Aranacak kelimeyi giriniz: ");

                    aranacakKelime = Console.ReadLine();

                    int index = 0;
                    bool kelimeVarmi = false;


                    while (index < karakterDizini.Length)
                    {
                        if (karakterDizini.Length - index < aranacakKelime.Length) break;

                        string subString = karakterDizini.Substring(index, aranacakKelime.Length);

                        if (subString.Equals(aranacakKelime, StringComparison.OrdinalIgnoreCase))
                        {
                            bool kelimeninSagindaBoslukVeyaNoktalamaVar = index + aranacakKelime.Length >= karakterDizini.Length || !Char.IsLetter(karakterDizini[index + aranacakKelime.Length]);
                            bool kelimeninSolundaBoslukVeyaNoktalamaVar = index == 0 || !Char.IsLetter(karakterDizini[index - 1]);

                            if (kelimeninSagindaBoslukVeyaNoktalamaVar && kelimeninSolundaBoslukVeyaNoktalamaVar)
                            {
                                Console.Write("Kelime  ");

                                Console.ForegroundColor = ConsoleColor.Green;

                                Console.Write(aranacakKelime);
                                kelimeVarmi = true;
                                Console.ResetColor();
                                Console.WriteLine("  İndis:  " + index);
                                Console.WriteLine("");

                            }

                        }

                        index++;

                    }

                    if (!kelimeVarmi)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Kelime Bulunamadı !!!");
                        Console.WriteLine("");
                        Console.ResetColor();
                    }
                }

                else if (secim == 3)
                {
                    char[] Alfabe = new char[29] { 'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'ğ', 'h', 'ı', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z' };
                    int[] harfSayi = new int[29];
                    Console.WriteLine("Ana metini giriniz: ");

                    karakterDizini = Console.ReadLine();

                    foreach (var karakter in karakterDizini.ToLower())
                    {
                        if (char.IsLetter(karakter))
                        {
                            for (int i = 0; i < Alfabe.Length; i++)
                            {
                                if (karakter == Alfabe[i])
                                {
                                    harfSayi[i]++;
                                    break;
                                }
                            }
                        }
                    }

                    Console.WriteLine("\tKarakter    Sayısı \t\tGrafik Gösterimi");

                    for (int i = 0; i < Alfabe.Length; i++)
                    {
                        Console.Write("\t   " + Alfabe[i] + "\t       " + harfSayi[i] + "\t\t");

                        for (int j = 0; j < harfSayi[i]; j++)
                        {
                            Console.Write(" * ");
                        }
                        Console.WriteLine();
                    }
                }
                else if(secim==4)
                {
                    Environment.Exit(0); // Konsolu kapatır.
                }

                string devam;

                do
                {                    
                    Console.Write("Başka işlem yapmak istiyor musunuz? (e): ");
                    Console.WriteLine("Çıkmak için lütfen 4'e basın");
                    devam = Console.ReadLine().ToLower();
                    Console.Clear();
                    if (devam == "4")
                    {
                        Environment.Exit(0); // Konsolu kapatır.
                    }
                } while (devam != "e");


            } while (secim == 1 || secim == 2 || secim == 3 || secim !=4);

            Console.ReadKey();
        }
    }
}
