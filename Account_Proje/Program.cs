//Account adında class oluşturunuz
//account sınıfının propertyleri 
//●	Iban numarası (string)
//●	Kişi adı
//●	Gelen para
//●	Giden para
//●	Toplam para

//eğer giden para değeri 1000 tl üzerinde ise ekstradan 4 tl
//2000 tl üzerindeyse 8 tl 
//10000 tl üzerindeyse 15 tl 
//20000 tl nin üzerinde ise %8 ekstra dan eklensin

//●	Toplam para değeri gelen para - giden para şeklinde hesaplanmalıdır
//Konu : Encapsulation
using Account_Proje;

Account a = new Account()
{
    Ibannumarası = "262213425",
    KişiAdı = "Hesap",
    GelenPara = 13000,
    GidenPara = 3500,
    ToplamPara = 9500,
};

//Console.WriteLine(a);
//a.setGidenPara(a.GidenPara);

//// ToplamPara'yı hesaplıyoruz
//a.setToplamPara(a.ToplamPara);

//// Bilgileri ekrana yazdırıyoruz
Console.WriteLine(a);
