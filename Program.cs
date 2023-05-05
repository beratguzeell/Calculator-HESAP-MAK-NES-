using System;

namespace IlkProjem

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Hesap Makinesi");
            Console.WriteLine("------------------");
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

               

                Console.Write("Birinci Sayıyı Girin: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("İkinci Sayıyı Girin: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Bir Seçeneği Yazın: ");
                Console.WriteLine("\t+ : Toplama");
                Console.WriteLine("\t- : Çıkarma");
                Console.WriteLine("\t* : Çarpma");
                Console.WriteLine("\t/ : Bölme");
                Console.Write("Bir Seçeneği Yazın: ");


                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Sonucunuz: {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Sonucunuz: {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Sonucunuz: {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Sonucunuz: {num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("Geçerli bir seçenek girmediniz.");
                        break;
                }
                Console.Write("Devam Etmek İster Misin? (E = Evet, H = Hayır): ");
            } while (Console.ReadLine().ToUpper() == "E");

            Console.WriteLine("Görüşürüz!");
            Console.ReadKey();
        }
    }
}