namespace AllMyThings
{
    class Car : IMyThings
    {
        int price = 700000;
        string name = "Mclaren";

        public Car(int price, string name)
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