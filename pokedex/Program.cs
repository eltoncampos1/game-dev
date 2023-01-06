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
                Console.Clear();
                if (asnwer == 1)
                {
                    pokedex.ListPokemon();
                }
                if (asnwer == 2)
                {
                    pokedex.ListPokemon();
                    Console.WriteLine("Choose your pokemon by code: ");
                    int code = Convert.ToInt32(Console.ReadLine());
                    PokemonPlus pPlayer = pokedex.Pokemons[code];
                    Random r = new Random();
                    code = r.Next(0, pokedex.Pokemons.Count());
                    PokemonPlus pPc = pokedex.Pokemons[code];
                    if (pPlayer.Power >= pPc.Power)
                    {
                        Console.WriteLine("Battle Data!!!\n");
                        pPlayer.ShowPokemonDataPlus();
                        pPc.ShowPokemonDataPlus();
                        Console.WriteLine("\nYou Win!!!");
                    }
                    else
                    {
                        Console.WriteLine("Battle Data!!!\n");
                        pPlayer.ShowPokemonDataPlus();
                        pPc.ShowPokemonDataPlus();
                        Console.WriteLine("\nYou lose!!!");
                    }
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
        static int Menu()
        {
            Console.WriteLine("POKEMON BATTLE ");
            Console.WriteLine("0 - Exit pokedex");
            Console.WriteLine("1 - Show Pokedex");
            Console.WriteLine("2 - Battle");
            Console.Write("Choose your option: ");
            int asnwer = Convert.ToInt32(Console.ReadLine());

            return asnwer;
        }
    }


}