using DryIoc;
using DryIoc.Microsoft.DependencyInjection;
using Splat;
using Splat.DryIoc;
using IContainer = DryIoc.IContainer;

namespace TurkishSandbox;

public static partial class ContainerConfiguration
{
    private static partial Container CreateContainer() =>
        new Container(r => r
            .WithUseInterpretation()
            .WithTrackingDisposableTransients());

    private static partial void RegisterPlatformDependencies(IRegistrator registrator)
    {
        // Not required on this platform.
    }

}