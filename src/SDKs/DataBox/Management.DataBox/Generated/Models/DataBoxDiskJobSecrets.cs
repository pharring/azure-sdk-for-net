// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The secrets related to disk job.
    /// </summary>
    [Newtonsoft.Json.JsonObject("DataBoxDisk")]
    public partial class DataBoxDiskJobSecrets : JobSecrets
    {
        /// <summary>
        /// Initializes a new instance of the DataBoxDiskJobSecrets class.
        /// </summary>
        public DataBoxDiskJobSecrets()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataBoxDiskJobSecrets class.
        /// </summary>
        /// <param name="diskSecrets">Contains the list of secrets object for
        /// that device.</param>
        /// <param name="passKey">PassKey for the disk Job.</param>
        /// <param name="isPasskeyUserDefined">Whether passkey was provided by
        /// user.</param>
        public DataBoxDiskJobSecrets(IList<DiskSecret> diskSecrets = default(IList<DiskSecret>), string passKey = default(string), bool? isPasskeyUserDefined = default(bool?))
        {
            DiskSecrets = diskSecrets;
            PassKey = passKey;
            IsPasskeyUserDefined = isPasskeyUserDefined;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets contains the list of secrets object for that device.
        /// </summary>
        [JsonProperty(PropertyName = "diskSecrets")]
        public IList<DiskSecret> DiskSecrets { get; private set; }

        /// <summary>
        /// Gets passKey for the disk Job.
        /// </summary>
        [JsonProperty(PropertyName = "passKey")]
        public string PassKey { get; private set; }

        /// <summary>
        /// Gets whether passkey was provided by user.
        /// </summary>
        [JsonProperty(PropertyName = "isPasskeyUserDefined")]
        public bool? IsPasskeyUserDefined { get; private set; }

    }
}
