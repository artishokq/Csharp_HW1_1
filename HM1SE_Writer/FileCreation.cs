namespace HM1SE_Writer;
public class FileCreation
{
    /// <summary>
    /// Создаём файл в котором будет храниться строковое представление
    /// зубчатого массива и N (кол-во одномерных вещественных массивов).
    /// </summary>
    /// <param name="data">Строковое представление.</param>
    public static void WriteToFile(string data)
    {
        Console.Write("Введите название файла: ");
        while (true)
        {
            // Имя файла.
            var path = Console.ReadLine();

            // Недопустимые символы в названии файла.
            char[] invalidChars = { '/', '\\', '*', ':', '?', '|', '"', '\'', '<', '>', (char)27, (char)0 };
            bool containsInvalidChars = false;

            // Поиск недопустимых символов.
            foreach (char c in invalidChars)
            {
                if (path.Contains(c))
                {
                    containsInvalidChars = true;
                    break;
                }
            }

            // Проверка на недопустимые символы.
            if (containsInvalidChars)
            {
                Console.WriteLine("Имя файла содержит недопустимые символы, повторите ввод.");
                continue;
            }

            // Записывает данные в файл.
            try
            {
                File.WriteAllText(path, data);
                Console.WriteLine("Данные записаны");
                break;
            }
            // Отлавливает ошибки при записи данных в файл.
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