// Copyright (c) 2014-2024 Sarin Na Wangkanai, All Rights Reserved.

using ObjCRuntime;

using UIKit;

namespace Wangkanai.Architecture
{
	public class Program
	{
		// This is the main entry point of the application.
		static void Main(string[] args)
		{
			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.
			UIApplication.Main(args, null, typeof(AppDelegate));
		}
	}
}