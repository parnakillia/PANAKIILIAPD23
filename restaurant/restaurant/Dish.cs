namespace RestaurantSystem
{
    public class Dish : MenuItem
    {
        public DishCategory Category { get; private set; }

        public Dish(string name, decimal price, DishCategory category)
            : base(name, price)
        {
            Category = category;
        }

        public override string GetDescription()
            => $"{Name} ({Category}) - {Price} грн";
    }
}