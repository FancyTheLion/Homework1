namespace Calculator
{
    public class Program
    {
        /// <summary>
        /// Кнопка, которую надо нажать для выхода из программы
        /// </summary>
        private const ConsoleKey ExitKey = ConsoleKey.Q;

        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            double arg1;
            double arg2;
            double result;

            arg1 = EnterNumber("делимое");
            arg2 = EnterNumber("делитель");

            result = arg1 / arg2;

            Console.WriteLine($"Частное {arg1} и {arg2} равно {result}");

            WaitForExit();
        }

        /// <summary>
        /// Ввод числа с клавиатуры
        /// </summary>
        /// <returns>Введённое число</returns>
        public static double EnterNumber(string numberName)
        {
            // Здесь мы пытаемся что-то сделать
            Console.WriteLine($"Введите {numberName}:");

            while (true)
            {
                string enteredString = Console.ReadLine();

                double result;

                bool isSuccess = double.TryParse(enteredString, out result);

                if (isSuccess)
                {
                    return result;
                }

                Console.WriteLine("Вы ввели не число, повторите ввод!");
            }
        }

        // Закоменчено по львиному желанию в целях развития.
        ///// <summary>
        ///// Ввод числа с клавиатуры
        ///// </summary>
        ///// <returns>Введённое число</returns>
        //public static double EnterNumber(string numberName)
        //{
        //    try
        //    {
        //        // Здесь мы пытаемся что-то сделать
        //        Console.WriteLine($"Введите {numberName}:");

        //        string enteredString = Console.ReadLine();

        //        double number = double.Parse(enteredString);

        //        return number;
        //    }
        //    catch (Exception ex)
        //    {
        //        // Этот код вызовется, когда что-то пойдёт не так
        //        Console.WriteLine($"Произошла ошибка: {ex.Message}");
        //        WaitForExit();

        //        return 0; // Этот 0 никогда не вернётся, программа умрёт в методе WaitForExit()
        //    }
        //}

        /// <summary>
        /// Метод ждёт разрешения от пользователя и завершает программу
        /// </summary>
        public static void WaitForExit()
        {
            Console.WriteLine($"Нажмите { ExitKey } для завершения работы");

            // Нужно бесконечно читать с клавиатуры символы, если попался Q - завершать работу
            while(true)
            {
                var key = Console.ReadKey();

                // Если Q - то выполнить то, что в теле IF, т.е. выход из программы
                if (key.Key == ExitKey)
                {
                    Environment.Exit(0); // 0 означает "программа завершилась без ошибок"
                }
            }
        }
    }
}