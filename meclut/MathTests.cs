using mecl;
using Xunit;

namespace meclut
{
    public class MathTests
    {
        #region Factorial
        ///
        /// <summary>
        /// Tests the integrity and correctness of the mecl.Math.Factorial method
        /// </summary>
        /// 
        /// <param name="input">
        /// This will be passed to mecl.Math.Factorial
        /// </param>
        /// 
        /// <param name="expected">
        /// Expected output of mecl.Math.Factorial(input)
        /// </param>
        /// 
        [Theory]
        [InlineData(1, 1)]            // Normal Data
        [InlineData(2, 2)]            // Normal Data
        [InlineData(3, 6)]            // Normal Data
        [InlineData(4, 24)]           // Normal Data
        [InlineData(5, 120)]          // Normal Data
        [InlineData(6, 720)]          // Normal Data
        [InlineData(7, 5_040)]        // Normal Data
        [InlineData(8, 40_320)]       // Normal Data
        [InlineData(9, 362_880)]      // Normal Data
        [InlineData(10, 3_628_800)]   // Normal Data
        [InlineData(11, 39_916_800)]  // Normal Data
        [InlineData(12, 479_001_600)] // Normal Data
        [InlineData(0, 1)]            // Special Data
        public static void Factorial_Int32ShouldEval(int input, int expected)
        {
            Assert.Equal(expected, Math.Factorial(input));
        }

        //[Theory]
        //[InlineData(-4, -1)]            // Out of Bounds Data
        //[InlineData(13, -1)]            // Out of Bounds Data
        //[InlineData(int.MaxValue, -1)]  // Out of Bounds Data
        //[InlineData(int.MinValue, -1)]  // Out of Bounds Data
        //public static void Factorial_Int32ShouldNotEval(int input, int expected)
        //{
        //    Assert.Equal(expected, Math.Factorial(input));
        //}
        #endregion Factorial


        #region Sum



        #endregion Sum
    }
}
