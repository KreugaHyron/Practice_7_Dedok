using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_7_Dedok
{
    public class Performance : IDisposable
    {
        
        private bool disposed = false;
        public string Title { get; set; }
        public string TheaterName { get; set; }
        public string Genre { get; set; }
        public TimeSpan Duration { get; set; }
        public List<string> Actors { get; set; }
        public Performance(string title, string theaterName, string genre, TimeSpan duration, List<string> actors)
        {
            Title = title;
            TheaterName = theaterName;
            Genre = genre;
            Duration = duration;
            Actors = actors;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Назва вистави: {Title}");
            Console.WriteLine($"Театр: {TheaterName}");
            Console.WriteLine($"Жанр: {Genre}");
            Console.WriteLine($"Тривалість: {Duration}");
            Console.WriteLine("Актори:");
            foreach (var actor in Actors)
            {
                Console.WriteLine($"- {actor}");
            }
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
                    
                    Actors.Clear();
                }
                disposed = true;
            }
        }
        ~Performance()
        {
            Dispose(false);
        }
    }
}
