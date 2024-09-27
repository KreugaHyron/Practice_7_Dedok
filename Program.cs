// See https://aka.ms/new-console-template for more information
using Practice_7_Dedok;
//1 - 3
Console.WriteLine("Task_1 with Task_3: ");
using (Film film = new Film("Inception", "Warner Bros.", "Наукова фантастика", 148, 2010))
{
    
    film.DisplayInfo();
}
Console.WriteLine();
//2 - 3
Console.WriteLine("Task_2 with Task_3: ");
var actors = new List<string> { "Актор 1", "Актор 2", "Актор 3" };
using (var performance = new Performance("Гамлет", "Національний театр", "Трагедія", new TimeSpan(2, 30, 0), actors))
{
    performance.DisplayInfo();
}
var anotherPerformance = new Performance("Ромео і Джульєтта", "Драматичний театр", "Драма", new TimeSpan(3, 0, 0), new List<string> { "Актор А", "Актор Б" });
anotherPerformance.DisplayInfo();
anotherPerformance.Dispose();
Console.WriteLine("Програма завершена.");
