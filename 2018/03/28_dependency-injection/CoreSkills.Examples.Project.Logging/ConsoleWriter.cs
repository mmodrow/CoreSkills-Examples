// <copyright file="ConsoleWriter.cs" company="Marc A. Modrow">
// Copyright (c) 2018 All Rights Reserved
// <author>Marc A. Modrow</author>
// </copyright>
using System;
using CoreSkills.Examples.Foundation.Logging;

namespace CoreSkills.Examples.Project.Logging
{
    /// <summary>
    /// Writes input to the console.
    /// </summary>
    /// <seealso cref="CoreSkills.Examples.Foundation.Logging.IStringSink" />
    public class ConsoleWriter : IStringSink
    {
        /// <summary>
        /// Prints the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        public void Print(string input)
        {
            Console.WriteLine(input);
        }
    }
}
