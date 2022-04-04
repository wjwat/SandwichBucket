using System.Collections.Generic;

namespace SandwichBucket.Models
{
  public class Tag
  {
    public Tag()
    {
      Sandwiches = new HashSet<SandwichTag> {};
      Ingredients = new HashSet<IngredientTag> {};
    }

    public int TagId { get; set; }

    public string Name { get; set; }

    public virtual ICollection<SandwichTag> Sandwiches { get; }
    public virtual ICollection<IngredientTag> Ingredients { get; }
  }
}
