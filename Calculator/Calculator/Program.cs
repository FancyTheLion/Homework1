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

            arg1 = 10;
            arg2 = 20;

            result = arg1 + arg2;

            Console.WriteLine($"Сумма {arg1} и {arg2} равна {result}");

            WaitForExit();
        }

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