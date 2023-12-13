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
        public void SurgerySurvival()
        {
            Random random = new();
            int survivalChance = random.Next(1, 100);

            if (survivalChance > 25)
                Console.WriteLine($"{Name} has survived the procedure\n");
            else
                Console.WriteLine($"{Name} did not survive the procedure\n");
        }
    }
}
