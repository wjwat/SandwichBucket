import json

ROWS = []
INGREDIENT_ID = 1

with open("data/ingredients.txt") as f:
  for x in f.readlines():
    name, description = [y.strip() for y in x.split(';')]
    ROWS.append({
      "IngredientId": INGREDIENT_ID,
      "Name": name,
      "Description": description
    })
    INGREDIENT_ID += 1

print(json.dumps(ROWS, indent=2))
