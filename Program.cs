using System;
namespace Lab_7_OOP
{
    internal abstract class Program
    {
        private protected static void Main()
        { 
            Method_batterfly batterfly = new Method_batterfly();
            Console.WriteLine("Нажмите 1, если хотите просуммировать дроби\n" +
                "Нажмите 2, если хотите произвести вычитание дробей");
            int pressed = int.Parse(Console.ReadLine());
            switch(pressed)
            {
                case 1:
                    batterfly.Sum_frac();
                    break;
                case 2:
                    batterfly.Sub_frac();
                    break;
            }
        }
    }
}