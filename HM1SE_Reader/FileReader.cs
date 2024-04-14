namespace HM1SE_Reader;
public class FileReader
{
    /// <summary>
    /// Запрашивает путь к файлу, вытаскивает текст из файла и конвертиует его
    /// в зубчатый массив и возвращает этот массив.
    /// </summary>
    /// <returns>Возвращает зубчатый массив.</returns>
    public static double[][] ConvertTextToArray()
    {

        Console.WriteLine("Введите путь к  файлу:");
        while (true)
        {
            var path = Console.ReadLine();

            double[][] array;
            string[] lines;

            try
            {
                lines = File.ReadAllLines(path);

                // Проверка на пустой файл.
                if (lines.Length == 0)
                {
                    Console.WriteLine("Передан пустой файл, повторите ввод:");
                    continue;
                }

                // Проверяет и копирует с первой строки файла
                // N(кол-во одномерных вещественных массивов)
                if (!int.TryParse(lines[0], out int numOfArrays) || numOfArrays < 1)
                {
                    Console.WriteLine("Неверно укакзан N, повторите ввод: ");
                    continue;
                }

                array = new double[numOfArrays][];

                bool formatError = false;

                for (int i = 1; i <= numOfArrays; i++)
                {
                    // Проверка формата строки.
                    if (!lines[i].EndsWith("?") ||
                    (lines[i].Contains(" ") && !lines[i].Contains("??")))
                    {
                        Console.WriteLine("Неверный формат в файле, повторите ввод:");
                        formatError = true;
                        break;
                    }

                    // Удаляет последний символ "?" и разделяем по "??".
                    var numbers = lines[i].TrimEnd('?').Split(new string[] { "??" }, StringSplitOptions.None);
                    array[i - 1] = Array.ConvertAll(numbers, double.Parse);
                }

                // Если найдена ошибка формата, возвращаемся к началу цикла while.
                if (formatError)
                {
                    continue;
                }

                Console.WriteLine("Данные успешно прочитаны");
                return array;
            }
            // Отлавливает ошибки.
            catch (ArgumentException)
            {
                Console.WriteLine("Некорректный ввод, повторите ввод: ");
            }
            catch (IOException)
            {
                Console.WriteLine("Возникла ошибка при открытии файла и записи структуры, повторите ввод: ");
            }
            catch (Exception)
            {
                Console.WriteLine("Возникла непредвиденная ошибка, повторите ввод:");
            }
        }
    }
}