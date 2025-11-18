using System;
using RestaurantSystem;

namespace RestaurantSystem
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var restaurant = new Restaurant();
            restaurant.ShowMenu();

            var order1 = restaurant.CreateOrder(5);
            order1.AddItem(restaurant.FindByName("Борщ"));
            order1.AddItem(restaurant.FindByName("Кава"));
            Console.WriteLine($"Сума: {order1.GetTotalPrice()} грн");
            order1.ChangeStatus(OrderStatus.InProgress);
            order1.ChangeStatus(OrderStatus.Ready);
            order1.ChangeStatus(OrderStatus.Paid);

            var vip = restaurant.CreateOrder(10, true);
            vip.AddItem(restaurant.FindByName("Котлета"));
            vip.AddItem(restaurant.FindByName("Вино"));
            vip.AddItem(restaurant.FindByName("Тірамісу"));
            Console.WriteLine($"VIP сума: {vip.GetTotalPrice()} грн");

            restaurant.ShowAllOrders();

            Console.WriteLine("\nГотово! Натисніть клавішу...");
            Console.ReadKey();
        }
    }
}