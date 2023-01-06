namespace pokedex
{
    public class Pokedex
    {
        public Pokedex()
        {
            this.Startlist();
        }
        private List<Pokemon> pokemons;
        public List<Pokemon> Pokemons
        {
            get { return this.pokemons; }
        }


        private void Startlist()
        {
            this.pokemons = new List<Pokemon>();
            for (int i = 0; i <= 10; i++)
            {
                Pokemon p = new Pokemon("Bubassaur-" + i, "Bubasaurl is green");
                this.pokemons.Add(p);
            }
        }

        public void ListPokemon()
        {
            for (int i = 0; i < this.Pokemons.Count; i++)
            {
                this.Pokemons[i].ShowPokemonData();
            }
        }
    }
}