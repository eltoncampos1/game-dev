namespace pokedex
{
    public class Pokemon
    {

        public Pokemon()
        {
            this.Name = "";
            this.PokemonDescription = "";
            this.name = "";
            this.pokemonDescription = "";
        }

        public Pokemon(String name, String description)
        {
            this.Name = name;
            this.PokemonDescription = description;
            this.name = name;
            this.pokemonDescription = description;
        }
        private String name;
        public String Name
        {
            get { return name; }
            set
            {
                this.name = value.ToUpper();
            }
        }
        private String pokemonDescription;
        public String PokemonDescription
        {
            get { return pokemonDescription; }

            set { this.pokemonDescription = value.ToUpper(); }
        }

        public void ShowPokemonData()
        {
            Console.WriteLine("Pokemon name: " + this.Name);
            Console.WriteLine("Pokemon description: " + this.PokemonDescription);
        }

        public void ShowPokemonData(Boolean formatted)
        {
            if (formatted == true)
            {
                Console.WriteLine("Pokemon name: " + this.Name + " " + this.PokemonDescription.ToLower());
            }
            else
            {
                Console.WriteLine("Pokemon name: " + this.Name);
                Console.WriteLine("Pokemon description: " + this.PokemonDescription);
            }
        }
    }
}