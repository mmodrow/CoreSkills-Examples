// <copyright file="BillingTests.cs" company="Marc A. Modrow">
// Copyright (c) 2018 All Rights Reserved
// <author>Marc A. Modrow</author>
// </copyright>

using System;
using Ecommerce.BackOffice.Order.Processing;
using Xunit;

namespace Ecommerce.BackOffice.Order.ProcessingTests
{
    /// <summary>
    /// Tests the Billing class.
    /// </summary>
    public class BillingTests
    {
        /// <summary>
        /// Tests correct handling of empty bills.
        /// </summary>
        [Fact]
        public void GetTotalPrice_Bill_Empty()
        {
            Billing billing = new Billing();
            Assert.Equal(0, billing.GetTotalPrice());
        }

        /// <summary>
        /// Tests correct handling of total percentage Coupons.
        /// </summary>
        [Fact]
        public void GetTotalPrice_Coupon_TotalPercentage()
        {
            Billing billing = new Billing();

            // Set a 25% discount coupon.
            billing.Coupon = input => input * 0.75;

            // Add some items.
            billing.Items.Add(new BillingPosition { Name = "Testing", Price = 1234 });
            billing.Items.Add(new BillingPosition { Amount = 0, Name = "Bugfixing", Price = 1234 });
            billing.Items.Add(new BillingPosition { Amount = 10, Name = "New Features", Price = 123 });

            Assert.Equal(2464 * 0.75, billing.GetTotalPrice());
        }

        /// <summary>
        /// Tests correct handling of null-coupons.
        /// </summary>
        [Fact]
        public void GetTotalPrice_Coupon_Null()
        {
            Billing billing = new Billing();

            // Set a null coupon.
            billing.Coupon = null;

            // Add some items.
            billing.Items.Add(new BillingPosition { Name = "Testing", Price = 1234 });
            billing.Items.Add(new BillingPosition { Amount = 0, Name = "Bugfixing", Price = 1234 });
            billing.Items.Add(new BillingPosition { Amount = 10, Name = "New Features", Price = 123 });

            Assert.Throws<NullReferenceException>(() => billing.GetTotalPrice());
        }
    }
}
