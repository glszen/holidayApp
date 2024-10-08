using System.Data;
using System.Data.Common;
using System.Runtime.InteropServices;
string anotherpick = string.Empty; //Buradaki değişken en sondaki do/while döngüsünü kontrol etmek için atandı.
do
{
    Console.WriteLine("Gitmek İstediğiniz Lokasyonu Seçiniz: ");

    Console.WriteLine("\nBodrum (Paket başlangıç fiyatı 4000 TL) ");
    Console.WriteLine("Marmaris (Paket başlangıç fiyatı 3000 TL) ");
    Console.WriteLine("Çeşme (Paket başlangıç fiyatı 5000 TL) ");

    string location = string.Empty;
    location = Console.ReadLine().ToLower();

    int price = 0;


    while (location != "bodrum" && location != "marmaris" && location != "çeşme") //Bu adımda eğer yazdığımız ifade istediğimiz bir değişkene eşit değilse tekrar soruyu yöneltecektir.
    {
        Console.WriteLine("Geçerli bir lokasyon giriniz.");
        Console.WriteLine("\nGitmek İstediğiniz Lokasyonu Seçiniz: ");
        Console.WriteLine("\nBodrum (Paket başlangıç fiyatı 4000 TL) ");
        Console.WriteLine("Marmaris (Paket başlangıç fiyatı 3000 TL) ");
        Console.WriteLine("Çeşme (Paket başlangıç fiyatı 5000 TL) ");
        location = Console.ReadLine();
    }

    Console.WriteLine("\nKaç kişi için tatil planlıyorsunuz?");
    int person = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(location + " lokasyonuna " + person + " kişi gitmek istiyorsunuz.");

    if (location == "bodrum") //Burada ise, istenilen girdi doğru girilmiş ve artık seçilen şehre göre açıklamalar basılacaktır.
    {
        Console.WriteLine("\nİlk defa Bodrum’a geliyorsanız arabanızı Kumbahçe tarafındaki yolcu limanına park edip, tabanlara kuvvet, sahilden marinaya kadar yürümenizi öneririz. Böylece Bodrum merkezi baştan başa yürüyerek tanımış olursunuz.");
        price = 4000;
    }
    else if (location == "marmaris")
    {
        Console.WriteLine("\nMarmaris tatiliniz süresince en iyi aktiviteleri yapmak ve unutulmaz bir tatil geçirmeniz için en iyi yollardan birisi olarak Marmaris günlük turlara katılmanızı tavsiye ediyoruz.");
        price = 3000;
    }
    else if (location == "çeşme")
    {
        Console.WriteLine("\nÇeşme Marina, gün içerisinde soluklanabileceğiniz ve Çeşme gezinize kısa bir mola verebileceğiniz eşsiz bir lokasyondur. Denize nazır mekanlarda yemek yiyebilir, içeceklerinizi yudumlarken manzaranın tadını çıkarabilirsiniz.");
        price = 5000;
    }

    Console.WriteLine("\nTatile giderken hangi ulaşım türünü tercih edersiniz? Lütfen yukarıdaki seçeneklerden bir tanesini seçiniz: (1/2?) ");

    Console.WriteLine("\n1-Kara yolu (Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL) ");
    Console.WriteLine("2-Hava yolu (Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL) ");

    int transport = Convert.ToInt32(Console.ReadLine()); //Ulaşım
    int overland = 1500;
    int air = 4000;

    while (transport != 1 && transport != 2) //Bu adımda eğer yazdığımız ifade istediğimiz bir değişkene eşit değilse tekrar soruyu yöneltecektir.

    {
        Console.WriteLine("Hatalı bir giriş yaptınız. Lütfen geçerli bir seçenek giriniz.");
        transport = Convert.ToInt32(Console.ReadLine());
    }

    if (transport == 1)
        Console.WriteLine("\nTatiliniz toplam:" + ((price * person) + (overland * person)) + "TL tutuyor");
    else 
    {
        Console.WriteLine("\nTatiliniz toplam:" + ((price * person) + (air * person)) + "TL tutuyor");
    }

    Console.WriteLine("\nBaşka bir tatil planlamak istiyor musunuz?(Evet/Hayır)"); 
    anotherpick = Console.ReadLine().ToLower();
}
while (anotherpick == "evet"); //Eğer cevap evet olursa döngü baştan başlayacak.
