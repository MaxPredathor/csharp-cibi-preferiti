namespace csharp_cibi_preferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cibiPreferiti = ["Pizza", "Tortellini", "Grigliata", "Cheesecake", "Carbonara", "Gamberoni"];
            Console.WriteLine($"La Classifica é lunga {cibiPreferiti.Length} elementi");
            for (int i = 0; i < cibiPreferiti.Length; i++)
            {
                Console.WriteLine($"In Posizione {i + 1} si trova {cibiPreferiti[i]} ");
            }
            Console.WriteLine($"Il mio cibo top é la {cibiPreferiti[0]}");
            Console.WriteLine($"Il mio cibo preferito ma non troppo sono i {cibiPreferiti[^1]}");

            // BONUS

            if(cibiPreferiti.Length % 2 == 0) 
            {
                Console.WriteLine($"Gli elementi nel mezzo sono: {cibiPreferiti[cibiPreferiti.Length / 2 - 1]} e {cibiPreferiti[cibiPreferiti.Length / 2]}");
            }
            else 
            {
                Console.WriteLine($"L'elemento nel mezzo é {cibiPreferiti[cibiPreferiti.Length / 2]}");
            }
        }
    }
}
