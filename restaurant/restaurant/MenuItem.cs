namespace RestaurantSystem
{
    public abstract class MenuItem : IMenuItem
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        protected MenuItem(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public abstract string GetDescription();
    }
}