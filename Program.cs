
/*
//soru 1
//math.abs kullanılarka sayının mutlak değerini al

Console.Write("Rakamları toplanacak sayıyı giriniz");
int sayi = Convert.ToInt32(Console.ReadLine());
int sonuc = 0;

for(int temp = Math.Abs(sayi); temp > 0; temp /= 10)
{
    sonuc += temp % 10;
}
Console.WriteLine("Girilen sayının rakamları toplamı: " + sonuc);
*/
//-----------------------------------------------------------------------------------------------
/*
//soru 2

Console.Write("10 ile 100 arasında bir sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());

while(sayi<10 || sayi>100)
{
    Console.Write("Geçersiz sayı girdiniz. Tekrar girin: ");
    sayi = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Koşul sağlanıyor: Girilen sayı: " + sayi);

*/
//-----------------------------------------------------------------------------------------------

// soru 3
/*
int[] yasDizisi = { 10, 7, 3, 12, 15, 16, 14, 22, 36, 41, 65, 73, 50,81, 90};

foreach (int i in yasDizisi)
{
    string kategori;
    if (i >= 0 && i <= 12)
        kategori = "Çocuk";
    else if (i >= 13 && i <= 19)
        kategori = "Genç";
    else if (i >= 20 && i <= 65)
        kategori = "Yetişkin";
    else kategori = "Yaşlı";
    Console.WriteLine($"Yaş: {i} - Kategori: {kategori}");
}
*/
//-----------------------------------------------------------------------------------------------
// soru 4 
/*
int[] dizi = { 1, 2, 7, 12, 18, 69, 87, 87, 2, 6, 22, 78, 22, 14, 7, 7, 69, 7, 2 };

Console.WriteLine("Tekrar eden elemanlar: ");

for(int i = 0;i<dizi.Length; i++)
{
    for(int j = i+1; j<dizi.Length; j++)
    {
        if (dizi[i] == dizi[j])
        {
            bool varmi = false;
            for(int k = 0; k < i; k++)
            {
                if (dizi[k] == dizi[i])
                {
                    varmi = true;
                    break;
                }
            }
            if ((!varmi))
            {
                Console.WriteLine(dizi[i]);
            }
            break;

        }
    }
}
*/
//-----------------------------------------------------------------------------------------------
/*
//soru 5
string[] dizi = {"çanta", "mouse", "kamera", "bilgisayar", "kulaklık", "masa", "telefon", "tablet"};
string uzunKelime = dizi[0];
string kısaKelime = dizi[0];

for(int i = 1; i<dizi.Length; i++)
{
    if (dizi[i].Length > uzunKelime.Length)
    {
        uzunKelime = dizi[i];
    }
    if(dizi[i].Length < kısaKelime.Length)
    {
        kısaKelime = dizi[i];
    }   
}
Console.WriteLine($"En uzun kelime: {uzunKelime}");
Console.WriteLine($"En kısa kelime: {kısaKelime}");
*/
//-----------------------------------------------------------------------------------------------
//soru 6 
/*
Console.Write("Bir cümle giriniz: ");
string cumle = Console.ReadLine();
string[] kelimeler = cumle.Split(' ');
Array.Sort(kelimeler);
Console.WriteLine("Cümlenin alfabetik sıralanmış hali: ");
foreach(string kelime in kelimeler)
{
    Console.WriteLine(kelime);
}
*/
//-----------------------------------------------------------------------------------------------
/*
//soru 7
List<int> sayilar = new List<int> { 45, 78, 69, 36, 12, 23 };
Console.WriteLine("Liste: ");
Ekle(sayilar);

sayilar.Add(14);
sayilar.Add(8);

static void Ekle(List<int> liste)
{
    foreach (var sayi in liste)
    {
        Console.WriteLine(sayi);
    }
}

Console.WriteLine("yeni liste: ");
foreach(int i in sayilar)
{
    Console.WriteLine(i);
}
*/
//-----------------------------------------------------------------------------------------------
/*
// soru 8

List<string> kelimeler = new List<string>();
string input = "";

while(input.ToLower() != "exit")
{
    Console.Write("Bir kelime girin:(Çıkmak için exit yazın) ");
    input = Console.ReadLine();

    if(input.ToLower() != "exit")
    {
        kelimeler.Add(input);
    }
}

kelimeler.Reverse();
Console.WriteLine("Girilen kelimelerin ters sıralanmış hali: ");
foreach(var kelime in kelimeler)
{
    Console.WriteLine(kelime);
}
*/
//-----------------------------------------------------------------------------------------------
/*
//soru 9 

List<int> sayilar = new List<int>();
string giris;
Console.WriteLine("Sayıları giriniz (Çıkmak için 'exit' yazın):");
while (true)
{
    Console.Write("Sayı Girin: ");
    giris = Console.ReadLine();
    if (giris.ToLower() == "exit")
        break;
    bool sayiMi = true;
    foreach (char c in giris)
    {
        if (!char.IsDigit(c) && c != '-')
        {
            sayiMi = false;
            break;
        }
    }
    if (sayiMi && int.TryParse(giris, out int sayi))
    {
        sayilar.Add(sayi);
    }
    else
    {
        Console.WriteLine("Geçersiz giriş! Lütfen bir sayı girin.");
    }
}

if (sayilar.Count > 0)
{
    int toplam = 0;
    for (int i = 0; i < sayilar.Count; i++)
    {
        toplam += sayilar[i];
    }
    double ortalama = (double)toplam / sayilar.Count;
    Console.WriteLine($"Sayıların ortalaması: {ortalama}");

    Console.WriteLine("Sıralama öncesi dizi:");
    foreach (int sayi in sayilar)
    {
        Console.Write(sayi + " ");
    }
    Console.WriteLine();

    // Bubble Sort algoritması
    for (int i = 0; i < sayilar.Count - 1; i++)
    {
        for (int j = 0; j < sayilar.Count - i - 1; j++)
        {
            if (sayilar[j] > sayilar[j + 1])
            {
                // Swap işlemi
                int temp = sayilar[j];
                sayilar[j] = sayilar[j + 1];
                sayilar[j + 1] = temp;
            }
        }
    }

    Console.WriteLine("Sıralama sonrası dizi:");
    foreach (int sayi in sayilar)
    {
        Console.Write(sayi + " ");
    }
    Console.WriteLine();
}
else
{
    Console.WriteLine("Hiç sayı girmediniz!");
}
*/
//-----------------------------------------------------------------------------------------------
//soru 10 
/*
List<int> sayilar = new List<int> { 7,16,22,31,2,41,5,34,8,81,1};
Console.Write("İlk Liste : ");
foreach (int sayi in sayilar)
{
    Console.Write(sayi + " ");
}

List<int> yeniListe = new List<int>();

foreach (int sayi in sayilar)
{
    if (sayi >= 10)
    {
        yeniListe.Add(sayi);
    }
}

sayilar = yeniListe;
Console.WriteLine();
Console.Write("10'dan küçük sayıların silinen listesi: ");
foreach (int sayi in sayilar)
{
    Console.Write(sayi + " ");
}
Console.WriteLine();
*/
//-----------------------------------------------------------------------------------------------

//soru 11
List<int> notlar = new List<int> { 45, 78, 60, 36, 90, 85, 30, 40, 90, 63 };

Console.WriteLine("İlk Notlar: ");
foreach(int j  in notlar)
{
    Console.Write(j + " " );
}
Console.WriteLine();

for (int i = 0; i < notlar.Count; i++)
{
    if (notlar[i] < 50 )
    {
        notlar[i] = 50;
    }
}
Console.WriteLine("Güncellenmiş not listesi: ");
foreach (int i in notlar)
{
    Console.Write(i + " ");
}

//--------------------------------------------------------------------------------------------------------------
/* --METOT NEDİR? 
 * belirli bir işlevi gerçekleştiren kod bloklarıdır 
 * en küçük program parçası
 


--- NEDEN KULLANILIR?
 * yeniden kullanılabilir, karmaşıklığı azaltan, okunabilirliği artırıp kod düzeni organizasyonu ve verimliliği açısından tercih edilir
 
 
---RETURN VE VOİD METOT FARKI?
 * Return: işlem sonucunda aldığı veri tipi ile sonuc veren metottur farklı işlemlerde kullanılmasını sağlar
   public int Topla ()
        { 
            return 2+2
        }

 * Void: işlemi doğrudan kullanılmasını sağlar, genellikle tek işlem üzerine kullanılır
   static void islem()
        {
            Console.WriteLine("geriye değer döndürmeyen ");
        }


--- METOTLARIN PARAMETRELERİ NASIL ÇALIŞIR?
 parametreler, metodu çağırırken  giriş verisi sağlar.
 metodun içinde işlem yapılacak değişkenler olarak tanımlanabilir
opsiyonel olarak kullanılır veya değer atanmazsa default değer  zorunlu kullanır
metot tanımlanırken zorunlu olanlar solda opsiyonel olan sağda tanımlanır 
static public void X(int a , int b , int x = 0 , int y = 0)
{

}

ErişimBelirteci DönüşTipi MetotAdı(ParametreTipi parametreAdı)
{
    // Metot içeriği
}
*/