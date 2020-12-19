using System;
namespace Lab_7_OOP
{
    internal sealed class Method_batterfly : Baseclass
    {
        private protected int integ;
        private protected int num_3;
        private protected int denum_3;
        protected override void Sum_frac()
        {
            Checking_Reading();
            num_3 = num_1 * denum_2 + num_2 * denum_1;
            denum_3 = denum_1 * denum_2;
            Checking_integer();
            MyWriteLine();
        }
        protected override void Sub_frac()
        {
            Checking_Reading();
            num_3 = num_1 * denum_2 - num_2 * denum_1;
            denum_3 = denum_1 * denum_2;
            Checking_integer();
            MyWriteLine();
        }
        private protected void Checking_Reading()
        {
            Console.WriteLine("Введите числитель первой дроби");
            while (!int.TryParse(Console.ReadLine(), out num_1))
            {
                Console.WriteLine("Неверный формат входных данных");
            }
            Console.WriteLine("Введите числитель второй дроби");
            while (!int.TryParse(Console.ReadLine(), out num_2))
            {
                Console.WriteLine("Неверный формат входных данных");
            }
            Console.WriteLine("Введите знаменатель первой дроби");
            while (!int.TryParse(Console.ReadLine(), out denum_1) && denum_1 == 0)
            {
                Console.WriteLine("Неверный формат входных данных");
            }
            Console.WriteLine("Введите знаменатель второй дроби");
            while (!int.TryParse(Console.ReadLine(), out denum_2) && denum_2 == 0)
            {
                Console.WriteLine("Неверный формат входных данных");
            }
        }
        private protected void Checking_integer()
        {
            double check = (double)num_3 / denum_3;
            if (Math.Abs(check) >= 1)
            {
                integ = num_3 / denum_3;
                if (Math.Abs(num_3) % Math.Abs(denum_3) != 0)
                {
                    num_3 = num_3 - integ * denum_3;
                }
            }
        }
        private protected void MyWriteLine()
        {
            Console.WriteLine("Результаты:");
            if (integ != 0)
            {
                Console.WriteLine($"Целая часть:{integ}");
                Console.WriteLine($"Числитель:{num_3}");
                Console.WriteLine($"Знаменатель:{denum_3}");
            }
            else
            {
                Console.WriteLine($"Числитель:{num_3}");
                Console.WriteLine($"Знаменатель:{denum_3}");
            }
        }
    }
}