namespace OrganTransplant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var DoctorBob = new Surgeon();
            var Kåre = new Patient("Kåre", 2);
            var Bernt = new Patient("Bernt", 0);

            Console.WriteLine("Surgery begins...\n");

            // Remove one kidney from Kåre
            DoctorBob.RemoveKidney(Kåre);
            Kåre.SurgerySurvival();

            // Insert one kidney into Bernt
            DoctorBob.InsertKidney(Bernt);
            Bernt.SurgerySurvival();
        }
    }
}
