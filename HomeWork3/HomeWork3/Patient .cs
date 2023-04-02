public class Patient
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public HealthStatus OphthalmologistStatus { get; set; }
    public HealthStatus DentistStatus { get; set; }

    public Patient(string name, int age, string address)
    {
        Name = name;
        Age = age;
        Address = address;
        OphthalmologistStatus = HealthStatus.NonDiagnostics;
        DentistStatus = HealthStatus.NonDiagnostics;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Информация о пациенте: {Name}, {Age} лет, адрес:{Address}, диагностика у стоматолога: {DentistStatus}, диагностика у офтальмолога: {OphthalmologistStatus}");
    }
    public enum HealthStatus
    {
        NonDiagnostics,
        Sick,
        Health
    }
}