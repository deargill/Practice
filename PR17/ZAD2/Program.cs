using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\New_folder";
        Directory.CreateDirectory(path);
    }
}