// <copyright file="EmptyBaseConfig.cs" company="Marc A. Modrow">
// Copyright (c) 2018 All Rights Reserved
// <author>Marc A. Modrow</author>
// </copyright>
namespace CoreSkills.Examples.AspNetcore.DependencyInjection.Models
{
    /// <summary>
    /// Represents an empty config.
    /// </summary>
    /// <seealso cref="CoreSkills.Examples.AspNetcore.DependencyInjection.Models.BaseConfig" />
    public class EmptyBaseConfig : BaseConfig
    {
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return string.Empty;
        }
    }
}