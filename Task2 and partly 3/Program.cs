namespace Task2_and_partly_3
{
    /*Задание 2:
Создайте класс Спектакль. Класс должен хранить такую
информацию:
 Название спектакля
 Название театра
 Жанр
 Длительность
 Список актёров
Реализуйте в классе методы и свойства, необходимые для
функционирования класса.
Класс должен реализовывать интерфейс IDisposable. Напишите
код для тестирования функциональности класса.
Напишите код для вызова метода Dispose.
    Добавьте ко второму заданию реализацию
деструктора. Напишите код для тестирования новых
возможностей.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Play> plays = new List<Play>();
            plays.Add(new Play("Название1", "Театр1", "Жанр1", new TimeOnly(1, 30), new List<string> { "Актёр1", "Актёр2" }));
            for (int i = 0; i < 10; i++)
                using (var play = new Play("Название", "Театр", "Жанр", new TimeOnly(12, 32), new List<string> {$"Актёр {i + 1}", $"Актёр {i + 2}" }))
                {
                    plays.Add(play);
                    Console.WriteLine($"{play}, {i+1}");
                }
            Console.ReadLine();
            Console.Clear();   
            try
            {
                foreach (var play in plays)
                {
                    Console.WriteLine(play);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");

            }
        }
    }
}

