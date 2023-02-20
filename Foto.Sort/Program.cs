using System.Diagnostics;
using System.Text;

const string root = @"C:\atari-monk\Image";
Console.Clear();
CloseImg();
ConsoleKeyInfo cki = new ConsoleKeyInfo();
Console.TreatControlCAsInput = true;
List<string> imgs = new();
int current = 0;
StringBuilder sb = new();
string menu;
bool useWallpaper = false;

SetMenu();

GetList();
var img = GetImgPath();
sb.AppendLine("Open");
sb.AppendLine(img);
OpenImg(img);


string GetImgPath() {
  if(imgs.Count == 0) return string.Empty;
  return imgs[current];
}

try
{
  do
  {
    sb.Insert(0, menu);
    Console.Write(sb.ToString());
    cki = Console.ReadKey();
    sb.Clear();
    Console.Clear();
    var key = cki.Key.ToString();
    if (key != "0") Console.WriteLine(key);
    HandleInput(key);
  }
  while (cki.Key != ConsoleKey.Escape);
}
catch (Exception ex)
{
  Console.WriteLine(ex);
}
finally
{
  CloseImg();
  Console.Clear();
}


void GetList()
{
  imgs.Clear();
  imgs.AddRange(Directory.GetFiles(root));
}

void SetMenu()
{
  var sb = new StringBuilder();
  sb.AppendLine("Right arrow - next foto");
  sb.AppendLine("Enter - delete foto");
  sb.AppendLine("Space - sort foto");
  sb.AppendLine("Escape - close app");
  sb.AppendLine();
  menu = sb.ToString();
}

void OpenImg(string img)
{
  if(useWallpaper) SetWallpaper(img);
  else OpenIrfan(img);
}

void OpenIrfan(string img)
{
  if(string.IsNullOrWhiteSpace(img) || File.Exists(img) == false) return; 
  var start = new ProcessStartInfo();
  start.Arguments = img + "/one" + "/fs";
  start.FileName = @"C:\Program Files\IrfanView\i_view64.exe";
  //Task.Delay(20).ContinueWith(t => Focus2.FocusProcess("Foto.Sort"));
  Process.Start(start);
  Mouse.DoMouseClick();
}

void SetWallpaper(string img)
{
  Wallpaper.SetWallpaper(img);
}

void CloseImg()
{
  Process[] workers = Process.GetProcessesByName("i_view64");
  foreach (Process worker in workers)
  {
    worker.Kill();
    worker.WaitForExit();
    worker.Dispose();
  }
}

void MoveImg(string folder)
{
  var currentPath = GetImgPath();
  if(string.IsNullOrWhiteSpace(currentPath)) return;
  var movePath = Path.Combine(root, folder, Path.GetFileName(currentPath));
  System.IO.File.Move(currentPath, movePath);
}

void NextFoto() 
{
  GetList();
  sb.AppendLine("Next");
  current++;
  CloseImg();
  if (current > imgs.Count - 1) current = 0;
  var imgPath = GetImgPath();
  OpenImg(imgPath);
  sb.AppendLine(string.IsNullOrWhiteSpace(imgPath) ? "no image" : imgPath);
}

void HandleInput(string key)
{
  switch (key)
  {
    case "RightArrow":
      NextFoto();
      break;
    case "Enter":
      sb.AppendLine("Trash");
      MoveImg("trash");
      NextFoto();
      break;
    case "Spacebar":
      sb.AppendLine("Sort");
      MoveImg("sphere");
      NextFoto();
      break;
    default:
      break;
  }
}