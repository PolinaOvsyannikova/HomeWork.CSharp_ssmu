public class Doctor
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Experience { get; set; }
    public string Specialization { get; set; }

    public Doctor(string name, int age, int experience, string specialization)
    {
        Name = name;
        Age = age;
        Experience = experience;
        Specialization = specialization;
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Информация о враче: имя: {Name}, возраст: {Age} стаж работы: {Experience} специализация: {Specialization}");
    }

    public virtual void Diagnosis(Patient patient)
    {
        Console.WriteLine("Направить на диагностику к врачу с конкретной специализацией");
    }
    public virtual void Cure(Patient patient)
    {
        Console.WriteLine("Направить на лечение к врачу с конкретной специализацией");
    }
}
