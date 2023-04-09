
using Common;

string path = Environment.ExpandEnvironmentVariables("%appData%//Lesson12Homework.txt");
using var pathReader = new StreamReader(path);

var csvPath = pathReader.ReadToEnd();

using var csvReader = new StreamReader(csvPath);
var csvData = csvReader.ReadToEnd();

List<Record> records = new List<Record>();

try
{
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
catch
{
    Console.WriteLine("Файл повреждён");
}

records.OrderBy(x=>x.LastWriteTime);

foreach(var record in records)
{
    Console.WriteLine($"Тип файла - {record.Type}");
    Console.WriteLine($"Имя файла - {record.Name}");
    Console.WriteLine($"Время последнего изменения файла - {record.LastWriteTime}");
    Console.WriteLine();
}