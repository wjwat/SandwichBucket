using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SandwichBucket.Migrations
{
    public partial class FINAL : Migration
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
                    { 92, "Spicy like AZ.", "Jalapeno" },
                    { 91, "Not from pine trees.", "Pineapple" },
                    { 90, "Elk brand", "Pepperoni" },
                    { 89, "Best from Water Buffalo. Mama Mia!", "Mozzarella Cheese" },
                    { 88, "More dough, more problems.", "Dough" },
                    { 87, "Yes it's spelled right.", "Tzatziki" },
                    { 86, "Thick like you like it. Make sure to mix the oil in first.", "Tahini" },
                    { 85, "DO not eat while dry.", "Chickpeas" },
                    { 84, "Take a bagel and smash it flat, like paper.", "Pita" },
                    { 83, "Flour, Water, Salt, Yeast", "Bread" },
                    { 82, "You don't want to know. Seriously, don't look it up.", "Schmaltz" },
                    { 81, "It's better than the Chicken Die-r.", "Chicken Liver" },
                    { 80, "Not recommended for witches consumption.", "Salt" },
                    { 79, "Add some crunch to your lunch!", "Celery" },
                    { 78, "Request them without pajamas, for a bananaier taste.", "Bananas" },
                    { 77, "Straight up, raw, uncut, not laced with nothin'.", "Sugar" },
                    { 76, "Used in bombs and pies, but a sweet addition to any sundae or sandwich.", "Cherries" },
                    { 75, "Also referred to as Pie Crusties in groups, frequently panhandle and tell you your life is a lie.", "Pie Crust" },
                    { 74, "The classiest way to enjoy cheese.", "Cheezewhiz" },
                    { 73, "Eat it raw, else the internet will have an opinion about it.", "Steak" },
                    { 72, "The ideal bun for a hamburger.", "Hamburger Bun" },
                    { 71, "The ideal hamburger for a hamburger bun.", "Hamburger" },
                    { 70, "Winter radishes is coming.", "Daikon" },
                    { 69, "Meat paste, also a way to refer to someone's head.", "Pate" },
                    { 68, "Great in salsa, bomb in sandwiches.", "Cilantro" },
                    { 67, "An abomination with a catchy dance.", "PenPineAppleApplePen" },
                    { 66, "No expiration date. Taste test first. Made with love.", "Your Grandma's Breadbox Bread" },
                    { 93, "Generic Name for Bic Mac Sauce.", "Thousand Island Dressing" },
                    { 94, "Green, Red, Mango, Chutney, a mystery flavor.", "Salsa" },
                    { 95, "Fiber supplement.", "Wood" },
                    { 96, "Rare, hard to find ..dirt. Found in most sandwiches in very small portions.", "Dirt" },
                    { 125, "What? It's basically a less processed HawtDog.", "Haggis" },
                    { 124, "boil 'em, mash 'em, stick 'em in a stew", "Potato" },
                    { 123, "who knows", "Mystery Meat" },
                    { 122, "fancy guac sauce", "Avacado" },
                    { 121, "when the dog is hot", "Hot Dog" },
                    { 120, "who cares what kind just eat it already", "cheese" },
                    { 119, "Why not?", "Bun" },
                    { 118, "Why, just why?", "Arugula" },
                    { 117, "Creamy delish on a cracker.", "Goat Cheese" },
                    { 116, "Mmmm burnt is the best.", "Roasted Red Peppers" },
                    { 115, "Nearly burnt is the best bestest.", "Caramelized Onions" },
                    { 114, "You get it right?", "Green Sauce" },
                    { 113, "Different than raw, burnt, or even flamebroiled.", "Roasted Onions" },
                    { 65, "Cheese from our most music-festival-attending ox.", "Yak Cheese" },
                    { 112, "Benjamin Button's aged cheese.", "Queso Fresco" },
                    { 110, "It has lots of layers, like Shrek.", "Onions" },
                    { 109, "Ninja Turtles favorite pizza topping after gang-fight snack.", "Nacho Cheese" },
                    { 108, "Little dried, cut, burrito casings.", "Tortillas" },
                    { 107, "Kissy Kissy, Mwawh!", "Lingua" },
                    { 106, "Old wine for kids!", "Vinegar" },
                    { 105, "Vegetable Oil for the classy.", "Olive Oil" },
                    { 104, "It is possible to have delish bologna, yes just believe. ET Phone Home.", "Mortadella" },
                    { 103, "Try is spicy!", "Capicola" },
                    { 101, "A-1 or Heinz-57? YOU DECIDE!?@?", "Steak Sauce" },
                    { 100, "Best home grown, do not store in fridge.", "Tomato" },
                    { 99, "Lil' for your lil' tummies.", "Lil'Smokies" },
                    { 98, "Like Chris Rock at the Oscars.", "Roast Vegetables" },
                    { 97, "oof ouch owee", "A Nail" },
                    { 111, "Far South BBQ", "Barbacoa" },
                    { 64, "Bread, just disputably healthier for you.", "Whole Wheat Bread" },
                    { 102, "*will smith voice* Ah, That's Hawt", "Hot Sauce" },
                    { 62, "I'm better than Marmite", "Vegemite" },
                    { 29, "Along with chocolate, makes for an excellent blood substitute with film.", "Ketchup" },
                    { 28, "If fruit and sugar got into a car accident and neither were wearing a seatbelt.", "Jam Jellies" },
                    { 27, "Pairs well with Avocado bread, thick rimmed glasses and The Shins.", "Hummus" },
                    { 26, "How cool is that horse? Eh. That horse is rad-ish.", "Horseradish" },
                    { 25, "During the day, a columnist. At night, a hero roll.", "Hoagie Bun" },
                    { 24, "Ya know like that cute costume", "HawtDwag" },
                    { 22, "Ham. Yup.", "Ham" },
                    { 21, "There's fried egg, boiled egg, sliced egg, Easter Egg, baked egg, salted egg, raw egg, egg burger, salsa'd egg, egg sandwich, egg salad, salad egg, egg fried rice, chicken egg, .... That-that's about it.", "Egg" },
                    { 20, "Like wet turkey, only dry.", "Dry Turkey" },
                    { 19, "If cucumbers were witches.", "Dill Pickles" },
                    { 18, "Please don't put this on your sandwich. It tastes best by itself!", "Daniel Angerer's Human Milk Cheese" },
                    { 17, "Old pickles, if they aged like Benjamin Button.", "Cucumber" },
                    { 16, "What's that in the sky? It's a cheese? It's a cream? It's a cream cheese!", "Cream Cheese" },
                    { 30, "A type of karate, filled with vegetables.", "KimChi" },
                    { 15, "Cranberry jelly is so fancy its considered a sauce", "Cranberry Sauce" },
                    { 13, "Cows after a Korn festival, pairs well with cabbage", "Corned Beef" },
                    { 12, "Just as much to say as it is to eat.", "Ciabatta Roll" },
                    { 11, "A non-confrontational bird.", "Chicken" },
                    { 10, "A mild-mannered cheese dyed a less intimidating color.", "Cheddar Cheese" },
                    { 9, "Human noses. If humans were snow-people.", "Carrot" },
                    { 8, "You best believe this is butter.", "Butter" },
                    { 7, "It's nonsense.", "Baloney" },
                    { 6, "Ordinary, crumbly cheese if you're colorblind.", "Blue Cheese" },
                    { 5, "1776 substituted with peppers instead of liberty.", "Bell Peppers" },
                    { 4, "You can't spell 'happiness' without 'bacon'. well, you can. you'd just be miserable spelling it.", "Bacon" },
                    { 3, "It's hip 'vocado. And $9 a cut.", "Avocado" },
                    { 2, "I'm better than both Vegemite or Marmite.", "Anchovy Paste" },
                    { 63, "The most boring of bread, will likely lecture you on politics or something.", "White Bread" },
                    { 14, "Boom na da mmm dum na ema Da boom na da mmm dum na ema", "Korned Beef" },
                    { 31, "A green blanket, enjoyed by rabbits.", "Lettuce" },
                    { 23, "A smooth, creamy, supple-in-texture cheese. Can't have a party without havarti.", "Havarti Cheese" },
                    { 33, "A trench in the ocean... Not sure what this has to do with sandwiches.", "Marinara" },
                    { 61, "This popular fish is said to be able to take down a lion.", "Tuna" },
                    { 60, "Low/no sodium, solidified ketchup miniature discuses (frisbees)", "ToeMaToe" },
                    { 59, "Hamburger + Spices = Taco Meat", "Taco Meat" },
                    { 58, "The best cheese ever, and nobody can poke holes in that fact.", "Swiss Cheese" },
                    { 57, "Created from slightly used yoga mats from the dance studio across the street.", "Subway Yoga Mat Bread" },
                    { 56, "Soggy lettuce, produces beachball-sized biceps when consumed.", "Spinach" },
                    { 32, "Bread, inspired by Vincent van Gogh.", "Marbled Rye Bread" },
                    { 54, "Sourful and powerful, this bread has a strong opinion on every. Damn. Thing.", "Sourdough Bread" },
                    { 53, "Is this appropriation?", "Slaw" },
                    { 52, "Allergies be damned!!", "Seitan" },
                    { 51, "(Insert Europeon Joke Here)", "Sauerkraut" },
                    { 50, "Xena the Warrior Princess's favorite meat, flies well when thrown.", "Salami" },
                    { 49, "Also known as 'I've got hurt feelings meat' or 'toasted conflict'.", "Roast Beef" },
                    { 48, "What is relish?", "Relish" },
                    { 47, "These onions were made famous after starring in an action comedy with Bruce Willis.", "Red Onion" },
                    { 55, "PastaFarians be craving those noodly apendages.", "Spaghetti" },
                    { 45, "Made in solidary in Provo, Utah.", "Provolone" },
                    { 46, "'I like my butt rubbed and my pork pulled' - Porky Pig", "Pulled Pork" },
                    { 35, "Spread for your bread.", "Mayo" },
                    { 36, "Boy, sure is nice not havin' Shake around.", "MeatBalls" },
                    { 38, "A zesty yellow fellow that isn't at all mellow, and can make you bellow.", "Mustard" },
                    { 39, "Brown spread. Don't worry, it's hazelnut and cocoa.", "Nutella" },
                    { 37, "Taste like freshly cut grass. Looks like freshly cut grass. is freshly cut grass", "MicroGreens" },
                    { 40, "I'm a tomato poser.", "Olive Bruschetta" },
                    { 41, "Be judged by your selection of this at Costco, by Steve, a passerby. Screw you, Steve! I LIKE JIF. I DON'T NEED MY PEANUT-BUTTER TO BE MADE OUT OF ALMONDS. THAT'S YOUR CHOICE. anyway, its peanuts in butter-form.", "Peanut Butter" },
                    { 42, "Like peppers, but from the east coast.", "PepperCini" },
                    { 43, "The last name of the family across the street from Bob's business.", "Pesto" },
                    { 44, "Uncured ham, sliced as thin as Ryan's wallet.", "Prosciutto" },
                    { 34, "Im better than Vegemite", "Marmite" }
                });

            migrationBuilder.InsertData(
                table: "Sandwiches",
                columns: new[] { "SandwichId", "Alignment", "Description", "Name" },
                values: new object[,]
                {
                    { 25, 8, "Gotta be with horsey sauce", "Roast Beef" },
                    { 32, 6, "Some dirt between two 2 x 4s", "Wood" },
                    { 26, 4, "666", "Seitan" },
                    { 27, 8, "Somehow this is a sandwich", "Spaghetti and Meatballs" },
                    { 28, 3, "An american sandwich", "Sub" },
                    { 29, 7, "Maybe the best of all sandwiches", "Taco" },
                    { 30, 3, "yum", "Torta" },
                    { 31, 0, "Chicken of the sea", "Tuna Salad" },
                    { 24, 2, "Who cares Ryan does!", "Reuben" },
                    { 37, 4, "", "Raining Sauce" },
                    { 34, 8, "", "Freak On A Sandwich" },
                    { 35, 1, "", "All Day I Dream About Sandwich" },
                    { 36, 4, "(A Sandwich)", "Give Me Something To Eat" },
                    { 38, 4, "No More, No less", "Eat 16 Sandwiches" },
                    { 39, 8, "", "F*ck You, Eat Me" },
                    { 40, 7, "(A Sandwich (cow's head))", "What's In The Box?" },
                    { 41, 5, "Your mom's favorite", "It's My Sandwich In a Box" },
                    { 23, 3, "This is making me hungry", "Pulled Pork" },
                    { 33, 8, "", "Falling Away From Meat" },
                    { 22, 8, "Fold it", "Pizza" },
                    { 9, 8, "All kinds of pork", "Cubano" },
                    { 20, 4, "Hand eating at its finest", "Pastie" },
                    { 21, 1, "That's it", "PB&J" },
                    { 2, 0, "Classic", "BLT" },
                    { 3, 6, "Watch out for the burglar", "Cheeseburger" },
                    { 4, 2, "Chop up", "Cheesesteak" },
                    { 5, 5, "Damn fine", "CherryPie" },
                    { 6, 2, "Chicken of the land", "Chicken Salad" },
                    { 7, 3, "Who am I?", "Chopped Liver" },
                    { 8, 5, "Damn fine", "Croque-monsieur" },
                    { 10, 7, "Veal or Beef??", "Doner kebab" },
                    { 1, 2, "Hell yes", "Banh Mi" },
                    { 12, 7, "Chickpeas or Garbanzos?", "Falafel" },
                    { 13, 5, "Turkey and slaw baby", "Georgia Reuben" },
                    { 14, 5, "Mayo or Butter???", "Grilled Cheese" },
                    { 15, 4, "GYYY-ROOOE", "Gyro" },
                    { 16, 2, "Some words", "Ham and Swiss" },
                    { 17, 7, "Don't put ketchup on a hot dog", "Hot Dog" },
                    { 18, 3, "You should eat this with a fork", "Meatball Sub" },
                    { 11, 4, "You're either with it or against it", "Egg Salad" },
                    { 19, 0, "Yum olives", "Muffuletta" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Name" },
                values: new object[,]
                {
                    { 21, "Smells Like Garbage" },
                    { 22, "So Much Gluten You're Going to Develop a Gluten Allergy" },
                    { 23, "Sour" },
                    { 24, "Straight from Grandma's Kitchen" },
                    { 25, "Straight outta Compton" },
                    { 26, "Sweet" },
                    { 27, "Terrible" },
                    { 31, "Vegan" },
                    { 29, "Turkish" },
                    { 30, "Two-faced" },
                    { 32, "Vegetarian" },
                    { 33, "Vietnamese" },
                    { 34, "We Ain't Got Time To Eat (Great for Smoothies)" },
                    { 35, "Would Only Feed To My Worst Enemy" },
                    { 36, "Wow, I Can't Believe It's Got Gluten" },
                    { 20, "Savory" },
                    { 28, "The Heart Wants Mayo" },
                    { 19, "People Who Go To Epicodus Would Eat This" },
                    { 9, "Good mineworker faire" },
                    { 17, "Open-faced" },
                    { 37, "Funny, But Not Really" },
                    { 1, "Basically a dog turd between two pieces of bread" },
                    { 2, "Building materials" },
                    { 3, "Closed-faced" },
                    { 4, "Delicious" },
                    { 5, "Dog Food" },
                    { 6, "Face-Off" },
                    { 18, "Pasta" },
                    { 7, "Fork Necessary" },
                    { 10, "Greek" },
                    { 11, "Japanese Sando" },
                    { 12, "John Travolta's Favorite" },
                    { 13, "Lots of Gluten" },
                    { 14, "Mexican" },
                    { 15, "Nic Cage Approved" },
                    { 16, "No-faced" },
                    { 8, "Gluten-Free" },
                    { 38, "" }
                });

            migrationBuilder.InsertData(
                table: "SandwichesIngredients",
                columns: new[] { "SandwichIngredientId", "IngredientId", "SandwichId" },
                values: new object[,]
                {
                    { 1, 22, 1 },
                    { 121, 5, 28 },
                    { 122, 11, 28 },
                    { 123, 17, 28 },
                    { 124, 22, 28 },
                    { 125, 25, 28 },
                    { 126, 31, 28 },
                    { 127, 35, 28 },
                    { 128, 38, 28 },
                    { 129, 49, 28 },
                    { 130, 50, 28 },
                    { 131, 49, 29 },
                    { 132, 10, 29 },
                    { 133, 31, 29 },
                    { 134, 11, 29 },
                    { 135, 59, 29 },
                    { 136, 94, 29 },
                    { 137, 108, 30 },
                    { 138, 109, 30 },
                    { 139, 59, 30 },
                    { 120, 4, 28 },
                    { 119, 122, 28 },
                    { 118, 1, 28 },
                    { 117, 36, 27 },
                    { 97, 92, 22 },
                    { 98, 46, 23 },
                    { 99, 25, 23 },
                    { 100, 10, 23 },
                    { 101, 33, 23 },
                    { 102, 32, 24 },
                    { 103, 93, 24 },
                    { 104, 51, 24 },
                    { 105, 14, 24 },
                    { 140, 11, 31 },
                    { 106, 49, 25 },
                    { 108, 35, 25 },
                    { 109, 31, 25 },
                    { 110, 45, 25 },
                    { 111, 17, 25 },
                    { 112, 52, 26 },
                    { 113, 52, 26 },
                    { 114, 52, 26 },
                    { 115, 38, 26 },
                    { 116, 55, 27 },
                    { 107, 63, 25 },
                    { 141, 31, 31 },
                    { 142, 56, 31 },
                    { 143, 95, 32 },
                    { 168, 22, 38 },
                    { 169, 50, 39 },
                    { 170, 103, 39 },
                    { 171, 104, 39 },
                    { 172, 105, 39 },
                    { 173, 106, 39 },
                    { 174, 31, 39 },
                    { 175, 100, 39 },
                    { 176, 45, 39 },
                    { 167, 1, 38 },
                    { 177, 63, 40 },
                    { 179, 111, 40 },
                    { 180, 112, 40 },
                    { 181, 113, 40 },
                    { 182, 114, 40 },
                    { 183, 92, 40 },
                    { 184, 46, 41 },
                    { 185, 115, 41 },
                    { 186, 116, 41 },
                    { 187, 117, 41 },
                    { 178, 107, 40 },
                    { 96, 91, 22 },
                    { 166, 102, 37 },
                    { 164, 35, 37 },
                    { 144, 96, 32 },
                    { 145, 97, 32 },
                    { 146, 98, 33 },
                    { 147, 16, 33 },
                    { 148, 83, 33 },
                    { 149, 14, 34 },
                    { 150, 13, 34 },
                    { 151, 38, 34 },
                    { 152, 35, 34 },
                    { 165, 94, 37 },
                    { 153, 91, 34 },
                    { 155, 14, 35 },
                    { 156, 58, 35 },
                    { 157, 38, 35 },
                    { 158, 99, 36 },
                    { 159, 35, 36 },
                    { 160, 1, 36 },
                    { 161, 110, 36 },
                    { 162, 73, 37 },
                    { 163, 101, 37 },
                    { 154, 51, 34 },
                    { 188, 16, 41 },
                    { 95, 90, 22 },
                    { 93, 88, 22 },
                    { 26, 78, 6 },
                    { 27, 35, 6 },
                    { 28, 79, 6 },
                    { 29, 80, 6 },
                    { 30, 81, 7 },
                    { 31, 110, 7 },
                    { 32, 82, 7 },
                    { 33, 83, 8 },
                    { 34, 120, 8 },
                    { 35, 22, 8 },
                    { 36, 83, 9 },
                    { 37, 22, 9 },
                    { 38, 120, 9 },
                    { 39, 19, 9 },
                    { 40, 38, 9 },
                    { 41, 84, 10 },
                    { 42, 123, 10 },
                    { 43, 110, 10 },
                    { 44, 17, 10 },
                    { 25, 11, 6 },
                    { 24, 77, 5 },
                    { 23, 76, 5 },
                    { 22, 8, 5 },
                    { 2, 68, 1 },
                    { 3, 69, 1 },
                    { 4, 9, 1 },
                    { 5, 70, 1 },
                    { 6, 35, 1 },
                    { 7, 92, 1 },
                    { 8, 4, 2 },
                    { 9, 31, 2 },
                    { 10, 100, 2 },
                    { 45, 21, 11 },
                    { 11, 35, 2 },
                    { 13, 119, 3 },
                    { 14, 31, 3 },
                    { 15, 100, 3 },
                    { 16, 110, 3 },
                    { 17, 1, 3 },
                    { 18, 73, 4 },
                    { 19, 110, 4 },
                    { 20, 74, 4 },
                    { 21, 75, 5 },
                    { 12, 71, 3 },
                    { 46, 31, 11 },
                    { 47, 56, 11 },
                    { 48, 84, 12 },
                    { 73, 119, 17 },
                    { 74, 38, 17 },
                    { 75, 48, 17 },
                    { 76, 47, 17 },
                    { 77, 25, 18 },
                    { 78, 36, 18 },
                    { 79, 33, 18 },
                    { 80, 89, 18 },
                    { 81, 12, 19 },
                    { 72, 121, 17 },
                    { 82, 40, 19 },
                    { 84, 22, 19 },
                    { 85, 58, 19 },
                    { 86, 88, 20 },
                    { 87, 110, 20 },
                    { 88, 59, 20 },
                    { 89, 30, 20 },
                    { 90, 63, 21 },
                    { 91, 41, 21 },
                    { 92, 28, 21 },
                    { 83, 50, 19 },
                    { 94, 89, 22 },
                    { 71, 31, 16 },
                    { 69, 58, 16 },
                    { 49, 85, 12 },
                    { 50, 19, 12 },
                    { 51, 86, 12 },
                    { 52, 32, 13 },
                    { 53, 14, 13 },
                    { 54, 53, 13 },
                    { 55, 35, 13 },
                    { 56, 4, 13 },
                    { 57, 63, 14 },
                    { 70, 60, 16 },
                    { 58, 8, 14 },
                    { 60, 84, 15 },
                    { 61, 100, 15 },
                    { 62, 110, 15 },
                    { 63, 124, 15 },
                    { 64, 87, 15 },
                    { 65, 64, 16 },
                    { 66, 22, 16 },
                    { 67, 35, 16 },
                    { 68, 38, 16 },
                    { 59, 10, 14 },
                    { 189, 118, 41 }
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
