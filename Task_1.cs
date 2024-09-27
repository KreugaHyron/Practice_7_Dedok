using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_7_Dedok
{
    class Film : IDisposable
    {
        
        private string title;
        private string studio;
        private string genre;
        private int duration; 
        private int year;
        private bool disposed = false;
        public Film(string title, string studio, string genre, int duration, int year)
        {
            Title = title;
            Studio = studio;
            Genre = genre;
            Duration = duration;
            Year = year;
        }
        public string Title
        {
            get { return title; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Назва фільму не може бути порожньою.");
                title = value;
            }
        }
        public string Studio
        {
            get { return studio; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Назва кіностудії не може бути порожньою.");
                studio = value;
            }
        }
        public string Genre
        {
            get { return genre; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Жанр не може бути порожнім.");
                genre = value;
            }
        }
        public int Duration
        {
            get { return duration; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Тривалість фільму має бути більше 0.");
                duration = value;
            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Рік має бути позитивним числом.");
                year = value;
            }
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Назва: {Title}");
            Console.WriteLine($"Кіностудія: {Studio}");
            Console.WriteLine($"Жанр: {Genre}");
            Console.WriteLine($"Тривалість: {Duration} хв.");
            Console.WriteLine($"Рік: {Year}");
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Console.WriteLine($"Фільм '{Title}' звільняє керовані ресурси.");
                }
                disposed = true;
            }
        }
        ~Film()
        {
            Console.WriteLine($"Фільм '{Title}' видалено з пам'яті.");
        }
    }
}
