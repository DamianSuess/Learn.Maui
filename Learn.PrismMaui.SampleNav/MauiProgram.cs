using Learn.PrismMaui.SampleNav.ViewModels;
using Learn.PrismMaui.SampleNav.Views;

namespace Learn.PrismMaui.SampleNav;

public static class MauiProgram
{
  public static MauiApp CreateMauiApp()
  {
    var builder = MauiApp.CreateBuilder()
      .UseMauiApp<App>()
      .UsePrism(ConfigurePrism)
      .ConfigureFonts(fonts =>
      {
        fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
        fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
      });

    return builder.Build();
  }

  public static void ConfigurePrism(PrismAppBuilder builder)
  {
    // You may also do this in-line via lambdas without the need of static methods.
    builder
      .ConfigureModuleCatalog(OnConfigureModuleCatalog)
      .RegisterTypes(OnRegisterTypes)
      .OnAppStart($"{nameof(NavigationPage)}/{nameof(MainPage)}");
  }

  private static void OnConfigureModuleCatalog(IModuleCatalog moduleCatalog)
  {
    // Add custom Module to catalog
    //  moduleCatalog.AddModule<MauiAppModule>();
    //  moduleCatalog.AddModule<MauiTestRegionsModule>();
  }

  private static void OnRegisterTypes(IContainerRegistry containerRegistry)
  {
    containerRegistry
      .RegisterForNavigation<MainPage>()                   // Auto-assign ViewModel
      .RegisterForNavigation<Page2View, Page2ViewModel>()  // Manually assign ViewModel
      .RegisterInstance(SemanticScreenReader.Default);
  }
}
