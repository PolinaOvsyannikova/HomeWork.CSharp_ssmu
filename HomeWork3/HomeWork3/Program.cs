using HomeWork3;

public class Program
{
    public static void Main()
    {
        var patients = new List<Patient>
        {
           new Patient("Анна", 20, "Котовского 15"),
           new Patient("Кирилл", 30, "Нахимова 34, кв 45"),
           new Patient("Марина", 26, "Красноармейская 161, кв 20")
        };

        var doctors = new List<IDoctor>
        {
            new Dentist("Виктор", 40, 12, "Стоматолог"),
            new Ophthalmologist("Ольга", 31, 4, "Офтальмолог")
        };

        //программа выводит информацию о всех пациентах больницы до диагностики, после диагностики и после лечения

        Console.WriteLine("Информация о пациентах до диагностики и лечения:\n");

        foreach (Patient pat in patients)
        {
            pat.DisplayInfo();
        }

        Console.WriteLine("\nРезультат диагностики:\n");

        foreach (Patient patient in patients)
        {
            foreach (IDoctor doctor in doctors)
            {
                doctor.Diagnosis(patient);
            }
        }

        foreach (Patient patient in patients)
        {
            patient.DisplayInfo();
        }

        foreach (Patient patient in patients)
        {
            foreach (IDoctor doctor in doctors)
            {
                doctor.Cure(patient);
            }
        }

        Console.WriteLine("\nРезультат лечения:\n");

        foreach (Patient patient in patients)
        {
            patient.DisplayInfo();
        }
    }
}
