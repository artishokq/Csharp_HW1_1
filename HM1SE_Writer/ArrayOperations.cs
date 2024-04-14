using System.Text;

namespace HM1SE_Writer
{
    public class ArrayOperations
    {
        /// <summary>
        /// Создает массив А из N одномерных вещественных массивов рандомной
        /// длины и присваивает значения для каждой ячейки по формуле.
        /// </summary>
        /// <param name="n">Кол-во одномерных вещественных массивов.</param>
        /// <param name="jaggedArray">Ссылка на массив передана в метод
        /// по ссылке out.</param>
        public static void CreateArrayA(int n, out double[][] jaggedArray)
        {
            Random rnd = new Random();

            // Создаём массив из N одномерных вещественных массивов.
            jaggedArray = new double[n][];

            int currentN = 1;
            for (int i = 0; i < n; i++)
            {
                // Случайная длина от 1 до 14.
                jaggedArray[i] = new double[rnd.Next(1, 15)];

                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    // Присваиваем значение для каждой ячейки по формуле.
                    jaggedArray[i][j] = Math.Sqrt((Math.Pow(currentN, 3) + 3) / (Math.Pow(currentN, 2) + 5));
                    // Инкрементируем n для следующего элемента.
                    currentN++;
                }
            }
        }

        /// <summary>
        /// Преобразует зубчатый массив в строковое представление с
        /// указанным количеством одномерных вещественных массивов.
        /// </summary>
        /// <param name="array">Зубчатый массив</param>
        /// <param name="num">Кол-во одномерных вещественных массивов.</param>
        /// <returns>Возвращаем строковое представление состоящее из N и
        /// зубчатого массива.</returns>
        public static string ConverteToString(double[][] array, int num)
        {
            var stringBuilder = new StringBuilder();

            // Добавляем на первую строку значение N.
            stringBuilder.Append(num);
            stringBuilder.AppendLine();

            // Элементы разделены '??', за исключением последнего элемента
            // в каждом внутреннем массиве, который заканчивается '?'.
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (j < array[i].Length - 1)
                    {
                        stringBuilder.Append($"{array[i][j]:f3}??");
                    }
                    else
                    {
                        stringBuilder.Append($"{array[i][j]:f3}?");
                    }
                }
                stringBuilder.AppendLine();
            }

            // Присваиваем переменной res строковое значение.
            var res = stringBuilder.ToString();

            return res;
        }
    }
}