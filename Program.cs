using static ListGeneratorNameSpace.ListGenerator;
namespace Assignment_LINQ_2
{
    internal class Program
    {
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
        }
    }
}
