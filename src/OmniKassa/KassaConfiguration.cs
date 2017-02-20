﻿// <copyright file="KassaConfiguration.cs" company="Dirk Lemstra">
// Copyright 2017 Dirk Lemstra (https://github.com/dlemstra/OmniKassa).
// Licensed under the MIT License.
// </copyright>

using System;

namespace OmniKassa
{
    /// <summary>
    /// Encapsulates the configuration of OmniKassa.
    /// </summary>
    public sealed class KassaConfiguration : IKassaConfiguration
    {
        /// <summary>
        /// Gets or sets version number of the secret key. Can be found on the Rabo OmniKassa Downloadsite.
        /// </summary>
        public int KeyVersion { get; set; } = 1;

        /// <summary>
        /// Gets or sets the identifier of the merchant/webshop.
        /// </summary>
        public string MerchantId { get; set; }

        /// <summary>
        /// Gets or sets the secret key that will be used to create the seal.
        /// </summary>
        public string SecretKey { get; set; }

        /// <summary>
        /// Gets or sets the url of the Rabo OmniKassa.
        /// </summary>
        public Uri Url { get; set; }

        internal static string InterfaceVersion { get; } = "HP_1.0";
    }
}