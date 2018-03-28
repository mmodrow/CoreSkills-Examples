// <copyright file="LoggingEventSource.cs" company="Marc A. Modrow">
// Copyright (c) 2018 All Rights Reserved
// <author>Marc A. Modrow</author>
// </copyright>
using System;
using CoreSkills.Examples.Foundation.Logging;

namespace CoreSkills.Examples.Project.Logging
{
    /// <summary>
    /// An event source that is used to raise events for logging.
    /// </summary>
    /// <seealso cref="CoreSkills.Examples.Foundation.Logging.IStringSource" />
    public class LoggingEventSource : IStringSource
    {
        /// <summary>
        /// Occurs when a new line is sourced.
        /// </summary>
        public event EventHandler<string> NewLineSourced;

        /// <summary>
        /// Sources a new line.
        /// </summary>
        /// <param name="input">The input.</param>
        public void SourceNewLine(string input)
        {
            NewLineSourced?.Invoke(this, input);
        }
    }
}
