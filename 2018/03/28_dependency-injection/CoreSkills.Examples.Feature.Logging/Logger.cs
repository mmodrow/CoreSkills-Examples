// <copyright file="Logger.cs" company="Marc A. Modrow">
// Copyright (c) 2018 All Rights Reserved
// <author>Marc A. Modrow</author>
// </copyright>

using CoreSkills.Examples.Foundation.Logging;

namespace CoreSkills.Examples.Feature.Logging
{
    /// <summary>
    /// Couples an IStringSource to an IStringSink to create an event-driven logger.
    /// </summary>
    public class Logger
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Logger"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="sink">The sink.</param>
        public Logger(IStringSource source, IStringSink sink)
        {
            Source = source;
            Sink = sink;
            Source.NewLineSourced += (sourceObject, input) => sink?.Print(input);
        }

        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public IStringSource Source { get; }

        /// <summary>
        /// Gets the sink.
        /// </summary>
        /// <value>
        /// The sink.
        /// </value>
        public IStringSink Sink { get; }

        /// <summary>
        /// Logs the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        public void Log(string input)
        {
            Source.SourceNewLine(input);
        }
    }
}