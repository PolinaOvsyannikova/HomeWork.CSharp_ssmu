using HomeWork3;

public class Program
{
    public static void Main()
    {
        List<Patient> Patients = new List<Patient>();
        List<IDoctor> Doctors = new List<IDoctor>();

        Doctors.Add(new Dentist("Виктор", 40, 12, "Стоматолог"));
        Doctors.Add(new Ophthalmologist("Ольга", 31, 4, "Офтальмолог"));
        Patients.Add(new Patient("Анна", 20, "Котовского 15"));
        Patients.Add(new Patient("Кирилл", 30, "Нахимова 34, кв 45"));
        Patients.Add(new Patient("Марина", 26, "Красноармейская 161, кв 20"));

        //программа выводит информацию о всех пациентах больницы до диагностики, после диагностики и после лечения
        Console.WriteLine("Информация о пациентах до диагностики и лечения:");
        Console.WriteLine();
        foreach (Patient pat in Patients)
        {
            pat.DisplayInfo();
        }

        Console.WriteLine();
        Console.WriteLine("Результат диагностики:");
        Console.WriteLine();

        foreach (Patient patient in Patients)
        { 
            foreach (IDoctor doctor in Doctors)
            {
                doctor.Diagnosis(patient);
            } 
        }

        foreach (Patient pat in Patients)
        {
            pat.DisplayInfo();
        }

        foreach (Patient patient in Patients)
        {
            foreach (IDoctor doctor in Doctors)
            {
                doctor.Cure(patient);
            }
        }
        Console.WriteLine();
        Console.WriteLine("Результат лечения:");
        Console.WriteLine();
        foreach (Patient pat in Patients)
        {
            pat.DisplayInfo();
        }

    }

}
