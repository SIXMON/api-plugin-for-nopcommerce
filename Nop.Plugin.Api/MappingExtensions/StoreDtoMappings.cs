﻿// // -----------------------------------------------------------------------
// // <copyright from="2019" to="2019" file="StoreDtoMappings.cs" company="Lindell Technologies">
// //    Copyright (c) Lindell Technologies All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using Nop.Core.Domain.Stores;
using Nop.Plugin.Api.AutoMapper;
using Nop.Plugin.Api.DTO.Stores;

namespace Nop.Plugin.Api.MappingExtensions
{
    public static class StoreDtoMappings
    {
        public static StoreDto ToDto(this Store store)
        {
            return store.MapTo<Store, StoreDto>();
        }
    }
}
