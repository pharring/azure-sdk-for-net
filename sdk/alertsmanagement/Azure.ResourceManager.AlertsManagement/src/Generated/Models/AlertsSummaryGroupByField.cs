// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary> The AlertsSummaryGroupByField. </summary>
    public readonly partial struct AlertsSummaryGroupByField : IEquatable<AlertsSummaryGroupByField>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AlertsSummaryGroupByField"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AlertsSummaryGroupByField(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SeverityValue = "severity";
        private const string AlertStateValue = "alertState";
        private const string MonitorConditionValue = "monitorCondition";
        private const string MonitorServiceValue = "monitorService";
        private const string SignalTypeValue = "signalType";
        private const string AlertRuleValue = "alertRule";

        /// <summary> severity. </summary>
        public static AlertsSummaryGroupByField Severity { get; } = new AlertsSummaryGroupByField(SeverityValue);
        /// <summary> alertState. </summary>
        public static AlertsSummaryGroupByField AlertState { get; } = new AlertsSummaryGroupByField(AlertStateValue);
        /// <summary> monitorCondition. </summary>
        public static AlertsSummaryGroupByField MonitorCondition { get; } = new AlertsSummaryGroupByField(MonitorConditionValue);
        /// <summary> monitorService. </summary>
        public static AlertsSummaryGroupByField MonitorService { get; } = new AlertsSummaryGroupByField(MonitorServiceValue);
        /// <summary> signalType. </summary>
        public static AlertsSummaryGroupByField SignalType { get; } = new AlertsSummaryGroupByField(SignalTypeValue);
        /// <summary> alertRule. </summary>
        public static AlertsSummaryGroupByField AlertRule { get; } = new AlertsSummaryGroupByField(AlertRuleValue);
        /// <summary> Determines if two <see cref="AlertsSummaryGroupByField"/> values are the same. </summary>
        public static bool operator ==(AlertsSummaryGroupByField left, AlertsSummaryGroupByField right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AlertsSummaryGroupByField"/> values are not the same. </summary>
        public static bool operator !=(AlertsSummaryGroupByField left, AlertsSummaryGroupByField right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AlertsSummaryGroupByField"/>. </summary>
        public static implicit operator AlertsSummaryGroupByField(string value) => new AlertsSummaryGroupByField(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AlertsSummaryGroupByField other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AlertsSummaryGroupByField other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
