// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The table temporal type. </summary>
    public readonly partial struct TableTemporalType : IEquatable<TableTemporalType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TableTemporalType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TableTemporalType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NonTemporalTableValue = "NonTemporalTable";
        private const string HistoryTableValue = "HistoryTable";
        private const string SystemVersionedTemporalTableValue = "SystemVersionedTemporalTable";

        /// <summary> NonTemporalTable. </summary>
        public static TableTemporalType NonTemporalTable { get; } = new TableTemporalType(NonTemporalTableValue);
        /// <summary> HistoryTable. </summary>
        public static TableTemporalType HistoryTable { get; } = new TableTemporalType(HistoryTableValue);
        /// <summary> SystemVersionedTemporalTable. </summary>
        public static TableTemporalType SystemVersionedTemporalTable { get; } = new TableTemporalType(SystemVersionedTemporalTableValue);
        /// <summary> Determines if two <see cref="TableTemporalType"/> values are the same. </summary>
        public static bool operator ==(TableTemporalType left, TableTemporalType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TableTemporalType"/> values are not the same. </summary>
        public static bool operator !=(TableTemporalType left, TableTemporalType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="TableTemporalType"/>. </summary>
        public static implicit operator TableTemporalType(string value) => new TableTemporalType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TableTemporalType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TableTemporalType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
