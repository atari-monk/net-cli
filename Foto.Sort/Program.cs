using System.Diagnostics;

const string Root = @"C:\atari-monk\test";
const string Sort = "sort";
const string Trash = "trash";
Console.Clear();
CloseImg();
ConsoleKeyInfo cki = new ConsoleKeyInfo();
Console.TreatControlCAsInput = true;
List<string> imgs = new();
int current = 0;
bool useWallpaper = false;

GetList();
var img = GetImgPath();
Console.WriteLine("H - help");
Console.WriteLine();
Console.WriteLine("Open");
Console.WriteLine(img);
OpenImg(img);

string GetImgPath() {
  if(imgs.Count == 0) return string.Empty;
  return imgs[current];
}

try
{
  while (cki.Key != ConsoleKey.Escape)
  {
    Console.Write("Press a key: ");
    cki = Console.ReadKey();
    Console.Clear();
    var key = cki.Key.ToString();
    Console.WriteLine(key);
    HandleInput(key);
  }
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
  imgs.AddRange(Directory.GetFiles(Root));
}

void WriteMenu()
{
  Console.WriteLine("H - help");
  Console.WriteLine("Right arrow - next foto");
  Console.WriteLine("Enter - delete foto");
  Console.WriteLine("Space - sort foto");
  Console.WriteLine("Escape - close app");
  Console.WriteLine();
}

void OpenImg(string img)
{
  if(useWallpaper) SetWallpaper(img);
  else OpenIrfan(img);
}

void OpenIrfan(string img)
{
  if(string.IsNullOrWhiteSpace(img) || File.Exists(img) == false) return;
  CloseImg();
  var start = new ProcessStartInfo();
  start.Arguments = img + "/one" + "/fs";
  start.FileName = @"C:\Program Files\IrfanView\i_view64.exe";
  Process.Start(start);
  Task.Delay(30).ContinueWith(t => Mouse.DoMouseClick());
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
  var movePath = Path.Combine(Root, folder, Path.GetFileName(currentPath));
  System.IO.File.Move(currentPath, movePath);
}

void NextFoto() 
{
  GetList();
  Console.WriteLine("Next");
  current++;
  if (current > imgs.Count - 1) current = 0;
  var imgPath = GetImgPath();
  Console.WriteLine(string.IsNullOrWhiteSpace(imgPath) ? "no image" : imgPath);
  OpenImg(imgPath);
}

void HandleInput(string key)
{
  switch (key)
  {
    case "H":
      WriteMenu();
      break;
    case "RightArrow":
      NextFoto();
      break;
    case "Enter":
      Console.WriteLine($"Trash {GetImgPath()}");
      MoveImg(Trash);
      NextFoto();
      break;
    case "Spacebar":
      Console.WriteLine($"Sort {GetImgPath()}");
      MoveImg(Sort);
      NextFoto();
      break;
    default:
      break;
  }
}