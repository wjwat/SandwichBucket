"""
Pretty simple script to use. Just pipe the output to whatever JSON file you'd
like to use with your database. Currently we've got it hardcoded to look for
`Animals.json` in the top level directory of `AnimalShelter.Api`

Ex:
$ python gen-db-entries.py > Animals.json
$ cp Animals.json /path/to/AnimalShelter.Api
"""

import json

ROWS = []
TAG_ID = 1

with open("data/tags.txt") as f:
  for x in [y.strip() for y in f.readlines()]:
    ROWS.append({
      "TagId": TAG_ID,
      "Name": x
    })
    TAG_ID += 1

print(json.dumps(ROWS, indent=2))
