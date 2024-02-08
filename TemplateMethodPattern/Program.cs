//Console.WriteLine("Hello, OS");

namespace TemplateMethodPattern
{
    public abstract class Recipe
    {
        // Template method defining the algorithm
        public void PrepareDish()
        {
            // Common steps shared among all recipes
            GatherIngredients();
            PrepareIngredients();

            // Abstract steps to be implemented by derived classes
            Cook();
            Serve();
        }

        // Common Steps
        private void GatherIngredients()
        {
            Console.WriteLine("Gathering Ingredients...");
        }

        private void PrepareIngredients()
        {
            Console.WriteLine("Preparing Ingredients...");
        }

        // Abstract Steps to be implemented by derived classes
        public abstract void Cook();
        public abstract void Serve();
    }

    public class PizzaRecipe : Recipe
    {
        // Implementing the abstract steps for Pizza
        public override void Cook()
        {
            Console.WriteLine("Baking the pizza in the oven...");
        }

        public override void Serve()
        {
            Console.WriteLine("Serve the delicious pizza!");
        }
    }

    public class PastaRecipe : Recipe
    {
        // Implementing the abstract steps for Pasta
        public override void Cook()
        {
            Console.WriteLine("Boiling the pasta in hot water...");
        }

        public override void Serve()
        {
            Console.WriteLine("Serve the tasty pasta with sauce!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Making Pizza:");
            Recipe recipe = new PizzaRecipe();
            recipe.PrepareDish();

            Console.WriteLine("\nMakikg Pasta:");
            recipe = new PastaRecipe();
            recipe.PrepareDish();
        }
    }
}