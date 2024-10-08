// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.Text
{
    /// <summary> The status of the task at the mentioned last update time. </summary>
    public readonly partial struct TextActionState : IEquatable<TextActionState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TextActionState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TextActionState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotStartedValue = "notStarted";
        private const string RunningValue = "running";
        private const string SucceededValue = "succeeded";
        private const string PartiallyCompletedValue = "partiallyCompleted";
        private const string FailedValue = "failed";
        private const string CancelledValue = "cancelled";
        private const string CancellingValue = "cancelling";

        /// <summary> Not started status. </summary>
        public static TextActionState NotStarted { get; } = new TextActionState(NotStartedValue);
        /// <summary> Running status. </summary>
        public static TextActionState Running { get; } = new TextActionState(RunningValue);
        /// <summary> Succeeded status. </summary>
        public static TextActionState Succeeded { get; } = new TextActionState(SucceededValue);
        /// <summary> Partially completed status. </summary>
        public static TextActionState PartiallyCompleted { get; } = new TextActionState(PartiallyCompletedValue);
        /// <summary> Failed status. </summary>
        public static TextActionState Failed { get; } = new TextActionState(FailedValue);
        /// <summary> Cancelled status. </summary>
        public static TextActionState Cancelled { get; } = new TextActionState(CancelledValue);
        /// <summary> Cancelling status. </summary>
        public static TextActionState Cancelling { get; } = new TextActionState(CancellingValue);
        /// <summary> Determines if two <see cref="TextActionState"/> values are the same. </summary>
        public static bool operator ==(TextActionState left, TextActionState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TextActionState"/> values are not the same. </summary>
        public static bool operator !=(TextActionState left, TextActionState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="TextActionState"/>. </summary>
        public static implicit operator TextActionState(string value) => new TextActionState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TextActionState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TextActionState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
