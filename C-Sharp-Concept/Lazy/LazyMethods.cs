using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazy
{
  public class LazyMethods
  {
    #region "load lazy objects"
    public void InitializeLazyObjects()
    {

      IList<LazyClass> lstClass = LoadObject();
      foreach (var item in lstClass)
      {
        Console.WriteLine("List Id value is --> : " + item.Id);
      }

      IList<Lazy<LazyClass>> lstLazyObject = LoadLazyObject();
      foreach (var item in lstLazyObject)
      {
        Console.WriteLine("List Id value is --> : " + item.Value.Id);
      }


      LazyClass objClass = new LazyClass();
      objClass.GetValue();
      objClass.GetValue();
      objClass.GetValue();
      objClass.GetValue();


      Console.ReadLine();

    }

    private IList<LazyClass> LoadObject()
    {

      Console.WriteLine(DateTime.Now);
      IList<LazyClass> list = LazyClass.GetProductList();
      Console.WriteLine("Total products in my list: " + list.Count);
      Console.WriteLine(DateTime.Now);
      return list;

    }

    private IList<Lazy<LazyClass>> LoadLazyObject()
    {

      Console.WriteLine(DateTime.Now);
      IList<Lazy<LazyClass>> list = LazyClass.GetProductListLazy();
      Console.WriteLine("Total products in my list: " + list.Count);
      Console.WriteLine(DateTime.Now);
      return list;

    }

    #endregion


  }
}
