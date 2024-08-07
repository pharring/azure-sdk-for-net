// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ApiManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing the ApiManagementCertificate data model.
    /// Certificate details.
    /// </summary>
    public partial class ApiManagementCertificateData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ApiManagementCertificateData"/>. </summary>
        public ApiManagementCertificateData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementCertificateData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="subject"> Subject attribute of the certificate. </param>
        /// <param name="thumbprint"> Thumbprint of the certificate. </param>
        /// <param name="expireOn">
        /// Expiration date of the certificate. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </param>
        /// <param name="keyVaultDetails"> KeyVault location details of the certificate. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiManagementCertificateData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string subject, string thumbprint, DateTimeOffset? expireOn, KeyVaultContractProperties keyVaultDetails, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Subject = subject;
            Thumbprint = thumbprint;
            ExpireOn = expireOn;
            KeyVaultDetails = keyVaultDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Subject attribute of the certificate. </summary>
        [WirePath("properties.subject")]
        public string Subject { get; set; }
        /// <summary> Thumbprint of the certificate. </summary>
        [WirePath("properties.thumbprint")]
        public string Thumbprint { get; set; }
        /// <summary>
        /// Expiration date of the certificate. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </summary>
        [WirePath("properties.expirationDate")]
        public DateTimeOffset? ExpireOn { get; set; }
        /// <summary> KeyVault location details of the certificate. </summary>
        [WirePath("properties.keyVault")]
        public KeyVaultContractProperties KeyVaultDetails { get; set; }
    }
}
