//Ткачук Артём
//БПИ-2311-1
//КДЗ вариант 4
namespace HM1SE_Writer;
class Program
{
    static void Main(string[] args)
    {
        char rep;
        do
        {
            // Вызываем метод для получения значение N,
            // присваиваем его переменной n.
            int n = GetValue.GetValueOfN();

            // Создает массив А из N одномерных вещественных массивов рандомной
            // длины и присваивает значения для каждой ячейки.
            ArrayOperations.CreateArrayA(n, out double[][] arrayA);

            // Присваиваем переменной result значение строкового представления
            // зубчатого массива выполненного методом.
            string result = ArrayOperations.ConverteToString(arrayA, n);

            // Создаем файл со строковым пердставлением.
            FileCreation.WriteToFile(result);

            Console.WriteLine("Хотите продолжить? если да - напишите Y");
            rep = char.Parse(Console.ReadLine());
            if (rep != 'Y')
                break;

        } while (true);
    }
}