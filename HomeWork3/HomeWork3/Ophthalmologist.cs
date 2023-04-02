
namespace HomeWork3
{
    public class Ophthalmologist : Doctor, IDoctor
    {
        public Ophthalmologist(string Name, int Age, int Experience, string Specialization) : base(Name, Age, Experience, Specialization)
        {

        }
        public override void Diagnosis(Patient patient)
        {
            Random rnd = new Random();
            int value = rnd.Next(1, 3);
            if (value == 1)
            {
             patient.OphthalmologistStatus = Patient.HealthStatus.Health; 
            }
            else
            {
                patient.OphthalmologistStatus = Patient.HealthStatus.Sick;
            }
        }

        public override void Cure(Patient patient)
        {
            if (patient.OphthalmologistStatus == Patient.HealthStatus.Sick)
            {
                patient.OphthalmologistStatus = Patient.HealthStatus.Health;
            }
        }
    }
}
  



