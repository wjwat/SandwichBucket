"""
THIS IS QUICK AND DIRTY

Use at your own risk :)
"""

import sys
import json

ROWS = []
INGREDIENTS = []
COUNTER = 1

with open("data/ingredients.txt") as i:
  INGREDIENTS = [x.split(';')[0].strip().upper() for x in i.readlines()]

with open("data/sandwiches.txt") as f:
  lines = f.readlines()
  for l in lines:
    y = l.split(';', 2)

    sandwich_ingredients = y[2]

    if len(y) != 3:
      print(f'LINE #{lines.index(l)} is missing 3 values: {l.strip()}')
      sys.exit()

    sandwich_ingredients = sandwich_ingredients.replace('[', '').replace(']', '')
    sandwich_ingredients = [a.strip().upper() for a in sandwich_ingredients.split(',')]

    for s in sandwich_ingredients:
      try:
        ROWS.append(
          {
            "SandwichIngredientId": COUNTER,
            "SandwichId": lines.index(l) + 1,
            "IngredientId": INGREDIENTS.index(s) + 1
          }
        )
      except ValueError:
        print(f'{lines.index(l)+1} {y[0]}: {s}', file=sys.stderr)

      COUNTER += 1

print(json.dumps(ROWS, indent=2))