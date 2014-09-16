using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lazy
{
  public class LazyClass : ILazyInterface
  {
    public long Id { get; set; }

    public string Title { get; set; }

    public LazyClass()
    {
      Console.Write("In a constructor \n");
      //Thread.Sleep(5000);
    }

    public static IList<LazyClass> GetProductList()
    {
      var product1 = new LazyClass { Id = 1, Title = "Product 1" };
      var product2 = new LazyClass { Id = 2, Title = "Product 2" };
      var product3 = new LazyClass { Id = 3, Title = "Product 3" };
      return new List<LazyClass>
      (new[] { product1, product2, product3 });
    }

    public static IList<Lazy<LazyClass>> GetProductListLazy()
    {
      var product1 = new Lazy<LazyClass>(() =>
      new LazyClass { Id = 1, Title = "Product 1" });
      var product2 = new Lazy<LazyClass>(() =>
      new LazyClass { Id = 2, Title = "Product 2" });
      var product3 = new Lazy<LazyClass>(() =>
      new LazyClass { Id = 3, Title = "Product 3" });
      return new List<Lazy<LazyClass>> { product1, product2, product3 };
    }

    public void GetValue()
    {

      
      Console.WriteLine("In a Get Value method");
      

    }

    public string Test()
    {
      throw new NotImplementedException();
    }
  }
}
