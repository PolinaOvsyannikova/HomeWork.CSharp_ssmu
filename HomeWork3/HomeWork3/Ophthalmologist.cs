

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
             patient.ophthalmologistStatus = Patient.HealthStatus.Health; 
            }
            else
            {
                patient.ophthalmologistStatus = Patient.HealthStatus.Sick;
            }
        }

        public override void Cure(Patient patient)
        {
            if (patient.ophthalmologistStatus == Patient.HealthStatus.Sick)
            {
                patient.ophthalmologistStatus = Patient.HealthStatus.Health;
            }
        }
    }
}
  



