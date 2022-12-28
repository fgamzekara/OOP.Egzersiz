using OOP.Egzersiz;

internal class Program
{

    // İnsan isimli bir sınıf içinde; boy,kilo,yaş tanımlayıp bir kurucu metot içinde bu alanlar için varsyılan değer atamaları yapacağız.Son olarak "Tanis" isimli metotla girilen bilgileri kullanıcıya açıklayıcı şekilde görüntüleyen bir program yazınız.

    //Örnek 
    private static void Main(string[] args)
    {
        clsInsan Insan = new clsInsan();
        Insan.Tanis();
        
    }
}