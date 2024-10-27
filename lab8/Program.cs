using lab8;
namespace lab8
{
    /// <summary>
    /// Класс для работы с классами и методами
    /// </summary>
    class Program
    {
        /// <summary>
        /// Основной метод, который будет выводить пользователю на экран название случайной погоды из класса Weather
        /// </summary>
        /// <param name="args">Массив строк, содержащий аргументы командной строки</param>
        static void Main(string[] args)
        {
            RandomWeatherGenerator weatherGenerator = new RandomWeatherGenerator();

            try
            {
                Weather randomWeather = weatherGenerator.GetRandomWeather();
                Console.WriteLine($"Случайная погода: {randomWeather}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Непредвиденная ошибка: {ex.Message}");
            }
        }
    }
}