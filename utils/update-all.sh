#!/bin/sh

python ingredients.py > ../SeedData/Ingredient.json
python sandwiches.py > ../SeedData/Sandwich.json
python tags.py > ../SeedData/Tag.json
python relationship.py > ../SeedData/SandwichIngredient.json