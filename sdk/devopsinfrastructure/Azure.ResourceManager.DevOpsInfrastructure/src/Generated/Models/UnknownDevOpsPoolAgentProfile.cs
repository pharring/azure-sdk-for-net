// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DevOpsInfrastructure.Models
{
    /// <summary> Unknown version of DevOpsPoolAgentProfile. </summary>
    internal partial class UnknownDevOpsPoolAgentProfile : DevOpsPoolAgentProfile
    {
        /// <summary> Initializes a new instance of <see cref="UnknownDevOpsPoolAgentProfile"/>. </summary>
        /// <param name="kind"> Discriminator property for DevOpsPoolAgentProfile. </param>
        /// <param name="resourcePredictions"> Defines pool buffer/stand-by agents. </param>
        /// <param name="resourcePredictionsProfile">
        /// Defines how the pool buffer/stand-by agents is provided.
        /// Please note <see cref="ResourcePredictionsProfile"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AutomaticResourcePredictionsProfile"/> and <see cref="ManualResourcePredictionsProfile"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownDevOpsPoolAgentProfile(string kind, ResourcePredictions resourcePredictions, ResourcePredictionsProfile resourcePredictionsProfile, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(kind, resourcePredictions, resourcePredictionsProfile, serializedAdditionalRawData)
        {
            Kind = kind ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownDevOpsPoolAgentProfile"/> for deserialization. </summary>
        internal UnknownDevOpsPoolAgentProfile()
        {
        }
    }
}
