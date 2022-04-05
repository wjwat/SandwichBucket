using System.Collections.Generic;

using SandwichBucket.Models;

namespace SandwichBucket.ViewModels
{
    public class IngredientEditViewModel
    {
      public Ingredient Ingredient { get; set; }

      public List<Sandwich> Sandwiches { get; set; }
      public List<Tag> Tags { get; set; }
    }

    public class SandwichEditViewModel
    {
      public Sandwich Sandwich { get; set; }

      public List<Ingredient> Ingredients { get; set; }
      public List<Tag> Tags { get; set; }
    }

    public class TagEditViewModel
    {
      public Tag Tag { get; set; }

      public List<Sandwich> Sandwiches { get; set; }
      public List<Ingredient> Ingredients { get; set; }
    }

    public class CreateViewModel
    {
      public List<Ingredient> Ingredients { get; set; }
      public List<Sandwich> Sandwiches { get; set; }
      public List<Tag> Tags { get; set; }
    }
}
