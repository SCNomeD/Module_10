using System;

namespace Module_10_Task1_2
{
    class MyMath : ISum
    {
        readonly ILogger log;
        readonly string numbers;

        public MyMath(ILogger logger, string numbers)
        {
            log = logger;
            log.Event("Калькулятор начал вычисление.");
            this.numbers = numbers;
        }

        public int Sum(int number1 = 0, int number2 = 0)
        {
            bool blank = false;
            try
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == ' ')
                    {
                        int a = 0;
                        string str = "";
                        while (a != i)
                        {
                            str += numbers[a];
                            a++;
                        }
                        number1 = Convert.ToInt32(str);
                        str = "";
                        while (a < numbers.Length)
                        {
                            str += numbers[a];
                            a++;
                        }
                        number2 = Convert.ToInt32(str);
                        blank = true;
                        break;
                    }
                }

                if (!blank) throw new Exception();

                log.Event("Калькулятор принял исходные данные.");
                return number1 + number2;
            }
            catch
            {
                log.Error("Произошла ошибка! Проверьте введенные исходные данные.");
                return 0;
            }
        }
    }
}
