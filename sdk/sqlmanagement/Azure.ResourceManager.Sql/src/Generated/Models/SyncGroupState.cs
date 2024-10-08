// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Sync state of the sync group. </summary>
    public readonly partial struct SyncGroupState : IEquatable<SyncGroupState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SyncGroupState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SyncGroupState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotReadyValue = "NotReady";
        private const string ErrorValue = "Error";
        private const string WarningValue = "Warning";
        private const string ProgressingValue = "Progressing";
        private const string GoodValue = "Good";

        /// <summary> NotReady. </summary>
        public static SyncGroupState NotReady { get; } = new SyncGroupState(NotReadyValue);
        /// <summary> Error. </summary>
        public static SyncGroupState Error { get; } = new SyncGroupState(ErrorValue);
        /// <summary> Warning. </summary>
        public static SyncGroupState Warning { get; } = new SyncGroupState(WarningValue);
        /// <summary> Progressing. </summary>
        public static SyncGroupState Progressing { get; } = new SyncGroupState(ProgressingValue);
        /// <summary> Good. </summary>
        public static SyncGroupState Good { get; } = new SyncGroupState(GoodValue);
        /// <summary> Determines if two <see cref="SyncGroupState"/> values are the same. </summary>
        public static bool operator ==(SyncGroupState left, SyncGroupState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SyncGroupState"/> values are not the same. </summary>
        public static bool operator !=(SyncGroupState left, SyncGroupState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SyncGroupState"/>. </summary>
        public static implicit operator SyncGroupState(string value) => new SyncGroupState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SyncGroupState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SyncGroupState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
