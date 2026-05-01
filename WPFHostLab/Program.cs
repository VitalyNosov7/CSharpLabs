using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace WPFHostLab
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            // создаем хост приложения
            var host = Host.CreateDefaultBuilder()
                // внедряем сервисы
                .ConfigureServices(services =>
                {
                    services.AddSingleton<App>();
                    services.AddSingleton<MainWindow>();
                    // добавляем сервис IDateService
                    services.AddTransient<IDateService, RuDateService>();
                })
                .Build();
            // получаем сервис - объект класса App
            var app = host.Services.GetService<App>();
            // запускаем приложения
            app?.Run();
        }
    }

    public interface IDateService
    {
        string FormatedDate { get; }
    }
    public class RuDateService : IDateService
    {
        public string FormatedDate => $"Сегодня: {DateTime.Now.ToString("dd.MM.yyyy")}";
    }
    public class EnDateService : IDateService
    {
        public string FormatedDate => $"Today: {DateTime.Now.ToString("MM.dd.yyyy")}";
    }
}
