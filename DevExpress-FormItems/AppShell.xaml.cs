﻿using FormItemExample.Views;

namespace FormItemExample;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("SettingsPage/EditBioPage", typeof(EditBioPage));
    }
}
