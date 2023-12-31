﻿// See https://aka.ms/new-console-template for more information
using Metotlar;


Urun urun1 = new Urun();
urun1.Adi = "Elma";
urun1.Fiyat = 15;
urun1.Aciklama = "Amasya elması";

Urun urun2 = new Urun();
urun2.Adi = "Karpuz";
urun2.Fiyat = 80;
urun2.Aciklama = "Diyarbakır karpuzu";

Urun[] urunler = new Urun[] { urun1, urun2 };

//type safe - tip güvenliği
foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyat);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("------------");

}

Console.WriteLine("------Metotlar--------");

//instance - örnek
//encapsulation


SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);

sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);







//Dont repeat yourself - DRY - Clean Code - Best Practice
