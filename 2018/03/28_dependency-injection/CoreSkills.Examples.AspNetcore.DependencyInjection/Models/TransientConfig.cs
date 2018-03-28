// <copyright file="TransientConfig.cs" company="Marc A. Modrow">
// Copyright (c) 2018 All Rights Reserved
// <author>Marc A. Modrow</author>
// </copyright>

namespace CoreSkills.Examples.AspNetcore.DependencyInjection.Models
{
    /// <summary>
    /// A configuration that is injected as transient.
    /// </summary>
    /// <seealso cref="CoreSkills.Examples.AspNetcore.DependencyInjection.Models.BaseConfig" />
    public class TransientConfig : BaseConfig
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public string Value { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Returns a <see cref="T:System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return "Value: " + Value;
        }
    }
}