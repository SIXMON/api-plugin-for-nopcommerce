﻿// // -----------------------------------------------------------------------
// // <copyright from="2019" to="2019" file="ProductAttributesParametersModel.cs" company="Lindell Technologies">
// //    Copyright (c) Lindell Technologies All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Nop.Plugin.Api.Infrastructure;
using Nop.Plugin.Api.ModelBinders;

namespace Nop.Plugin.Api.Models.ProductAttributesParameters
{
    // JsonProperty is used only for swagger
    [ModelBinder(typeof(ParametersModelBinder<ProductAttributesParametersModel>))]
    public class ProductAttributesParametersModel
    {
        public ProductAttributesParametersModel()
        {
            Ids = null;
            Limit = Constants.Configurations.DefaultLimit;
            Page = Constants.Configurations.DefaultPageValue;
            SinceId = Constants.Configurations.DefaultSinceId;
            Fields = string.Empty;
        }

        /// <summary>
        ///     A comma-separated list of category ids
        /// </summary>
        [JsonProperty("ids")]
        public List<int> Ids { get; set; }

        /// <summary>
        ///     Amount of results (default: 50) (maximum: 250)
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }

        /// <summary>
        ///     Page to show (default: 1)
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        ///     Restrict results to after the specified ID
        /// </summary>
        [JsonProperty("since_id")]
        public int SinceId { get; set; }

        /// <summary>
        ///     comma-separated list of fields to include in the response
        /// </summary>
        [JsonProperty("fields")]
        public string Fields { get; set; }
    }
}
