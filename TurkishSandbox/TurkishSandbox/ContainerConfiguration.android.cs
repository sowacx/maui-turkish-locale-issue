using Android.Content;
using DryIoc;
using DryIoc.Microsoft.DependencyInjection;
using Splat;
using Splat.DryIoc;
using IContainer = DryIoc.IContainer;

namespace TurkishSandbox;

public static partial class ContainerConfiguration
{
    private static partial Container CreateContainer() =>
        new(r => r.WithTrackingDisposableTransients());

    private static partial void RegisterPlatformDependencies(IRegistrator registrator)
    {
        registrator.RegisterDelegate<Context?>(() => Platform.AppContext);
    }
}