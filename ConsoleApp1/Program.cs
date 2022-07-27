using SpreadsheetLight;
using System.IO;

namespace ConsoleApp1
{
   internal class Program
   {
      static void Main(string[] args)
      {
         string temp = $"PathToFile\\FilenameOfExcel_tmp.xlsx";
         string dest = $"PathToFile\\FilenameOfExcel.xlsx";
         File.Copy(dest, temp);
         SLDocument sheet;
         using (SLDocument sl = new SLDocument())
         {
            sheet = new SLDocument(temp);
         }

         using (SLDocument sl = new SLDocument(temp))
         {
            sheet.SaveAs(dest);
         }
         File.Delete(temp);
      }
   }
}
