﻿// // -----------------------------------------------------------------------
// // <copyright from="2019" to="2019" file="IProductManufacturerMappingsApiService.cs" company="Lindell Technologies">
// //    Copyright (c) Lindell Technologies All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System.Collections.Generic;
using Nop.Core.Domain.Catalog;
using Nop.Plugin.Api.Infrastructure;

namespace Nop.Plugin.Api.Services
{
    public interface IProductManufacturerMappingsApiService
    {
        IList<ProductManufacturer> GetMappings(
            int? productId = null, int? manufacturerId = null, int limit = Constants.Configurations.DefaultLimit,
            int page = Constants.Configurations.DefaultPageValue, int sinceId = Constants.Configurations.DefaultSinceId);

        int GetMappingsCount(int? productId = null, int? manufacturerId = null);

        ProductManufacturer GetById(int id);
    }
}
