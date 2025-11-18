namespace RestaurantSystem
{
    public class Drink : MenuItem
    {
        public int VolumeMl { get; private set; }
        public DrinkType Type { get; private set; }

        public Drink(string name, decimal price, int volumeMl, DrinkType type = DrinkType.Безалкогольний)
            : base(name, price)
        {
            VolumeMl = volumeMl;
            Type = type;
        }

        public override string GetDescription()
        {
            string alcohol = Type == DrinkType.Алкогольний ? ", з алкоголем" : "";
            return $"{Name} ({VolumeMl} мл{alcohol}) - {Price} грн";
        }
    }
}