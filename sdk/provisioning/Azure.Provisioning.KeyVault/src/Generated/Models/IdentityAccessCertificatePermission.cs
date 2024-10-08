// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.KeyVault;

/// <summary>
/// The IdentityAccessCertificatePermission.
/// </summary>
public enum IdentityAccessCertificatePermission
{
    /// <summary>
    /// all.
    /// </summary>
    [DataMember(Name = "all")]
    All,

    /// <summary>
    /// get.
    /// </summary>
    [DataMember(Name = "get")]
    Get,

    /// <summary>
    /// list.
    /// </summary>
    [DataMember(Name = "list")]
    List,

    /// <summary>
    /// delete.
    /// </summary>
    [DataMember(Name = "delete")]
    Delete,

    /// <summary>
    /// create.
    /// </summary>
    [DataMember(Name = "create")]
    Create,

    /// <summary>
    /// import.
    /// </summary>
    [DataMember(Name = "import")]
    Import,

    /// <summary>
    /// update.
    /// </summary>
    [DataMember(Name = "update")]
    Update,

    /// <summary>
    /// managecontacts.
    /// </summary>
    [DataMember(Name = "managecontacts")]
    ManageContacts,

    /// <summary>
    /// getissuers.
    /// </summary>
    [DataMember(Name = "getissuers")]
    GetIssuers,

    /// <summary>
    /// listissuers.
    /// </summary>
    [DataMember(Name = "listissuers")]
    ListIssuers,

    /// <summary>
    /// setissuers.
    /// </summary>
    [DataMember(Name = "setissuers")]
    SetIssuers,

    /// <summary>
    /// deleteissuers.
    /// </summary>
    [DataMember(Name = "deleteissuers")]
    DeleteIssuers,

    /// <summary>
    /// manageissuers.
    /// </summary>
    [DataMember(Name = "manageissuers")]
    ManageIssuers,

    /// <summary>
    /// recover.
    /// </summary>
    [DataMember(Name = "recover")]
    Recover,

    /// <summary>
    /// purge.
    /// </summary>
    [DataMember(Name = "purge")]
    Purge,

    /// <summary>
    /// backup.
    /// </summary>
    [DataMember(Name = "backup")]
    Backup,

    /// <summary>
    /// restore.
    /// </summary>
    [DataMember(Name = "restore")]
    Restore,
}
