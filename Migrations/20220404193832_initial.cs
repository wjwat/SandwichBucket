using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SandwichBucket.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    IngredientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.IngredientId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sandwiches",
                columns: table => new
                {
                    SandwichId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Alignment = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sandwiches", x => x.SandwichId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    TagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.TagId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SandwichesIngredients",
                columns: table => new
                {
                    SandwichIngredientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SandwichId = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SandwichesIngredients", x => x.SandwichIngredientId);
                    table.ForeignKey(
                        name: "FK_SandwichesIngredients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "IngredientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SandwichesIngredients_Sandwiches_SandwichId",
                        column: x => x.SandwichId,
                        principalTable: "Sandwiches",
                        principalColumn: "SandwichId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "IngredientTag",
                columns: table => new
                {
                    IngredientTagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientTag", x => x.IngredientTagId);
                    table.ForeignKey(
                        name: "FK_IngredientTag_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "IngredientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientTag_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SandwichesTags",
                columns: table => new
                {
                    SandwichTagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SandwichId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SandwichesTags", x => x.SandwichTagId);
                    table.ForeignKey(
                        name: "FK_SandwichesTags_Sandwiches_SandwichId",
                        column: x => x.SandwichId,
                        principalTable: "Sandwiches",
                        principalColumn: "SandwichId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SandwichesTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "IngredientId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "O'er the land of the cheese and the home of the brave.", "American Cheese" },
                    { 36, "Taste like freshly cut grass. Looks like freshly cut grass. is freshly cut grass", "MicroGreens" },
                    { 37, "A zesty yellow fellow that isn't at all mellow, and can make you bellow.", "Mustard" },
                    { 38, "Brown spread. Don't worry, it's hazelnut and cocoa.", "Nutella" },
                    { 39, "I'm a tomato poser.", "Olive Bruschetta" },
                    { 40, "Be judged by your selection of this at Costco, by Steve, a passerby. Screw you, Steve! I LIKE JIF. I DON'T NEED MY PEANUT-BUTTER TO BE MADE OUT OF ALMONDS. THAT'S YOUR CHOICE. anyway, its peanuts in butter-form.", "Peanut Butter" },
                    { 42, "The last name of the family across the street from Bob's business.", "Pesto" },
                    { 43, "Uncured ham, sliced as thin as Ryan's wallet.", "Prosciutto" },
                    { 44, "Made in solidary in Provo, Utah.", "Provolone" },
                    { 45, "'I like my butt rubbed and my pork pulled' - Porky Pig", "Pulled Pork" },
                    { 46, "These onions were made famous after starring in an action comedy with Bruce Willis.", "Red Onion" },
                    { 47, "What is relish?", "Relish" },
                    { 48, "Also known as 'I've got hurt feelings meat' or 'toasted conflict'.", "Roast Beef" },
                    { 49, "Xena the Warrior Princess's favorite meat, flies well when thrown.", "Salami" },
                    { 50, "[Insert Europeon Joke Here]", "Sauerkraut" },
                    { 51, "Allergies be damned!!", "Seitan" },
                    { 52, "Is this appropriation?", "Slaw" },
                    { 53, "Sourful and powerful, this bread has a strong opinion on every. Damn. Thing.", "Sourdough Bread" },
                    { 54, "PastaFarians be craving those noodly apendages.", "Spaghetti" },
                    { 55, "Soggy lettuce, produces beachball-sized biceps when consumed.", "Spinach" },
                    { 56, "Created from slightly used yoga mats from the dance studio across the street.", "Subway Yoga Mat Bread" },
                    { 57, "The best cheese ever, and nobody can poke holes in that fact.", "Swiss Cheese" },
                    { 58, "Hamburger + Spices = Taco Meat", "Taco Meat" },
                    { 59, "Low/no sodium, solidified ketchup miniature discuses (frisbees)", "ToeMaToe" },
                    { 60, "This popular fish is said to be able to take down a lion.", "Tuna" },
                    { 61, "I'm better than Marmite", "Vegimite" },
                    { 62, "The most boring of bread, will likely lecture you on politics or something.", "White Bread" },
                    { 63, "Bread, just disputably healthier for you.", "Whole Wheat Bread" },
                    { 64, "Cheese from our most music-festival-attending ox.", "Yak Cheese" },
                    { 65, "No expiration date. Taste test first. Made with love.", "Your Grandma's Breadbox Bread" },
                    { 35, "Boy, sure is nice not havin' Shake around.", "MeatBalls" },
                    { 34, "Spread for your bread.", "Mayo" },
                    { 41, "Like peppers, but from the east coast.", "PepperCini" },
                    { 32, "A trench in the ocean... Not sure what this has to do with sandwiches.", "Marinara" },
                    { 2, "I'm better than both Vegemite or Marmite.", "Anchovy Paste" },
                    { 3, "It's hip 'vocado. And $9 a cut.", "Avocado" },
                    { 4, "You can't spell 'happiness' without 'bacon'. well, you can. you'd just be miserable spelling it.", "Bacon" },
                    { 5, "1776 substituted with peppers instead of liberty.", "Bell Peppers" },
                    { 6, "Ordinary, crumbly cheese if you're colorblind.", "Blue Cheese" },
                    { 7, "It's nonsense.", "Baloney" },
                    { 8, "You best believe this is butter.", "Butter" },
                    { 33, "Im better than Vegemite", "Marmite" },
                    { 10, "A mild-mannered cheese dyed a less intimidating color.", "Cheddar" },
                    { 11, "A non-confrontational bird.", "Chicken" },
                    { 12, "Just as much to say as it is to eat.", "Ciabatta Roll" },
                    { 13, "Cows after a Korn festival, pairs well with cabbage.", "Corned Beef" },
                    { 14, "Cranberry jelly is so fancy its considered a sauce.", "Cranberry Sauce" },
                    { 15, "What's that in the sky? It's a cheese? It's a cream? It's a cream cheese!", "Cream Cheese" },
                    { 16, "Old pickles, if they aged like Benjamin Button.", "Cucumbers" },
                    { 9, "Human noses. If humans were snow-people.", "Carrot" },
                    { 18, "If cucumbers were witches.", "Dill Pickles" },
                    { 17, "Please don't put this on your sandwich. It tastes best by itself!", "Daniel Angerer's Human Milk Cheese" },
                    { 31, "Bread, inspired by Vincent van Gogh.", "Marbled Rye Bread" },
                    { 30, "A green blanket, enjoyed by rabbits.", "Lettuce" },
                    { 29, "A type of karate, filled with vegetables.", "KimChi" },
                    { 28, "Along with chocolate, makes for an excellent blood substitute with film.", "Ketchup" },
                    { 26, "Pairs well with Avocado bread, thick rimmed glasses and The Shins.", "Hummus" },
                    { 27, "If fruit and sugar got into a car accident and neither were wearing a seatbelt.", "Jam Jellies" },
                    { 24, "During the day, a columnist. At night, a hero roll.", "Hoagie Bun" },
                    { 23, "Ya know like that cute costume", "HawtDwag" },
                    { 22, "A smooth, creamy, supple-in-texture cheese. Can't have a party without havarti.", "Havarti Cheese" },
                    { 21, "Ham. Yup.", "Ham" },
                    { 20, "There's fried egg, boiled egg, sliced egg, baked egg, salted egg, raw egg, egg burger, salsa'd egg, egg sandwich, egg salad, salad egg, egg fried rice, chicken egg, .... That-that's about it.", "Egg" },
                    { 19, "Like wet turkey, only dry.", "Dry Turkey" },
                    { 25, "How cool is that horse? Eh. That horse is rad-ish.", "Horseradish" }
                });

            migrationBuilder.InsertData(
                table: "Sandwiches",
                columns: new[] { "SandwichId", "Alignment", "Description", "Name" },
                values: new object[,]
                {
                    { 20, 0, "Hand eating at its finest", "Pastie" },
                    { 25, 0, "Gotta be with horsey sauce", "Roast Beef" },
                    { 21, 0, "That's it", "PB&J" },
                    { 22, 0, "Fold it", "Pizza" },
                    { 23, 0, "This is making me hungry", "Pulled Pork" },
                    { 24, 0, "Who cares", "Reuben" },
                    { 26, 0, "666", "Seitan" },
                    { 34, 0, "Some dirt between two 2 x 4s", "Wood" },
                    { 28, 0, "A bunch of things", "Sub" },
                    { 29, 0, "Maybe the best of all sandwiches", "Taco" },
                    { 30, 0, "Maybe the best of all sandwiches", "Taco" },
                    { 31, 0, "yum", "Torta" },
                    { 32, 0, "Chicken of the sea", "Tuna Salad" },
                    { 33, 0, "Chicken of the sea", "Tuna Salad" },
                    { 19, 0, "Yum olives", "Muffuletta" },
                    { 27, 0, "Somehow this is a sandwich", "Spaghetti and Meatballs" },
                    { 18, 0, "You should eat this with a fork", "Meatball Sub" },
                    { 3, 0, "Watch out for the burglar", "Cheeseburger" },
                    { 16, 0, "Some words", "Ham and Swiss" },
                    { 17, 0, "Don't put ketchup on a hot dog", "Hot Dog" },
                    { 1, 0, "Hell yes", "Banh Mi" },
                    { 2, 0, "Classic", "BLT" },
                    { 4, 0, "Chop up", "Cheesesteak" },
                    { 6, 0, "Chicken of the land", "Chicken Salad" },
                    { 7, 0, "Who am I?", "Chopped Liver" },
                    { 8, 0, "Damn fine", "Croque-monsieur" },
                    { 5, 0, "Damn fine", "CherryPie" },
                    { 10, 0, "Veal or Beef??", "Doner kebab" },
                    { 11, 0, "You're either with it or against it", "Egg Salad" },
                    { 12, 0, "Chickpeas or Garbanzos?", "Falafel" },
                    { 13, 0, "Turkey and slaw baby", "Georgia Reuben" },
                    { 14, 0, "Mayo or Butter???", "Grilled Cheese" },
                    { 15, 0, "GYYY-ROOOE", "Gyro" },
                    { 9, 0, "All kinds of pork", "Cubano" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Name" },
                values: new object[,]
                {
                    { 25, "Straight outta Compton" },
                    { 20, "Savory" },
                    { 21, "Smells Like Garbage" },
                    { 22, "So Much Gluten You're Going to Develop a Gluten Allergy" },
                    { 23, "Sour" },
                    { 24, "Straight from Grandma's Kitchen" },
                    { 26, "Sweet" },
                    { 33, "Vietnamese" },
                    { 28, "The Heart Wants Mayo" },
                    { 29, "Turkish" },
                    { 30, "Two-faced" },
                    { 31, "Vegan" },
                    { 32, "Vegetarian" },
                    { 19, "People Who Go To Epicodus Would Eat This" },
                    { 34, "We Ain't Got Time To Eat (Great for Smoothies)" },
                    { 27, "Terrible" },
                    { 18, "Pasta" },
                    { 10, "Greek" },
                    { 16, "No-faced" },
                    { 35, "Would Only Feed To My Worst Enemy" },
                    { 1, "Basically a dog turd between two pieces of bread" },
                    { 2, "Building materials" },
                    { 3, "Closed-faced" },
                    { 4, "Delicious" },
                    { 5, "Dog Food" },
                    { 6, "Face-Off" },
                    { 7, "Fork Necessary" },
                    { 8, "Gluten-Free" },
                    { 9, "Good mineworker faire" },
                    { 11, "Japanese Sando" },
                    { 12, "John Travolta's Favorite" },
                    { 13, "Lots of Gluten" },
                    { 14, "Mexican" },
                    { 15, "Nic Cage Approved" },
                    { 17, "Open-faced" },
                    { 36, "Wow, I Can't Believe It's Got Gluten" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientTag_IngredientId",
                table: "IngredientTag",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientTag_TagId",
                table: "IngredientTag",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_SandwichesIngredients_IngredientId",
                table: "SandwichesIngredients",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_SandwichesIngredients_SandwichId",
                table: "SandwichesIngredients",
                column: "SandwichId");

            migrationBuilder.CreateIndex(
                name: "IX_SandwichesTags_SandwichId",
                table: "SandwichesTags",
                column: "SandwichId");

            migrationBuilder.CreateIndex(
                name: "IX_SandwichesTags_TagId",
                table: "SandwichesTags",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientTag");

            migrationBuilder.DropTable(
                name: "SandwichesIngredients");

            migrationBuilder.DropTable(
                name: "SandwichesTags");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Sandwiches");

            migrationBuilder.DropTable(
                name: "Tags");
        }
    }
}
