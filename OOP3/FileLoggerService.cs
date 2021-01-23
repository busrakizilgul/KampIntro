using OOP3;
using System;
//interface içinde sadece imza metodları olur, içi dolu olamaz.

class FileLoggerService : ILoggerService
{
    public void Log()
    {
        Console.WriteLine("Dosyaya loglandı.");
    }
}