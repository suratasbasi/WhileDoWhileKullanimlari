
// Döngüyü önce while ile yazdırıyorum.

int sayac = 0;

Console.WriteLine("Lütfen bir sayı değeri giriniz: ");
int limit = Convert.ToInt32(Console.ReadLine());

 while (sayac < limit)
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac++;
}


Console.WriteLine("\n----------------------------------------------------------\n");


// Döngüyü do while ile yazdırıyorum.

int sayac2 = 0;

Console.WriteLine("Lütfen bir sayı değeri giriniz: ");
int limit2 = Convert.ToInt32(Console.ReadLine());

do
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac2++;
}

while (sayac2 < limit2);


// While döngüsü ile yazdırıldığında kullanıcı eğer negatif değer girerse döngü hiç çalışmaz ama do-while döngüsü ile yazdırılırsa kullanıcı negatif değer girse dahi döngü bir kez çalıştırılır ve Console ekranına metin yazdırılır ancak döngü devam etmez. Yazılan bu metinde döngünün en az bir kez çalıştırılması mantıklı olacağı için do-while ile yazdırmak daha mantıklı olacaktır.