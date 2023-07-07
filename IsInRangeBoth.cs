namespace DigitRanger
{
   /// <summary>
   /// static Class containing methods for testing ranges of digits.
   /// </summary>
   public partial class CDigitRanger
   {
      /// <summary>
      /// Test to see if both ends of the target range fit within a base range.
      /// </summary>
      /// <param name="ulngLow"></param>
      /// <param name="ulngHigh"></param>
      /// <param name="ulngTargetLow"></param>
      /// <param name="ulngTargetHigh"></param>
      /// <returns></returns>
      public static bool IsInRangeBoth(ulong ulngLow, ulong ulngHigh, ulong ulngTargetLow, ulong ulngTargetHigh)
      {
         return
            (
            IsInRange(ulngLow, ulngHigh, ulngTargetLow)
            &&
            IsInRange(ulngLow, ulngHigh, ulngTargetHigh)
            );
      }
   }
}