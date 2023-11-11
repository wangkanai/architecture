// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.

using Android.App;
using Android.Content.PM;
using Android.OS;

namespace Wangkanai.Architecture
{
	[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
	public class MainActivity : MauiAppCompatActivity
	{
	}
}
