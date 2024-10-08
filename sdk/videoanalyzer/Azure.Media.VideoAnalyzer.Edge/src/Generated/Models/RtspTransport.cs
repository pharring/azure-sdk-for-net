// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Network transport utilized by the RTSP and RTP exchange: TCP or HTTP. When using TCP, the RTP packets are interleaved on the TCP RTSP connection. When using HTTP, the RTSP messages are exchanged through long lived HTTP connections, and the RTP packages are interleaved in the HTTP connections alongside the RTSP messages. </summary>
    public readonly partial struct RtspTransport : IEquatable<RtspTransport>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RtspTransport"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RtspTransport(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HttpValue = "http";
        private const string TcpValue = "tcp";

        /// <summary> HTTP transport. RTSP messages are exchanged over long running HTTP requests and RTP packets are interleaved within the HTTP channel. </summary>
        public static RtspTransport Http { get; } = new RtspTransport(HttpValue);
        /// <summary> TCP transport. RTSP is used directly over TCP and RTP packets are interleaved within the TCP channel. </summary>
        public static RtspTransport Tcp { get; } = new RtspTransport(TcpValue);
        /// <summary> Determines if two <see cref="RtspTransport"/> values are the same. </summary>
        public static bool operator ==(RtspTransport left, RtspTransport right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RtspTransport"/> values are not the same. </summary>
        public static bool operator !=(RtspTransport left, RtspTransport right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="RtspTransport"/>. </summary>
        public static implicit operator RtspTransport(string value) => new RtspTransport(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RtspTransport other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RtspTransport other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
