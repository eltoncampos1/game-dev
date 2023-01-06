namespace Pitch
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Alarm alarm;
            String anwser = "Y";

            while (anwser != "N") 
            {
                Console.Clear();
                Console.WriteLine("Pitch Time");

                Console.Write("Inform the pitch duration: ");
                int time = Convert.ToInt32(Console.ReadLine());

                Console.Write("Inform the sound effect (1 - 500): ");
                int soundEffect = Convert.ToInt32(Console.ReadLine());
                
                alarm = new Alarm(time, soundEffect);
                alarm.Start();
                Console.WriteLine("Run the program again: S/N");
                anwser = Console.ReadLine().ToUpper();
            }
        }
    }
}



