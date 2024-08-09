using System.Collections.Generic;
using static ListGeneratorNameSpace.ListGenerator;
namespace Assignment_LINQ_2
{
    internal class Program
    {
        static string GetSortedString(string str)
        {
            char[] chars = str.Where(c => !char.IsWhiteSpace(c)).OrderBy(c => c).ToArray() ;
            return new string(chars) ;
        }
        static void Main(string[] args)
        {
            #region Element Operators

            #region Q1
            //var outOFStockProduct = ProductsList.FirstOrDefault(p => p.UnitsInStock == 0);
            //Console.WriteLine(outOFStockProduct);
            #endregion

            #region Q2
            //var expensiveProduct = ProductsList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine(expensiveProduct);
            #endregion

            #region Q3
            // Int [] Arr = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            //var secondNumberGreaterThanFive = Arr.Where(n => n > 5).Skip(1).FirstOrDefault();
            //Console.WriteLine(secondNumberGreaterThanFive);

            #endregion

            #endregion

            #region Aggregate Operators

            #region Q1
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var oddCount = Arr.Count(n => n % 2 == 1);
            //Console.WriteLine(oddCount);
            #endregion

            #region Q2
            //var customerAndOrderCount = CustomersList.Select(c => new
            //{
            //    name = c.CustomerName,
            //    orderCount = c.Orders.Count()
            //});
            //foreach (var customer in customerAndOrderCount)
            //{
            //    Console.WriteLine(customer);
            //}
            #endregion

            #region Q3
            //var categoryProductCounts = ProductsList.GroupBy(p => p.Category)
            //                                        .Select(g => new
            //                                        {
            //                                            category = g.Key,
            //                                            productCount = g.Count()
            //                                        });
            //foreach (var category in categoryProductCounts)
            //{
            //    Console.WriteLine(category);
            //}
            #endregion

            #region Q4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var sum = Arr.Sum(x => x);
            //Console.WriteLine(sum);
            #endregion

            #region Q5,6,7,8  dictionary_english

            //string[] words = File.ReadAllLines("dictionary_english.txt").ToArray();

            #region Q5
            //var totalChar = words.Sum(w => w.Length);
            //Console.WriteLine(totalChar);
            #endregion

            #region Q6
            //var minLenght = words.Min(x => x.Length);
            //Console.WriteLine(minLenght);
            #endregion

            #region Q7
            //var maxLenght = words.Max(w => w.Length);
            //Console.WriteLine(maxLenght);
            #endregion

            #region Q8
            //var averageLength = words.Average(w => w.Length);
            //Console.WriteLine(averageLength);
            #endregion

            #endregion

            #region Q9
            //var totalUnitsPerCategory = ProductsList.GroupBy(p => p.Category)
            //                                        .Select(g => new
            //                                        {
            //                                            category = g.Key,
            //                                            totalUnits = g.Sum(p=>p.UnitsInStock)
            //                                        });
            //foreach (var unit in totalUnitsPerCategory)
            //{
            //    Console.WriteLine(unit);
            //}
            #endregion

            #region Q10

            //var cheapestPricePerCategory = ProductsList.GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        category = g.Key,
            //        cheapestPrice = g.Min(p => p.UnitPrice),
            //    });
            //foreach (var category in cheapestPricePerCategory)
            //{
            //    Console.WriteLine(category);
            //}

            #endregion

            #region Q11
            //var cheapestProductPerCategory = ProductsList.GroupBy(g => g.Category)
            //                                             .Select(g => new
            //                                             {
            //                                                 category = g.Key,
            //                                                 cheapestProduct = g.OrderBy(p => p.UnitPrice).FirstOrDefault(),
            //                                             });
            //foreach (var category in cheapestProductPerCategory)
            //{
            //    Console.WriteLine(category.category);
            //    Console.WriteLine(category.cheapestProduct);
            //}
            #endregion

            #region Q12
            //var higherPricePerCategory = ProductsList.GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        category = g.Key,
            //        heigherPrice = g.Max(p => p.UnitPrice),
            //    });
            //foreach (var category in higherPricePerCategory)
            //{
            //    Console.WriteLine(category);
            //}
            #endregion

            #region Q13
            //var heigherProductPerCategory = ProductsList.GroupBy(g => g.Category)
            //                                             .Select(g => new
            //                                             {
            //                                                 category = g.Key,
            //                                                 heigherProduct = g.OrderByDescending(p => p.UnitPrice).FirstOrDefault(),
            //                                             });
            //foreach (var category in heigherProductPerCategory)
            //{
            //    Console.WriteLine(category.category);
            //    Console.WriteLine(category.heigherProduct);
            //}
            #endregion

            #region Q14
            //var AveragePricePerCategory = ProductsList.GroupBy(g => g.Category)
            //                                             .Select(g => new
            //                                             {
            //                                                 category = g.Key,
            //                                                 averagePrice = g.Average(p=>p.UnitPrice),
            //                                             });
            //foreach (var category in AveragePricePerCategory)
            //{
            //    Console.WriteLine(category);
            //}
            #endregion

            #endregion

            #region Set Operators

            #region Q1
            //var uniqueCategory = ProductsList.Select(p => p.Category).Distinct();
            //foreach (var category in uniqueCategory)
            //{
            //    Console.WriteLine(category);
            //}
            #endregion

            #region Q2
            //var uniqueProductFirstLetters = ProductsList.Select(p => p.ProductName[0]).Distinct();
            //var uniqueCustomerFirstLetters = CustomersList.Select(c => c.CustomerName[0]).Distinct();
            //var uniqueFirstLetters = uniqueProductFirstLetters.Concat(uniqueCustomerFirstLetters).Distinct();
            //foreach (var product in uniqueProductFirstLetters)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region Q3
            //var uniqueProductFirstLetters = ProductsList.Select(p => p.ProductName[0]).Distinct();
            //var uniqueCustomerFirstLetters = CustomersList.Select(c => c.CustomerName[0]).Distinct();

            //var commonFirstLetters = uniqueProductFirstLetters.Intersect(uniqueCustomerFirstLetters);
            //foreach (var product in commonFirstLetters)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region Q4
            //var uniqueProductFirstLetters = ProductsList.Select(p => p.ProductName[0]).Distinct();
            //var uniqueCustomerFirstLetters = CustomersList.Select(c => c.CustomerName[0]).Distinct();

            //var uniqueLetters = uniqueProductFirstLetters.Except(uniqueCustomerFirstLetters);
            //foreach (var product in uniqueLetters)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region Q5

            //// لو فى طريقه تانيه ابعتها ميل عشان ال 
            //// where 
            //// هتخلينى اخد لما يكونوا اكبر من 3 بس 
            //var customerLastThreeChars = CustomersList.Select(c => c.CustomerName.Length >= 3
            //                                                  ? c.CustomerName.Substring(c.CustomerName.Length - 3)
            //                                                  : c.CustomerName);
            //var productLastThreeChars = ProductsList.Select(p => p.ProductName.Length >= 3
            //                                                ? p.ProductName.Substring(p.ProductName.Length - 3)
            //                                                : p.ProductName);

            //var lastThreeChars = customerLastThreeChars.Concat(productLastThreeChars);
            //foreach(var letters in lastThreeChars)
            //{
            //    Console.WriteLine(letters);
            //}
            #endregion
            #endregion

            #region Partitioning Operators

            #region Q1
            //var first3OrdersInWashington = CustomersList.Where(c => c.Address == "Washington")
            //                                            .SelectMany(c => c.Orders)
            //                                            .Take(3);
            //foreach( var order in first3OrdersInWashington)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion

            #region Q2
            //var allExceptFirst2OrdersInWashington = CustomersList.Where(c => c.Address == "Washington")
            //                                                  .SelectMany(c => c.Orders)
            //                                                  .Skip(2);
            //foreach (var order in allExceptFirst2OrdersInWashington)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion

            #region Q3
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.TakeWhile((n, index) => n >= index);
            //foreach (int n in result)
            //{
            //    Console.WriteLine(n);
            //}
            #endregion

            #region Q4
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.SkipWhile(x => x %3 != 0);
            //foreach (int x in result)
            //{
            //    Console.WriteLine(x);
            //}

            #endregion

            #region Q5
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile((x,index) => x >= index);

            //foreach (var i in result)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #endregion

            #region Quantifiers

            #region Q1
            //var words = File.ReadAllLines("dictionary_english.txt");

            //bool containsEi = words.Any(word => word.Contains("ei"));

            //Console.WriteLine(containsEi);

            #endregion

            #region Q2
            //var categoriesWithOutOfStock = ProductsList.GroupBy(p => p.Category)
            //                                           .Where(g => g.Any(p => p.UnitsInStock == 0));
            //foreach (var category in categoriesWithOutOfStock)
            //{
            //    Console.WriteLine(category);
            //}

            #endregion

            #region Q3
            //var categoriesWithAllInStock = ProductsList.GroupBy(p => p.Category)
            //                                           .Where(g => g.All(p => p.UnitsInStock != 0));

            //foreach (var category in categoriesWithAllInStock)
            //{
            //    Console.WriteLine(category);
            //}
            #endregion

            #endregion

            #region Grouping Operators

            #region Q1
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var groupedByRemainder = numbers.GroupBy(x => x % 5)
            //                                .Select(g => new
            //                                {
            //                                    Reminder = g.Key,
            //                                    numbers = g
            //                                });
            //foreach(var group in groupedByRemainder)
            //{
            //    Console.WriteLine($"Numbers with a remainder of {group.Reminder} when divided by 5 :");
            //    foreach(var item in group.numbers) Console.WriteLine(item);
            //}
            #endregion

            #region Q2
            //var words = File.ReadAllLines("dictionary_english.txt");

            //var groupedByFirstLetter = words.GroupBy(w => char.ToLower(w[0]))
            //                                .Select(g => new
            //                                {
            //                                    firstLetter = g.Key,
            //                                    words = g
            //                                });

            //foreach (var word in groupedByFirstLetter)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine($"Words that start with {word.firstLetter}");
            //    foreach(var w in word.words) Console.WriteLine(w);
            //}
            #endregion

            #region Q3


            //String[] Arr = { "from", "salt", "earn", " last", "near", "form" };
            //var groupedByAnagram = Arr.GroupBy(w => GetSortedString(w))
            //                          .Select(g => new
            //                          {
            //                              anagram = g.Key,
            //                              words = g
            //                          });
            //foreach (var g in groupedByAnagram)
            //{
            //    Console.WriteLine($"the words that folow this anagram {g.anagram}");
            //    foreach (var w in g.words)
            //    {
            //        Console.WriteLine(w);
            //    }
            //}
            #endregion

            #endregion
        }
    }
}
