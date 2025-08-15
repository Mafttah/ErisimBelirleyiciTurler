// Musteri.cs dosyası


public class Musteri
{
    public string AdiSoyadi { get; set; }
    public void BilgileriYazdir()
    {
        Console.WriteLine($"Müşterinin Adı: {AdiSoyadi}");
    }
}

class Program
{
    static void Main()
    {
        Musteri musteri1 = new Musteri();
        musteri1.AdiSoyadi = "Malik Burak Sarkan";
    }
}

public class BankaHesabi
{
    private decimal _bakiye;

    public BankaHesabi(decimal baslangicBakiye)
    {
        _bakiye = baslangicBakiye;
    }



    public void ParaYatir(decimal miktar)
    {
        if (miktar > 10)
        {
            _bakiye += miktar;
            GunlukLimitiKontrolEt();
        }
    }

    private void GunlukLimitiKontrolEt()
    {
        throw new NotImplementedException();
    }

    class Program
    {
        static void Main()
        {
            BankaHesabi hesap = new BankaHesabi(1500);
            hesap.ParaYatir(430);
        }
    }

    internal record struct NewStruct(object Item1, object Item2)
    {
        public static implicit operator (object, object)(NewStruct value)
        {
            return (value.Item1, value.Item2);
        }

        public static implicit operator NewStruct((object, object) value)
        {
            return new NewStruct(value.Item1, value.Item2);
        }
    }
}

internal record struct NewStruct1(object Item1, object Item2)
{
    public static implicit operator (object, object)(NewStruct1 value)
    {
        return (value.Item1, value.Item2);
    }

    public static implicit operator NewStruct1((object, object) value)
    {
        return new NewStruct1(value.Item1, value.Item2);
    }
}
