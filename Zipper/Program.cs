using Zipper;

class Program
{
    static void Main(string[] args)
    {
        var filePath = "D:\\zipperTest\\1Cv8.1CD";  
        var compressor = new GZipCompressor(4096);

        var originalData = File.ReadAllBytes(filePath);
        var compressedData = compressor.Compress(originalData);

        var compressedFilePath = Path.ChangeExtension(filePath, ".gz");
        File.WriteAllBytes(compressedFilePath, compressedData);

        Console.WriteLine($"Файл {filePath} был успешно сжат и сохранен как {compressedFilePath}");
    }
}

