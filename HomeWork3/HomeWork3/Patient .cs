public class Patient
{
    public string name { get; set; }
    public int age { get; set; }
    public string address { get; set; }
    public HealthStatus ophthalmologistStatus { get; set; }
    public HealthStatus dentistStatus { get; set; }

    public Patient(string Name, int Age, string Address)
    {
        name = Name;
        age = Age;
        address = Address;
        ophthalmologistStatus = HealthStatus.NonDiagnostics;
        dentistStatus = HealthStatus.NonDiagnostics;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Информация о пациенте:{name}, {age} лет, адрес:{address} диагностика у стоматолога: {dentistStatus}, диагностика у офтальмолога: {ophthalmologistStatus} ");
    }
    public enum HealthStatus
    {
        NonDiagnostics,
        Sick,
        Health
    }
}