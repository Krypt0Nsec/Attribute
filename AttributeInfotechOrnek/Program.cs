// See https://aka.ms/new-console-template for more information
using AttributeInfotechOrnek;

Console.WriteLine("Hello, World!");


Ogrenci ogrenci = new Ogrenci();
ogrenci.Adi = "ibrahim";
ogrenci.Soyadi = "gökyar";
if (!ZorunlulukKontrolu.Dogrula(ogrenci))
{
    Console.WriteLine("Öğrenci bilgileri doğrulamadan geçemedi!");
}
else
{
    Console.WriteLine("form başarılı");
}