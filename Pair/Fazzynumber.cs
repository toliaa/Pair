using System;  // Підключення основного простору імен System для роботи з базовими класами C#

namespace Pair  // Простір імен Pair
{
    // Клас Fazzynumber для представлення нечітких чисел
    public class Fazzynumber : Pair
    {
        // Конструктор класу Fazzynumber, який викликає конструктор базового класу Pair
        public Fazzynumber(double real, double imaginary) : base(real, imaginary)
        {
        }

        // Перевизначений метод перетворення у рядок для представлення нечіткого числа
        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";  // Повертає рядок, що представляє реальну і уявну частини числа у форматі "a + bi"
        }
    }
}
