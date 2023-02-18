using System.Diagnostics;
using System.Runtime.InteropServices;

public static class Focus
{
  [DllImport("USER32.DLL")]
  public static extern bool SetForegroundWindow(IntPtr hWnd);

  private static void listProcess()
  {
    List<Process> p = new();
    foreach (Process process in Process.GetProcesses())
    {
      p.Add(process);
      Console.WriteLine(process.ProcessName);
    }
  }

  public static void SetFocus() 
  {
    try
    {
      Process process = Process.GetProcessesByName("Foto.Sort")[0];
      if (process != null)
      {
        //process.WaitForInputIdle();
        IntPtr s = process.MainWindowHandle;
        SetForegroundWindow(s);

        Console.Write("Proccess found: " + process.ToString());
      }
      //listProcess();
    }
    catch (Exception exc)
    {
      Console.WriteLine("ERROR: Application is not running!\nException: " + exc.Message);
      Console.ReadKey();
      return;
    }
  }
}
