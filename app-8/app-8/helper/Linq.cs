using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_8
{
    public class Linq
    {
        public void run()
        {
            int[] fibonacci = { 0, 1, 1, 2, 3, 5 };

            int numberOfElements = fibonacci.Count();
            Console.WriteLine($"{numberOfElements}");

            IEnumerable<int> distinictNumbers = fibonacci.Distinct();
            Console.WriteLine("Elements in output sequence:");

            foreach (var number in distinictNumbers)
            {
                Console.WriteLine(number);
            }

            //***************************************************


            // ايجاد پرس و جو
            IEnumerable<int> numbersGreaterThanTwoQuery = fibonacci.Where(x => x > 2);
            // در اين مرحله پرس و جو ايجاد شده ولي هنوز اجرا نشده است
            // تغيير عنصر اول توالي
            fibonacci[0] = 99;
            // حرکت بر روي عناصر توالي باعث اجراي پرس و جو مي‌شود
            foreach (var number in numbersGreaterThanTwoQuery)
            {
                Console.WriteLine(number);
            }

            //***************************************************


            // ساخت پرس و جو
            IEnumerable<int> numbersGreaterThanTwoQuery2 = fibonacci.Where(x => x > 2).ToArray();
            // در اين مرحله به خاطر عملگر استفاده شده پرس و جو اجرا مي‌شود
            // تغيير اولين عنصر توالي
            fibonacci[0] = 99;
            // حرکت بر روي نتيجه
            foreach (var number in numbersGreaterThanTwoQuery2)
            {
                Console.WriteLine(number);
            }


            //***************************************************

            // The Three Parts of a LINQ Query:
            //  1. منبع داده
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };
            // 2. ايجاد پرس و جو
            // numQuery is an IEnumerable<int>
            var numQuery =
                from num in numbers
                where (num % 2) == 0
                select num;
            // 3. اجراي پرس و جو
            foreach (int num in numQuery)
            {
                Console.Write("{0,1} ", num);
            }


            //******************************************
            Ingredient[] ingredients =
                {
                   new Ingredient {Name = "Suger", Calories = 500},
                   new Ingredient {Name = "Egg", Calories = 100 },
                   new Ingredient {Name = "Milk", Calories = 150 },
                   new Ingredient {Name = "Flour", Calories = 50 },
                   new Ingredient {Name = "Butter", Calories = 200 }
                };

            //Fluent Style 
            IEnumerable<string> highCalories =
                ingredients.Where(x => x.Calories >= 150)
                  .OrderBy(x => x.Name)
                  .Select(x => x.Name);

            foreach (var item in highCalories)
            {
                Console.WriteLine(item);
            }

            //Query Expression 
            IEnumerable<string> highCalories2 =
                    from i in ingredients
                    where i.Calories >= 150
                    orderby i.Name
                    select i.Name;

            foreach (var item in highCalories2)
            {
                Console.WriteLine(item);
            }

            //***********************************************

            //cast
            object[] ints = new object[] { 1, 2, 3 };
            //error
            //var query = from num in ints
            //            where num < 3
            //            select num;
            var query = from int num in ints
                        where num < 3
                        select num;



            //***********************************************

            List<string> list = new List<string> { "LINQ", "Query", "adventure" };

            var query2 = from string word in list
                        where word.Contains("r")
                        orderby word ascending
                        select word;

            //**************************************************

            //let
            IEnumerable<Ingredient> highCalDairyQuery =
                from i in ingredients
                let isDairy = i.Name == "Milk" || i.Name == "Butter"
                where i.Calories >= 150 && isDairy
                select i;

            foreach (var ingredient in highCalDairyQuery)
            {
                Console.WriteLine(ingredient.Name);
            }

            //*********************************************

            //let
            string[] csvRecipes = { "milk,sugar,eggs", "flour,BUTTER,eggs", "vanilla,ChEEsE,oats" };

            var dairyQuery = from csvRecipe in csvRecipes
                             let ingredients2 = csvRecipe.Split(',')
                             from ingredient in ingredients2
                             let uppercaseIngredient = ingredient.ToUpper()
                             where
                               uppercaseIngredient == "MILK" ||
                               uppercaseIngredient == "BUTTER" ||
                               uppercaseIngredient == "CHEESE"
                             select uppercaseIngredient;

            foreach (var dairyIngredient in dairyQuery)
            {
                Console.WriteLine($"{dairyIngredient} is dairy");
            }

            //*********************************************

            //into
            IEnumerable<Ingredient> highCalDairyQuery3 =
                    from i in ingredients
                    select new //نوع بي نام
                    {
                        OriginalIngredient = i,
                        IsDairy = i.Name == "Milk" || i.Name == "Butter",
                        IsHighCalorie = i.Calories >= 150
                    }
                    into temp
                    where temp.IsDairy && temp.IsHighCalorie
                    select temp.OriginalIngredient;

            foreach (var ingredient in highCalDairyQuery3)
            {
                Console.WriteLine(ingredient.Name);
            }

            //*************************************************

            //join
            Recipe[] recipes =
                    {
                       new Recipe {Id = 1, Name = "Mashed Potato"},
                       new Recipe {Id = 2, Name = "Crispy Duck"},
                       new Recipe {Id = 3, Name = "Sachertorte"}
                    };

            Review[] reviews =
                    {
                       new Review {RecipeId = 1, ReviewText = "Tasty!"},
                       new Review {RecipeId = 1, ReviewText = "Not nice :("},
                       new Review {RecipeId = 1, ReviewText = "Pretty good"},
                       new Review {RecipeId = 2, ReviewText = "Too hard"},
                       new Review {RecipeId = 2, ReviewText = "Loved it"}
                    };


            var query3 = from recipe in recipes
                        join review in reviews on recipe.Id equals review.RecipeId
                        select new //anonymous type
                        {
                            RecipeName = recipe.Name,
                            RecipeReview = review.ReviewText
                        };

            foreach (var item in query3)
            {
                Console.WriteLine($"{item.RecipeName}-{item.RecipeReview}");
            }

            //*************************************************

            //Group Join 
            var query4 = from recipe in recipes
                        join review in reviews on recipe.Id equals review.RecipeId
                        into reviewGroup
                        select new //anonymous type
                        {
                            RecipeName = recipe.Name,
                            Reviews = reviewGroup//collection of related reviews
                        };

            foreach (var item in query4)
            {
                Console.WriteLine($"Review for {item.RecipeName}");
                foreach (var review in item.Reviews)
                {
                    Console.WriteLine($"-{review.ReviewText}");
                }
            }

            //*************************************************

            //Left outer join 
            var query5 = from recipe in recipes
                        join review in reviews on recipe.Id equals review.RecipeId
                        into reviewGroup
                        from rg in reviewGroup.DefaultIfEmpty()
                        select new //anonymous type
                        {
                            RecipeName = recipe.Name,
                            //RecipeReview = rg.ReviewText SystemNullException
                            RecipeReview = (rg == null ? "n/a" : rg.ReviewText)
                        };

            foreach (var item in query5)
            {
                Console.WriteLine($"{item.RecipeName}-{item.RecipeReview}");
            }


            //*************************************************

            //Left outer join 
            var query6 = from recipe in recipes
                        join review in reviews on recipe.Id equals review.RecipeId
                        into reviewGroup
                        from rg in reviewGroup.DefaultIfEmpty(new Review { ReviewText = "N/A" })
                        select new //anonymous type
                        {
                            RecipeName = recipe.Name,
                            RecipeReview = rg.ReviewText
                        };

            foreach (var item in query6)
            {
                Console.WriteLine($"{item.RecipeName}-{item.RecipeReview}");
            }


            //*************************************************

            //group and by
            IEnumerable<IGrouping<int, Ingredient>> query7 =
                    from i in ingredients
                    group i by i.Calories;

            foreach (IGrouping<int, Ingredient> group in query7)
            {
                Console.WriteLine($"Ingredients with {group.Key} calories");
                foreach (Ingredient ingredient in group)
                {
                    Console.WriteLine($"- {ingredient.Name}");
                }
            }



            //*************************************************

            //orderby 
            IOrderedEnumerable<Ingredient> sortedByNameQuery =
                        from i in ingredients
                        orderby i.Name
                        select i;

            foreach (var ingredient in sortedByNameQuery)
            {
                Console.WriteLine(ingredient.Name);
            }

            //descending
            IOrderedEnumerable<Ingredient> sortedByNameQuery2 =
                        from i in ingredients
                        orderby i.Name descending
                        select i;



            IEnumerable<IGrouping<int, Ingredient>> query8 =
                        from i in ingredients
                        group i by i.Calories
                        into calorieGroup
                        orderby calorieGroup.Key
                        select calorieGroup;

            foreach (IGrouping<int, Ingredient> group in query8)
            {
                Console.WriteLine($"Ingredients with {group.Key} calories");
                foreach (Ingredient ingredient in group)
                {
                    Console.WriteLine($"- {ingredient.Name}");
                }
            }

            //*************************************************

            int mixedQuery =
                (from i in ingredients
                 where i.Calories > 100
                 select i).Count();



            //*************************************************

            //Where
            IEnumerable<Ingredient> query9 = ingredients.Where(x => x.Calories >= 200);

            foreach (var ingredient in query9)
            {
                Console.WriteLine(ingredient.Name);
            }

            IEnumerable<Ingredient> query10 = 
                ingredients.Where((ingredient, index) => ingredient.Name == "Sugar" || index == 4);

            //*************************************************

            //Select 
            IEnumerable<string> query11 = ingredients.Select(x => x.Name);

            IEnumerable<int> query12 = ingredients.Select(x => x.Name.Length);


            IEnumerable<IngredientNameAndLength> query13 = ingredients.Select(x =>
                                new IngredientNameAndLength
                                {
                                    Name = x.Name,
                                    Length = x.Name.Length
                                });

            var query14 = ingredients.Select(x =>
                                new
                                {
                                    Name = x.Name,
                                    Length = x.Name.Length
                                });


            var query15 = from i in ingredients
                        select new
                        {
                            Name = i.Name,
                            Length = i.Name.Length
                        };
            //*************************************************

            //SelectMany   
            string[] ingredients4 = { "Sugar", "Egg", "Milk", "Flour", "Butter" };

            IEnumerable<char> query16 = ingredients4.SelectMany(x => x.ToCharArray());
            foreach (var item in query16)
            {
                Console.WriteLine(item);
            }


            IEnumerable<char> query17 = from i in ingredients4
                                       from c in i.ToCharArray()
                                       select c;

            foreach (var item in query17)
            {
                Console.WriteLine(item);
            }

            //*************************************************

            //take
            IEnumerable<Ingredient> query18 = ingredients.Take(3);
            foreach (var ingredient in query18)
            {
                Console.WriteLine(ingredient.Name);
            }


            IEnumerable<Ingredient> query19 = 
                ingredients.Where(x => x.Calories > 100).Take(2);

            foreach (var ingredient in query19)
            {
                Console.WriteLine(ingredient.Name);
            }


            IEnumerable<Ingredient> query20 =
                    (from i in ingredients
                     where i.Calories > 100
                     select i).Take(2);


            IEnumerable<Ingredient> query21 = ingredients.TakeWhile(x => x.Calories >= 100);
            foreach (var ingredient in query21)
            {
                Console.WriteLine(ingredient.Name);
            }


            //*************************************************

            //skip
            IEnumerable<Ingredient> query22 = ingredients.Skip(3);
            foreach (var ingredient in query22)
            {
                Console.WriteLine(ingredient.Name);
            }

            //*************************************************

            //OrderBy
            var query23 = ingredients.OrderBy(x => x.Name);
            foreach (var item in query23)
            {
                Console.WriteLine(item);
            }


            var query24 = from i in ingredients
                        orderby i.Calories
                        select i;


            //*************************************************

            //ThenBy
            var query25 = ingredients
                     .OrderBy(x => x.Calories)
                     .ThenBy(x => x.Name);

            foreach (var item in query25)
            {
                Console.WriteLine(item.Name + " " + item.Calories);
            }


            var query26 = from i in ingredients
                        orderby i.Calories, i.Name
                        select i;


            //*************************************************

            //OrderByDescending 
            var query27 = ingredients.OrderByDescending(x => x.Calories);

            foreach (var item in query27)
            {
                Console.WriteLine(item.Name + " " + item.Calories);
            }

            var query28 = from i in ingredients
                        orderby i.Calories descending
                        select i;

            //*************************************************

            //ThenByDescending 
            var query29 = ingredients
                    .OrderBy(x => x.Calories)
                    .ThenByDescending(x => x.Name);

            foreach (var item in query29)
            {
                Console.WriteLine(item.Name + " " + item.Calories);
            }

            var query30 = from i in ingredients
                        orderby i.Calories, i.Name descending
                        select i;

            //*************************************************

            //Reverse  
            char[] letters = { 'A', 'B', 'C' };

            var query31 = letters.Reverse();
            foreach (var item in query31)
            {
                Console.WriteLine(item);
            }


            //*************************************************

            //GroupBy 
            IEnumerable<IGrouping<int, Ingredient>> query32 = ingredients.GroupBy(x => x.Calories);

            foreach (IGrouping<int, Ingredient> group in query32)
            {
                Console.WriteLine("Ingredients with {0} calories", group.Key);
                foreach (Ingredient ingredient in group)
                {
                    Console.WriteLine(" -{0}", ingredient.Name);
                }
            }


            //*************************************************

            //Concat
            //اين عملگر دو توالي را با هم ادغام مي‌کند؛ 
            string[] applePie = { "Apple", "Sugar", "Pastry", "Cinnamon" };
            string[] cherryPie = { "Cherry", "Sugar", "Pastry", "Kirsch" };

            IEnumerable<string> query33 = applePie.Concat(cherryPie);
            foreach (string item in query33)
            {
                Console.WriteLine(item);
            }


            //*************************************************

            //Union
            //اين عملگر همچون عملگر Concat رفتار مي‌کند؛ با اين تفاوت که عناصر تکراري در توالي خروجي حضور نخواهند داشت.
            IEnumerable<string> query34 = applePie.Union(cherryPie);
            foreach (string item in query34)
            {
                Console.WriteLine(item);
            }

            //*************************************************

            //Distinct
            //اين عملگر عناصر تکراري توالي را حذف مي‌کند
            IEnumerable<string> query35 = applePie.Distinct();
            foreach (string item in query35)
            {
                Console.WriteLine(item);
            }


            IEnumerable<string> query36 = applePie.Concat(cherryPie).Distinct();
            foreach (string item in query36)
            {
                Console.WriteLine(item);
            }

            //*************************************************

            //Intersect  
            //اين عملگر عناصر مشترک بين دو توالي را باز مي‌گرداند
            IEnumerable<string> query37 = applePie.Intersect(cherryPie);
            foreach (string item in query37)
            {
                Console.WriteLine(item);
            }

            //*************************************************

            //Except
            //اين عملگر عناصري از توالي اول را انتخاب مي‌کند که در توالي دوم همتايي نداشته باشند
            IEnumerable<string> query38 = applePie.Except(cherryPie);
            foreach (string item in query38)
            {
                Console.WriteLine(item);
            }



            //*************************************************

            //OfType
            IEnumerable input = new object[] { "Apple", 33, "Sugar", 44, 'a', new DateTime() };

            IEnumerable<string> query39 = input.OfType<string>();
            foreach (var item in query39)
            {
                Console.WriteLine(item);
            }
            //Apple
            //Sugar


            //OfType
            IEnumerable<Ingredient2> input2 = new Ingredient2[]
                        {
                           new DryIngredient { Name = "Flour" },
                           new WetIngredient { Name = "Milk" },
                           new WetIngredient { Name = "Water" }
                        };

            IEnumerable<WetIngredient> query40 = input2.OfType<WetIngredient>();
            foreach (WetIngredient item in query40)
            {
                Console.WriteLine(item.Name);
            }
            //Milk
            //Water


            //*************************************************

            //Cast
            //Error
            //IEnumerable<string> query41 = input.Cast<string>();
            //foreach (string item in query41)
            //{
            //    Console.WriteLine(item);
            //}


            IEnumerable input3 = new object[] { "Apple", "Sugar", "Flour" };
            IEnumerable<string> query42 =
            from string i in input3
            select i;

            foreach (var item in query42)
            {
                Console.WriteLine(item);
            }

            //*************************************************

            //ToArray  
            IEnumerable<string> input4 = new List<string> { "Apple", "Sugar", "Flour" };
            string[] array = input4.ToArray();


            //*************************************************

            //ToList  
            IEnumerable<string> input5 = new[] { "Apple", "Sugar", "Flour" };
            List<string> list2 = input5.ToList();

            //*************************************************

            //ToDictionary  
            IEnumerable<Recipe2> recipes2 = new[]
                    {
                       new Recipe2 { Id = 1, Name = "Apple Pie", Rating = 5 },
                       new Recipe2 { Id = 2, Name = "Cherry Pie", Rating = 2 },
                       new Recipe2 { Id = 3, Name = "Beef Pie", Rating = 3 }
                    };

            Dictionary<int, Recipe2> dict = recipes2.ToDictionary(x => x.Id);

            foreach (KeyValuePair<int, Recipe2> item in dict)
            {
                Console.WriteLine($"Key={item.Key}, Recipe={item.Value}");
            }

            //*************************************************

            //ToLookup 
            IEnumerable<Recipe3> recipes3 = new[]
                        {
                           new Recipe3{ Id = 1, Name = "Apple Pie", Rating = 5 },
                           new Recipe3 { Id = 1, Name = "Banana Pie", Rating = 5 },
                           new Recipe3 { Id = 2, Name = "Cherry Pie", Rating = 2 },
                           new Recipe3 { Id = 3, Name = "Beef Pie", Rating = 3 }
                        };


            ILookup<byte, Recipe3> look = recipes3.ToLookup(x => x.Rating);

            foreach (IGrouping<byte, Recipe3> ratingGroup in look)
            {
                byte rating = ratingGroup.Key;
                Console.WriteLine($"Rating {rating}");
                foreach (var recipe in ratingGroup)
                {
                    Console.WriteLine($" - {recipe.Name}");
                }
            }

            //*************************************************

            //First 
            Ingredient element = ingredients.First();
            Console.WriteLine(element.Name);


            Ingredient element2 = ingredients.First(x => x.Calories == 150);
            Console.WriteLine(element.Name);

            //*************************************************

            //FirstOrDefault
            Ingredient[] ingredients5 = { };
            Ingredient element3 = ingredients.FirstOrDefault();
            Console.WriteLine(element3 == null);


            Ingredient element4 = ingredients.FirstOrDefault(x => x.Calories == 1500);
            Console.WriteLine(element4 == null);


            //*************************************************

            //Last
            //LastOrDefault 
            Ingredient element5 = ingredients.Last(x => x.Calories == 500);
            Console.WriteLine(element5.Name);

            //*************************************************

            //Single
            Ingredient[] ingredients6 =
                    {
                       new Ingredient { Name = "Sugar", Calories = 500 }
                    };

            Ingredient element6 = ingredients6.Single();
            Console.WriteLine(element6.Name);

            Ingredient element7 = ingredients.Single(x => x.Calories == 150);
            Console.WriteLine(element7.Name);

            //*************************************************

            //SingleOrDefault 
            Ingredient element8 = ingredients.SingleOrDefault(x => x.Calories == 9999);
            Console.WriteLine(element8 == null);

            //*************************************************

            //ElementAt
            Ingredient element9 = ingredients.ElementAt(2);
            Console.WriteLine(element9.Name);

            //*************************************************

            //ElementAtOrDefault
            Ingredient element10 = ingredients.ElementAtOrDefault(5);
            Console.WriteLine(element10 == null);

            //*************************************************

            //DefaultIfEmpty 
            IEnumerable<Ingredient> query41 = ingredients.DefaultIfEmpty();
            foreach (Ingredient item in query41)
            {
                Console.WriteLine(item.Name);
            }


            Ingredient[] ingredients7 = { };
            IEnumerable<Ingredient> query43 = ingredients7.DefaultIfEmpty();
            foreach (Ingredient item in query43)
            {
                Console.WriteLine(item == null);
            }

            //*************************************************

            //عملگر Empty يک توالي بدون عنصر (Empty) را بر اساس نوع مشخص شده، ايجاد مي‌کند
            //Empty
            IEnumerable<Ingredient> ingredients8 = Enumerable.Empty<Ingredient>();
            Console.WriteLine(ingredients8.Count());

            //*************************************************

            //Range 
            IEnumerable<int> fiveToTen = Enumerable.Range(5, 6);
            foreach (var num in fiveToTen)
            {
                Console.WriteLine(num);
            }


            //*************************************************

            //Repeat
            IEnumerable<int> fiveToTen2 = Enumerable.Repeat(42, 6);
            foreach (var num in fiveToTen2)
            {
                Console.WriteLine(num);
            }

            //*************************************************

            //Contains 
            int[] nums = { 1, 2, 3 };
            bool isTowThere = nums.Contains(2);
            bool isFiveThere = nums.Contains(5);

            Console.WriteLine(isTowThere);
            Console.WriteLine(isFiveThere);

            //*************************************************

            //Any
            int[] nums2 = { 1, 2, 3 };
            IEnumerable<int> noNums = Enumerable.Empty<int>();

            Console.WriteLine(nums2.Any());
            Console.WriteLine(noNums.Any());


            bool areAnyEvenNumbers = nums2.Any(x => x % 2 == 0);
            Console.WriteLine(areAnyEvenNumbers);

            //*************************************************


            //All
            //در کد زير بررسي مي‌کنيم که آيا همه عناصر توالي مواد غذايي، جزء مواد غذايي کم چرب مي‌باشند يا خير .
            bool isLowFatRecipe = ingredients.All(x => x.Calories < 200);
            Console.WriteLine(isLowFatRecipe);

            //*************************************************

            //SequenceEqual
            //دو توالي را با هم مقايسه کرده و در صورتيکه عناصر هر دو توالي برابر و ترتيب قرار گيري آنها نيز يکسان باشند، ارزش True باز گردانده مي‌شود
            IEnumerable<int> sequence1 = new[] { 1, 2, 3 };
            IEnumerable<int> sequence2 = new[] { 1, 2, 3 };
            bool isSeqEqual = sequence1.SequenceEqual(sequence2);
            Console.WriteLine(isSeqEqual);

            //*************************************************

            //Count
            //LongCount 
            int numberOfElements2 = nums.Count();
            Console.WriteLine(numberOfElements2);


            int numberOfEvenElements = nums.Count(x => x % 2 == 0);
            Console.WriteLine(numberOfEvenElements);


            //*************************************************

            //Sum
            int total = nums.Sum();
            Console.WriteLine(total);

            int totalCalories = ingredients.Sum(x => x.Calories);
            Console.WriteLine(totalCalories);

            //*************************************************

            //Average
            var avg = nums.Average();
            Console.WriteLine(avg);

            var avgCalories = ingredients.Average(x => x.Calories);
            Console.WriteLine(avgCalories);


            //*************************************************


            //Min
            var smallest = nums.Min();
            Console.WriteLine(smallest);

            var smallestCalories = ingredients.Min(x => x.Calories);
            Console.WriteLine(smallestCalories);

            //*************************************************

            //Max
            var largest = nums.Max();
            Console.WriteLine(largest);

            //*************************************************


            //Aggregate
            //create custom function
            var result = nums.Aggregate(0,
                        (currentElement, runningTotal) => runningTotal + currentElement);

            Console.WriteLine(result);

            var result2 = nums.Aggregate((runningProduct, nextfactor) => runningProduct * nextfactor);

            Console.WriteLine(result);

            //*************************************************

            //Join
            Recipe[] recipes4 =
                    {
                       new Recipe {Id = 1, Name = "Mashed Potato"},
                       new Recipe {Id = 2, Name = "Crispy Duck"},
                       new Recipe {Id = 3, Name = "Sachertorte"}
                    };

            // inner sequence
            Review[] reviews4 =
                        {
               new Review {RecipeId = 1, ReviewText = "Tasty!"},
               new Review {RecipeId = 1, ReviewText = "Not nice :("},
               new Review {RecipeId = 1, ReviewText = "Pretty good"},
               new Review {RecipeId = 2, ReviewText = "Too hard"},
               new Review {RecipeId = 2, ReviewText = "Loved it"}
                        };


            var query44 = recipes4 // recipes توالي خارجي
                .Join(reviews4, // reviewsتوالي داخلي
                (Recipe outerKey) => outerKey.Id, // کليد انخاب شده از توالي خارجي
                (Review innerKey) => innerKey.RecipeId, // کليد انتخاب شده از توالي داخلي
                                                        // نحوه قالب بندي خروجي
                (recipe, review) => recipe.Name + " - " + review.ReviewText);

            foreach (string item in query44)
            {
                Console.WriteLine(item);
            }

            //*************************************************

            //GroupJoin
            var query45 = recipes4
                    .GroupJoin(
                    reviews4,
                    (Recipe outerKey) => outerKey.Id,//outer key
                    (Review innerKey) => innerKey.RecipeId,//inner key
                    (Recipe recipe, IEnumerable<Review> rev) => new //تعريف ساختار گروه‌ها
                    {
                        RecipeName = recipe.Name,
                        Reviews = rev
                    }
                    );

            foreach (var item in query45)
            {
                Console.WriteLine($"Reviews for {item.RecipeName}");
                foreach (var review in item.Reviews)
                {
                    Console.WriteLine($" - {review.ReviewText}");
                }
            }

            //*************************************************

            //Zip
            string[] names = { "Flour", "Butter", "Sugar" };
            int[] calories = { 100, 400, 500 };
            IEnumerable<Ingredient> ingredients9 =
            names.Zip(calories, (name, calorie) =>
            new Ingredient
            {
                Name = name,
                Calories = calorie
            });

            foreach (var item in ingredients9)
            {
                Console.WriteLine($"{item.Name} has {item.Calories} calories");
            }

            //*************************************************
        }
    }


    class Ingredient
    {
        public string Name { get; set; }
        public int Calories { get; set; }
    }

    class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Review
    {
        public int RecipeId { get; set; }
        public string ReviewText { get; set; }
    }

    class IngredientNameAndLength
    {
        public string Name { get; set; }
        public int Length { get; set; }
        public override string ToString()
        {
            return Name + " " + Length;
        }
    }
    class Ingredient2
    {
        public string Name { get; set; }
    }
    class DryIngredient : Ingredient2
    {
        public int Grams { get; set; }
    }

    class WetIngredient : Ingredient2
    {
        public int Millilitres { get; set; }
    }

    class Recipe2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
    }


    class Recipe3
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Rating { get; set; }
    }


}
