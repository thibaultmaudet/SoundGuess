using Microsoft.Windows.ApplicationModel.DynamicDependency;

[assembly: WinUITestTarget(typeof(SoundGuess.App))]

namespace SoundGuess.Tests.MSTest;

[TestClass]
public class Initialize
{
    protected Initialize()
    {
    }

    [AssemblyInitialize]
    public static void AssemblyInitialize(TestContext context)
    {
        // This is required when testing MSIX apps that are framework-dependent on the Windows App SDK.
        Bootstrap.TryInitialize(0x00010001, out var _);
    }

    [AssemblyCleanup]
    public static void AssemblyCleanup()
    {
        Bootstrap.Shutdown();
    }
}
