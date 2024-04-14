namespace HM1SE_Reader;
class Program
{
    static void Main(string[] args)
    {
        char rep;
        do
        {
            // Достает текст из файла и конвертирует его в зубчатый массив,
            // присваивает зубчатому массиву B.
            double[][] arrayB = FileReader.ConvertTextToArray();

            // Запрашивает k у пользователя и получает значение по ссылке.
            int k;
            GetValue.GetValueOfK(out k);

            // Проводит изменения в зубчатом массиве, присваивает значение
            // и получает по ссылке.
            double[][] jaggedArrayB;
            ArrayOperations.ShiftJaggedArrayByK(arrayB, k, out jaggedArrayB);

            // Выводит массив до изменени.
            Console.WriteLine("Массив до изменений: ");
            ArrayOperations.PrintArray(arrayB);

            // Выводит массив после изменений.
            Console.WriteLine("Массив после изменений: ");
            ArrayOperations.PrintArray(jaggedArrayB);

            Console.WriteLine("Хотите продолжить? если да - напишите Y");
            rep = char.Parse(Console.ReadLine());
            if (rep != 'Y')
                break;

        } while (true);
    }
}