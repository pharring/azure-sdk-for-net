// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Subscription.Models
{
    /// <summary> The accept ownership state of the resource. </summary>
    public readonly partial struct AcceptOwnershipState : IEquatable<AcceptOwnershipState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AcceptOwnershipState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AcceptOwnershipState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string CompletedValue = "Completed";
        private const string ExpiredValue = "Expired";

        /// <summary> Pending. </summary>
        public static AcceptOwnershipState Pending { get; } = new AcceptOwnershipState(PendingValue);
        /// <summary> Completed. </summary>
        public static AcceptOwnershipState Completed { get; } = new AcceptOwnershipState(CompletedValue);
        /// <summary> Expired. </summary>
        public static AcceptOwnershipState Expired { get; } = new AcceptOwnershipState(ExpiredValue);
        /// <summary> Determines if two <see cref="AcceptOwnershipState"/> values are the same. </summary>
        public static bool operator ==(AcceptOwnershipState left, AcceptOwnershipState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AcceptOwnershipState"/> values are not the same. </summary>
        public static bool operator !=(AcceptOwnershipState left, AcceptOwnershipState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AcceptOwnershipState"/>. </summary>
        public static implicit operator AcceptOwnershipState(string value) => new AcceptOwnershipState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AcceptOwnershipState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AcceptOwnershipState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
