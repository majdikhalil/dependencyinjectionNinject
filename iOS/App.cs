using Ninject;

namespace NinjectDemo.iOS
{
	public static class App
	{
		public static StandardKernel Container { get; set; }

		public static void Initialize()
		{
			var kernel = new StandardKernel(new NinjectDemoModule());			
			
			App.Container = kernel;
		}
	}
}