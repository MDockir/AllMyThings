namespace AllMyThings
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<IMyThings> allThings = new List<IMyThings>();
            allThings.Add(new Car(70000, "Seat"));
            allThings.Add(new Car(80000, "Ford"));
 
            allThings.Add(new Amimsl(200, "Dog"));
            allThings.Add(new Amimsl(350, "Cat"));

            allThings.Add(new Fruit(50, "Apple"));
            allThings.Add(new Fruit(45, "Kiwi"));

            foreach (var item in allThings) 
            {
                Console.WriteLine(item.GetName() + " and the price is: " + item.GetPrice() + " euro ");            
            }
        }

        
    }
}
