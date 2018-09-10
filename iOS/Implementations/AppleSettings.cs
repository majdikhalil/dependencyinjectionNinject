using NinjectDemo;

namespace NinjectDemo.iOS
{
	public class AppleSettings : ISettings
	{
		public string UserName {
			get {
				return "majdi";
			}
		}
		public string Password {
			get {
				return "****";
			}
		}
	}
}