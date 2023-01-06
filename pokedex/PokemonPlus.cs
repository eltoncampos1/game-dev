namespace pokedex
{
    public class PokemonPlus : Pokemon
    {
        public PokemonPlus() : base()
        {
            this.Power = 0;
        }

        public PokemonPlus(String name, String description, int power) : base(name, description)
        {
            this.Power = power;
        }
        public int Power { get; set; }

        public void ShowPokemonDataPlus()
        {
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Description: " + this.PokemonDescription);
            Console.WriteLine("Power: " + this.Power);
        }
    }
}