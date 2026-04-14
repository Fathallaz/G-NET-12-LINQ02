
using G_NET_12_LINQ02.DataSource;
using G_NET_12_LINQ02.Models;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.IO.Pipelines;
using System.Runtime.ConstrainedExecution;



namespace G_NET_12_LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1 
            //1.Get top 3 most expensive products

            //Answer:
            //var result = Source.ProductList.OrderByDescending(p => p.UnitPrice).Take(3).Select(p => p.ProductName );


            #endregion

            #region Question 2 
            //2.show page 2 of products, with page size = 5

            //Answer:
            //var result = Source.ProductList.Skip(5).Take(5).Select(p => p.ProductName);
            #endregion

            #region Question 3 
            //            3.Take products from the list as long as Their UnitPrice is less than
            //$25(list is ordered by price).

            //Answer:
            //var result = Source.ProductList.OrderBy(p=> p.UnitPrice).TakeWhile(p => p.UnitPrice < 25).Select(p => p.ProductName);
            #endregion

            #region Question 4 
            //4.Check if ALL products in the "Seafood" category are in stock

            //Answer:
            //var result = Source.ProductList.Where(p => p.Category == "Seafood").All(p => p.UnitsInStock > 0);
            //Console.WriteLine(result);
            #endregion

            #region Question 5 
            //            5.Check if the ID list contains 9
            //int[] ids = { 3, 9, 13, 18 };

            //Answer:
            //int[] ids = { 3, 9, 13, 18 };
            //Console.WriteLine(ids.Contains(9));
            #endregion

            #region Question 6 
            //            6.Group all products by Category and print each group with its
            //product count.

            //Answer:
            //var result = Source.ProductList.GroupBy(p => p.Category).Select(g => $"{g.Key}: {g.Count()} products");

            #endregion

            #region Question 7 
            //7.Group products by Category and project only product names per group

            //Answer:
            //var result = Source.ProductList.GroupBy(p=>p.Category).Select(g => $"{g.Key}: {string.Join(", ", g.Select(p => p.ProductName))}");

            #endregion

            #region Question 8 
            //8.Find all categories that have MORE THAN 3 products

            //Answer:
            //var result = Source.ProductList.GroupBy(p => p.Category).Where(g => g.Count() > 3).Select(g => g.Key);

            #endregion

            #region Question 9 
            //9.Using QUERY SYNTAX, group customers by Country, and for each
            //group select { Country, Count, TotalOrderValue }.

            //Answer:
            //var result = from c in Source.CustomerList
            //             group c by c.Country into g
            //             select new
            //             {
            //                 Country = g.Key,
            //                 Count = g.Count(),
            //                 TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
            //             };


            #endregion

            #region Question 10 
            //10.Calculate the total number of units in stock across all products

            //Answer:
            //var total = Source.ProductList.Sum(p => p.UnitsInStock);
            //Console.WriteLine(total);

            #endregion

            #region Question 11 
            //11.Find the CHEAPEST and MOST EXPENSIVE product prices

            //Answer:
            //var cheapest = Source.ProductList.Min(p => p.UnitPrice);
            //var mostExpensive = Source.ProductList.Max(p => p.UnitPrice);
            //Console.WriteLine($"Cheapest: {cheapest}, Most Expensive: {mostExpensive}");

            #endregion

            #region Question 12 
            //12.Get a distinct list of all product categories

            //Answer:
            //var result = Source.ProductList.Select(p => p.Category).Distinct();

            #endregion

            #region Question 13 
            //            13.find product IDs that are in setA but NOT in setB
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //            int[] setB = { 3, 6, 9, 12, 15, 13 };

            //Answer:
            //int [] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int [] setB = { 3, 6, 9, 12, 15, 13 };
            //var result = setA.Except(setB);

            #endregion

            #region Question 14 
            //            14.Find countries that appear in list1 but NOT in list2
            //(case -insensitive).
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //                string[] list2 = { "france", "SPAIN", "Italy" };

            //Answer:
            //string [] list1 = { "Germany", "France", "UK", "Spain" };
            //string [] list2 = { "france", "SPAIN", "Italy" };
            //var result = list1.Except(list2, StringComparer.OrdinalIgnoreCase);

            #endregion

            #region Question 16
            //16.Get the first product whose price is greater than $50.

            //Answer:

            //var first = Source.ProductList.FirstOrDefault(p => p.UnitPrice > 50)?.ProductName ?? "No product found";
            //Console.WriteLine(first);


            #endregion

            #region Question 17 
            //17.Try to get the first product with a price > $500.it returns null
            //instead of throwing.

            //Answer:
            //var first = Source.ProductList.FirstOrDefault(p => p.UnitPrice > 500)?.ProductName ?? "No product found";   
            //Console.WriteLine(first);

            #endregion





            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
