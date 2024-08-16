using DryIoc;

namespace TurkishSandbox;

public static partial class Composition
{
    private static partial void RegisterPlatformDependencies(IRegistrator registrator)
    {
        registrator.Register<ILocaleService, LocaleService>(Reuse.Singleton);
    }
}