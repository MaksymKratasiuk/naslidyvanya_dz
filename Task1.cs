using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naslidyvanya_dz
{
    public class Money
    {
        private int dollars { get; set; }
        private int cents{ get; set; }

        public Money(int dollars, int cents)
        {
            this.dollars = dollars;
            this.cents = cents;
        }

        public void SetDollars(int dollars)
        {
            this.dollars = dollars;
        }

        public void SetCents(int cents)
        {
            this.cents = cents;
        }

        public int GetDollars()
        {
            return this.dollars;
        }

        public int GetCents()
        {
            return this.cents;
        }


        public void Print()
        {
            Console.WriteLine($"{dollars}.{cents:00}");
        }
    }

    public class Product
    {
        private string name;
        private Money price;

        public Product(string name, Money price)
        {
            this.name = name;
            this.price = price;
        }

        public void DecreasePrice(Money amount)
        {
            int totalCents = price.GetDollars() * 100 + price.GetCents();
            int amountCents = amount.GetDollars() * 100 + amount.GetCents();
            int newTotalCents = totalCents - amountCents;
            if (newTotalCents < 0)
            {
                Console.WriteLine("Price cannot be negative.");
                return;
            }
            int newDollars = newTotalCents / 100;
            int newCents = newTotalCents % 100;
            price.SetDollars(newDollars);
            price.SetCents(newCents);
        }

        public void Print()
        {
            Console.WriteLine($"Product name : {name}, price = {price.GetDollars()}.{price.GetCents():00}");
        }
    }
    internal class Task1
    {
        public static void task1()
        {
            // Створення об'єкту класу Money
            Money money = new Money(10, 50);
            money.Print(); // Виведення значення грошей на екран

            // Створення об'єкту класу Product
            Product product = new Product("Телефон", new Money(500, 0));
            product.Print();
            product.DecreasePrice(new Money(100, 0)); // Зменшення ціни продукту
            product.Print();
            product.DecreasePrice(new Money(600, 0)); // Виведення повідомлення про помилку
            product.Print();
        }
    }
}
