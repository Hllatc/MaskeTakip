

using Business.Concrete;
using Entities.Concrete;

selamver("hilal");
selamver();

int sonuc = Topla(3, 5);

static void selamver(string isim="isimsiz")
{
    Console.WriteLine("Merhaba.."+isim);
}
static int Topla(int sayi1,int sayi2)
{
    var sonuc=sayi1+sayi2;
    Console.WriteLine("Sonuc.." + sonuc);
    return sonuc;
}

Person person =new Person();
person.FistName = "Hilal";
person.LastName = "Danışan";
person.DateofBirthYear = 1992;
person.NationalIdentitiy = 22669846430;

PttManager pttmaneger=new PttManager(new PersonManager());
pttmaneger.GiveMask(person);
public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int Dogumyili { get; set; }
    public long TcNo { get; set; }
}
