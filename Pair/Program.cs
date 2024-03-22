using Pair;  // Підключення простору імен для класів Pair, Fazzynumber і Complex
using System;

namespace Pair  // Простір імен для класу Program
{
    // Головний клас програми
    class Program
    {
        // Головний метод програми
        static void Main()
        {
            // Створення об'єктів класів Fazzynumber і Complex
            Fazzynumber fazzynumber1 = new Fazzynumber(3, 2);  // Створення нечіткого числа з реальною частиною 3 і уявною частиною 2
            Fazzynumber fazzynumber2 = new Fazzynumber(1, 4);  // Створення нечіткого числа з реальною частиною 1 і уявною частиною 4

            Complex complex1 = new Complex(5, 6);  // Створення комплексного числа з реальною частиною 5 і уявною частиною 6
            Complex complex2 = new Complex(2, 3);  // Створення комплексного числа з реальною частиною 2 і уявною частиною 3

            // Демонстрація арифметичних операцій
            Console.WriteLine($"Fazzynumber1: {fazzynumber1}");  // Виведення на консоль значення нечіткого числа fazzynumber1
            Console.WriteLine($"Fazzynumber2: {fazzynumber2}");  // Виведення на консоль значення нечіткого числа fazzynumber2
            Console.WriteLine($"Complex1: {complex1}");  // Виведення на консоль значення комплексного числа complex1
            Console.WriteLine($"Complex2: {complex2}");  // Виведення на консоль значення комплексного числа complex2

            Console.WriteLine("\nAddition:");  // Виведення на консоль рядка для позначення додавання
            Pair resultAdd = fazzynumber1.Add(fazzynumber2);  // Виклик методу додавання для нечітких чисел
            Console.WriteLine($"Fazzynumber1 + Fazzynumber2 = {resultAdd}");  // Виведення на консоль результату додавання

            Console.WriteLine("\nSubtraction:");  // Виведення на консоль рядка для позначення віднімання
            Pair resultSubtract = fazzynumber1.Subtract(fazzynumber2);  // Виклик методу віднімання для нечітких чисел
            Console.WriteLine($"Fazzynumber1 - Fazzynumber2 = {resultSubtract}");  // Виведення на консоль результату віднімання

            Console.WriteLine("\nMultiplication:");  // Виведення на консоль рядка для позначення множення
            Pair resultMultiply = complex1.Multiply(complex2);  // Виклик методу множення для комплексних чисел
            Console.WriteLine($"Complex1 * Complex2 = {resultMultiply}");  // Виведення на консоль результату множення

            Console.WriteLine("\nDivision:");  // Виведення на консоль рядка для позначення ділення
            try
            {
                Pair resultDivide = complex1.Divide(complex2);  // Виклик методу ділення для комплексних чисел
                Console.WriteLine($"Complex1 / Complex2 = {resultDivide}");  // Виведення на консоль результату ділення
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");  // Виведення на консоль повідомлення про помилку ділення на нуль
            }

            Console.ReadKey();  // Очікування натискання користувачем будь-якої клавіші
        }
    }
}
