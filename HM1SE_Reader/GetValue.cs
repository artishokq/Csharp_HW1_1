namespace HM1SE_Reader
{
	public class GetValue
	{
        /// <summary>
        /// Проверяет корректность ввода значения k (кол-во сдвигов)
        /// и возвращает его.
        /// </summary>
        /// <returns>Возвращает значение k.</returns>
        public static void GetValueOfK(out int k)
        {
            Console.Write("Введите значение k >= 0: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out k) && k >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный ввод");
                    Console.Write("Введите значение k >= 0: ");
                }
            }
        }
    }
}