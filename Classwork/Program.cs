using System.Runtime.Remoting;

namespace Classwork
{/*Задание 1:
Создайте класс Фильм. Класс должен хранить такую
информацию:
 Название фильма
 Название киностудии
 Жанр
 Длительность
 Год выпуска
Реализуйте в классе методы и свойства, необходимые для
функционирования класса.
Добавьте в классе деструктор. Напишите код для тестирования
функциональности класса.
Напишите код для вызова деструктора.
Добавьте к первому заданию реализацию интерфейса
IDisposable. 
*/
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Film> films =
            //[
            //    new("Начало", "Warner Bros.", "Фантастика", new TimeOnly(2, 28), new DateOnly(2010, 7, 16)),
            //    new("Крёстный отец", "Paramount Pictures", "Криминал", new TimeOnly(2, 55), new DateOnly(1972, 3, 24)),
            //    new("Тёмный рыцарь", "Warner Bros.", "Боевик", new TimeOnly(2, 32), new DateOnly(2008, 7, 18)),
            //    new ("Очень странный фильм", "Студия Весёлый Банан", "Комедия", new TimeOnly(1, 23), new DateOnly(2024, 4, 1))
            //];

            //foreach (var film in films)
            //{
            //    Console.WriteLine(film);
            //}

            //films[2].Dispose();
            //try{
            //Console.WriteLine(films[2]);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Ошибка: {ex.Message}");
            //}

            //films[2] = new Film("Котик", "Кашалотик", "Сказка", new TimeOnly(2, 28), new DateOnly(2010, 7, 16));
            /////////////


            Film[] obj = new Film[10];
            for (int i = 0; i < 10; i++)
                using (obj[i] = new Film($"Фильм {i + 1}", "КиноСтудия", "Жанр", new TimeOnly(1, 30), new DateOnly(2023, 1, 1)))
                {
                Console.WriteLine($"Фильм {i + 1}: {obj[i]}");
            }
            Console.Read();
            Console.Clear();
            foreach (Film ob in obj){
                Console.WriteLine(ob);
            }
        }
    }
}
