using System.Diagnostics;
using Microsoft.Extensions.Configuration;

namespace PrevisaoTempoSQLite
{
    public partial class App : Application
    {
        public static string apiKey {  get; private set; }
        public App()
        {
            InitializeComponent();


            //MainPage = new AppShell();
            MainPage = new NavigationPage(new Views.MainPage());

            var configuration = new ConfigurationBuilder()
                .AddUserSecrets<App>()
                .Build();

            apiKey = configuration["API_KEY"];

        }

    }
}
