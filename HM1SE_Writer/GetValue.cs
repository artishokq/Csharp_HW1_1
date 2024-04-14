namespace HM1SE_Writer
{
    public class GetValue
    {
        /// <summary>
        /// Проверяет корректность ввода значения N (кол-во одномерных
        /// вещественных массивов) и возвращает его.
        /// </summary>
        /// <returns>Возвращает значение N.</returns>
        public static int GetValueOfN()
        {
            Console.Write("Введите значение N (1 <= N < 21): ");
            int num;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out num) && num >= 1 && num < 21)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный ввод");
                    Console.Write("Введите значение N (1 <= N < 21): ");
                }
            }

            return num;
        }
    }
}