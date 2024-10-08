// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HardwareSecurityModules.Models
{
    /// <summary> Sku family of the Cloud HSM Cluster. </summary>
    public readonly partial struct CloudHsmClusterSkuFamily : IEquatable<CloudHsmClusterSkuFamily>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CloudHsmClusterSkuFamily"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CloudHsmClusterSkuFamily(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BValue = "B";

        /// <summary> B. </summary>
        public static CloudHsmClusterSkuFamily B { get; } = new CloudHsmClusterSkuFamily(BValue);
        /// <summary> Determines if two <see cref="CloudHsmClusterSkuFamily"/> values are the same. </summary>
        public static bool operator ==(CloudHsmClusterSkuFamily left, CloudHsmClusterSkuFamily right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CloudHsmClusterSkuFamily"/> values are not the same. </summary>
        public static bool operator !=(CloudHsmClusterSkuFamily left, CloudHsmClusterSkuFamily right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="CloudHsmClusterSkuFamily"/>. </summary>
        public static implicit operator CloudHsmClusterSkuFamily(string value) => new CloudHsmClusterSkuFamily(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CloudHsmClusterSkuFamily other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CloudHsmClusterSkuFamily other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
