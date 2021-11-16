using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

namespace Learn.HelloMaui
{
  public partial class MainPage : ContentPage
  {
    int _count = 0;

    public MainPage()
    {
      InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
      _count++;
      CounterLabel.Text = $"Current count: {_count}";

      SemanticScreenReader.Announce(CounterLabel.Text);
    }
  }
}
