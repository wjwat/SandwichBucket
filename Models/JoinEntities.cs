namespace SandwichBucket.Models
{
  public class SandwichIngredient
  {
    public int SandwichIngredientId { get; set; }
    public int SandwichId { get; set; }
    public int IngredientId { get; set; }
    public virtual Sandwich Sandwich { get; set; }
    public virtual Ingredient Ingredient { get; set; }
  }

  public class SandwichTag
  {
    public int SandwichTagId { get; set; }
    public int SandwichId { get; set; }
    public int TagId { get; set; }
    public virtual Sandwich Sandwich { get; set; }
    public virtual Tag Tag { get; set; }
  }

  public class IngredientTag
  {
    public int IngredientTagId { get; set; }
    public int IngredientId { get; set; }
    public int TagId { get; set; }
    public virtual Ingredient Ingredient { get; set; }
    public virtual Tag Tag { get; set; }
  }
}
