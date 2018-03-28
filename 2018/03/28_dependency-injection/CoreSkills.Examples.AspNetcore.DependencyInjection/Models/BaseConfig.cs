// <copyright file="BaseConfig.cs" company="Marc A. Modrow">
// Copyright (c) 2018 All Rights Reserved
// <author>Marc A. Modrow</author>
// </copyright>
namespace CoreSkills.Examples.AspNetcore.DependencyInjection.Models
{
    /// <summary>
    /// Base for all dependency injectable types in this project.
    /// </summary>
    public abstract class BaseConfig
    {
        /// <summary>
        /// Gets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public string Type => GetType().Name;

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public new abstract string ToString();
    }
}