using System.Diagnostics;
using System.Runtime.InteropServices;

public static class Focus2
{
  [DllImport("user32.dll")]
  public static extern bool ShowWindowAsync(HandleRef hWnd, int nCmdShow);
  [DllImport("user32.dll")]
  public static extern bool SetForegroundWindow(IntPtr WindowHandle);

  public const int SW_RESTORE = 9;

  public static void FocusProcess(string procName)
  {
    Process[] objProcesses = Process.GetProcessesByName(procName);
    if (objProcesses.Length > 0)
    {
      Console.WriteLine($"Focus");
      IntPtr hWnd = IntPtr.Zero;
      hWnd = objProcesses[0].MainWindowHandle;
      ShowWindowAsync(new HandleRef(null, hWnd), 9);
      SetForegroundWindow(objProcesses[0].MainWindowHandle);
    }
  }
}
