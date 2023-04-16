
using Common;
using System.Reflection.Metadata.Ecma335;

public class Program
{
    public static async Task Main()
    {
        string path = Environment.ExpandEnvironmentVariables("%appData%//Lesson12Homework.txt");

        List<Record> records = new List<Record>();
        try
        {
            var csvData = await PathAndCsvReader(path);
            string[] stringRecords = csvData.Split('\n');
            foreach (string stringRecord in stringRecords)
            {
                if (!string.IsNullOrWhiteSpace(stringRecord))
                {
                    string[] innerData = stringRecord.Split(';');
                    records.Add(new Record(innerData[0], innerData[1], DateTime.Parse(innerData[2])));
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        records.OrderBy(x => x.LastWriteTime);

        // надеюсь я правильно поняла комментарий "Проще было вывести одной таблицей в формате: Тип файла, Имя файла, Время изменения"

        foreach (var record in records)
        {
            Console.WriteLine($"{record.Type}\t{record.Name}\t{record.LastWriteTime}\n");
        }

        if (File.Exists(path))
        {
            File.Delete(path);
        }
    }
    public static async Task<string> PathAndCsvReader(string path)
    {
        using var pathReader = new StreamReader(path);
        var csvPath = await pathReader.ReadToEndAsync();
        using var csvReader = new StreamReader(csvPath);
        var csvData = await csvReader.ReadToEndAsync();
        return csvData;
    }
}


