
using G_NET_12_LINQ02.DataSource;
using G_NET_12_LINQ02.Models;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
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





            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
