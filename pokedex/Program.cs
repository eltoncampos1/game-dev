namespace pokedex
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();
            int asnwer = 100;
            while (asnwer != 0)
            {
                asnwer = Menu();
                if (asnwer == 1)
                {
                    pokedex.ListPokemon();
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
        static int Menu()
        {
            Console.WriteLine("Pokedex :::");
            Console.WriteLine("0 - Exit pokedex");
            Console.WriteLine("1 - Show all Pokemons");
            Console.Write("Choose your option: ");
            int asnwer = Convert.ToInt32(Console.ReadLine());

            return asnwer;
        }
    }


}