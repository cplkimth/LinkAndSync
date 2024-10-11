using System.Runtime.InteropServices;

namespace LinkAndSync.Gui;

public class Linker
{
    #region singleton
    private static readonly Lazy<Linker> _instance = new(() => new Linker());

    public static Linker Instance => _instance.Value;

    private Linker()
    {
    }
    #endregion

    [DllImport("Kernel32.dll", CharSet = CharSet.Unicode)]
    private static extern bool CreateHardLink(
        string lpFileName,
        string lpExistingFileName,
        IntPtr lpSecurityAttributes
    );

    public string Create(string linkPath, string sourcePath)
    {
        var created = CreateHardLink(linkPath, sourcePath, IntPtr.Zero);
        return created ? linkPath : string.Empty;
    }
}