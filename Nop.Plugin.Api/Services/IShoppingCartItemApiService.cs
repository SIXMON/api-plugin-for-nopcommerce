﻿// // -----------------------------------------------------------------------
// // <copyright from="2019" to="2019" file="IShoppingCartItemApiService.cs" company="Lindell Technologies">
// //    Copyright (c) Lindell Technologies All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Nop.Core.Domain.Orders;
using Nop.Plugin.Api.Infrastructure;

namespace Nop.Plugin.Api.Services
{
    public interface IShoppingCartItemApiService
    {
        List<ShoppingCartItem> GetShoppingCartItems(
            int? customerId = null, DateTime? createdAtMin = null, DateTime? createdAtMax = null,
            DateTime? updatedAtMin = null, DateTime? updatedAtMax = null, int limit = Constants.Configurations.DefaultLimit,
            int page = Constants.Configurations.DefaultPageValue);

        ShoppingCartItem GetShoppingCartItem(int id);
    }
}
