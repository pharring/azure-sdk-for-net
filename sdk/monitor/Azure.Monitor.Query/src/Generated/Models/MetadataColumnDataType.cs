// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Monitor.Query.Models
{
    /// <summary> The data type of the column. </summary>
    internal readonly partial struct MetadataColumnDataType : IEquatable<MetadataColumnDataType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MetadataColumnDataType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MetadataColumnDataType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BoolValue = "bool";
        private const string DatetimeValue = "datetime";
        private const string DynamicValue = "dynamic";
        private const string IntValue = "int";
        private const string LongValue = "long";
        private const string RealValue = "real";
        private const string StringValue = "string";
        private const string GuidValue = "guid";
        private const string DecimalValue = "decimal";
        private const string TimespanValue = "timespan";

        /// <summary> bool. </summary>
        public static MetadataColumnDataType Bool { get; } = new MetadataColumnDataType(BoolValue);
        /// <summary> datetime. </summary>
        public static MetadataColumnDataType Datetime { get; } = new MetadataColumnDataType(DatetimeValue);
        /// <summary> dynamic. </summary>
        public static MetadataColumnDataType Dynamic { get; } = new MetadataColumnDataType(DynamicValue);
        /// <summary> int. </summary>
        public static MetadataColumnDataType Int { get; } = new MetadataColumnDataType(IntValue);
        /// <summary> long. </summary>
        public static MetadataColumnDataType Long { get; } = new MetadataColumnDataType(LongValue);
        /// <summary> real. </summary>
        public static MetadataColumnDataType Real { get; } = new MetadataColumnDataType(RealValue);
        /// <summary> string. </summary>
        public static MetadataColumnDataType String { get; } = new MetadataColumnDataType(StringValue);
        /// <summary> guid. </summary>
        public static MetadataColumnDataType Guid { get; } = new MetadataColumnDataType(GuidValue);
        /// <summary> decimal. </summary>
        public static MetadataColumnDataType Decimal { get; } = new MetadataColumnDataType(DecimalValue);
        /// <summary> timespan. </summary>
        public static MetadataColumnDataType Timespan { get; } = new MetadataColumnDataType(TimespanValue);
        /// <summary> Determines if two <see cref="MetadataColumnDataType"/> values are the same. </summary>
        public static bool operator ==(MetadataColumnDataType left, MetadataColumnDataType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MetadataColumnDataType"/> values are not the same. </summary>
        public static bool operator !=(MetadataColumnDataType left, MetadataColumnDataType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MetadataColumnDataType"/>. </summary>
        public static implicit operator MetadataColumnDataType(string value) => new MetadataColumnDataType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MetadataColumnDataType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MetadataColumnDataType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
