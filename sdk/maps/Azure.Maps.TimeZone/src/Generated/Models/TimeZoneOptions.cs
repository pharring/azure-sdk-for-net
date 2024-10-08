// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Maps.TimeZone.Models
{
    /// <summary> The TimezoneOptions. </summary>
    public readonly partial struct TimeZoneOptions : IEquatable<TimeZoneOptions>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TimeZoneOptions"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TimeZoneOptions(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "none";
        private const string ZoneInfoValue = "zoneInfo";
        private const string TransitionsValue = "transitions";
        private const string AllValue = "all";

        /// <summary> Do not include zoneinfo or transitions in the result. </summary>
        public static TimeZoneOptions None { get; } = new TimeZoneOptions(NoneValue);
        /// <summary> Include additional time zone info in the result. </summary>
        public static TimeZoneOptions ZoneInfo { get; } = new TimeZoneOptions(ZoneInfoValue);
        /// <summary> Include transition information in the result (The number of transitions is currently capped at 250). </summary>
        public static TimeZoneOptions Transitions { get; } = new TimeZoneOptions(TransitionsValue);
        /// <summary> Include both zoneinfo and transitions in the result. </summary>
        public static TimeZoneOptions All { get; } = new TimeZoneOptions(AllValue);
        /// <summary> Determines if two <see cref="TimeZoneOptions"/> values are the same. </summary>
        public static bool operator ==(TimeZoneOptions left, TimeZoneOptions right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TimeZoneOptions"/> values are not the same. </summary>
        public static bool operator !=(TimeZoneOptions left, TimeZoneOptions right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="TimeZoneOptions"/>. </summary>
        public static implicit operator TimeZoneOptions(string value) => new TimeZoneOptions(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TimeZoneOptions other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TimeZoneOptions other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
