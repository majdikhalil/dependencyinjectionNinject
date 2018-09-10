using Ninject.Modules;
using NinjectDemo;

namespace NinjectDemo.Droid
{
	public class NinjectDemoModule : NinjectModule
	{
        public NinjectDemoModule()
        {
        }
        public override void Load()
		{
			this.Bind<IPlatform>().To<DroidPlatform>();
			this.Bind<ISettings> ().To<DroidSettings> ();
		}

	}
}