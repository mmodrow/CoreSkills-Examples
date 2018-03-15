// <copyright file="Billing.cs" company="Marc A. Modrow">
// Copyright (c) 2018 All Rights Reserved
// <author>Marc A. Modrow</author>
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ecommerce.BackOffice.Order.Processing
{
    /// <summary>
    /// Models a minimal billing object.
    /// </summary>
    public class Billing
    {
        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        /// <value>
        /// The items.
        /// </value>
        public IList<BillingPosition> Items { get; set; } = new List<BillingPosition>();

        /// <summary>
        /// Gets or sets the coupon.
        /// </summary>
        /// <value>
        /// The coupon.
        /// </value>
        public Func<double, double> Coupon { get; set; } = input => input;

        /// <summary>
        /// Gets the total price.
        /// </summary>
        /// <returns>THe summed up price incl. applied coupons.</returns>
        public double GetTotalPrice()
        {
            double subtotal = Items.Select(item => item.Price * item.Amount).Sum();

            subtotal = Coupon(subtotal);

            return subtotal;
        }
    }
}
