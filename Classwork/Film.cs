/*Задание 1:
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
*/using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    internal class Film : IDisposable, IEnumerable<Film>
    {
        public string Title { get; set; }
        public string Studio { get; set; }
        public string Genre { get; set; }
        public TimeOnly Duration { get; set; }
        public DateOnly ReleaseYear { get; set; }

        private bool _disposed = false;

        public Film(string title, string studio, string genre, TimeOnly duration, DateOnly releaseYear)
        {
            Title = title;
            Studio = studio;
            Genre = genre;
            Duration = duration;
            ReleaseYear = releaseYear;
        }

        ~Film()
        {
            Console.WriteLine($"Деструктор вызван для фильма: {Title}");
        }
        public void Dispose()
        {
            Console.WriteLine($"Освобождение ресурсов фильма: {Title}");
            //Dispose(true);
            Title = null;
            Studio = null;
            Genre = null;
            Duration = default;
            ReleaseYear = default;

            GC.SuppressFinalize(this);
        }

        public override string ToString()
        {
            return $"Фильм: {Title}, Киностудия: {Studio}, Жанр: {Genre}, Длительность: {Duration}, Год выпуска: {ReleaseYear.Year}";
        }

        //public void Dispose(bool disposing)
        //{
        //    if (!_disposed)
        //    {
        //        if (disposing)
        //        {
        //            Console.WriteLine($"Освобождение ресурсов для фильма: {Title}, После этого флага повторное освобождение не произойдет");
        //        }

        //        _disposed = true;
        //    }
        //}

        public IEnumerator<Film> GetEnumerator()
        {
            yield return this;
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
