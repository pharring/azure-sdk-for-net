// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    /// <summary> The application client type. </summary>
    public readonly partial struct LinkerClientType : IEquatable<LinkerClientType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LinkerClientType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LinkerClientType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "none";
        private const string DotnetValue = "dotnet";
        private const string JavaValue = "java";
        private const string PythonValue = "python";
        private const string GoValue = "go";
        private const string PhpValue = "php";
        private const string RubyValue = "ruby";
        private const string DjangoValue = "django";
        private const string NodejsValue = "nodejs";
        private const string SpringBootValue = "springBoot";

        /// <summary> none. </summary>
        public static LinkerClientType None { get; } = new LinkerClientType(NoneValue);
        /// <summary> dotnet. </summary>
        public static LinkerClientType Dotnet { get; } = new LinkerClientType(DotnetValue);
        /// <summary> java. </summary>
        public static LinkerClientType Java { get; } = new LinkerClientType(JavaValue);
        /// <summary> python. </summary>
        public static LinkerClientType Python { get; } = new LinkerClientType(PythonValue);
        /// <summary> go. </summary>
        public static LinkerClientType Go { get; } = new LinkerClientType(GoValue);
        /// <summary> php. </summary>
        public static LinkerClientType Php { get; } = new LinkerClientType(PhpValue);
        /// <summary> ruby. </summary>
        public static LinkerClientType Ruby { get; } = new LinkerClientType(RubyValue);
        /// <summary> django. </summary>
        public static LinkerClientType Django { get; } = new LinkerClientType(DjangoValue);
        /// <summary> nodejs. </summary>
        public static LinkerClientType Nodejs { get; } = new LinkerClientType(NodejsValue);
        /// <summary> springBoot. </summary>
        public static LinkerClientType SpringBoot { get; } = new LinkerClientType(SpringBootValue);
        /// <summary> Determines if two <see cref="LinkerClientType"/> values are the same. </summary>
        public static bool operator ==(LinkerClientType left, LinkerClientType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LinkerClientType"/> values are not the same. </summary>
        public static bool operator !=(LinkerClientType left, LinkerClientType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="LinkerClientType"/>. </summary>
        public static implicit operator LinkerClientType(string value) => new LinkerClientType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LinkerClientType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LinkerClientType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
