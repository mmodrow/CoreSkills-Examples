// <copyright file="ConsoleWriterTests.cs" company="Marc A. Modrow">
// Copyright (c) 2018 All Rights Reserved
// <author>Marc A. Modrow</author>
// </copyright>
using System;
using CoreSkills.Examples.Project.Logging;
using CoreSkills.Examples.TestUtils;
using Xunit;
using Xunit.Abstractions;

namespace CoreSkills.Examples.Project.LoggingTests
{
    /// <summary>
    /// Tests the ConsoleWriter.
    /// </summary>
    public class ConsoleWriterTests
    {
        /// <summary>
        /// The output helper.
        /// </summary>
        private readonly ITestOutputHelper output;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsoleWriterTests"/> class.
        /// </summary>
        /// <param name="output">The output.</param>
        public ConsoleWriterTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        /// <summary>
        /// Tests writing strings.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="expectedOutput">The expected output.</param>
        [Theory]
        [InlineData("value", "value")]
        [InlineData("", "")]
        [InlineData(null, "")]
        public void WriteString(string input, string expectedOutput)
        {
            var currentConsoleOut = Console.Out;
            string lineBreak = Environment.NewLine;
            ConsoleWriter writer = new ConsoleWriter();
            using (var consoleOutput = new ConsoleOutput())
            {
                writer.Print(input);

                Assert.Equal(expectedOutput + lineBreak, consoleOutput.GetOuput());
            }

            Assert.Equal(currentConsoleOut, Console.Out);
        }
    }
}
