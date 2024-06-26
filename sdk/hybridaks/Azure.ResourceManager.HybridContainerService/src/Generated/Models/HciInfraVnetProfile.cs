// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> Infrastructure network profile for HCI platform. </summary>
    public partial class HciInfraVnetProfile
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

        /// <summary> Initializes a new instance of <see cref="HciInfraVnetProfile"/>. </summary>
        public HciInfraVnetProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HciInfraVnetProfile"/>. </summary>
        /// <param name="mocGroup"> Group in MOC(Microsoft On-premises Cloud). </param>
        /// <param name="mocLocation"> Location in MOC(Microsoft On-premises Cloud). </param>
        /// <param name="mocVnetName"> Virtual Network name in MOC(Microsoft On-premises Cloud). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HciInfraVnetProfile(string mocGroup, string mocLocation, string mocVnetName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MocGroup = mocGroup;
            MocLocation = mocLocation;
            MocVnetName = mocVnetName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Group in MOC(Microsoft On-premises Cloud). </summary>
        public string MocGroup { get; set; }
        /// <summary> Location in MOC(Microsoft On-premises Cloud). </summary>
        public string MocLocation { get; set; }
        /// <summary> Virtual Network name in MOC(Microsoft On-premises Cloud). </summary>
        public string MocVnetName { get; set; }
    }
}
