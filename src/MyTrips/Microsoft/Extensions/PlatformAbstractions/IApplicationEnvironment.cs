namespace Microsoft.Extensions.PlatformAbstractions
{
    public interface IApplicationEnvironment
    {
        string ApplicationBasePath { get; set; }
    }
}