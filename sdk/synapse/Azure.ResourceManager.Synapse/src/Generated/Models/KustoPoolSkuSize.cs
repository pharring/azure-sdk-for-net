// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> SKU size. </summary>
    public readonly partial struct KustoPoolSkuSize : IEquatable<KustoPoolSkuSize>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KustoPoolSkuSize"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KustoPoolSkuSize(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ExtraSmallValue = "Extra small";
        private const string SmallValue = "Small";
        private const string MediumValue = "Medium";
        private const string LargeValue = "Large";

        /// <summary> Extra small. </summary>
        public static KustoPoolSkuSize ExtraSmall { get; } = new KustoPoolSkuSize(ExtraSmallValue);
        /// <summary> Small. </summary>
        public static KustoPoolSkuSize Small { get; } = new KustoPoolSkuSize(SmallValue);
        /// <summary> Medium. </summary>
        public static KustoPoolSkuSize Medium { get; } = new KustoPoolSkuSize(MediumValue);
        /// <summary> Large. </summary>
        public static KustoPoolSkuSize Large { get; } = new KustoPoolSkuSize(LargeValue);
        /// <summary> Determines if two <see cref="KustoPoolSkuSize"/> values are the same. </summary>
        public static bool operator ==(KustoPoolSkuSize left, KustoPoolSkuSize right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KustoPoolSkuSize"/> values are not the same. </summary>
        public static bool operator !=(KustoPoolSkuSize left, KustoPoolSkuSize right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="KustoPoolSkuSize"/>. </summary>
        public static implicit operator KustoPoolSkuSize(string value) => new KustoPoolSkuSize(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KustoPoolSkuSize other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KustoPoolSkuSize other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
