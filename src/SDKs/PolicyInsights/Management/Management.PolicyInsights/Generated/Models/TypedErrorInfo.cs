// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PolicyInsights.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Scenario specific error details.
    /// </summary>
    public partial class TypedErrorInfo
    {
        /// <summary>
        /// Initializes a new instance of the TypedErrorInfo class.
        /// </summary>
        public TypedErrorInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TypedErrorInfo class.
        /// </summary>
        /// <param name="type">The type of included error details.</param>
        /// <param name="info">The scenario specific error details.</param>
        public TypedErrorInfo(string type = default(string), object info = default(object))
        {
            Type = type;
            Info = info;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the type of included error details.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets the scenario specific error details.
        /// </summary>
        [JsonProperty(PropertyName = "info")]
        public object Info { get; private set; }

    }
}
