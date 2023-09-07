using System;
namespace Задание1
{

    class МирТрудМай
   {
      static void Main(string[] args)
      {
        //первое задание
        Console.Write("Задание 1:");
        Console.ReadLine();
        Console.WriteLine("МирТрудМай");
        Console.WriteLine("Мир");
        Console.WriteLine("   Труд");
        Console.WriteLine("      Май");
        //второе задание
        Console.Write("Задание 2:");
        Console.ReadLine();
        Console.Write("Введите первую переменную:");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите вторую переменную:");
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{number2} {number1}");
        //третье задание
        Console.Write("Задание 3:");
        Console.ReadLine();
        Console.Write("Введите радиус окружности: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        Console.Write("Длина окружности равна:");
        Console.WriteLine(2*3.14*radius);
        double S=Math.Pow(radius,2)*3.14;
        Console.WriteLine($"Площадь круга равна:{S}");
        //четвертое задание
        Console.Write("Задание 4:");
        Console.ReadLine();
         Console.WriteLine("Решим y=cos(x)");
        Console.Write("Введите x(в радианах):");
        double argument = Convert.ToDouble(Console.ReadLine());               
        Console.WriteLine("y=" + Math.Cos(argument));
        Console.Write("Введите x(в градусах):");
        double grad=Convert.ToDouble(Console.ReadLine());
        double grad1=grad*Math.PI/ 180;
        Console.WriteLine("y=" + Math.Cos(grad1));

        //пятое задание
        Console.Write("Задание 5:");
        Console.ReadLine();
        Console.WriteLine("Решим квадратное уравнеие вида: ax^2+bx+c=0");
       Console.Write("Введите значение a:");
       int a= Convert.ToInt32(Console.ReadLine());
       Console.Write("Введите значение b:");
       int b= Convert.ToInt32(Console.ReadLine());
       Console.Write("Введите значение c:");
       int c= Convert.ToInt32(Console.ReadLine());
       Console.Write("Найдем корни:"); 
      
         double D= Math.Pow(b,2)-4*a*c;
         if (D <0)
              {
               Console.WriteLine("Корней нет");
              }
         if (D == 0) 
              {
                double x= -b/2*a;
                Console.Write($"x={x}");
              }  
          if (D>0)       
           {
       double x1 = (-b + Math.Sqrt(D)) / 2 * a;
       double x2 = (-b - Math.Sqrt(D)) / 2 * a;
           
       Console.WriteLine($" x1={x1}, x2={x2}");
           }
           //шестое задание
           Console.Write("Задание 6:");
        Console.ReadLine();
       Console.WriteLine("Введите значение переменной a:");
        int v = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение переменной b:");
        int j = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение переменной c:");
        int i = Convert.ToInt32(Console.ReadLine());

        

        int temp = j;
        j = i;
        i = v;
        v = temp;

        Console.WriteLine("a)новые значения переменных:");
        Console.WriteLine("a = " + v);
        Console.WriteLine("b = " + j);
        Console.WriteLine("c = " + i); 
          int temp1 = i;
        j = v;
        i = j;
        v = temp1;     
        Console.WriteLine("b)новые значения переменных:");
        Console.WriteLine("a = " + v);
        Console.WriteLine("b = " + j);
        Console.WriteLine("c = " + i);
        //седьмое задание
        Console.Write("Задание 7:");
        Console.ReadLine();

        Random kardan= new Random();
        int number_1=kardan.Next();
        int number_2=kardan.Next();
        int number_3=kardan.Next();
        int number_4=kardan.Next();
        Console.WriteLine(number_1);
        Console.WriteLine(number_2);
        Console.WriteLine(number_3);
        Console.WriteLine(number_4);
        //восьмое задание
        Console.WriteLine("Задание 8:");
        Console.WriteLine("Введите трехзначное число:");
        int число=Convert.ToInt32(Console.ReadLine());
        int число1=число/10;
        int цифра=число%10;
        int итог=цифра*100+число1;
        Console.WriteLine(итог);
        //девятое задание
        Console.Write("Задание 9:");
        Console.ReadLine();
        Console.WriteLine("Введите цену 1 кг конфет, печенья и яблок:");
        Console.Write("Цена конфет в рублях: ");
        double конфет_цена = Convert.ToDouble(Console.ReadLine());
        Console.Write("Цена печенья в рублях: ");
        double печенья_цена = Convert.ToDouble(Console.ReadLine());
        Console.Write("Цена яблок в рублях: ");
        double яблок_цена = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите кол-во кг продуктов:");
        Console.Write("Количество кг конфет: ");
        double конфет_кг = Convert.ToDouble(Console.ReadLine());
        Console.Write("Количество кг печенья: ");
        double печенья_кг = Convert.ToDouble(Console.ReadLine());
        Console.Write("Количество кг яблок: ");
        double яблок_кг = Convert.ToDouble(Console.ReadLine());

        double стоимостьКонфет = конфет_цена * конфет_кг;
        double стоимостьПеченья = печенья_цена * печенья_кг;
        double стоимостьЯблок = яблок_цена * яблок_кг;
        double стоимость = стоимостьКонфет + стоимостьПеченья + стоимостьЯблок;

        Console.WriteLine($"Cтоимость всей покупки: {стоимость} рублей");



       
       
        
      }
   }              
}