namespace DNA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String dna1 = "ATGCGATACGCTTGA";
            String dna2 = "ATGCGATACGTGA";
            String dna3 = "ATTAATATGTACTGA";

            String dna = dna1;
            int length = dna.Length;
            Console.WriteLine("Length: " + length);

            // Find start codon:
            int start = dna.IndexOf("ATG");
            Console.WriteLine("Start: " + start);

            // Find stop codon:
            int stop = dna.IndexOf("TGA");
            Console.WriteLine("Stop: " + stop);

            if (start != -1 && stop != -1 && (start - stop) % 3 == 0)
            {
                String protein = dna.Substring(start, stop + 3);
                Console.WriteLine("Protein: " + protein);
                Console.WriteLine("Condition 1 and 2 are satisfied.");
            }
            else
            {
                Console.WriteLine("no protein");
            }
        }
    }
}