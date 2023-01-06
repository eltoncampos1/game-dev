namespace pokedex
{
    public class Pokedex
    {
        public Pokedex()
        {
            this.Startlist();
        }
        private List<PokemonPlus> pokemons;
        public List<PokemonPlus> Pokemons
        {
            get { return this.pokemons; }
        }


        private void Startlist()
        {
            this.pokemons = new List<PokemonPlus>();
            for (int i = 0; i <= 10; i++)
            {
                Random r = new Random();
                int power = r.Next(0, 500);
                PokemonPlus p = new PokemonPlus("Bubassaur-" + i, "Bubasaurl is green", power);
                this.pokemons.Add(p);
            }
        }

        public void ListPokemon()
        {
            for (int i = 0; i < this.Pokemons.Count; i++)
            {
                Console.WriteLine("Pokemon code: ", +i);
                this.Pokemons[i].ShowPokemonData();
            }
        }
    }
}