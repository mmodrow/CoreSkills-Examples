// <copyright file="LoggingEventSourceTests.cs" company="Marc A. Modrow">
// Copyright (c) 2018 All Rights Reserved
// <author>Marc A. Modrow</author>
// </copyright>
using CoreSkills.Examples.Project.Logging;
using Xunit;

namespace CoreSkills.Examples.Project.LoggingTests
{
    /// <summary>
    /// Tests the correct behaviour of the LoggingEventSource.
    /// </summary>
    public class LoggingEventSourceTests
    {
        /// <summary>
        /// Tests the SourceNewLine with event-handlers set.
        /// </summary>
        /// <param name="input">The input.</param>
        [Theory]
        [InlineData("input")]
        [InlineData(null)]
        [InlineData("")]
        public void SourceNewLine_EventSet(string input)
        {
            LoggingEventSource source = new LoggingEventSource();
            string output = "this is not the input value";
            source.NewLineSourced += (sender, eventInput) => output = eventInput;
            
            source.SourceNewLine(input);

            Assert.Equal(input, output);
        }
    }
}