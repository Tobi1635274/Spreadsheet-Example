using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   internal class Program
   {
      static void Main(string[] args)
      {
         using (SLDocument sl = new SLDocument($"d:\\tmp\\ipsYdion ZV Abrechnung Master - ipsYdion - alt.xlsx", "Tabelle1"))
         {
            //var templateSheet = new SLDocument($"d:\\tmp\\IpsYdion ZV Abrechnung Master.xlsx", "Tabelle1");
            sl.SaveAs($"d:\\tmp\\abc.xlsx");
         }
      }
   }
}
