namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 3 == 0)
            { Console.Write("Fizz"); }
            if (a % 5 == 0)
            { Console.WriteLine("Buzz"); }
            else
                Console.WriteLine(a);


            //задание 2

            int b;
            int c;
            Console.WriteLine("Введите число");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите процент");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Результат:");
            Console.WriteLine((b * c) / 100);

            //задание 3

            int d;
            int e;
            int f;
            int g;
            
            Console.WriteLine("Введите  4 числа");
            d = Convert.ToInt32(Console.ReadLine());
            e = Convert.ToInt32(Console.ReadLine());
            f = Convert.ToInt32(Console.ReadLine());
            g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(d * 1000 + e * 100 + f * 10 + g);

            //вариант 2
            //string d;
            //string e;
            //string f;
            //string g;
            //string h;
            //Console.WriteLine("Введите  4 числа");
            //d = Console.ReadLine();
            //e = Console.ReadLine();
            //f = Console.ReadLine();
            //g = Console.ReadLine();
            //Console.WriteLine(Convert.ToInt32(d + e + f + g));

            int num1, num2;
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            
            if (num1 > num2)
            {
                (num1, num2) = (num2, num1);
            }

            for (int i = num1; i <= num2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}
