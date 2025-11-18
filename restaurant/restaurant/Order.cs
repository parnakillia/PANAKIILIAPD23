using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantSystem
{
    public class Order
    {
        private static int _nextId = 100;

        public int Id { get; private set; }
        public int TableNumber { get; private set; }
        public List<IMenuItem> Items { get; } = new List<IMenuItem>();
        public OrderStatus Status { get; private set; } = OrderStatus.New;
        public bool IsVip { get; private set; }

        public Order(int tableNumber, bool isVip = false)
        {
            Id = _nextId++;
            TableNumber = tableNumber;
            IsVip = isVip;
            Console.WriteLine($"\nСтворено замовлення №{Id} для столика {TableNumber}" + (isVip ? " [VIP]" : ""));
        }

        public void AddItem(IMenuItem item) => Items.Add(item);
        public void RemoveItem(IMenuItem item) => Items.Remove(item);

        public decimal GetTotalPrice()
        {
            var total = Items.Sum(x => x.Price);
            return IsVip ? total * 0.9m : total;
        }

        public void ChangeStatus(OrderStatus newStatus)
        {
            Status = newStatus;
            Console.WriteLine($"> Статус: {Status}");
        }

        public void Print()
        {
            var total = GetTotalPrice();
            Console.WriteLine($"\nID: {Id} | Стіл: {TableNumber} | Статус: {Status} | Сума: {total} грн" + (IsVip ? " [VIP -10%]" : ""));
            foreach (var item in Items)
                Console.WriteLine($"   • {item.GetDescription()}");
        }
    }
}