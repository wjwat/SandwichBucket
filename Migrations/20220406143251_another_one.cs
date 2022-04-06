using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SandwichBucket.Migrations
{
    public partial class another_one : Migration
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
                name: "IngredientsTags",
                columns: table => new
                {
                    IngredientTagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientsTags", x => x.IngredientTagId);
                    table.ForeignKey(
                        name: "FK_IngredientsTags_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "IngredientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientsTags_Tags_TagId",
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
                    { 1, "oof ouch owee", "A Nail" },
                    { 94, "Like Chris Rock at the Oscars.", "Roast Vegetables" },
                    { 93, "Also known as 'I've got hurt feelings meat' or 'toasted conflict'.", "Roast Beef" },
                    { 92, "What is relish?", "Relish" },
                    { 91, "These onions were made famous after starring in an action comedy with Bruce Willis.", "Red Onion" },
                    { 90, "Benjamin Button's aged cheese.", "Queso Fresco" },
                    { 89, "'I like my butt rubbed and my pork pulled' - Porky Pig", "Pulled Pork" },
                    { 88, "Made in solidary in Provo, Utah.", "Provolone" },
                    { 87, "Uncured ham, sliced as thin as Ryan's wallet.", "Prosciutto" },
                    { 86, "boil 'em, mash 'em, stick 'em in a stew", "Potato" },
                    { 85, "Take a bagel and smash it flat, like paper.", "Pita" },
                    { 84, "Not from pine trees.", "Pineapple" },
                    { 83, "Also referred to as Pie Crusties in groups, frequently panhandle and tell you your life is a lie.", "Pie Crust" },
                    { 82, "The last name of the family across the street from Bob's business.", "Pesto" },
                    { 95, "Different than raw, burnt, or even flamebroiled.", "Roasted Onions" },
                    { 81, "Elk brand", "Pepperoni" },
                    { 79, "An abomination with a catchy dance.", "PenPineAppleApplePen" },
                    { 78, "Be judged by your selection of this at Costco, by Steve, a passerby. Screw you, Steve! I LIKE JIF. I DON'T NEED MY PEANUT-BUTTER TO BE MADE OUT OF ALMONDS. THAT'S YOUR CHOICE. anyway, its peanuts in butter-form.", "Peanut Butter" },
                    { 77, "Meat paste, also a way to refer to someone's head.", "Pate" },
                    { 76, "It has lots of layers, like Shrek.", "Onions" },
                    { 75, "Vegetable Oil for the classy.", "Olive Oil" },
                    { 74, "I'm a tomato poser.", "Olive Bruschetta" },
                    { 73, "Brown spread. Don't worry, it's hazelnut and cocoa.", "Nutella" },
                    { 72, "Ninja Turtles favorite pizza topping after gang-fight snack.", "Nacho Cheese" },
                    { 71, "Scooby's stumped on this one too.", "Mystery Meat" },
                    { 70, "A zesty yellow fellow that isn't at all mellow, and can make you bellow.", "Mustard" },
                    { 69, "Best from Water Buffalo. Mama Mia!", "Mozzarella Cheese" },
                    { 68, "It is possible to have delish bologna, yes just believe. ET Phone Home.", "Mortadella" },
                    { 67, "Taste like freshly cut grass. Looks like freshly cut grass. is freshly cut grass", "MicroGreens" },
                    { 80, "Like peppers, but from the east coast.", "PepperCini" },
                    { 66, "Boy, sure is nice not havin' Shake around.", "MeatBalls" },
                    { 96, "Mmmm burnt is the best.", "Roasted Red Peppers" },
                    { 98, "Xena the Warrior Princess's favorite meat, flies well when thrown.", "Salami" },
                    { 127, "No expiration date. Taste test first. Made with love.", "Your Grandma's Breadbox Bread" },
                    { 126, "Cheese from our most music-festival-attending ox.", "Yak Cheese" },
                    { 125, "Fiber supplement.", "Wood" },
                    { 124, "Bread, just disputably healthier for you.", "Whole Wheat Bread" },
                    { 123, "The most boring of bread, will likely lecture you on politics or something.", "White Bread" },
                    { 122, "Old wine for kids!", "Vinegar" },
                    { 121, "I'm better than Marmite", "Vegemite" },
                    { 120, "Yes it's spelled right.", "Tzatziki" },
                    { 119, "This popular fish is said to be able to take down a lion.", "Tuna" },
                    { 118, "Little dried, cut, burrito casings.", "Tortillas" },
                    { 117, "Best home grown, do not store in fridge.", "Tomato" },
                    { 116, "Low/no sodium, solidified ketchup miniature discuses (frisbees)", "ToeMaToe" },
                    { 115, "Generic Name for Bic Mac Sauce.", "Thousand Island Dressing" },
                    { 97, "Good for your fingers", "Salad" },
                    { 114, "Thick like you like it. Make sure to mix the oil in first.", "Tahini" },
                    { 112, "The best cheese ever, and nobody can poke holes in that fact.", "Swiss Cheese" },
                    { 111, "Straight up, raw, uncut, not laced with nothin'.", "Sugar" },
                    { 110, "Created from slightly used yoga mats from the dance studio across the street.", "Subway Yoga Mat Bread" },
                    { 109, "Eat it raw, else the internet will have an opinion about it.", "Steak" },
                    { 108, "A-1 or Heinz-57? YOU DECIDE!?@?", "Steak Sauce" },
                    { 107, "Soggy lettuce, produces beachball-sized biceps when consumed.", "Spinach" },
                    { 106, "PastaFarians be craving those noodly apendages.", "Spaghetti" },
                    { 105, "Sourful and powerful, this bread has a strong opinion on every. Damn. Thing.", "Sourdough Bread" },
                    { 103, "Allergies be damned!!", "Seitan" },
                    { 102, "You don't want to know. Seriously, don't look it up.", "Schmaltz" },
                    { 101, "(Insert Europeon Joke Here)", "Sauerkraut" },
                    { 100, "Not recommended for witches consumption.", "Salt" },
                    { 99, "Green, Red, Mango, Chutney, a mystery flavor.", "Salsa" },
                    { 113, "Hamburger + Spices = Taco Meat", "Taco Meat" },
                    { 65, "Spread for your bread.", "Mayo" },
                    { 104, "Is this appropriation?", "Slaw" },
                    { 63, "A trench in the ocean... Not sure what this has to do with sandwiches.", "Marinara" },
                    { 29, "Cows after a Korn festival, pairs well with cabbage", "Corned Beef" },
                    { 28, "Great in salsa, bomb in sandwiches.", "Cilantro" },
                    { 27, "Just as much to say as it is to eat.", "Ciabatta Roll" },
                    { 26, "The holes are where the flavor is!", "Chocolate Bread With Holes" },
                    { 25, "DO not eat while dry.", "Chickpeas" },
                    { 24, "A non-confrontational bird.", "Chicken" },
                    { 22, "Used in bombs and pies, but a sweet addition to any sundae or sandwich.", "Cherries" },
                    { 21, "The classiest way to enjoy cheese.", "Cheezewhiz" },
                    { 20, "who cares what kind just eat it already", "Cheese" },
                    { 19, "A mild-mannered cheese dyed a less intimidating color.", "Cheddar Cheese" },
                    { 18, "Add some crunch to your lunch!", "Celery" },
                    { 17, "Human noses. If humans were snow-people.", "Carrot" },
                    { 16, "Nearly burnt is the best bestest.", "Caramelized Onions" },
                    { 30, "Cranberry jelly is so fancy its considered a sauce", "Cranberry Sauce" },
                    { 15, "Try is spicy!", "Capicola" },
                    { 13, "Don't think outside it. Think it.", "Bun" },
                    { 12, "Flour, Water, Salt, Yeast", "Bread" },
                    { 11, "Ordinary, crumbly cheese if you're colorblind.", "Blue Cheese" },
                    { 10, "1776 substituted with peppers instead of liberty.", "Bell Peppers" },
                    { 9, "Far South BBQ", "Barbacoa" },
                    { 8, "Request them without pajamas, for a bananaier taste.", "Bananas" },
                    { 7, "It's nonsense.", "Baloney" },
                    { 6, "You can't spell 'happiness' without 'bacon'. well, you can. you'd just be miserable spelling it.", "Bacon" },
                    { 5, "It's hip 'vocado. And $9 a cut.", "Avocado" },
                    { 4, "Why, just why?", "Arugula" },
                    { 3, "I'm better than both Vegemite or Marmite.", "Anchovy Paste" },
                    { 2, "O'er the land of the cheese and the home of the brave.", "American Cheese" },
                    { 64, "Im better than Vegemite", "Marmite" },
                    { 14, "You best believe this is butter.", "Butter" },
                    { 31, "What's that in the sky? It's a cheese? It's a cream? It's a cream cheese!", "Cream Cheese" },
                    { 23, "It's better than the Chicken Die-r.", "Chicken Liver" },
                    { 33, "Winter radishes is coming.", "Daikon" },
                    { 62, "Bread, inspired by Vincent van Gogh.", "Marbled Rye Bread" },
                    { 61, "Kissy Kissy, Mwawh!", "Lingua" },
                    { 60, "Lil' for your lil' tummies.", "Lil'Smokies" },
                    { 59, "A green blanket, enjoyed by rabbits.", "Lettuce" },
                    { 58, "Boom na da mmm dum na ema Da boom na da mmm dum na ema", "Korned Beef" },
                    { 57, "A type of karate, filled with vegetables.", "KimChi" },
                    { 32, "Old pickles, if they aged like Benjamin Button.", "Cucumber" },
                    { 55, "If fruit and sugar got into a car accident and neither were wearing a seatbelt.", "Jam Jellies" },
                    { 54, "Spicy like AZ.", "Jalapeno" },
                    { 53, "It's cold.", "Ice Cream" },
                    { 52, "Pairs well with Avocado bread, thick rimmed glasses and The Shins.", "Hummus" },
                    { 51, "*will smith voice* Ah, That's Hawt", "Hot Sauce" },
                    { 50, "Some(most) like it hot.", "Hot Dog" },
                    { 49, "How cool is that horse? Eh. That horse is rad-ish.", "Horseradish" },
                    { 48, "During the day, a columnist. At night, a hero roll.", "Hoagie Bun" },
                    { 56, "Along with chocolate, makes for an excellent blood substitute with film.", "Ketchup" },
                    { 46, "A smooth, creamy, supple-in-texture cheese. Can't have a party without havarti.", "Havarti Cheese" },
                    { 47, "Ya know like that cute costume", "HawtDwag" },
                    { 35, "If cucumbers were witches.", "Dill Pickles" },
                    { 36, "Rare, hard to find ..dirt. Found in most sandwiches in very small portions.", "Dirt" },
                    { 38, "Like wet turkey, only dry.", "Dry Turkey" },
                    { 39, "There's fried egg, boiled egg, sliced egg, Easter Egg, baked egg, salted egg, raw egg, egg burger, salsa'd egg, egg sandwich, egg salad, salad egg, egg fried rice, chicken egg, .... That-that's about it.", "Egg" },
                    { 40, "Creamy delish on a cracker.", "Goat Cheese" },
                    { 37, "More dough, more problems.", "Dough" },
                    { 41, "You get it right?", "Green Sauce" },
                    { 42, "What? It's basically a less processed HawtDog. All Organic!", "Haggis" },
                    { 43, "Ham. Yup.", "Ham" },
                    { 44, "The ideal bun for a hamburger.", "Hamburger Bun" },
                    { 45, "The ideal hamburger for a hamburger bun.", "Hamburger" },
                    { 34, "Please don't put this on your sandwich. It tastes best by itself!", "Daniel Angerer's Human Milk Cheese" }
                });

            migrationBuilder.InsertData(
                table: "Sandwiches",
                columns: new[] { "SandwichId", "Alignment", "Description", "Name" },
                values: new object[,]
                {
                    { 26, 0, "You should eat this with a fork", "Meatball Sub" },
                    { 33, 7, "Who cares Ryan does!", "Reuben" },
                    { 27, 7, "Yum olives", "Muffuletta" },
                    { 28, 5, "Hand eating at its finest", "Pastie" },
                    { 29, 2, "That's it", "PB&J" },
                    { 30, 5, "Fold it", "Pizza" },
                    { 31, 4, "This is making me hungry", "Pulled Pork" },
                    { 32, 1, "From a delicious sky", "Raining Sauce" },
                    { 25, 7, "Your mom's favorite", "It's My Sandwich In a Box" },
                    { 39, 5, "Maybe the best of all sandwiches", "Taco" },
                    { 35, 2, "No please don't 'member this horror", "Salad Fingers" },
                    { 36, 3, "666", "Seitan" },
                    { 37, 7, "Somehow this is a sandwich", "Spaghetti and Meatballs" },
                    { 38, 0, "An american sandwich", "Sub" },
                    { 40, 7, "yum", "Torta" },
                    { 41, 7, "Chicken of the sea", "Tuna Salad" },
                    { 42, 2, "(A Sandwich (cow's head))", "What's In The Box?" },
                    { 43, 4, "Some dirt between two 2 x 4s", "Wood" },
                    { 24, 0, "Who put it there?", "Ice Cream Sandwich" },
                    { 34, 5, "Gotta be with horsey sauce", "Roast Beef" },
                    { 23, 6, "Don't put ketchup on a hot dog", "Hot Dog" },
                    { 9, 6, "Damn fine", "Croque-monsieur" },
                    { 21, 5, "GYYY-ROOOE", "Gyro" },
                    { 22, 5, "Some words", "Ham and Swiss" },
                    { 1, 8, "Yes, All Day", "All Day I Dream About Sandwich" },
                    { 3, 2, "Classic", "BLT" },
                    { 4, 5, "Watch out for the burglar", "Cheeseburger" },
                    { 5, 1, "Chop up", "Cheesesteak" },
                    { 6, 4, "Damn fine", "CherryPie" },
                    { 7, 1, "Chicken of the land", "Chicken Salad" },
                    { 8, 5, "Who am I?", "Chopped Liver" },
                    { 10, 0, "All kinds of pork", "Cubano" },
                    { 2, 2, "Hell yes", "Banh Mi" },
                    { 12, 1, "No More, No less", "Eat 16 Sandwiches" },
                    { 11, 5, "Veal or Beef??", "Doner kebab" },
                    { 18, 4, "Turkey and slaw baby", "Georgia Reuben" },
                    { 17, 8, "Are you feeling like it?", "Freak On A Sandwich" },
                    { 19, 4, "(A Sandwich)", "Give Me Something To Eat" },
                    { 15, 8, "Chickpeas or Garbanzos?", "Falafel" },
                    { 14, 2, "I'll get mine before you get yours", "F*ck You, Eat Me" },
                    { 13, 1, "You're either with it or against it", "Egg Salad" },
                    { 16, 1, "Nu-sandwich for sandwich-heads", "Falling Away From Meat" },
                    { 20, 8, "Mayo or Butter???", "Grilled Cheese" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Name" },
                values: new object[,]
                {
                    { 21, "Smells Like Garbage" },
                    { 27, "Terrible" },
                    { 22, "So Much Gluten You're Going to Develop a Gluten Allergy" },
                    { 23, "Sour" },
                    { 24, "Straight from Grandma's Kitchen" },
                    { 25, "Straight outta Compton" },
                    { 26, "Sweet" },
                    { 31, "Vegan" },
                    { 29, "Turkish" },
                    { 30, "Two-faced" },
                    { 32, "Vegetarian" },
                    { 33, "Vietnamese" },
                    { 34, "We Ain't Got Time To Eat (Great for Smoothies)" },
                    { 35, "Would Only Feed To My Worst Enemy" },
                    { 20, "Savory" },
                    { 28, "The Heart Wants Mayo" },
                    { 19, "People Who Go To Epicodus Would Eat This" },
                    { 8, "Gluten-Free" },
                    { 17, "Open-faced" },
                    { 36, "Wow, I Can't Believe It's Got Gluten" },
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
                    { 9, "Good mineworker faire" },
                    { 37, "Funny, But Not Really" }
                });

            migrationBuilder.InsertData(
                table: "SandwichesIngredients",
                columns: new[] { "SandwichIngredientId", "IngredientId", "SandwichId" },
                values: new object[,]
                {
                    { 1, 58, 1 },
                    { 125, 78, 29 },
                    { 126, 55, 29 },
                    { 127, 37, 30 },
                    { 128, 69, 30 },
                    { 129, 81, 30 },
                    { 130, 84, 30 },
                    { 131, 54, 30 },
                    { 132, 89, 31 },
                    { 133, 48, 31 },
                    { 124, 123, 29 },
                    { 134, 19, 31 },
                    { 136, 109, 32 },
                    { 137, 108, 32 },
                    { 138, 65, 32 },
                    { 139, 99, 32 },
                    { 140, 51, 32 },
                    { 141, 62, 33 },
                    { 142, 115, 33 },
                    { 143, 101, 33 },
                    { 144, 58, 33 },
                    { 135, 63, 31 },
                    { 123, 57, 28 },
                    { 122, 113, 28 },
                    { 121, 76, 28 },
                    { 100, 70, 23 },
                    { 101, 92, 23 },
                    { 102, 91, 23 },
                    { 103, 26, 24 },
                    { 104, 53, 24 },
                    { 105, 89, 25 },
                    { 106, 16, 25 },
                    { 107, 96, 25 },
                    { 108, 40, 25 },
                    { 109, 31, 25 },
                    { 110, 4, 25 },
                    { 111, 48, 26 },
                    { 112, 66, 26 },
                    { 113, 63, 26 },
                    { 114, 69, 26 },
                    { 115, 27, 27 },
                    { 116, 74, 27 },
                    { 117, 98, 27 },
                    { 118, 43, 27 },
                    { 119, 112, 27 },
                    { 120, 37, 28 },
                    { 145, 93, 34 },
                    { 99, 13, 23 },
                    { 146, 123, 34 },
                    { 148, 59, 34 },
                    { 174, 93, 39 },
                    { 175, 19, 39 },
                    { 176, 59, 39 },
                    { 177, 24, 39 },
                    { 178, 113, 39 },
                    { 179, 99, 39 },
                    { 180, 118, 40 },
                    { 181, 72, 40 },
                    { 182, 113, 40 },
                    { 173, 98, 38 },
                    { 183, 24, 41 },
                    { 185, 107, 41 },
                    { 186, 123, 42 },
                    { 187, 61, 42 },
                    { 188, 9, 42 },
                    { 189, 90, 42 },
                    { 190, 95, 42 },
                    { 191, 41, 42 },
                    { 192, 54, 42 },
                    { 193, 125, 43 },
                    { 184, 59, 41 },
                    { 172, 93, 38 },
                    { 171, 70, 38 },
                    { 170, 65, 38 },
                    { 149, 88, 34 },
                    { 150, 32, 34 },
                    { 151, 97, 35 },
                    { 152, 56, 35 },
                    { 153, 71, 35 },
                    { 154, 40, 35 },
                    { 155, 103, 36 },
                    { 156, 103, 36 },
                    { 157, 103, 36 },
                    { 158, 70, 36 },
                    { 159, 106, 37 },
                    { 160, 66, 37 },
                    { 161, 2, 38 },
                    { 162, 5, 38 },
                    { 163, 6, 38 },
                    { 164, 10, 38 },
                    { 165, 24, 38 },
                    { 166, 32, 38 },
                    { 167, 43, 38 },
                    { 168, 48, 38 },
                    { 169, 59, 38 },
                    { 147, 65, 34 },
                    { 194, 36, 43 },
                    { 98, 47, 23 },
                    { 96, 116, 22 },
                    { 27, 111, 6 },
                    { 28, 24, 7 },
                    { 29, 8, 7 },
                    { 30, 65, 7 },
                    { 31, 18, 7 },
                    { 32, 100, 7 },
                    { 33, 23, 8 },
                    { 34, 76, 8 },
                    { 35, 102, 8 },
                    { 26, 22, 6 },
                    { 36, 12, 9 },
                    { 38, 43, 9 },
                    { 39, 12, 10 },
                    { 40, 43, 10 },
                    { 41, 20, 10 },
                    { 42, 35, 10 },
                    { 43, 70, 10 },
                    { 44, 85, 11 },
                    { 45, 71, 11 },
                    { 46, 76, 11 },
                    { 37, 20, 9 },
                    { 25, 14, 6 },
                    { 24, 83, 6 },
                    { 23, 21, 5 },
                    { 2, 112, 1 },
                    { 3, 70, 1 },
                    { 4, 43, 2 },
                    { 5, 28, 2 },
                    { 6, 77, 2 },
                    { 7, 17, 2 },
                    { 8, 33, 2 },
                    { 9, 65, 2 },
                    { 10, 54, 2 },
                    { 11, 6, 3 },
                    { 12, 59, 3 },
                    { 13, 117, 3 },
                    { 14, 65, 3 },
                    { 15, 45, 4 },
                    { 16, 13, 4 },
                    { 17, 59, 4 },
                    { 18, 117, 4 },
                    { 19, 76, 4 },
                    { 20, 2, 4 },
                    { 21, 109, 5 },
                    { 22, 76, 5 },
                    { 47, 32, 11 },
                    { 97, 59, 22 },
                    { 48, 2, 12 },
                    { 50, 39, 13 },
                    { 76, 104, 18 },
                    { 77, 65, 18 },
                    { 78, 6, 18 },
                    { 79, 60, 19 },
                    { 80, 65, 19 },
                    { 81, 2, 19 },
                    { 82, 76, 19 },
                    { 83, 123, 20 },
                    { 84, 14, 20 },
                    { 75, 58, 18 },
                    { 85, 19, 20 },
                    { 87, 117, 21 },
                    { 88, 76, 21 },
                    { 89, 86, 21 },
                    { 90, 120, 21 },
                    { 91, 124, 22 },
                    { 92, 43, 22 },
                    { 93, 65, 22 },
                    { 94, 70, 22 },
                    { 95, 112, 22 },
                    { 86, 85, 21 },
                    { 74, 62, 18 },
                    { 73, 101, 17 },
                    { 72, 84, 17 },
                    { 51, 59, 13 },
                    { 52, 107, 13 },
                    { 53, 98, 14 },
                    { 54, 15, 14 },
                    { 55, 68, 14 },
                    { 56, 75, 14 },
                    { 57, 122, 14 },
                    { 58, 59, 14 },
                    { 59, 117, 14 },
                    { 60, 88, 14 },
                    { 61, 85, 15 },
                    { 62, 25, 15 },
                    { 63, 35, 15 },
                    { 64, 114, 15 },
                    { 65, 94, 16 },
                    { 66, 31, 16 },
                    { 67, 12, 16 },
                    { 68, 58, 17 },
                    { 69, 29, 17 },
                    { 70, 70, 17 },
                    { 71, 65, 17 },
                    { 49, 43, 12 },
                    { 195, 1, 43 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientsTags_IngredientId",
                table: "IngredientsTags",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientsTags_TagId",
                table: "IngredientsTags",
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
                name: "IngredientsTags");

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
