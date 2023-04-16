using Common;
using System.IO.Compression;
using System.Text;


public class Program
{
    public static void Main()
    {
        const string _zipPath = "D://test.zip";

        const string _folderPath = "Папка";

        const string _filePath = "D:\\C#\\HomeWork.CSharp_ssmu.git\\Homework5\\Homework5\\Homework5_consoleApp1\\bin\\Debug\\net6.0\\fileInfo.csv";

        try
        {
            ExtractZip(_folderPath, _zipPath);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        var fileData = ShowDirectoryAndFile(_folderPath);

        CreateAndWriteCSVFile(_filePath, fileData);

        if (Directory.Exists(_folderPath))
        {
            Directory.Delete(_folderPath, true);
        }

        string path = Environment.ExpandEnvironmentVariables("%appData%//Lesson12Homework.txt");

        try
        {
            CreateAndWriteFile(path, _filePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    static void ExtractZip(string folderPath, string zipPath)
    {
        if (!Directory.Exists(folderPath) && File.Exists(zipPath))
        {
            Directory.CreateDirectory(folderPath);
            ZipFile.ExtractToDirectory($"{zipPath}", $"{folderPath}");
        }
        if (Directory.Exists(folderPath) && File.Exists(zipPath))
        {
            ZipFile.ExtractToDirectory($"{zipPath}", $"{folderPath}");
        }
    }
    static List<Record> ShowDirectoryAndFile(string path)
    {
        List<Record> records = new List<Record>();
        foreach (var element in Directory.GetDirectories(path))
        {
            FileInfo fileInfo = new FileInfo(element);
            records.Add(new Record("Folder", fileInfo.Name, fileInfo.LastWriteTime));
        }

        foreach (var element in Directory.GetFiles(path))
        {
            FileInfo fileInfo = new FileInfo(element);
            records.Add(new Record("File", fileInfo.Name, fileInfo.LastWriteTime));
        }
        return records;
    }
    static void CreateAndWriteCSVFile(string path, List<Record> records)
    { 
        File.Create(path).Dispose();
        var stringOfRecords = ConvertListRecordsToString(records);
        File.AppendAllText(path, stringOfRecords);
    }
    static string ConvertListRecordsToString(List<Record> record)
    {
        StringBuilder stringBuilder = new StringBuilder();
        foreach (var recordItem in record)
        {
            stringBuilder.Append(recordItem.Type);
            stringBuilder.Append(";");
            stringBuilder.Append(recordItem.Name);
            stringBuilder.Append(";");
            stringBuilder.Append(recordItem.LastWriteTime);
            stringBuilder.Append("\n");
        }
        return stringBuilder.ToString();
    }
    static public async Task CreateAndWriteFile(string path, string contents)
    {
        File.Create(path).Close();
        await using var streamWriter = new StreamWriter(path);
        await streamWriter.WriteAsync(contents);
    }
}






