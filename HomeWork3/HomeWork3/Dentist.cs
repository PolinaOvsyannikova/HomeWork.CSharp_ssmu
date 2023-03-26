using HomeWork3;

public class Dentist : Doctor, IDoctor
{
    public Dentist(string Name, int Age, int Experience, string Specialization) : base(Name, Age, Experience, Specialization)
    {

    }
    public override void Diagnosis(Patient patient)
    {
        Random rnd = new Random();
        int value = rnd.Next(1, 3);
        if (value == 1)
        {
            patient.dentistStatus = Patient.HealthStatus.Health;
        }
        else
        {
            patient.dentistStatus = Patient.HealthStatus.Sick;
        }
    }
    public override void Cure(Patient patient)
    {
        if (patient.dentistStatus == Patient.HealthStatus.Sick)
        {
            patient.dentistStatus = Patient.HealthStatus.Health;
        }
    }
}