using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;

namespace PageLifeCycle
{
 public class Class2 : Page
  {
     //protected override void Render(HtmlTextWriter writer) 
     //{
     //  string helloWorld="Hello World";
     //  writer.Write(helloWorld);
     //  //Controls.Add(new LiteralControl("Hello world"));
     
     //}
    public virtual void TestMethod() 
     { }
  }
}
