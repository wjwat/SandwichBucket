import json
import random

ROWS = []
SANDWICH_ID = 1

with open("data/sandwiches.txt") as f:
  for x in f.readlines():
    name, description = [y.strip() for y in x.split(';')]
    ROWS.append({
      "SandwichId": SANDWICH_ID,
      "Name": name,
      "Description": description,
      "Alignment": random.randint(0, 8)
    })
    SANDWICH_ID += 1

print(json.dumps(ROWS, indent=2))
