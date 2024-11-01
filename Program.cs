namespace Lists2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Boş bir liste oluşturalım
            List<string> kahveListesi = new List<string>();

            // Kullanıcıdan 5 kahve ismi alalım
            for (int i = 0; i < 5; i++)
            {
                Console.Write($" Kahve {i + 1} : ");
                string kahveIsmi = Console.ReadLine();
                kahveListesi.Add(kahveIsmi); // Kahve ismi ekleniyor
            }

            // Oluşturulan listeyi ekrana yazdıralım
            Console.WriteLine("\nKahve listeniz:");
            foreach (string kahve in kahveListesi)
            {
                Console.WriteLine(kahve);
            }
        }
    }
}
