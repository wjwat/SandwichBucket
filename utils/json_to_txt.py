print("""
This no longer matches what our models look like, unless you're willing to update
it please do not use.
""")

# Remove these lines if you want to start using this again
import sys
sys.exit()

import json

OUT_DIR = "from_json/"

for z in ['Ingredient', 'Sandwich']:
  with open(OUT_DIR + z + "_from_json.txt", 'w') as out:
    with open("../SeedData/" + z + ".json") as f:
      data = json.load(f)

      for x in data:
        out.write(x["Name"] + ';' + x["Description"] + '\n')

with open(OUT_DIR + "Tag_from_json.txt", 'w') as out:
  with open("../SeedData/Tag.json") as f:
    data = json.load(f)

    for x in data:
      out.write(x["Name"] + '\n')