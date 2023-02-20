using System.Runtime.InteropServices;

public static class NativeMethods
{
  [DllImport("user32.dll", EntryPoint = "BlockInput")]
  [return: MarshalAs(UnmanagedType.Bool)]
  public static extern bool BlockInput([MarshalAs(UnmanagedType.Bool)] bool fBlockIt);
}