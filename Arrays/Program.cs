using System;

class Program
{
    static void Main()
    {
        // 1. Adım: 10 adet tam sayı verisi alacak bir dizi tanımlıyoruz.
        int[] sayilar = new int[10];

        // 2. Adım: Bu dizinin elemanlarını bir for döngüsü ile doldurup, foreach döngüsü ile tekrar ekrana yazıyoruz.
        // Diziyi kullanıcıdan veri alarak dolduruyoruz.
        Console.WriteLine("Lütfen 10 adet tam sayı giriniz:");
        for (int i = 0; i < sayilar.Length; i++)
        {
            Console.Write($"Sayı {i + 1}: ");
            sayilar[i] = int.Parse(Console.ReadLine());
        }

        // Diziyi foreach döngüsü ile ekrana yazdırıyoruz.
        Console.WriteLine("\nDizinin elemanları:");
        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);
        }

        // 3. Adım: Kullanıcıdan yeni bir değer alıp 11. eleman olarak diziyi büyütüyoruz.
        Console.Write("\n11. eleman olarak eklemek istediğiniz yeni değeri giriniz: ");
        int yeniSayi = int.Parse(Console.ReadLine());

        // Yeni bir dizi oluşturup, eski dizinin elemanlarını kopyalıyoruz ve yeni elemanı ekliyoruz.
        int[] yeniDizi = new int[sayilar.Length + 1];
        for (int i = 0; i < sayilar.Length; i++)
        {
            yeniDizi[i] = sayilar[i];
        }
        yeniDizi[yeniDizi.Length - 1] = yeniSayi;

        // 4. Adım: Diziyi büyükten küçüğe sıralayıp ekrana yazdırıyoruz.
        Array.Sort(yeniDizi); // Küçükten büyüğe sıralar
        Array.Reverse(yeniDizi); // Büyükten küçüğe çevirmek için ters çevirir

        Console.WriteLine("\nDizinin büyükten küçüğe sıralanmış halleri:");
        foreach (int sayi in yeniDizi)
        {
            Console.WriteLine(sayi);
        }
    }
}
