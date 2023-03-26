 public class Doctor
{
    public string name { get; set; }
    public int age { get; set; }
    public int experience { get; set; }
    public string specialization { get; set; }

    public Doctor (string Name, int Age, int Experience, string Specialization)
    {
        name = Name; 
        age = Age;
        experience = Experience;
        specialization = Specialization;
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Информация о враче: имя: {name}, возраст: {age} стаж работы: {experience} специализация: {specialization}");
    }

    public virtual void Diagnosis(Patient patient)
    {
        Console.WriteLine("Направить на диагностику к врачу с конкретной специализацией");
    }
    public  virtual void Cure (Patient patient)
    {
        Console.WriteLine("Направить на лечение к врачу с конкретной специализацией");
    }

}
