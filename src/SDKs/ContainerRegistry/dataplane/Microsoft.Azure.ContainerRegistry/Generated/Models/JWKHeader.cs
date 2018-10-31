// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.ContainerRegistry.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// JSON web key parameter
    /// </summary>
    public partial class JWKHeader
    {
        /// <summary>
        /// Initializes a new instance of the JWKHeader class.
        /// </summary>
        public JWKHeader()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JWKHeader class.
        /// </summary>
        /// <param name="crv">crv value</param>
        /// <param name="kid">kid value</param>
        /// <param name="kty">kty value</param>
        /// <param name="x">x value</param>
        /// <param name="y">y value</param>
        public JWKHeader(string crv = default(string), string kid = default(string), string kty = default(string), string x = default(string), string y = default(string))
        {
            Crv = crv;
            Kid = kid;
            Kty = kty;
            X = x;
            Y = y;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets crv value
        /// </summary>
        [JsonProperty(PropertyName = "crv")]
        public string Crv { get; set; }

        /// <summary>
        /// Gets or sets kid value
        /// </summary>
        [JsonProperty(PropertyName = "kid")]
        public string Kid { get; set; }

        /// <summary>
        /// Gets or sets kty value
        /// </summary>
        [JsonProperty(PropertyName = "kty")]
        public string Kty { get; set; }

        /// <summary>
        /// Gets or sets x value
        /// </summary>
        [JsonProperty(PropertyName = "x")]
        public string X { get; set; }

        /// <summary>
        /// Gets or sets y value
        /// </summary>
        [JsonProperty(PropertyName = "y")]
        public string Y { get; set; }

    }
}
