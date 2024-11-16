using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string ve  stringbuilder ın en büyük farkı string değeri değiştirdiğinde her değişiklik
            //için sistemde bir yer ayırır ve en son halini üstüne yazdırarak gösterir.
            //stringbuilder ise en son halini sistemde tutar ve onu gösterir.
            //hızlılık ve zaman açısından stringbuilder çok daha hızlıdır.


            //StringBuilder Sınıfının Temel Metotları:
            //Append: Metne yeni bir şey ekler.
            //Insert: Belirli bir konuma metin ekler.
            //Remove: Belirli bir aralıktaki metni siler.
            //Replace: Metindeki bir karakteri veya kelimeyi değiştirir.
            //ToString: StringBuilder nesnesini normal bir string'e dönüştürür.

            StringBuilder str = new StringBuilder();
            //str değişkenine "Append" kullanarak bir cümle attım.
            str.Append("C# Programlama Eğitimine Hoşgeldiniz.");
            Console.WriteLine(str);
            //str değişkeninin içinde "Raplace" kullanarak var olan "Programlama" Kelimesini "Yazılım" olarak değiştirdim.
            str.Replace("Programlama", "Yazılım");
            Console.WriteLine(str);
            //str değişkeninin içinde 0. indexe "Sıfırdan" Kelimesini eklemesini söyledim 0.index cümlenin başı olacağı için başına ekledi.
            str.Insert(0, "Sıfırdan ");
            Console.WriteLine(str);
            //str değişkeninin içinde ki cümleden "Remove" Kullanarak dedim ki cümlede ki 0. karakterden başla 9. karaktere kadar sil.
            //yani yukarıda eklediğimiz "Sıfırdan" kelimesini silmiş olacak.
            str.Remove(0,9);
            Console.WriteLine(str);
            //-----------------------------------------
            //DateTime anahtar sözcüğü zamanla ilgili olup bilgisayarınızdan mevcut zamanı sistemsel saait günü ayı yılı saniyeyi çeker
            //baslangic değişkenine de datetime.now dediğim için şuan ki zamanı al ve başlangıç değişkenine at dedim
            DateTime baslangic = DateTime.Now;
            //i yi 0 dan başlat 5000e kadar devam etsin ve her işlemde i yi 1 arttır dedim ve i yi append kullanrak str değişkeninin içine attım
            for (int i = 0; i < 5000; i++)
            {
                str.Append(i);
            }
            //yukarda ki işlemin aynısını yapıp bu sefer bitiş olarak değer aldım işlemden sonra ki süreyi.
            DateTime bitis = DateTime.Now;
            //bitiş de ki süre ile başlangıçta ki süreyi çıkart arada ki farkı da bana "TotalSeconds" sözcüğüyle saniye bazında al dedim.
            double sure = (bitis - baslangic).TotalSeconds;
            //saniye bazında aldığımız değeri de ekrana göster.
            Console.WriteLine(sure);

            //aynı işlemi String ile yaparsanız eğer arada ki 3 saniyelik farkı görürsünüz.
            //buda fazla kelime içeren metinlerde sürenin ne kadar büyüyeceğini tahmin etmenize olanak sağlar.
        }
    }
}
