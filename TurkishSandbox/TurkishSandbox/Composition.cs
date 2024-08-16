using DryIoc;

namespace TurkishSandbox;

public static partial class Composition
{
    private static partial void RegisterPlatformDependencies(IRegistrator registrator);
    
    public static void Configure(IRegistrator registrator)
    {
        RegisterPlatformDependencies(registrator);
    }
}