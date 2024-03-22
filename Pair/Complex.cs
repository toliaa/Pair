using System;  // Підключення основного простору імен System для роботи з базовими класами C#

namespace Pair  // Простір імен Pair
{
    // Клас Complex для представлення комплексних чисел
    public class Complex : Pair
    {
        // Конструктор класу Complex, який викликає конструктор базового класу Pair
        public Complex(double real, double imaginary) : base(real, imaginary)
        {
        }

        // Перевизначений метод перетворення у рядок для представлення комплексного числа
        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";  // Повертає рядок, що представляє реальну і уявну частини числа у форматі "a + bi"
        }
    }
}
