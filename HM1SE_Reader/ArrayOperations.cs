namespace HM1SE_Reader;
public class ArrayOperations
{
    /// <summary>
    /// Сдвигает элементы массива на k вправо и передает значение
    /// нового массива по ссылке.
    /// </summary>
    /// <param name="array">Исходный массив.</param>
    /// <param name="k">Количество сдвигов.</param>
    /// <param name="jaggedArrayB">Передаем по ссылке измененный массив.</param>
    public static void ShiftJaggedArrayByK(double[][] array, int k, out double[][] jaggedArrayB)
    {
        // Инициализация выходного массива с тем же размером, что и исходный массив.
        jaggedArrayB = new double[array.Length][];

        // Цикл по всем подмассивам в исходном массиве.
        for (int i = 0; i < array.Length; i++)
        {
            // Получение размера текущего подмассива.
            int n = array[i].Length;

            // Просто копирует исходный массив, если нет необходимости в сдвиге.
            if (n == 0 || k % n == 0)
            {
                jaggedArrayB[i] = array[i];
                continue;
            }

            int shift = k % n;

            // Инициализация нового подмассива для хранения сдвинутых элементов.
            double[] shiftedSubArray = new double[n];

            // Сдвиг элементов текущего подмассива на значение shift
            // и сохранение их в новом подмассиве.
            for (int j = 0; j < n; j++)
            {
                shiftedSubArray[(j + shift) % n] = array[i][j];
            }

            // Сохранение сдвинутого подмассива в выходном массиве.
            jaggedArrayB[i] = shiftedSubArray;
        }
    }

    /// <summary>
    /// Вывод массива пользователю.
    /// </summary>
    /// <param name="array">Массив, который надо вывести.</param>
    public static void PrintArray(double[][] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                Console.Write(array[i][j] + " ");
            }
            // Переход на новую строку после вывода каждого подмассива.
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}