namespace Lesson2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double sum = a + b;
            double difference = a - b;
            double product = a * b;
            double quotient = a / b;

            Console.WriteLine();
            Console.WriteLine("Результаты:");
            Console.WriteLine("Сумма: {0}", sum);
            Console.WriteLine("Разность: {0}", difference);
            Console.WriteLine("Произведение: {0}", product);
            Console.WriteLine("Частное: {0}", quotient);
        }
    }
}
