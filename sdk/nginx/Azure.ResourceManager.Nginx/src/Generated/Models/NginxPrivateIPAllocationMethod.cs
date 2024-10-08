// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Nginx.Models
{
    /// <summary> The NginxPrivateIPAllocationMethod. </summary>
    public readonly partial struct NginxPrivateIPAllocationMethod : IEquatable<NginxPrivateIPAllocationMethod>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NginxPrivateIPAllocationMethod"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NginxPrivateIPAllocationMethod(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StaticValue = "Static";
        private const string DynamicValue = "Dynamic";

        /// <summary> Static. </summary>
        public static NginxPrivateIPAllocationMethod Static { get; } = new NginxPrivateIPAllocationMethod(StaticValue);
        /// <summary> Dynamic. </summary>
        public static NginxPrivateIPAllocationMethod Dynamic { get; } = new NginxPrivateIPAllocationMethod(DynamicValue);
        /// <summary> Determines if two <see cref="NginxPrivateIPAllocationMethod"/> values are the same. </summary>
        public static bool operator ==(NginxPrivateIPAllocationMethod left, NginxPrivateIPAllocationMethod right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NginxPrivateIPAllocationMethod"/> values are not the same. </summary>
        public static bool operator !=(NginxPrivateIPAllocationMethod left, NginxPrivateIPAllocationMethod right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="NginxPrivateIPAllocationMethod"/>. </summary>
        public static implicit operator NginxPrivateIPAllocationMethod(string value) => new NginxPrivateIPAllocationMethod(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NginxPrivateIPAllocationMethod other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NginxPrivateIPAllocationMethod other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
