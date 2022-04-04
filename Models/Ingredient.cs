using System.Collections.Generic;

namespace SandwichBucket.Models
{
  public class Ingredient
  {
    public Ingredient()
    {
      Sandwiches = new HashSet<SandwichIngredient> {};
      Tags = new HashSet<IngredientTag> {};
    }

    public int IngredientId { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }
   
    public virtual ICollection<SandwichIngredient> Sandwiches { get; }
    public virtual ICollection<IngredientTag> Tags { get; }
  }
}
