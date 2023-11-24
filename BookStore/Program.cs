using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplamFiyat = 0;
            string kitapSecimi;

            Console.WriteLine("**************************************************************************");
            Console.WriteLine();
            Console.WriteLine("**   Türkçe Kitaplar Kategorisi    **    Yabancı Kitaplar Kategorisi    **");
            Console.WriteLine();
            Console.WriteLine("**   1-Çalıkuşu : Reşat Nuri       **    7-Tuna Kılavuzu: Jules Verne   **");
            Console.WriteLine("**   2-Yaban : Yakup Kadri         **    8-Yabancı: Albet Camus         **");
            Console.WriteLine("**   3-Tehlikeli Oyunlar: O.Atay   **    9-1987: George Orwell          **");
            Console.WriteLine("**   4-Sinekli Bakkal : H.Edip     **    10-Arsene Lupin: M.Leblanc     **");
            Console.WriteLine("**   5-Geçtiğm Günlerden:H.A.Yücel **    11-Altıncı Koğuş: A.Çehov      **");
            Console.WriteLine("**   6-Kuyucaklı Yusuf : S.Ali     **    12-Kumarbaz: Dostoyevski       **");
            Console.WriteLine();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine();
            Console.WriteLine("-----İşlemler Menüsü-----");
            Console.WriteLine();
            Console.WriteLine("1-Fiyat Sorgulama");
            Console.WriteLine("2-Yeni Okur Kaydı");
            Console.WriteLine("3-Günün Kitabı");
            Console.WriteLine("4-Kitap Arşivi");
            Console.WriteLine("5-Yeni Kitap Satın Al");
            Console.WriteLine("6-Oyun");
            Console.WriteLine();
            Console.Write("Yapmak İstediğiniz İşlemin Numarası: ");


            try
            {
                char islem;

                islem = Convert.ToChar(Console.ReadLine());

                if (islem == '1')
                {
                    Console.WriteLine();
                    Console.Write("Lütfen Fiyatını Öğrenmek İstediğini Kitabın Numarasını Girin: ");
                    string numara;
                    numara= Console.ReadLine();

                    switch (numara) 
                    {
                        case "1": Console.WriteLine("Çalı Kuşu: 12Tl"); break;
                        case "2": Console.WriteLine("Yaban: 99Tl"); break;
                        case "3": Console.WriteLine("Tehlikeli Oyunlar: 52Tl"); break;
                        case "4": Console.WriteLine("Sinekli Bakkal: 82Tl"); break;
                        case "5": Console.WriteLine("Geçtiğim Günlerden: 52Tl"); break;
                        case "6": Console.WriteLine("Kuyucaklı Yusuf: 17Tl"); break;
                        case "7": Console.WriteLine("Tuna Kılavuzu: 20Tl"); break;
                        case "8": Console.WriteLine("Yabancı: 30Tl"); break;
                        case "9": Console.WriteLine("1987: 2002Tl"); break;
                        case "10": Console.WriteLine("Arsene Lupin: 15Tl"); break;
                        case "11": Console.WriteLine("Altıncı Koğuş: 32Tl"); break;
                        case "12": Console.WriteLine("Kumarbaz: 99.99Tl"); break;
                            default: Console.WriteLine("Bu Kitap Elimizde Yok"); break;
                     }

                }
                else if (islem == '2')
                {
                    Console.WriteLine("******* YENİ OKUR KAYDI *******");
                    string ad, soyad, universite;
                    Console.Write("Adınız: ");
                    ad= Console.ReadLine();
                    Console.Write("Soyadınız: ");
                    soyad = Console.ReadLine();
                    Console.Write("Üniversiteniz: ");
                    universite = Console.ReadLine();

                    string dynamicTxt = ad + "_" + soyad + ".txt";
                    string dosya = "C:\\Users\\Hp\\Desktop\\"+ dynamicTxt;

                    StreamWriter sw= new StreamWriter(dosya);
                    sw.WriteLine("Adınız: " + ad);
                    sw.WriteLine("Soydınız: " + soyad);
                    sw.WriteLine("Üniversteniz: " + universite);
                    sw.Close();


                }
                else if (islem == '3')
                {
                    DateTime bugun = DateTime.Now;
                    DayOfWeek haftaninGunu = bugun.DayOfWeek;
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("------------ İşte Günün Kitabı ----------------");
                    Console.WriteLine("-----------------------------------------------");

                    if (haftaninGunu == DayOfWeek.Monday)
                    {
                    Console.WriteLine("---------    Ç   alıkuşu : Reşat Nuri    ---------");
                    }
                    if (haftaninGunu == DayOfWeek.Tuesday)
                    {
                    Console.WriteLine("---------    Tutunamayanlar : Oğuz Atay   ----");
                    }
                    if (haftaninGunu == DayOfWeek.Wednesday)
                    {
                    Console.WriteLine("---------    Kumarbaz : Dostoyevski   --------");
                    }
                    if (haftaninGunu == DayOfWeek.Thursday)
                    {
                    Console.WriteLine("---------    Tehlikeli Oyunlar : Oğuz Atay   -");
                    }
                    if (haftaninGunu == DayOfWeek.Friday)
                    {
                    Console.WriteLine("---------    1987: George Orwell   -----------");
                    }
                    if (haftaninGunu == DayOfWeek.Saturday)
                    {
                    Console.WriteLine("---------    Kuyucaklı Yusuf: Sabahattin Ali  ");
                    }
                    if (haftaninGunu == DayOfWeek.Sunday)
                    {
                    Console.WriteLine("---------    Altıncı Koğuş: A.Çehov   --------");
                    }



                }
                else if (islem == '4')
                {
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("------------     Kitap Arşivi     -------------");
                    FileStream fs = new FileStream("C:\\Users\\Hp\\Desktop\\BooksCollection.txt", FileMode.Open, FileAccess.Read);
                    StreamReader sr= new StreamReader(fs);
                    string metin = sr.ReadLine();
                    while (metin != null){
                        Console.WriteLine(metin);
                        metin=sr.ReadLine();

                    }
                    sr.Close();
                    fs.Close();

                }
                else if (islem == '5')
                {
                    Console.WriteLine("----Bu sekmeden bir numara girerek kitap alabilirisinz---- ");


                    for (int i = 1; i <= 100; i++)
                    {
                        Console.WriteLine("---- Alacağınız Kitabın Numarasını giriniz ---- ");
                        kitapSecimi = Console.ReadLine();

                        if (kitapSecimi == "1")
                        {
                            toplamFiyat += 12;
                        }
                        else if (kitapSecimi == "2")
                        {
                            toplamFiyat += 99;
                        }
                        else if (kitapSecimi == "3")
                        {
                            toplamFiyat += 52;
                        }
                        else if (kitapSecimi == "4")
                        {
                            toplamFiyat += 82;
                        }
                        else if (kitapSecimi == "5")
                        {
                            toplamFiyat += 52;
                        }
                        else if (kitapSecimi == "6")
                        {
                            toplamFiyat += 17;
                        }
                        else if (kitapSecimi == "7")
                        {
                            toplamFiyat += 20;
                        }
                        else if (kitapSecimi == "8")
                        {
                            toplamFiyat += 30;
                        }
                        else if (kitapSecimi == "9")
                        {
                            toplamFiyat += 2002;
                        }
                        else if (kitapSecimi == "10")
                        {
                            toplamFiyat += 15;
                        }
                        else if (kitapSecimi == "11")
                        {
                            toplamFiyat += 32;
                        }
                        else if (kitapSecimi == "12")
                        {
                            toplamFiyat += 100;
                        }
                        else
                       
                            Console.WriteLine("Böyle bir kitap numarası yok");
                            Console.WriteLine("******");
                            Console.WriteLine("Başka bir kitap almak ister misiniz? (Evet/Hayır)");
                            string cevap = Console.ReadLine();
                            if (string.Equals(cevap, "hayır", StringComparison.OrdinalIgnoreCase))
                                break;
                        
                    }
                    Console.WriteLine("Toplam Fiyat: " + toplamFiyat + "TL");





                }

                else if (islem == '6')
                {
                    Console.WriteLine();
                    Console.WriteLine("işlem: Oyun");

                }
                else
                {
                    throw new Exception("HATA: böyle Bir İşlem Yok!!!!! Lütfen işlem listesini kontrol edip tekrar deneyiniz");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"{ex.Message}");


            }

            Console.Read();
        }
    }
}
