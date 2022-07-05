using System;

namespace ShiftArrayValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Добро пожаловать в программу: Сдвиг значений массива!");

            Random random = new Random();
            int initialNumber = 0;
            int finitNumber = 15;
            int[] numbers = new int[finitNumber];
            int value;
            int first;
            int second;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(initialNumber, finitNumber);
            }

            Console.WriteLine("\n Массив, созданный рандомными числами функцией random numbers = ");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(" " + numbers[i] + " ");
            }

            Console.Write("\n\n Введите значение (цифру) сдвига массива на указаное вами позиций влево: ");
            value = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < value; i++)
            {
                first = numbers[0];
                numbers[0] = numbers[numbers.Length - 1];

                for (int j = 1; j < numbers.Length; j++)
                {
                    second = numbers[j];
                    numbers[j] = first;
                    first = second;
                }
            }

            Console.WriteLine("\n Массив, сдвинутый циклически на указанное пользователем " + value + " позиций влево numbers = ");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(" " + numbers[i] + " ");
            }

            Console.WriteLine("");
        }
    }
}