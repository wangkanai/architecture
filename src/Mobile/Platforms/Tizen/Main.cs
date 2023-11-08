// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.

using System;

using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace Wangkanai.Architecture.Mobile
{
	internal class Program : MauiApplication
	{
		protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

		static void Main(string[] args)
		{
			var app = new Program();
			app.Run(args);
		}
	}
}
