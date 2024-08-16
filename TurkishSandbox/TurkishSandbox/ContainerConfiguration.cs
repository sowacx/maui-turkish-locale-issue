using DryIoc;
using DryIoc.Microsoft.DependencyInjection;
using Splat;
using Splat.DryIoc;
using IContainer = DryIoc.IContainer;

namespace TurkishSandbox;

public static partial class ContainerConfiguration
{
    public static DryIocServiceProviderFactory Setup()
    {
        var container = CreateContainer()
            .WithDependencyInjectionAdapter();
        RegisterDependencies(container);

        Locator.SetLocator(new DryIocDependencyResolver(container));
        Locator.CurrentMutable.InitializeSplat();

        return new DryIocServiceProviderFactory(container);
    }

    private static void RegisterDependencies(IContainer container)
    {
        RegisterPlatformDependencies(container);
    }

    private static partial Container CreateContainer();
    private static partial void RegisterPlatformDependencies(IRegistrator registrator);

}