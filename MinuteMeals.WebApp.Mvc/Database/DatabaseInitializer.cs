using global::MinuteMeals.WebApp.Mvc.Models;


namespace MinuteMeals.WebApp.Mvc.Database
{
    public static class DatabaseInitializer
    {
        public static void SeedData(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                context.Database.EnsureCreated();

                if (!context.Recipes.Any())
                {
                    context.Recipes.AddRange(new List<Recipe>
                    {
                        new Recipe { Name = "Spaghetti Aglio e Olio", Ingredients = "Spaghetti, garlic, olive oil, chili flakes, parsley, salt", Steps = "1. Cook spaghetti until al dente. | 2. Sauté garlic in olive oil. | 3. Add pasta, chili flakes, and parsley.", CookingTimeInMinutes = 15 },
                        new Recipe { Name = "Chicken Stir-Fry", Ingredients = "Chicken breast, mixed vegetables, soy sauce, ginger, garlic", Steps = "1. Slice chicken and veggies. | 2. Cook chicken, add veggies, soy sauce, and ginger.", CookingTimeInMinutes = 20 },
                        new Recipe { Name = "Caprese Salad", Ingredients = "Tomatoes, mozzarella, basil, balsamic glaze", Steps = "1. Slice tomatoes and mozzarella. | 2. Arrange on plate with basil. | 3. Drizzle with balsamic glaze.", CookingTimeInMinutes = 5 },
                        new Recipe { Name = "Beef Tacos", Ingredients = "Ground beef, taco seasoning, tortillas, lettuce, cheese, salsa", Steps = "1. Cook beef with seasoning. | 2. Serve in tortillas with lettuce, cheese, and salsa.", CookingTimeInMinutes = 15 },
                        new Recipe { Name = "Veggie Omelette", Ingredients = "Eggs, bell peppers, onions, spinach, cheese", Steps = "1. Beat eggs. | 2. Cook veggies, pour eggs, add cheese.", CookingTimeInMinutes = 10 },
                        new Recipe { Name = "Margherita Pizza", Ingredients = "Pizza dough, tomato sauce, mozzarella, basil", Steps = "1. Spread sauce on dough, add mozzarella and basil. | 2. Bake until crust is golden.", CookingTimeInMinutes = 15 },
                        new Recipe { Name = "Garlic Butter Shrimp", Ingredients = "Shrimp, garlic, butter, lemon, parsley", Steps = "1. Cook garlic in butter. | 2. Add shrimp, lemon, and parsley.", CookingTimeInMinutes = 10 },
                        new Recipe { Name = "Chickpea Curry", Ingredients = "Chickpeas, coconut milk, curry powder, garlic, onion", Steps = "1. Sauté garlic and onion. | 2. Add curry powder, chickpeas, and coconut milk.", CookingTimeInMinutes = 20 },
                        new Recipe { Name = "Avocado Toast", Ingredients = "Avocado, bread, salt, pepper, chili flakes", Steps = "1. Toast bread. | 2. Spread mashed avocado, season with salt, pepper, and chili flakes.", CookingTimeInMinutes = 5 },
                        new Recipe { Name = "Banana Smoothie", Ingredients = "Banana, milk, honey, cinnamon", Steps = "1. Blend banana, milk, honey, and cinnamon until smooth.", CookingTimeInMinutes = 5 }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}

