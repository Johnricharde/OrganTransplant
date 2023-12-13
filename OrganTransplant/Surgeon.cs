namespace OrganTransplant
{
    public class Surgeon
    {
        public void RemoveKidney(Patient patient)
        {
            Console.WriteLine($"Removing kidney from {patient.Name}");
            patient.NumberOfKidneys--;
            Console.WriteLine($"{patient.Name} now has {patient.NumberOfKidneys} kidneys left");
        }
        public void InsertKidney(Patient patient)
        {
            Console.WriteLine($"Inserting kidney into {patient.Name}");
            patient.NumberOfKidneys++;
            Console.WriteLine($"{patient.Name} now has {patient.NumberOfKidneys} kidneys");
        }
    }
}
