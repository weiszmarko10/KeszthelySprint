namespace KeszthelySprint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Versenyzo> versenyzok = new();
            foreach (var sor in File.ReadAllLines("eredmenyek.txt"))
            {
                versenyzok.Add(new Versenyzo(sor));
            }
            Console.WriteLine($"{versenyzok.Count} ");

            var junior = 0;

        }
    }
}
