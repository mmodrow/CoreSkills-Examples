// <copyright file="IStringSink.cs" company="Marc A. Modrow">
// Copyright (c) 2018 All Rights Reserved
// <author>Marc A. Modrow</author>
// </copyright>
namespace CoreSkills.Examples.Foundation.Logging
{
    /// <summary>
    /// Interface for classes that take strings and put them to a usefuly place.
    /// </summary>
    public interface IStringSink
    {
        /// <summary>
        /// Prints the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        void Print(string input);
    }
}