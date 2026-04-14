
using G_NET_12_LINQ02.DataSource;
using G_NET_12_LINQ02.Models;
using System.Collections;
using System.ComponentModel;



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





            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
