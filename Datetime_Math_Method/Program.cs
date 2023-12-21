using System;
namespace Datetime_Math_Method
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); //günün tarihini
            Console.WriteLine(DateTime.Now.Date); //gün ay yıl
            Console.WriteLine(DateTime.Now.Day);// gününü
            Console.WriteLine(DateTime.Now.Month);//ayını
            Console.WriteLine(DateTime.Now.Year);//yılını
            Console.WriteLine(DateTime.Now.Hour);//saatini
            Console.WriteLine(DateTime.Now.Minute);//dakikasını
            Console.WriteLine(DateTime.Now.Second);//saniyesini

            Console.WriteLine(DateTime.Now.DayOfWeek);//haftanın gününü string hale getiriyor
            Console.WriteLine(DateTime.Now.DayOfYear);//yılın kaçıncı gününü

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            //Datetime format
            Console.WriteLine(DateTime.Now.ToString("dd"));//20
            Console.WriteLine(DateTime.Now.ToString("ddd"));//Wed
            Console.WriteLine(DateTime.Now.ToString("dddd"));//Wednesday
            
            Console.WriteLine(DateTime.Now.ToString("MM"));//12
            Console.WriteLine(DateTime.Now.ToString("MMM"));//Dec
            Console.WriteLine(DateTime.Now.ToString("MMMM"));//December
            
            Console.WriteLine(DateTime.Now.ToString("yy"));//23
            Console.WriteLine(DateTime.Now.ToString("yyyy"));//2023
            
            Console.WriteLine("***** Math Kütüphanesi *****");

            //Math Kütüphanesi
            Console.WriteLine(Math.Abs(-25));//mutlak 25
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));
            
            Console.WriteLine(Math.Ceiling(22.3));//büyük en küçük tam sayı 23
            Console.WriteLine(Math.Round(22.3)); //en yakın tam sayı 22
            Console.WriteLine(Math.Round(22.7)); //en yakın tam sayı 23
            Console.WriteLine(Math.Floor(22.7)); //küçük en büyük tam sayı 22

            Console.WriteLine(Math.Max(2,6)); 
            Console.WriteLine(Math.Min(2,6));

            Console.WriteLine(Math.Pow(3,4)); //3^4 ü verir 81 
            Console.WriteLine(Math.Sqrt(9)); //karekök alır 3
            Console.WriteLine(Math.Log(9)); // 9 un e tabanındaki logoritmik karşılığı
            Console.WriteLine(Math.Exp(3)); // e üzeri 3 ü verir
            Console.WriteLine(Math.Log10(10)); // 10 sayısının logaritma 10 tabanındaki karşılığı
            
        }            
    }
}