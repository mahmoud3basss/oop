namespace oop
{
    class Player
    {
        //Define properties
        public string Name;
        public double Health;
        public double Exp;
        //constructor
        public Player(string name, double health, double exp)
        { 
            Name = name;
            Health = health;    
            Exp = exp;
        }
    }
    class Program
    {
        public static void Main()

        {
            Player cr7 = new Player("PlayerOne", 100.0, 2000.0);

            Player messi = new Player("PlayerTwo", 80.0, 1500.0);

            Console.WriteLine($"cr7: {cr7.Name}, Health: {cr7.Health}, Exp: {cr7.Exp}");

            Console.WriteLine($"messi: {messi.Name}, Health: {messi.Health}, Exp: {messi.Exp}");

            
            cr7.Name = "NewPlayerOne";

            
            Console.WriteLine($"Updated Player 1 Name: {cr7.Name}");
            Console.WriteLine("Hello, World!");
        }
    } 
}
