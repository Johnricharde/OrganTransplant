namespace OrganTransplant
{
    public class Patient
    {
        public string Name { get; set; }
        public int NumberOfKidneys { get; set; }

        public Patient(string name, int numberOfKidneys)
        {
            Name = name;
            NumberOfKidneys = numberOfKidneys;
        }
    }
}
