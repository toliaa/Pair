using System;  // Підключення основного простору імен System для роботи з базовими класами C#
using Pair;  // Підключення власного простору імен Pair для класів Pair та Fazzynumber

namespace Pair  // Простір імен Pair
{
    // Абстрактний базовий клас Pair для пар чисел
    public abstract class Pair
    {
        protected double Real { get; set; }  // Реальна частина пари чисел
        protected double Imaginary { get; set; }  // Уявна частина пари чисел

        // Конструктор класу Pair
        public Pair(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        // Віртуальний метод додавання
        public virtual Pair Add(Pair other)
        {
            return new Fazzynumber(Real + other.Real, Imaginary + other.Imaginary);
        }

        // Віртуальний метод віднімання
        public virtual Pair Subtract(Pair other)
        {
            return new Fazzynumber(Real - other.Real, Imaginary - other.Imaginary);
        }

        // Віртуальний метод множення
        public virtual Pair Multiply(Pair other)
        {
            return new Fazzynumber((Real * other.Real) - (Imaginary * other.Imaginary), (Real * other.Imaginary) + (Imaginary * other.Real));
        }

        // Віртуальний метод ділення
        public virtual Pair Divide(Pair other)
        {
            double denominator = (other.Real * other.Real) + (other.Imaginary * other.Imaginary);
            if (denominator == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            double realPart = ((Real * other.Real) + (Imaginary * other.Imaginary)) / denominator;
            double imaginaryPart = ((Imaginary * other.Real) - (Real * other.Imaginary)) / denominator;
            return new Fazzynumber(realPart, imaginaryPart);
        }

        // Абстрактний метод перетворення у рядок (перевизначається в похідних класах)
        public abstract override string ToString();
    }
}
