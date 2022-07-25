using System;

namespace Module_10_Task1_2
{
    class Program
    {
        static void Main()
        {
            Logger logger = new Logger();

            Console.WriteLine("Для нахождения суммы двух чисел введите их через пробел.");
            Console.Write("Ввод: ");
            var numbers = Console.ReadLine();
            
            var math = new MyMath(logger, numbers);
            
            Console.WriteLine("Сумма: {0}", math.Sum());

            Console.ReadLine();
        }
    }
}
