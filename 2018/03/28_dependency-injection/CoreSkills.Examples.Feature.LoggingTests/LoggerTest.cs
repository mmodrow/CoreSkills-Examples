// <copyright file="LoggerTest.cs" company="Marc A. Modrow">
// Copyright (c) 2018 All Rights Reserved
// <author>Marc A. Modrow</author>
// </copyright>
using System;
using CoreSkills.Examples.Feature.Logging;
using CoreSkills.Examples.Project.Logging;
using CoreSkills.Examples.TestUtils;
using Xunit;

namespace CoreSkills.Examples.Feature.LoggingTests
{
    /// <summary>
    /// Tests the correct behaviour of the Logger class.
    /// </summary>
    public class LoggerTest
    {
        /// <summary>
        /// The line break character(s).
        /// </summary>
        private static readonly string LineBreak = Environment.NewLine;

        /// <summary>
        /// Tests loggin via string source's source event.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="expectedOutput">The expected output.</param>
        [Theory]
        [InlineData("value", "value")]
        [InlineData("", "")]
        [InlineData(null, "")]
        public void LogFromEvent(string input, string expectedOutput)
        {
            var currentConsoleOut = Console.Out;
            string lineBreak = LineBreak;
            Logger logger = CreateLogger();
            
            using (var consoleOutput = new ConsoleOutput())
            {
                logger.Source.SourceNewLine(input);

                Assert.Equal(expectedOutput + lineBreak, consoleOutput.GetOuput());
            }

            Assert.Equal(currentConsoleOut, Console.Out);
        }

        /// <summary>
        /// Tests loggin via the Logger's "Log" method.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="expectedOutput">The expected output.</param>
        [Theory]
        [InlineData("value", "value")]
        [InlineData("", "")]
        [InlineData(null, "")]
        public void Log(string input, string expectedOutput)
        {
            var currentConsoleOut = Console.Out;
            string lineBreak = LineBreak;
            Logger logger = CreateLogger();
            
            using (var consoleOutput = new ConsoleOutput())
            {
                logger.Log(input);

                Assert.Equal(expectedOutput + lineBreak, consoleOutput.GetOuput());
            }

            Assert.Equal(currentConsoleOut, Console.Out);
        }

        /// <summary>
        /// Creates the logger.
        /// </summary>
        /// <returns>A freshly created Logger instance.</returns>
        private Logger CreateLogger()
        {
            ConsoleWriter writer = new ConsoleWriter();
            LoggingEventSource source = new LoggingEventSource();
            Logger logger = new Logger(source, writer);
            return logger;
        }
    }
}