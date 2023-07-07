namespace DigitRanger
{
   /// <summary>
   /// static Class containing methods for testing ranges of digits.
   /// </summary>
   public partial class CDigitRanger
   {
      /// <summary>
      /// Test to see if either end of the target range fit within a base range.
      /// </summary>
      /// <param name="ulngLow"></param>
      /// <param name="ulngHigh"></param>
      /// <param name="ulngTargetLow"></param>
      /// <param name="ulngTargetHigh"></param>
      /// <returns></returns>
      public static bool IsInRangeEither(ulong ulngLow, ulong ulngHigh, ulong ulngTargetLow, ulong ulngTargetHigh)
      {
         return
            (
            IsInRange(ulngLow, ulngHigh, ulngTargetLow)
            ||
            IsInRange(ulngLow, ulngHigh, ulngTargetHigh)
            ||
            IsInRange(ulngTargetLow, ulngTargetHigh, ulngLow)
            ||
            IsInRange(ulngTargetLow, ulngTargetHigh, ulngHigh)
            );
      }
   }
}