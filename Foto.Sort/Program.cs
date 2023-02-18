using System.Diagnostics;

//InterceptKeys.Start();
const string root = @"F:\atari-monk\Image";
Console.Clear();
CloseImg();
ConsoleKeyInfo cki = new ConsoleKeyInfo();
Console.TreatControlCAsInput = true;
List<string> imgs = new();
int current = 0;
GetList();
//Task.Delay(250).ContinueWith(t => Focus2.FocusProcess("Foto.Sort"));
OpenImg(GetImgPath());


string GetImgPath() {
  if(imgs.Count == 0) return string.Empty;
  return imgs[current];
}

try
{
  do
  {
    WriteMenu();
    cki = Console.ReadKey();
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
  //InterceptKeys.Stop();
}


void GetList()
{
  imgs.Clear();
  imgs.AddRange(Directory.GetFiles(@"F:\atari-monk\Image"));
}

void WriteMenu()
{
  Console.WriteLine("Right arrow - next foto");
  Console.WriteLine("Enter - delete foto");
  Console.WriteLine("Space - sort foto");
  Console.WriteLine("Escape - close app");
  Console.WriteLine();
}

void OpenImg(string img)
{
  // if(string.IsNullOrWhiteSpace(img) || File.Exists(img) == false) return; 
  // var start = new ProcessStartInfo();
  // start.Arguments = img;
  // start.FileName = @"C:\Program Files\IrfanView\i_view64.exe";
  // start.WindowStyle = ProcessWindowStyle.Minimized;
  // //start.CreateNoWindow = true;
  // //Task.Delay(250).ContinueWith(t => Focus2.FocusProcess2("Foto.Sort"));
  // Process.Start(start);
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
  Console.WriteLine("Next");
  current++;
  CloseImg();
  if (current > imgs.Count - 1) current = 0;
  var imgPath = GetImgPath();
  OpenImg(imgPath);
  Console.WriteLine(string.IsNullOrWhiteSpace(imgPath) ? "no image" : imgPath);
}

void HandleInput(string key)
{
  switch (key)
  {
    case "RightArrow":
      NextFoto();
      break;
    case "Enter":
      Console.WriteLine("Trash");
      MoveImg("trash");
      NextFoto();
      break;
    case "Spacebar":
      Console.WriteLine("Sort");
      MoveImg("sphere");
      NextFoto();
      break;
    default:
      break;
  }
}