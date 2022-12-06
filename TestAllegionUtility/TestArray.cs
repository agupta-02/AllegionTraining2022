using AllegionUtility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestAllegionUtility
{
    [TestClass]
    public class TestArray
    {
        /// <summary>
        /// Method <c>BirarySearchOFFirstExistingItem</c> models a method where it checks whether <c>BinarySearch</c> returns correct index value for the first item of an array.
        /// <example>
        /// For example:
        /// <code>
        ///  actual = ArrayClass.BinarySearch({1,2,3},1)
        /// </code>
        /// Result is in <c>actual</c> which should have the value 0.
        /// </example>
        /// </summary>


        [TestMethod]
        public void BirarySearchOFFirstExistingItem()
        {
            int[] input = { 1, 2, 3 };
            int searchItem = 1;

            int actual = AllegionArray.BinarySearch(input, searchItem);

            Assert.AreEqual(0, actual);
        }

        /// <summary>
        /// Method <c>BirarySearchOFMiddleExistingItem</c> models a method where it checks whether <c>BinarySearch</c> returns correct index value for the middle item of an array.
        /// <example>
        /// For example:
        /// <code>
        ///  actual = ArrayClass.BinarySearch({1,2,3},1)
        /// </code>
        /// Result is in <c>actual</c> which should have the value 1.
        /// </example>
        /// </summary>

        [TestMethod]
        public void BirarySearchOFMiddleExistingItem()
        {
            int[] input = { 1, 2, 3 };
            int searchItem = 2;

            int actual = AllegionArray.BinarySearch(input, searchItem);

            Assert.AreEqual(1, actual);
        }

        /// <summary>
        /// Method <c>BirarySearchOFEndExistingItem</c> models a method where it checks whether <c>BinarySearch</c> returns correct index value for the middle item of an array.
        /// <example>
        /// For example:
        /// <code>
        ///  actual = ArrayClass.BinarySearch({1,2,3},1)
        /// </code>
        /// Result is in <c>actual</c> which should have the value 2.
        /// </example>
        /// </summary>

        [TestMethod]
        public void BirarySearchOFEndExistingItem()
        {
            int[] input = { 1, 2, 3 };
            int searchItem = 3;

            int actual = AllegionArray.BinarySearch(input, searchItem);

            Assert.AreEqual(2, actual);
        }
    }
}
