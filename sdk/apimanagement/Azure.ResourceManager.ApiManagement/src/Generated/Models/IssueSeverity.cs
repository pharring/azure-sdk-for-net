// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> The severity of the issue. </summary>
    public readonly partial struct IssueSeverity : IEquatable<IssueSeverity>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IssueSeverity"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IssueSeverity(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ErrorValue = "Error";
        private const string WarningValue = "Warning";

        /// <summary> Error. </summary>
        public static IssueSeverity Error { get; } = new IssueSeverity(ErrorValue);
        /// <summary> Warning. </summary>
        public static IssueSeverity Warning { get; } = new IssueSeverity(WarningValue);
        /// <summary> Determines if two <see cref="IssueSeverity"/> values are the same. </summary>
        public static bool operator ==(IssueSeverity left, IssueSeverity right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IssueSeverity"/> values are not the same. </summary>
        public static bool operator !=(IssueSeverity left, IssueSeverity right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="IssueSeverity"/>. </summary>
        public static implicit operator IssueSeverity(string value) => new IssueSeverity(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IssueSeverity other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IssueSeverity other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
