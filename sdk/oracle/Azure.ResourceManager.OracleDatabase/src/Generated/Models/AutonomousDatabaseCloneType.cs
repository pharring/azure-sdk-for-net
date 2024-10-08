// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    /// <summary> Clone type enum. </summary>
    public readonly partial struct AutonomousDatabaseCloneType : IEquatable<AutonomousDatabaseCloneType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AutonomousDatabaseCloneType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AutonomousDatabaseCloneType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FullValue = "Full";
        private const string MetadataValue = "Metadata";

        /// <summary> Full clone. </summary>
        public static AutonomousDatabaseCloneType Full { get; } = new AutonomousDatabaseCloneType(FullValue);
        /// <summary> Metadata only. </summary>
        public static AutonomousDatabaseCloneType Metadata { get; } = new AutonomousDatabaseCloneType(MetadataValue);
        /// <summary> Determines if two <see cref="AutonomousDatabaseCloneType"/> values are the same. </summary>
        public static bool operator ==(AutonomousDatabaseCloneType left, AutonomousDatabaseCloneType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AutonomousDatabaseCloneType"/> values are not the same. </summary>
        public static bool operator !=(AutonomousDatabaseCloneType left, AutonomousDatabaseCloneType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AutonomousDatabaseCloneType"/>. </summary>
        public static implicit operator AutonomousDatabaseCloneType(string value) => new AutonomousDatabaseCloneType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AutonomousDatabaseCloneType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AutonomousDatabaseCloneType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
