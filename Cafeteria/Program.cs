using System.Globalization;
using Cafeteria.Forms;

namespace Cafeteria;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ConfigurarCultura();
        ApplicationConfiguration.Initialize();

        using (var splash = new FormSplash())
        {
            if (splash.ShowDialog() != DialogResult.OK)
                return;
        }

        Application.Run(new FormMenu());
    }

    private static void ConfigurarCultura()
    {
        var cultura = new CultureInfo("pt-BR");
        CultureInfo.DefaultThreadCurrentCulture = cultura;
        CultureInfo.DefaultThreadCurrentUICulture = cultura;
        Thread.CurrentThread.CurrentCulture = cultura;
        Thread.CurrentThread.CurrentUICulture = cultura;
    }
}
