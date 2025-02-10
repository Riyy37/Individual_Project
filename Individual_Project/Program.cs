using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            //Главный метод, который проверяет условие
            {
                InPut("Введите число, в пределах которого будут выведены все совершенные числа: ");
                //Выводим сообщение для пользователя

                // Проверяем, ввел ли пользователь корректное число
                if (!int.TryParse(Console.ReadLine(), out int limit) || limit < 0)
                //Проверка чтобы число не было отрицательным 
                {
                    Console.WriteLine("Ошибка! Введите положительное целое число."); //Вывод текста ошибки
                    Console.ReadKey();
                    //Ожидаем нажатие клавиши пользователем

                    return;
                    //Выходим из метода, если введено неверное число
                }
                try
                {
                    if (limit < 6)
                    //Проверка чтобы число было больше или равно минимальному совершенному
                    {
                        throw new InvalidOperationException("Введенное число меньше минимального совершенного (6).");
                        //Присваиваем текст ошибке
                    }

                    Console.WriteLine($"Совершенные числа в пределах {limit}: "); //Выводим сообщение о найденных совершенных числах

                    for (int i = 1; i <= limit; i++)
                    //Цикл для перебора всех чисел от 1 до limit
                    {
                        if (IsPerfectNumber(i))
                        //Проверяем, является ли число совершенным
                        {
                            Console.WriteLine(i);
                            //Выводим совершенное число
                        }
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                    //Выводим сообщение об ошибке, если число меньше 6
                }
                Console.ReadKey();
                //Ожидаем нажатия клавиши пользователем
            }

            // Метод, который проверяет, является ли число совершенным
            static bool IsPerfectNumber(int number)
            {
                if (number <= 5) return false;
                //Проверка, если число меньше или равно 5, то метод выдаст условие: ложь. Будет вызвано сообщение об ошибке
                int sum = 1;
                //Сумма делителей числа, начинаем с 1, так как 1 всегда является делителем
                int sqrt = (int)Math.Sqrt(number);
                //Вычисляем квадратный корень числа для оптимизации цикла

                // Ищем делители числа до квадратного корня
                for (int i = 2; i <= sqrt; i++)
                {
                    if (number % i == 0)
                    //Если число делится на i, значит i является делителем
                    {
                        sum += i + number / i;
                        //Добавляем i и number/i к сумме делителей
                    }
                }
                return sum == number;
                //Возвращаем true, если сумма делителей равна числу, иначе false
            }

            // Метод для вывода сообщения пользователю
            static void InPut(string message)
            {
                Console.Write(message);
            }

        }
    }
}
