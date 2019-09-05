using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACBingo
{
    class GoalData
    {
        private static readonly CodeInfo[] CodeInfoArray =
        {
            new CodeInfo("Catch a Grasshopper",                                 1,  "Insects",      "All",  false, true),
            new CodeInfo("Catch 4 diff. Insects with 'Beetle' in their name",   1,  "Insects",      "All",  false, true),
            new CodeInfo("Catch an Ant and Cockroach",                          1,  "Insects",      "All",  false, true),
            new CodeInfo("Catch 3 diff. Insects with 'Dragonfly' in their name", 1,  "Insects",      "All",  false, true),
            new CodeInfo("Catch 3 diff. Insects with 'Butterfly' in their name", 1,  "Insects",      "All",  false, true),
            new CodeInfo("Catch a Spider",                                      2,  "Insects",      "All",  false, true),
            new CodeInfo("Catch a Water Beetle",                                2,  "Insects",      "e+",   false, true),
            new CodeInfo("Catch an Insect with 'Crab' in their name",           2,  "Insects",      "e+",   false, true),
            new CodeInfo("Catch 4 diff. Insects with 'Cicada' in their name",   2,  "Insects",      "All",  false, true),
            new CodeInfo("Have 10 diff. Insects in your encyclopedia",          2,  "Insects",      "All",  false, true),
            new CodeInfo("Catch a Giant Beetle",                                3,  "Insects",      "All",  false, true),
            new CodeInfo("Catch a Purple Butterfly",                            3,  "Insects",      "All",  false, true),
            new CodeInfo("Catch a Bagworm",                                     3,  "Insects",      "All",  false, true),
            new CodeInfo("Catch 2 Bees",                                        3,  "Insects",      "All",  false, true),
            new CodeInfo("Catch 3 Snails",                                      3,  "Insects",      "All",  false, true),
            new CodeInfo("Catch 4 diff. Insects with 'Cricket' in their name",  3,  "Insects",      "All",  false, true),
            new CodeInfo("Catch a Crab and a Hermit Crab",                      4,  "Insects",      "e+",   false, true),
            new CodeInfo("Have 20 diff. Insects in your encyclopedia",          4,  "Insects",      "All",  false, true),
            new CodeInfo("Catch a Banded Dragonfly",                            5,  "Insects",      "All",  false, true),
            new CodeInfo("Have 35 diff. Insects in your encyclopedia",          7,  "Insects",      "All",  false, true),
            new CodeInfo("Catch a Flea",                                        7,  "Insects",      "e+",   false, true),
            new CodeInfo("Catch 10 diff. Insects with 'Beetle' in their name",  7,  "Insects",      "e+",   false, true),

            new CodeInfo("Catch a Loach",                                       1,  "Fish",         "All",  false, true),
            new CodeInfo("Catch a Dab or Olive Flounder",                       1,  "Fish",         "e+",   false, true),
            new CodeInfo("Catch an Octopus or Squid",                           1,  "Fish",         "e+",   false, true),
            new CodeInfo("Catch a Jellyfish and Horse Mackerel",                1,  "Fish",         "e+",   false, true),
            new CodeInfo("Win an item from the Summer Fishing Tourney",         1,  "Fish",         "All",  false, true),
            new CodeInfo("Win an item from the Autumn Fishing Tourney",         1,  "Fish",         "All",  false, true),
            new CodeInfo("Catch both types of Salmon",                          2,  "Fish",         "All",  false, true),
            new CodeInfo("Catch a Rainbow Trout and Catfish",                   2,  "Fish",         "All",  false, true),
            new CodeInfo("Catch a Dace and Barbel Steed",                       2,  "Fish",         "All",  false, true),
            new CodeInfo("Catch a Coelacanth",                                  2,  "Fish",         "AC",   false, true),
            new CodeInfo("Have 10 diff. fish in your encyclopedia",             2,  "Fish",         "All",  false, true),
            new CodeInfo("Catch either type of Goldfish",                       2,  "Fish",         "All",  false, true),
            new CodeInfo("Catch 4 diff. types of Bass",                         3,  "Fish",         "All",  false, true),
            new CodeInfo("Get a piece of Trash",                                3,  "Fish",         "AC",   false, true),
            new CodeInfo("Get a piece of Trash",                                5,  "Fish",         "e+",   false, true),
            new CodeInfo("Catch a Bitterling and Guppy",                        3,  "Fish",         "All",  false, true),
            new CodeInfo("Catch an Arapaima",                                   4,  "Fish",         "All",  false, true),
            new CodeInfo("Catch a Stringfish",                                  4,  "Fish",         "All",  false, true),
            new CodeInfo("Catch a Piranha",                                     4,  "Fish",         "All",  false, true),
            new CodeInfo("Catch a Coelacanth",                                  4,  "Fish",         "e+",   false, true),
            new CodeInfo("Catch a Koi",                                         4,  "Fish",         "All",  false, true),
            new CodeInfo("Catch 3 Brook Trout",                                 4,  "Fish",         "All",  false, true),
            new CodeInfo("Catch both types of Goldfish",                        4,  "Fish",         "All",  false, true),
            new CodeInfo("Have 20 diff. fish in your encyclopedia",             4,  "Fish",         "All",  false, true),
            new CodeInfo("Win a Fishing Tourney",                               4,  "Fish",         "All",  false, true),
            new CodeInfo("Catch an Arowana",                                    5,  "Fish",         "All",  false, true),
            new CodeInfo("Catch a Piranha",                                     5,  "Fish",         "All",  false, true),
            new CodeInfo("Catch an Angelfish",                                  5,  "Fish",         "All",  false, true),
            new CodeInfo("Catch 5 diff. types of Ocean Fish",                   5,  "Fish",         "AC",   false, true),
            new CodeInfo("Catch 7 diff. types of Ocean Fish",                   5,  "Fish",         "e+",   false, true),
            new CodeInfo("Catch 4 diff. fish that start with 'Large' or 'Giant'", 6,  "Fish",         "All",  false, true),
            new CodeInfo("Catch 10 diff. types of Ocean Fish",                  7,  "Fish",         "e+",   false, true),
            new CodeInfo("Catch 3 diff. fish that begin with 'A'",              7,  "Fish",         "All",  false, true),

            new CodeInfo("Get an item from the Blue Series",                    3,  "Series",       "All",  false, false),
            new CodeInfo("Get an item from the Cabana Series",                  3,  "Series",       "All",  false, false),
            new CodeInfo("Get an item from the Cabin Series",                   3,  "Series",       "All",  false, false),
            new CodeInfo("Get an item from the Classic Series",                 3,  "Series",       "All",  false, false),
            new CodeInfo("Get an item from the Exotic Series",                  3,  "Series",       "All",  false, false),
            new CodeInfo("Get an item from the Green Series",                   3,  "Series",       "All",  false, false),
            new CodeInfo("Get an item from the Kiddie Series",                  3,  "Series",       "All",  false, false),
            new CodeInfo("Get an item from the Lovely Series",                  3,  "Series",       "All",  false, false),
            new CodeInfo("Get an item from the Modern Series",                  3,  "Series",       "All",  false, false),
            new CodeInfo("Get an item from the Ranch Series",                   3,  "Series",       "All",  false, false),
            new CodeInfo("Get an item from the Regal Series",                   3,  "Series",       "All",  false, false),
            new CodeInfo("Complete the 'necessities' bonus for the HRA",        4,  "Series",       "AC",   false, false),
            new CodeInfo("Complete the 'necessities' bonus for the HRA",        6,  "Series",       "e+",   false, false),
            new CodeInfo("Get an item from each non-holiday Series",            7,  "Series",       "All",  false, false),

            new CodeInfo("Get a furniture item from the Backyard Theme",        3,  "Theme",        "All",  false, false),
            new CodeInfo("Get a furniture item from the Classroom Theme",       3,  "Theme",        "All",  false, false),
            new CodeInfo("Get a furniture item from the Construction Theme",    3,  "Theme",        "All",  false, false),
            new CodeInfo("Get a furniture item from the Boxing Theme",          4,  "Theme",        "All",  false, false),
            new CodeInfo("Get a furniture item from the Space Theme",           4,  "Theme",        "All",  false, false),
            new CodeInfo("Get a furniture item from the Western Theme",         4,  "Theme",        "All",  false, false),
            new CodeInfo("Get a furniture item from the Spa Theme",             5,  "Theme",        "e+",   false, false),
            new CodeInfo("Get a furniture item from the Japanese Theme",        5,  "Theme",        "e+",   false, false),
            new CodeInfo("Complete a Theme",                                    10, "Theme",        "All",  false, false),

            new CodeInfo("Place a Chair in your house",                         2,  "Furniture",    "All",  false, false),
            new CodeInfo("Place a Couch in your house",                         3,  "Furniture",    "All",  false, false),
            new CodeInfo("Place a Bed in your house",                           3,  "Furniture",    "All",  false, false),
            new CodeInfo("Place 3 diff. Festive items in your house",           2,  "Furniture",    "All",  true, true),
            new CodeInfo("Reach level 3 OR obtain 30,000 points in an NES Game",2,  "Furniture",    "e+",   true,  true),
            new CodeInfo("Reach level 3 OR obtain 30,000 points in an NES Game",5,  "Furniture",    "AC",   false, false),
            new CodeInfo("Place a Musical Instrument in your house",            4,  "Furniture",    "All",  false, false),
            new CodeInfo("Place 2 diff. items that play airchecks in your house", 4,  "Furniture",    "All",  false, false),
            new CodeInfo("Place a Bonsai in your house",                        5,  "Furniture",    "All",  false, false),
            new CodeInfo("Get an item that has 'machine' in its name",          5,  "Furniture",    "e+",   false, false),
            new CodeInfo("Place a Fruit Furniture in your house",               5,  "Furniture",    "All",  false, false),
            new CodeInfo("Place a Chess Piece in your house",                   5,  "Furniture",    "All",  false, false),
            new CodeInfo("Ring a Judge's Bell",                                 6,  "Furniture",    "All",  false, false),
            new CodeInfo("Place a Dharma in your house",                        6,  "Furniture",    "e+",   false, false),
            new CodeInfo("Place a Teddy Bear in your house",                    6,  "Furniture",    "All",  false, false),
            new CodeInfo("Place a Cactus in your house",                        6,  "Furniture",    "All",  false, false),
            new CodeInfo("Place a Golf Bag in your house",                      6,  "Furniture",    "All",  false, false),
            new CodeInfo("Place a Piano in your house",                         6,  "Furniture",    "All",  false, false),
            new CodeInfo("Place a Totem Pole in your house",                    6,  "Furniture",    "All",  false, false),
            new CodeInfo("Place a Stone in your house",                         6,  "Furniture",    "All",  false, false),
            new CodeInfo("Place a Kotatsu in your house",                       6,  "Furniture",    "e+",   false, false),
            new CodeInfo("Place a Lucky Cat or Luck Frog in your house",        6,  "Furniture",    "e+",   false, false),
            new CodeInfo("Place a Mario Trophy or Luigi Trophy in your house",  6,  "Furniture",    "All",  false, false),
            new CodeInfo("Place a Robo-Furniture Item in your house",           6,  "Furniture",    "All",  false, false),
            new CodeInfo("Complete a Furniture Set",                            7,  "Furniture",    "All",  false, false),
            new CodeInfo("Place a Toilet in your house",                        7,  "Furniture",    "All",  false, false),
            new CodeInfo("Complete 3 diff. Furniture Sets",                     9,  "Furniture",    "All",  false, false),

            new CodeInfo("Build a Snowman",                                     2,  "Holidays",     "All",  false, true),
            new CodeInfo("Get an item from Franklin",                           2,  "Holidays",     "All",  false, true),
            new CodeInfo("Get an item from Jack",                               3,  "Holidays",     "All",  false, true),
            new CodeInfo("Get an item from Jingle",                             4,  "Holidays",     "All",  false, true),
            new CodeInfo("Get an item from the Snowman",                        5,  "Holidays",     "All",  false, true),
            new CodeInfo("Get a Franklin, Jack, Jingle, and Snowman Item",      7,  "Holidays",     "All",  false, true),

            new CodeInfo("Get an item from Gulliver",                           2,  "Characters",   "All",  false, true),
            new CodeInfo("Get 2 items from Gulliver",                            5,  "Characters",   "All",  false, true),
            new CodeInfo("Get 4 items from Gulliver",                           8,  "Characters",   "All",  false, true),
            new CodeInfo("Get a carpet from Saharah",                           2,  "Characters",   "All",  false, true),
            new CodeInfo("Receive a fortune from Katrina",                      2,  "Characters",   "All",  false, true),
            new CodeInfo("Get a wallpaper from Wendell",                        3,  "Characters",   "All",  false, true),
            new CodeInfo("Get a balloon from Nook's Sale Day",                  3,  "Characters",   "All",  false, true),
            new CodeInfo("Get a Gracie Shirt",                                  3,  "Characters",   "All",  false, true),
            new CodeInfo("Get 3 diff. carpets from Saharah",                    4,  "Characters",   "All",  false, true),
            new CodeInfo("Trip on your face",                                   6,  "Characters",   "All",  false, true),

            new CodeInfo("Get two Tree Models",                                 1,  "Events",       "All",  false, true),
            new CodeInfo("Get the Well Model, Locomotive Model, and Dump Model",1,  "Events",       "All",  false, true),
            new CodeInfo("Get the Tailor Model, Police Model, and Shop Model",  1,  "Events",       "All",  false, true),
            new CodeInfo("Get the Weed Model and a Flower Model",               1,  "Events",       "All",  false, true),
            new CodeInfo("Get the Telescope and Moon",                          1,  "Events",       "All",  false, true),
            new CodeInfo("Get the Angler Trophy and Fishing Trophy",            1,  "Events",       "All",  false, true),
            new CodeInfo("Get the Market Model, Katrina's Tent, and a Station Model",  1, "Events", "All",  false, true),
            new CodeInfo("Enter the Lighthouse",                                2,  "Events",       "All",  false, true),
            new CodeInfo("Get two diff. Flower Models",                         5,  "Events",       "All",  false, false),
            new CodeInfo("Get the Miniature Car and Dolly from Toy Day",        5,  "Events",       "All",  false, false),
            new CodeInfo("Get 10 diff. 'Model' Items",                          5,  "Events",       "All",  false, true),
            new CodeInfo("Get the Lighthouse Model or Chocolates",              5,  "Events",       "All",  true,  true),
            new CodeInfo("Get the Aerobics Radio",                              7,  "Events",       "All",  true,  true),
            new CodeInfo("Get 15 diff. 'Model' Items",                          7,  "Events",       "All",  true,  true),

            new CodeInfo("Fill your inventory with seashells",                  1,  "Tasks",        "All",  true,  true),
            new CodeInfo("Get the Birthday Cake",                               1,  "Tasks",        "All",  true,  true),
            new CodeInfo("Use Medicine to cure a bee sting",                    1,  "Tasks",        "e+",   true,  true),
            new CodeInfo("Open 5 Grab Bags",                                    1,  "Tasks",        "All",  true,  true),
            new CodeInfo("Receive furniture from a villager in the mail",       2,  "Tasks",        "All",  true,  true),
            new CodeInfo("Fill your inventory with letters from Home",          3,  "Tasks",        "All",  true,  true),
            new CodeInfo("Win an Item from Nook's Lottery",                     3,  "Tasks",        "All",  true,  true),
            new CodeInfo("Buy a Pinwheel, Balloon, and Fan from Redd's Tent",   3,  "Tasks",        "All",  true,  true),
            new CodeInfo("Fill your inventory with one type of seashell",       4,  "Tasks",        "All",  true,  true),
            new CodeInfo("Get a Lottery Ticket for each month",                 5,  "Tasks",        "All",  true,  true),
            new CodeInfo("Open a Present from a Balloon",                       5,  "Tasks",        "All",  true,  true),
            new CodeInfo("Erect a Sign Board",                                  5,  "Tasks",        "All",  true,  true),
            new CodeInfo("Win all 3 Prizes from a Nook's Lottery",              7,  "Tasks",        "All",  false, true),
            new CodeInfo("Win a Prize from 7 diff. months of Nook's Lottery",   8, "Tasks",        "All",  false, true),
            new CodeInfo("Repaint your roof all 4 diff. ways",                  8,  "Tasks",        "All",  true,  true),

            new CodeInfo("Pay off your 1st Debt",                               2,  "Debts",        "All",  false, false),
            new CodeInfo("Pay off your 2nd Debt",                               5,  "Debts",        "All",  false, false),
            new CodeInfo("Pay off your 3rd Debt",                               6,  "Debts",        "All",  false, false),
            new CodeInfo("Pay off your 4th Debt",                               7,  "Debts",        "All",  false, false),
            new CodeInfo("Pay off all your Debt",                               8,  "Debts",        "All",  false, false),
            new CodeInfo("Obtain the Tissue Box",                               10, "Debts",        "All",  false, false),

            new CodeInfo("Eavesdrop on a villager conversation",                1,  "Villagers",    "e+",   true,  true),
            new CodeInfo("Send a letter to 7 diff. villagers",                  1,  "Villagers",    "All",  true,  true),
            new CodeInfo("Get a Furniture Item from an Igloo",                  1,  "Villagers",    "e+",   true,  true),
            new CodeInfo("Complete 2 villager quests",                          2,  "Villagers",    "e+",   true,  true),
            new CodeInfo("Complete 5 villager quests",                          2,  "Villagers",    "AC",   true,  true),
            new CodeInfo("Get a Furniture Item from a Summer Camper",           2,  "Villagers",    "All",  true,  true),
            new CodeInfo("Get an Igloo item",                                   3,  "Villagers",    "AC",   true,  true),
            new CodeInfo("Get an Igloo item",                                   4,  "Villagers",    "e+",   true,  true),
            new CodeInfo("Change a Villager's Catchphrase to 'Mp16'",           3,  "Villagers",    "All",  true,  true),
            new CodeInfo("Get a Summer Camper item",                            4,  "Villagers",    "All",  true,  true),
            new CodeInfo("Complete a 'Catch a Fish or Bug' chore",              5,  "Villagers",    "All",  false, true),
            new CodeInfo("Complete a 'Lost Item' chore",                        5,  "Villagers",    "e+",   false, true),
            new CodeInfo("Complete a 'Find a Ball' chore",                      5,  "Villagers",    "AC",   false, true),
            new CodeInfo("Complete a 'Find a Ball' chore",                      8,  "Villagers",    "e+",   false, true),
            new CodeInfo("Complete a 'Plant Flowers' chore",                    6,  "Villagers",    "All",  false, true),
            new CodeInfo("Complete a 'Build a Snowman' chore",                  6,  "Villagers",    "AC",   false, true),
            new CodeInfo("Cure a villager's illness",                           8,  "Villagers",    "e+",   false, true),

            new CodeInfo("Have Resetti fake reset your game",                   1,  "Special",      "All",  true,  true),
            new CodeInfo("See Sable sew a pattern which shows a letter or number", 1,  "Special",   "All",  true,  true),
            new CodeInfo("Buy 3 furniture items from Crazy Redd",               2,  "Special",      "All",  true,  true),
            new CodeInfo("Sell Turnips for over 9000 Bells",                    2,  "Special",      "All",  true,  true),
            new CodeInfo("Buy 1000 Turnips from Joan",                          4,  "Special",      "All",  true,  true),
            new CodeInfo("Befriend Sable",                                      4,  "Special",      "All",  true,  true),
            new CodeInfo("Buy a painting from Crazy Redd",                      5,  "Special",      "All",  true,  true),
            new CodeInfo("Enter the Reset Surveillance Center",                 6,  "Special",      "e+",   true,  true),

            new CodeInfo("Pick 25 Weeds in a single day",                       1,  "Nature",       "All",  true,  true),
            new CodeInfo("Get 1,000 Bells from shaking trees",                  1,  "Nature",       "All",  true,  true),
            new CodeInfo("Eat 2 Mushrooms",                                     2,  "Nature",       "All",  true,  true),
            new CodeInfo("Get a satisfactory rating from the Wishing Well",     2,  "Nature",       "All",  true,  true),
            new CodeInfo("Grow a non-native fruit tree",                        3,  "Nature",       "All",  true,  true),
            new CodeInfo("Get 25+ full grown trees in one acre",                3,  "Nature",       "All",  true,  true),
            new CodeInfo("Get the Golden Shovel",                               3,  "Nature",       "All",  true,  true),
            new CodeInfo("Plant every type of flower",                          4,  "Nature",       "All",  false, true),
            new CodeInfo("Plant a flower in every acre",                        4,  "Nature",       "All",  false, true),
            new CodeInfo("Get 7 Mushrooms",                                     4,  "Nature",       "All",  true,  true),
            new CodeInfo("Get 2 Pieces of Furniture from shaking trees",        5,  "Nature",       "All",  true,  true),
            new CodeInfo("Get 7 Mushrooms",                                     5,  "Nature",       "All",  true,  true),
            new CodeInfo("Grow a 10K Bell Tree",                                5,  "Nature",       "All",  false, true),
            new CodeInfo("Grow a 30K Bell Tree",                                6,  "Nature",       "All",  false, true),
            new CodeInfo("Grow 3 diff. non-native fruit trees",                 6,  "Nature",       "All",  false, true),
            new CodeInfo("Get the Golden Axe",                                  6,  "Nature",       "All",  true,  true),
            new CodeInfo("Grow one of every type of fruit tree",                9,  "Nature",       "All",  false, true),

            new CodeInfo("Remove 5 Stumps",                                     1,  "Digging",      "All",  true,  true),
            new CodeInfo("Dig up 4 Gyriods",                                    2,  "Digging",      "All",  true,  true),
            new CodeInfo("Get at least 7 bell bags from one money rock",        2,  "Digging",      "All",  true,  true),
            new CodeInfo("Dig up 2 furniture items buried by villager(s)",      2,  "Digging",      "All",  true,  true),
            new CodeInfo("Dig up 3 Shining Spots",                              2,  "Digging",      "All",  true,  true),
            new CodeInfo("Make a villager fall in a pitfall",                   3,  "Digging",      "All",  true,  true),
            new CodeInfo("Get at least 8 bell bags from one money rock",        9,  "Digging",      "All",  true,  true),
            
            new CodeInfo("Get over 10K HRA points",                             2,  "HRA",          "All",  false, true),
            new CodeInfo("Get an HRA Score between X1 and X2",                  2,  "HRA",          "All",  false, true), //2K-3.8K with 200pt range
            new CodeInfo("Get an HRA Score between X3 and X4",                  3,  "HRA",          "All",  false, true), //4K-5.9K with 100pt range
            new CodeInfo("Get an HRA Score between X5 and X6",                  4,  "HRA",          "All",  false, true), //11K-12.95K with 50pt range
            new CodeInfo("Get an HRA Score between X7 and X7",                  7,  "HRA",          "All",  false, true), //20K-25K exact value
            new CodeInfo("Get the House Model",                                 5,  "HRA",          "AC",   false, true),
            new CodeInfo("Get the House Model",                                 6,  "HRA",          "e+",   false, true),
            new CodeInfo("Get the Manor Model",                                 7,  "HRA",          "All",  false, true),

            new CodeInfo("Place 2 diff. Red Feng Shui items in your house",     2,  "FengShui",     "All",  false, true),
            new CodeInfo("Place 2 diff. Orange Feng Shui items in your house",  2,  "FengShui",     "All",  false, true),
            new CodeInfo("Place 4 diff. Green Feng Shui items in your house",   2,  "FengShui",     "All",  false, true),
            new CodeInfo("Place 1 Yellow Feng Shui item in your house",         2,  "FengShui",     "All",  false, true),
            new CodeInfo("Place an item of each Feng Shui type in your house",  4,  "FengShui",     "All",  false, true),
            new CodeInfo("Place 5 diff. Red Feng Shui items in your house",     5,  "FengShui",     "All",  false, true),
            new CodeInfo("Place 5 diff. Orange Feng Shui items in your house",  5,  "FengShui",     "All",  false, true),
            new CodeInfo("Place 7 diff. Green Feng Shui items in your house",   5,  "FengShui",     "All",  false, true),
            new CodeInfo("Place 3 diff. Yellow Feng Shui item in your house",   6,  "FengShui",     "All",  false, true),
            new CodeInfo("Place 7 diff. diff. lucky items in your house",       6,  "FengShui",     "All",  false, true),

            new CodeInfo("Write a Diary Entry for each Month",                  1,  "Challenges",   "All",  true,  true),
            new CodeInfo("Eat 5 Pieces of Candy",                               1,  "Challenges",   "AC",   true,  true),
            new CodeInfo("Eat 3 Pieces of Candy",                               1,  "Challenges",   "e+",   true,  true),
            new CodeInfo("Pop 3 Party Poppers",                                 1,  "Challenges",   "e+",   true,  true),
            new CodeInfo("Get a bug or fish with a second character",           1,  "Challenges",   "All",  true,  true),
            new CodeInfo("Get a villager to wear a shirt of themself",          2,  "Challenges",   "All",  true,  true),
            new CodeInfo("Buy a Town Decoration",                               2,  "Challenges",   "e+",   true,  true),
            new CodeInfo("See 2 rainbows over waterfall(s)",                    2,  "Challenges",   "All",  true, true),
            new CodeInfo("Kick 5 Balls into the water",                         3,  "Challenges",   "All",  true,  true),
            new CodeInfo("Buy 3 Town Decorations",                              4,  "Challenges",   "e+",   true,  true),
            new CodeInfo("Get a reward from Wisp",                              5,  "Challenges",   "All",  true,  true),
            new CodeInfo("Have Tortimer build an extra bridge",                 6,  "Challenges",   "All",  true,  true),

            new CodeInfo("Get 2 diff. diaries",                                 1,  "Miscellaneous","All",  false, true),
            new CodeInfo("Spin 3 diff. Umbrellas in the rain",                  1,  "Miscellaneous","All",  true,  true),
            new CodeInfo("Kill 7 Cockroaches in your house",                    1,  "Miscellaneous","All",  true,  true),
            new CodeInfo("Get 7 diff. stationeries",                            1,  "Miscellaneous","All",  false, true),
            new CodeInfo("Get 7 diff. shirts",                                  1,  "Miscellaneous","All",  false, true),
            new CodeInfo("Get 7 diff. carpets",                                 2,  "Miscellaneous","All",  false, true),
            new CodeInfo("Get 7 diff. wallpapers",                              2,  "Miscellaneous","All",  false, true),
            new CodeInfo("Get 7 diff. umbrellas",                               2,  "Miscellaneous","All",  false, true),
            new CodeInfo("Donate at least 2 fish per tank to 3 tanks",          2,  "Miscellaneous","All",  false, true),
            new CodeInfo("Donate at least 2 bugs per display to 3 displays",    2,  "Miscellaneous","All",  false, true),
            new CodeInfo("Donate 5 fossils to the Museum",                      3,  "Miscellaneous","All",  false, true),
            new CodeInfo("Donate a fish to every tank",                         4,  "Miscellaneous","All",  false, true),
            new CodeInfo("Donate at least 3 fish per tank to 3 tanks",          5,  "Miscellaneous","All",  false, true),
            new CodeInfo("Donate at least 2 bugs per display to 5 displays",    5,  "Miscellaneous","All",  false, true),
            new CodeInfo("Donate all 5 non-Dinosaur fossils",                   5,  "Miscellaneous","All",  false, true),
            new CodeInfo("Complete a Dinosaur in the Museum",                   5,  "Miscellaneous","All",  false, true),
            new CodeInfo("Donate 3 Paintings",                                  7,  "Miscellaneous","All",  false, true),
            new CodeInfo("Complete 3 Dinosaurs in the Museum",                  8,  "Miscellaneous","All",  false, true),
            new CodeInfo("Get an Empty Can, Boot, and Old Tire",                8,  "Miscellaneous","All",  true,  true),
            new CodeInfo("Get a star in your Catalog",                          9,  "Miscellaneous","All",  false, true),
            //new CodeInfo("Have 0 Bells in your inventory",                             3, "Challenges", "All",  true, true),
            //new CodeInfo("Only change time forwards or back up to one month at a time",2, "Challenges", "All",  true, true),
        };

        public static int GetCodeInfoArrayLength()
        {
            return CodeInfoArray.Length;
        }

        public static Tuple<CodeInfo, int> GetTaskCheckByTag(string tagSelect, int taskNumber)
        {
            if (CodeInfoArray[taskNumber].Tag.Equals(tagSelect))
            {
                return new Tuple<CodeInfo, int>(CodeInfoArray[taskNumber], 1);
            }
            else
            {
                return new Tuple<CodeInfo, int>(null, 0);
            }
        }

        public static Tuple<CodeInfo, int> GetTaskCheckByName(string name)
        {
            for (int i = 0; i < CodeInfoArray.Length; i++)
            {
                if (CodeInfoArray[i].Name.Equals(name))
                {
                    return new Tuple<CodeInfo, int>(CodeInfoArray[i], 1);
                }
            }

            return new Tuple<CodeInfo, int>(null, 0);
        }

    }
}
