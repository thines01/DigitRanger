using System.Collections.Generic;

namespace DigitRanger
{
   using RangeObj;

   /// <summary>
   /// static Class containing methods for testing ranges of digits.
   /// </summary>
   public partial class CDigitRanger
   {
      /// <summary>
      /// Collapses a group of ranges into a string
      /// </summary>
      /// <param name="lst_strRanges"></param>
      /// <returns>string containing all ranges in the list (collapsed)</returns>
      public static string Collapse(List<string> lst_strRanges)
      {
         string strPaniRange = "";

         ///////////////////////////////////////////////////////////////////////
         // Collapse the ranges
         CRange rangeOut = new CRange();
         bool blnGotFirst = false;
         lst_strRanges.Sort(); // <- Critical!
         foreach (string str in lst_strRanges)
         {
            CRange rangeLoop = new CRange(str);

            if (!blnGotFirst)
            {
               rangeOut.strLow = rangeLoop.strLow;
               rangeOut.strHigh = rangeLoop.strHigh;
               blnGotFirst = true;
               continue;
            }

            ///////////////////////////////////////////////////////////////////
            //
            if ((long.Parse(rangeLoop.strLow) - 1) > long.Parse(rangeOut.strHigh))
            {  // It's more than one off, create a new range.
               strPaniRange += rangeOut.ToString() + ",";
               //
               rangeOut.strLow = rangeLoop.strLow;
               rangeOut.strHigh = rangeLoop.strHigh;
               continue;
            }

            // It's one off or embedded, collapse the range
            rangeOut.strHigh = rangeLoop.strHigh;
         }
         //
         strPaniRange += rangeOut.ToString();
         return strPaniRange;
      }
   }
}
