// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.HealthDataAIServices.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableHealthDataAIServicesArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableHealthDataAIServicesArmClient"/> class for mocking. </summary>
        protected MockableHealthDataAIServicesArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableHealthDataAIServicesArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableHealthDataAIServicesArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableHealthDataAIServicesArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="DeidServiceResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DeidServiceResource.CreateResourceIdentifier" /> to create a <see cref="DeidServiceResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DeidServiceResource"/> object. </returns>
        public virtual DeidServiceResource GetDeidServiceResource(ResourceIdentifier id)
        {
            DeidServiceResource.ValidateResourceId(id);
            return new DeidServiceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HealthDataAIServicesPrivateEndpointConnectionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HealthDataAIServicesPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="HealthDataAIServicesPrivateEndpointConnectionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HealthDataAIServicesPrivateEndpointConnectionResource"/> object. </returns>
        public virtual HealthDataAIServicesPrivateEndpointConnectionResource GetHealthDataAIServicesPrivateEndpointConnectionResource(ResourceIdentifier id)
        {
            HealthDataAIServicesPrivateEndpointConnectionResource.ValidateResourceId(id);
            return new HealthDataAIServicesPrivateEndpointConnectionResource(Client, id);
        }
    }
}
