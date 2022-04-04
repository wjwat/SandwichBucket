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
    public SandwichAlignment Alignment { get; set; }

    public virtual ICollection<SandwichIngredient> Ingredients { get; }
    public virtual ICollection<SandwichTag> Tags { get; }
  }

  public enum SandwichAlignment
  {
    LawfulGood,
    NeutralGood,
    ChaoticGood,
    LawfulNeutral,
    TrueNeutral,
    ChaoticNeutral,
    LawfulEvil,
    NeutralEvil,
    ChaoticEvil
  }

  // How could we represent a sandwich on a political compass?
  // What would be a sandwiches Meyers-Briggs type?
}
