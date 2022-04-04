using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
    [Display(Name = "Lawful Good")]
    LawfulGood,
    [Display(Name = "Neutral Good")]
    NeutralGood,
    [Display(Name = "Chaotic Good")]
    ChaoticGood,
    [Display(Name = "Lawful Neutral")]
    LawfulNeutral,
    [Display(Name = "True Neutral")]
    TrueNeutral,
    [Display(Name = "Chaotic Neutral")]
    ChaoticNeutral,
    [Display(Name = "Lawful Evil")]
    LawfulEvil,
    [Display(Name = "Neutral Evil")]
    NeutralEvil,
    [Display(Name = "Chaotic Evil")]
    ChaoticEvil
  }

  // How could we represent a sandwich on a political compass?
  // What would be a sandwiches Meyers-Briggs type?
}
