// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Defines the sensitivity for the rule. </summary>
    public readonly partial struct ManagedRuleSensitivityType : IEquatable<ManagedRuleSensitivityType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ManagedRuleSensitivityType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ManagedRuleSensitivityType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string LowValue = "Low";
        private const string MediumValue = "Medium";
        private const string HighValue = "High";

        /// <summary> None. </summary>
        public static ManagedRuleSensitivityType None { get; } = new ManagedRuleSensitivityType(NoneValue);
        /// <summary> Low. </summary>
        public static ManagedRuleSensitivityType Low { get; } = new ManagedRuleSensitivityType(LowValue);
        /// <summary> Medium. </summary>
        public static ManagedRuleSensitivityType Medium { get; } = new ManagedRuleSensitivityType(MediumValue);
        /// <summary> High. </summary>
        public static ManagedRuleSensitivityType High { get; } = new ManagedRuleSensitivityType(HighValue);
        /// <summary> Determines if two <see cref="ManagedRuleSensitivityType"/> values are the same. </summary>
        public static bool operator ==(ManagedRuleSensitivityType left, ManagedRuleSensitivityType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ManagedRuleSensitivityType"/> values are not the same. </summary>
        public static bool operator !=(ManagedRuleSensitivityType left, ManagedRuleSensitivityType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ManagedRuleSensitivityType"/>. </summary>
        public static implicit operator ManagedRuleSensitivityType(string value) => new ManagedRuleSensitivityType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManagedRuleSensitivityType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ManagedRuleSensitivityType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
