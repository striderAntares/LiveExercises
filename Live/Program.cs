using System.Numerics;

int gelenSayi = int.Parse(Console.ReadLine());

int karesi = (int)Math.Pow(5, 2);
//burada pow double döndürüyor fakat parantez içine int girdiğimiz için inte çevirecek. tabi inte çevrilecek bir yapı olmasının kontrolü bize ait.

//BigInteger.Parse("asdaaf"); //bu class gördüğün gibi System.Numerics namespaceini kullanır. ne manası var arbitrary bir rakama neden parse metodu atanmış meçhul.


int sayi = 255;
byte donusturulenSayi = (byte)sayi;
Console.WriteLine(donusturulenSayi);
//büyük bi şeyi küçüğe atmaya çalışınca mod alıyo küçüğe göre

byte sayi2 = 255;
sayi = sayi2;
Console.WriteLine(sayi);
//kapalı dönüşüm. küçükten büyüğe sıkıntısız bir geçiş.

byte dogruMu2 = 4;
bool booleanDeger = Convert.ToBoolean(dogruMu2);
Console.WriteLine(booleanDeger);
double dg = 0.000000000000000001d;
bool boolean = Convert.ToBoolean(dg);
Console.WriteLine(boolean);
//0 girilmiyosa hep true genelde
Console.WriteLine(dg);
//Boxing ve unboxing kavramlarını araştırınız. Bir console örneği yapınız.

int i = 256;
object o = i;
i = (int)o;


//faktöriyel

Console.WriteLine("You should enter a number if you wish to see it's factorial");
int n = Convert.ToInt32(Console.ReadLine());
int factorial = 1;
int counter = 1;
if(n==0)
    {
    factorial = 1;
    }
Console.WriteLine("Entered number= " + n + " Factorial= " + factorial);