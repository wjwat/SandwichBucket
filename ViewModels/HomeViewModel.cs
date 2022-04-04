using System.Collections.Generic;

using SandwichBucket.Models;

namespace SandwichBucket.ViewModels
{
    public class HomeViewModel
    {
        // This your Random Sandwich => It's made up of these ingredients
        public Sandwich Sandwich { get; set; }
        public Ingredient Ingredient { get; set; }
        public Tag Tag { get; set; }

        // Try to make a sandwich with these ingredients!
        public List<Ingredient> RandomSandwich { get; set; }
    }
}
