void WriteMenu() {
  Console.WriteLine("Right arrow - next foto");
  Console.WriteLine("Enter - delete foto");
  Console.WriteLine("Space - sort foto");
  Console.WriteLine("Escape - close app");
  Console.WriteLine();
}

ConsoleKeyInfo cki = new ConsoleKeyInfo();
Console.TreatControlCAsInput = true;

do
{
  Console.Clear();
  WriteMenu();
  Console.WriteLine(cki.Key.ToString());
  cki = Console.ReadKey();
}
while (cki.Key != ConsoleKey.Escape);