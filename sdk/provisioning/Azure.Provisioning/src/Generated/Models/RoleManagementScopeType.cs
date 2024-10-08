// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.Authorization;

/// <summary>
/// Type of the scope.
/// </summary>
public enum RoleManagementScopeType
{
    /// <summary>
    /// subscription.
    /// </summary>
    [DataMember(Name = "subscription")]
    Subscription,

    /// <summary>
    /// managementgroup.
    /// </summary>
    [DataMember(Name = "managementgroup")]
    ManagementGroup,

    /// <summary>
    /// resourcegroup.
    /// </summary>
    [DataMember(Name = "resourcegroup")]
    ResourceGroup,
}
