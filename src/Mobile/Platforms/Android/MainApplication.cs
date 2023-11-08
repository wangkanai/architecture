// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.

using Android.App;
using Android.Runtime;

namespace Wangkanai.Architecture.Mobile
{
	[Application]
	public class MainApplication : MauiApplication
	{
		public MainApplication(IntPtr handle, JniHandleOwnership ownership)
			: base(handle, ownership)
		{
		}

		protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
	}
}
