using Learn.PrismMaui.Basic.Views;

namespace Learn.PrismMaui.Basic
{
  internal static class PrismStartup
  {
    public static void Configure(PrismAppBuilder builder)
    {
      builder.RegisterTypes(RegisterTypes)
             .OnAppStart($"{nameof(NavigationPage)}/{nameof(MainPage)}");
    }

    private static void RegisterTypes(IContainerRegistry containerRegistry)
    {
      containerRegistry.RegisterForNavigation<MainPage>()
                       .RegisterInstance(SemanticScreenReader.Default);
    }
  }
}
