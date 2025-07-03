using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_and_partly_3
{    /*Задание 2:
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
    internal class Play : IDisposable, IEnumerable<Play>
    {
        public string? Title { get; set; }
        public string? Theater { get; set; }
        public string? Genre { get; set; }
        public TimeOnly? Duration { get; set; }
        public List<string> Actors { get; set; }

        private bool _disposed = false;

        public Play(string title, string theater, string genre, TimeOnly duration, List<string> actors)
        {
            Title = title;
            Theater = theater;
            Genre = genre;
            Duration = duration;
            Actors = actors;
        }

        ~Play() 
        {
            Console.WriteLine("Дестуктора финалка");

            Dispose(false);
        }

        public void Dispose()
        {
            Console.WriteLine("Бльоп");
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            //эээксперименты!
            if (!_disposed)
            {
                if (disposing)
                {
                    Console.WriteLine($"Мама, удалился!");
                    Actors.Clear();
                }
                Title = null;
                Theater = null;
                Genre = null;
                Duration = default;

                _disposed = true;
            }
        }

        public override string ToString()
        {
            return $"{Title} в {Theater}, Жанр: {Genre}, Длительность: {Duration}, Актеры: {string.Join(", ", Actors)}";
        }

        public IEnumerator<Play> GetEnumerator()
        {
            yield return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
