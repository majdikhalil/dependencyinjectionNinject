using System;
using NinjectDemo;

namespace NinjectDemo.iOS
{
	public class ApplePlatform : IPlatform
	{
		public string GetPlatformName ()
		{
			return "iOS";
		}

		public string ContainerName {
			get {
				return "Ninject";
			}
		}
	}
}