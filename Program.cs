Console.Write("Path kiriting: ");
var path = Console.ReadLine();

if (!Directory.Exists(path))
{
    Console.WriteLine("Path mavjud emas");
    return;
}

Console.WriteLine("Folder structurasi: ");
ShowTree(path, "");


void ShowTree(string path, string step)
{
    string[] directories = Directory.GetDirectories(path);
    string[] files = Directory.GetFiles(path);

    foreach(string directory in directories)
    {
        string currentDirectory = Path.GetFileName(directory);
        Console.WriteLine(step + currentDirectory);
        ShowTree(directory, step + " ");
    }

    foreach(string file in files)
    {
        string currentFile = Path.GetFileName(file);
        Console.WriteLine(step + currentFile);
    } 
}