namespace NinjectDemo
{
	public interface IPlatform
	{
		string GetPlatformName ();
		string ContainerName { get; }
	}
}