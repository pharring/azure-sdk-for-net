// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Result of this upgrade. </summary>
    public readonly partial struct ClusterPoolUpgradeHistoryUpgradeResultType : IEquatable<ClusterPoolUpgradeHistoryUpgradeResultType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ClusterPoolUpgradeHistoryUpgradeResultType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ClusterPoolUpgradeHistoryUpgradeResultType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceedValue = "Succeed";
        private const string FailedValue = "Failed";

        /// <summary> Succeed. </summary>
        public static ClusterPoolUpgradeHistoryUpgradeResultType Succeed { get; } = new ClusterPoolUpgradeHistoryUpgradeResultType(SucceedValue);
        /// <summary> Failed. </summary>
        public static ClusterPoolUpgradeHistoryUpgradeResultType Failed { get; } = new ClusterPoolUpgradeHistoryUpgradeResultType(FailedValue);
        /// <summary> Determines if two <see cref="ClusterPoolUpgradeHistoryUpgradeResultType"/> values are the same. </summary>
        public static bool operator ==(ClusterPoolUpgradeHistoryUpgradeResultType left, ClusterPoolUpgradeHistoryUpgradeResultType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ClusterPoolUpgradeHistoryUpgradeResultType"/> values are not the same. </summary>
        public static bool operator !=(ClusterPoolUpgradeHistoryUpgradeResultType left, ClusterPoolUpgradeHistoryUpgradeResultType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ClusterPoolUpgradeHistoryUpgradeResultType"/>. </summary>
        public static implicit operator ClusterPoolUpgradeHistoryUpgradeResultType(string value) => new ClusterPoolUpgradeHistoryUpgradeResultType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ClusterPoolUpgradeHistoryUpgradeResultType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ClusterPoolUpgradeHistoryUpgradeResultType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
