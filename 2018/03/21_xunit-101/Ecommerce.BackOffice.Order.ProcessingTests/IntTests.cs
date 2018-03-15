// <copyright file="IntTests.cs" company="Marc A. Modrow">
// Copyright (c) 2018 All Rights Reserved
// <author>Marc A. Modrow</author>
// </copyright>

using Xunit;

namespace Ecommerce.BackOffice.Order.ProcessingTests
{
    /// <summary>
    /// Tests the official int functionality.
    /// </summary>
    public class IntTests
    {
        /// <summary>
        /// Tests if int properly can be parsed from different strings.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <param name="expectedOutput">The expected int after parsing.</param>
        [Theory]
        [InlineData("-1", -1)]
        [InlineData("1", 1)]
        [InlineData("0", 0)]
        [InlineData("1234567890", 1234567890)]
        public void TryParse_ValidInputs(string input, int expectedOutput)
        {
            int result = int.Parse(input);
            Assert.Equal(expectedOutput, result);
        }
    }
}
