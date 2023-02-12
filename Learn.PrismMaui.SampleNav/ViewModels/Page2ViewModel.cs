﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learn.PrismMaui.SampleNav.Views;

namespace Learn.PrismMaui.SampleNav.ViewModels
{
  public class Page2ViewModel : BindableBase
  {
    private readonly INavigationService _nav;

    public Page2ViewModel(INavigationService nav)
    {
      _nav = nav;
    }

    public string Title => "Prism Maui - Subpage View";

    public DelegateCommand CmdNavigateBack => new DelegateCommand(() =>
    {
      _nav.GoBackAsync();
    });
  }
}
