namespace DigitRanger
{
   /// <summary>
   /// static Class containing methods for testing ranges of digits.
   /// </summary>
   public partial class CDigitRanger
   {
      /// <summary>
      /// Tests to see if a target number falls within a particular range
      /// </summary>
      /// <param name="ulngLow"></param>
      /// <param name="ulngHigh"></param>
      /// <param name="ulngTarget"></param>
      /// <returns></returns>
      public static bool IsInRange(ulong ulngLow, ulong ulngHigh, ulong ulngTarget)
      {
         return ((ulngLow <= ulngTarget) && (ulngTarget <= ulngHigh));
      }
   }
}