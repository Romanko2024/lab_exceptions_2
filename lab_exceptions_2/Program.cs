using System.Drawing;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        //список файлів у поточній папці
        string currentDirectory = Directory.GetCurrentDirectory();
        string[] files = Directory.GetFiles(currentDirectory);

        //регулярний вираз перевірки графічних розширень
        Regex imageExtensions = new Regex(@"(bmp|gif|tiff?|jpe?g|png)$", RegexOptions.IgnoreCase);

        
    }
}

