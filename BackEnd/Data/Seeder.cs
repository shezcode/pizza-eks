namespace PizzeriaApi.Data
{
    public static class Seeder
    {
        // Demo seed only. Runs once, when the Pizzas table is empty.
        // The original car app used AutoFixture to generate random rows; here the
        // rows are written by hand so the pizza data reads sensibly.
        public static void Seed(this PizzeriaContext context)
        {
            if (context.Pizzas is null || context.Pizzas.Any())
            {
                return;
            }

            context.Pizzas.AddRange(
                new Pizza { Name = "Margherita", Description = "Tomato, mozzarella, basil", Size = PizzaSize.Medium, Price = 8.50m, Vegetarian = true },
                new Pizza { Name = "Pepperoni", Description = "Tomato, mozzarella, pepperoni", Size = PizzaSize.Large, Price = 11.00m, Vegetarian = false },
                new Pizza { Name = "Quattro Formaggi", Description = "Four cheese blend", Size = PizzaSize.Medium, Price = 10.50m, Vegetarian = true },
                new Pizza { Name = "Prosciutto e Funghi", Description = "Ham and mushroom", Size = PizzaSize.Large, Price = 12.00m, Vegetarian = false },
                new Pizza { Name = "Marinara", Description = "Tomato, garlic, oregano", Size = PizzaSize.Small, Price = 6.50m, Vegetarian = true }
            );

            context.SaveChanges();
        }
    }
}
