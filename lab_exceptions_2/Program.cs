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

        foreach (string file in files)
        {
            try
            {
                //
                using (Bitmap bitmap = new Bitmap(file))
                {
                    //дзеркало по вертикалі
                    bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);

                    //нове ім'я, що збер. в currentDirectory,
                    string newFileName = Path.Combine(
                        currentDirectory,
                        Path.GetFileNameWithoutExtension(file) + "-mirrored.gif"
                    );

                    //збереження .GIF
                    bitmap.Save(newFileName, System.Drawing.Imaging.ImageFormat.Gif);

                    Console.WriteLine($"Файл збережено: {newFileName}");
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        Console.WriteLine("***");
    }
}

