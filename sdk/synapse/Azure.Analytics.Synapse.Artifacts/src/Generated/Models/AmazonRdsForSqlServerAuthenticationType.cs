// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The type used for authentication. Type: string. </summary>
    public readonly partial struct AmazonRdsForSqlServerAuthenticationType : IEquatable<AmazonRdsForSqlServerAuthenticationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AmazonRdsForSqlServerAuthenticationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AmazonRdsForSqlServerAuthenticationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SQLValue = "SQL";
        private const string WindowsValue = "Windows";

        /// <summary> SQL. </summary>
        public static AmazonRdsForSqlServerAuthenticationType SQL { get; } = new AmazonRdsForSqlServerAuthenticationType(SQLValue);
        /// <summary> Windows. </summary>
        public static AmazonRdsForSqlServerAuthenticationType Windows { get; } = new AmazonRdsForSqlServerAuthenticationType(WindowsValue);
        /// <summary> Determines if two <see cref="AmazonRdsForSqlServerAuthenticationType"/> values are the same. </summary>
        public static bool operator ==(AmazonRdsForSqlServerAuthenticationType left, AmazonRdsForSqlServerAuthenticationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AmazonRdsForSqlServerAuthenticationType"/> values are not the same. </summary>
        public static bool operator !=(AmazonRdsForSqlServerAuthenticationType left, AmazonRdsForSqlServerAuthenticationType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AmazonRdsForSqlServerAuthenticationType"/>. </summary>
        public static implicit operator AmazonRdsForSqlServerAuthenticationType(string value) => new AmazonRdsForSqlServerAuthenticationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AmazonRdsForSqlServerAuthenticationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AmazonRdsForSqlServerAuthenticationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
