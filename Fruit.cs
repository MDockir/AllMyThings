namespace AllMyThings
{
    class Fruit : IMyThings
    {
        int price = 25;
        string name = "Frugt";

        public Fruit(int price, string name)
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