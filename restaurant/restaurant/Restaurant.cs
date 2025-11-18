using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantSystem
{
    public class Restaurant
    {
        private readonly List<IMenuItem> _menu = new List<IMenuItem>();
        private readonly List<Order> _orders = new List<Order>();

        public Restaurant() => InitializeMenu();

        private void InitializeMenu()
        {
            _menu.Add(new Dish("Борщ", 120, DishCategory.Перше));
            _menu.Add(new Dish("Котлета по-київськи", 180, DishCategory.Друге));
            _menu.Add(new Dish("Картопляне пюре", 60, DishCategory.Гарнір));
            _menu.Add(new Dish("Грецький салат", 95, DishCategory.Салат));
            _menu.Add(new Dish("Тірамісу", 110, DishCategory.Десерт));
            _menu.Add(new Drink("Кава", 60, 200));
            _menu.Add(new Drink("Сік апельсиновий", 70, 250));
            _menu.Add(new Drink("Кола", 50, 330));
            _menu.Add(new Drink("Вино червоне", 150, 150, DrinkType.Алкогольний));
        }

        public void ShowMenu()
        {
            Console.WriteLine("\n--- МЕНЮ РЕСТОРАНУ ---");
            for (int i = 0; i < _menu.Count; i++)
                Console.WriteLine($"{i + 1}. {_menu[i].GetDescription()}");
            Console.WriteLine("-----------------------");
        }

        public IMenuItem FindByName(string name)
            => _menu.FirstOrDefault(m => m.Name.Contains(name, StringComparison.OrdinalIgnoreCase));

        public Order CreateOrder(int table, bool vip = false)
        {
            var order = new Order(table, vip);
            _orders.Add(order);
            return order;
        }

        public void ShowAllOrders()
        {
            Console.WriteLine("\n=== УСІ ЗАМОВЛЕННЯ ===");
            if (!_orders.Any()) Console.WriteLine("Порожньо");
            foreach (var o in _orders) o.Print();
        }
    }
}