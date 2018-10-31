// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// VpnSite Resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VpnSite : Resource
    {
        /// <summary>
        /// Initializes a new instance of the VpnSite class.
        /// </summary>
        public VpnSite()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VpnSite class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="virtualWan">The VirtualWAN to which the vpnSite
        /// belongs</param>
        /// <param name="deviceProperties">The device properties</param>
        /// <param name="ipAddress">The ip-address for the vpn-site.</param>
        /// <param name="siteKey">The key for vpn-site that can be used for
        /// connections.</param>
        /// <param name="addressSpace">The AddressSpace that contains an array
        /// of IP address ranges.</param>
        /// <param name="bgpProperties">The set of bgp properties.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'</param>
        /// <param name="isSecuritySite">IsSecuritySite flag</param>
        /// <param name="etag">Gets a unique read-only string that changes
        /// whenever the resource is updated.</param>
        public VpnSite(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), SubResource virtualWan = default(SubResource), DeviceProperties deviceProperties = default(DeviceProperties), string ipAddress = default(string), string siteKey = default(string), AddressSpace addressSpace = default(AddressSpace), BgpSettings bgpProperties = default(BgpSettings), string provisioningState = default(string), bool? isSecuritySite = default(bool?), string etag = default(string))
            : base(id, name, type, location, tags)
        {
            VirtualWan = virtualWan;
            DeviceProperties = deviceProperties;
            IpAddress = ipAddress;
            SiteKey = siteKey;
            AddressSpace = addressSpace;
            BgpProperties = bgpProperties;
            ProvisioningState = provisioningState;
            IsSecuritySite = isSecuritySite;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the VirtualWAN to which the vpnSite belongs
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualWan")]
        public SubResource VirtualWan { get; set; }

        /// <summary>
        /// Gets or sets the device properties
        /// </summary>
        [JsonProperty(PropertyName = "properties.deviceProperties")]
        public DeviceProperties DeviceProperties { get; set; }

        /// <summary>
        /// Gets or sets the ip-address for the vpn-site.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets the key for vpn-site that can be used for connections.
        /// </summary>
        [JsonProperty(PropertyName = "properties.siteKey")]
        public string SiteKey { get; set; }

        /// <summary>
        /// Gets or sets the AddressSpace that contains an array of IP address
        /// ranges.
        /// </summary>
        [JsonProperty(PropertyName = "properties.addressSpace")]
        public AddressSpace AddressSpace { get; set; }

        /// <summary>
        /// Gets or sets the set of bgp properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties.bgpProperties")]
        public BgpSettings BgpProperties { get; set; }

        /// <summary>
        /// Gets or sets the provisioning state of the resource. Possible
        /// values include: 'Succeeded', 'Updating', 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets isSecuritySite flag
        /// </summary>
        [JsonProperty(PropertyName = "properties.isSecuritySite")]
        public bool? IsSecuritySite { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

    }
}
