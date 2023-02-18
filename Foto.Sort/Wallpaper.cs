using System.Drawing;
using System.Runtime.InteropServices;
using Microsoft.Win32;

public static class Wallpaper
{
  [DllImport("user32.dll", CharSet = CharSet.Auto)]
  private static extern Int32 SystemParametersInfo(
 UInt32 action, UInt32 uParam, String vParam, UInt32 winIni);

  private static readonly UInt32 SPI_SETDESKWALLPAPER = 0x14;
  private static readonly UInt32 SPIF_UPDATEINIFILE = 0x01;
  private static readonly UInt32 SPIF_SENDWININICHANGE = 0x02;

  static public void SetWallpaper(String path)
  {
    RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
    key.SetValue(@"WallpaperStyle", 0.ToString()); // 2 is stretched
    key.SetValue(@"TileWallpaper", 0.ToString());

    SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
  }
}
