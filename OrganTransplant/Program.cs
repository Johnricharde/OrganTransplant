namespace OrganTransplant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var DoctorBob = new Surgeon();
            var Kåre = new Patient("Kåre", 2);
            var Bernt = new Patient("Bernt", 0);

            Console.WriteLine("Surgery begins...");

            // Remove one kidney from Kåre
            DoctorBob.RemoveKidney(Kåre);

            // Insert one kidney into Bernt
            DoctorBob.InsertKidney(Bernt);
        }
    }
}
