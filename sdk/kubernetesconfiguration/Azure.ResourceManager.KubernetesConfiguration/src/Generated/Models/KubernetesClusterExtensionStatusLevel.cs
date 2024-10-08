// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    /// <summary> Level of the status. </summary>
    public readonly partial struct KubernetesClusterExtensionStatusLevel : IEquatable<KubernetesClusterExtensionStatusLevel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KubernetesClusterExtensionStatusLevel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KubernetesClusterExtensionStatusLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ErrorValue = "Error";
        private const string WarningValue = "Warning";
        private const string InformationValue = "Information";

        /// <summary> Error. </summary>
        public static KubernetesClusterExtensionStatusLevel Error { get; } = new KubernetesClusterExtensionStatusLevel(ErrorValue);
        /// <summary> Warning. </summary>
        public static KubernetesClusterExtensionStatusLevel Warning { get; } = new KubernetesClusterExtensionStatusLevel(WarningValue);
        /// <summary> Information. </summary>
        public static KubernetesClusterExtensionStatusLevel Information { get; } = new KubernetesClusterExtensionStatusLevel(InformationValue);
        /// <summary> Determines if two <see cref="KubernetesClusterExtensionStatusLevel"/> values are the same. </summary>
        public static bool operator ==(KubernetesClusterExtensionStatusLevel left, KubernetesClusterExtensionStatusLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KubernetesClusterExtensionStatusLevel"/> values are not the same. </summary>
        public static bool operator !=(KubernetesClusterExtensionStatusLevel left, KubernetesClusterExtensionStatusLevel right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="KubernetesClusterExtensionStatusLevel"/>. </summary>
        public static implicit operator KubernetesClusterExtensionStatusLevel(string value) => new KubernetesClusterExtensionStatusLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KubernetesClusterExtensionStatusLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KubernetesClusterExtensionStatusLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
