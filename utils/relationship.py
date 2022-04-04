import sys
import json

ROWS = []
INGREDIENTS = []
COUNTER = 1

with open("data/ingredients.txt") as i:
  INGREDIENTS = [x.split(';')[0].strip().upper() for x in i.readlines()]

  # print(INGREDIENTS)

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

      # print(y[0] + ': ', end='')
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
          print(f'{lines.index(l)} {y[0]}: {s}')

        COUNTER += 1
        # print(INGREDIENTS.index(s), end=', ')
      # print('')

print(json.dumps(ROWS, indent=2))