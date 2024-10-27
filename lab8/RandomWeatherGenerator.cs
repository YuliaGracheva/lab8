using System;

namespace lab8
{
    /// <summary>
    /// Класс для хранения случайной погоды
    /// </summary>
    public class RandomWeatherGenerator
    {
        /// <summary>
        /// Параметр, в которм хранится случайная погода
        /// </summary>
        private Random _randomWeather = new Random();

        /// <summary>
        /// Метод для определения случайной погоды
        /// </summary>
        /// <returns>Возвращает значение случайной погоды</returns>
        /// <exception cref="InvalidOperationException">Выбрасывается когда в классе Weather нет значений</exception>
        /// <exception cref="Exception">Выбрасывается когда случилось непредвиденное исключение</exception>
        /// <example>
        /// Пример 1. В классе Weather существуют значения. Выбирается правильное значение. (Идеальный исход).
        /// <code>
        /// RandomWeatherGenerator weatherGenerator = new RandomWeatherGenerator();
        /// try
        /// {
        ///     Weather randomWeather = weatherGenerator.GetRandomWeather();
        ///     Console.WriteLine($"Случайная погода: {randomWeather}");
        /// }
        /// catch (InvalidOperationException ex)
        /// {
        ///     Console.WriteLine($"Ошибка: {ex.Message}");
        /// }
        /// catch (Exception ex)
        /// {
        ///     Console.WriteLine($"Непредвиденная ошибка: {ex.Message}");
        /// }
        /// </code>
        /// </example>
        /// 
        /// <example>
        /// Пример 2. В классе Weather не существуют значения.Выбрасывается исключение.
        /// <code>
        /// RandomWeatherGenerator weatherGenerator = new RandomWeatherGenerator();
        /// try
        /// {
        ///     Weather randomWeather = weatherGenerator.GetRandomWeather(); // На данном этапе обрабатывается исключение InvalidOperationException
        ///     Console.WriteLine($"Случайная погода: {randomWeather}");
        /// }
        /// catch (InvalidOperationException ex)
        /// {
        ///     Console.WriteLine($"Ошибка: {ex.Message}"); // Пользователю выводит описание исключения, программа завершает свою работу
        /// }
        /// catch (Exception ex)
        /// {
        ///     Console.WriteLine($"Непредвиденная ошибка: {ex.Message}");
        /// }
        /// </code>
        /// </example>
        public Weather GetRandomWeather()
        {
            Array values = Enum.GetValues(typeof(Weather));

            if (values.Length == 0)
            {
                throw new InvalidOperationException("Класс Weather (Погода) не содержит значений");
            }
            var randomValue = values.GetValue(_randomWeather.Next(values.Length));

            if (randomValue is Weather weather)
            {
                return weather;
            }

            throw new Exception("Не удалось выбрать случайную погоду.");
        }
    }
}
