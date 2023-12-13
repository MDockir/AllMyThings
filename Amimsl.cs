


namespace AllMyThings
{
   
    class Amimsl : IMyThings
    {
        int price = 70;
        string name = "Flodhest";

        public Amimsl(int price, string name) 
        {
            this.price = price;
            this.name = name;
        }
        public string GetName()
        {
            return $"Name of {GetType().Name}: {name}";
        }

        public double GetPrice()
        {
            return price;
        }
    }

}