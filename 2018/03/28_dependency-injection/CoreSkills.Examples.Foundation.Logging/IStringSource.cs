// <copyright file="IStringSource.cs" company="Marc A. Modrow">
// Copyright (c) 2018 All Rights Reserved
// <author>Marc A. Modrow</author>
// </copyright>
using System;

namespace CoreSkills.Examples.Foundation.Logging
{
    /// <summary>
    /// Interface for classes that are able to throw string-events for further use.
    /// </summary>
    public interface IStringSource
    {
        /// <summary>
        /// Occurs when a new line is sourced.
        /// </summary>
        event EventHandler<string> NewLineSourced;

        /// <summary>
        /// Sources a new line.
        /// </summary>
        /// <param name="input">The input.</param>
        void SourceNewLine(string input);
    }
}