using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMMSCommon
{
  public class Class1
  {
    public static string GetMyVersion()
    {
      return "MyNuggetVer=1.2.3.1" + "Using IndSoftTestNuget01: " + IndSoftTestNuget01.NugetMain.GetMyVersion();
    }
  }
}
