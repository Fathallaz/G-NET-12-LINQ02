
using G_NET_12_LINQ02.DataSource;
using G_NET_12_LINQ02.Models;



namespace G_NET_12_LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1 
            //1.Get top 3 most expensive products

            //Answer:
            var result = Source.ProductList.OrderByDescending(p => p.UnitPrice).Take(3).Select(p => p.ProductName );


            #endregion
            foreach (var item in result )
            {
                Console.WriteLine(item);
            }
        }
    }
}
