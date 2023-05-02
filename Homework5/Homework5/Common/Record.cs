namespace Common
{
    public class Record
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public DateTime LastWriteTime { get; set; }
        public Record(string type, string name, DateTime lastWriteTime)
        { 
            Type = type;
            Name = name;
            LastWriteTime = lastWriteTime;
        }
    }
}