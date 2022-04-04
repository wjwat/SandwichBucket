using System.Collections.Generic;

namespace SandwichBucket.Models
{
  public class Sandwich
  {
    public Sandwich()
    {
      Ingredients = new HashSet<SandwichIngredient> {};
      Tags = new HashSet<SandwichTag> {};
    }

    public int SandwichId { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }

    public virtual ICollection<SandwichIngredient> Ingredients { get; }
    public virtual ICollection<SandwichTag> Tags { get; }
  }
}
