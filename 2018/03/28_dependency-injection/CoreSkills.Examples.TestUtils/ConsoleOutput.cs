// <copyright file="ConsoleOutput.cs" company="Marc A. Modrow">
// Copyright (c) 2018 All Rights Reserved
// <author>Marc A. Modrow</author>
// </copyright>

using System;
using System.IO;

namespace CoreSkills.Examples.TestUtils
{
    /// <summary>
    /// Console output capture helper.
    /// Kudos to Vasil Trifonov
    /// <see>
    /// https://www.codeproject.com/Articles/501610/Getting-Console-Output-Within-A-Unit-Test
    /// </see>
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    public class ConsoleOutput : IDisposable
    {
        /// <summary>
        /// The string writer
        /// </summary>
        private readonly StringWriter stringWriter;

        /// <summary>
        /// The original output
        /// </summary>
        private readonly TextWriter originalOutput;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsoleOutput"/> class.
        /// </summary>
        public ConsoleOutput()
        {
            stringWriter = new StringWriter();
            originalOutput = Console.Out;
            Console.SetOut(stringWriter);
        }

        /// <summary>
        /// Gets the ouput.
        /// </summary>
        /// <returns>The written string.</returns>
        public string GetOuput()
        {
            return stringWriter.ToString();
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Console.SetOut(originalOutput);
            stringWriter.Dispose();
        }
    }
}