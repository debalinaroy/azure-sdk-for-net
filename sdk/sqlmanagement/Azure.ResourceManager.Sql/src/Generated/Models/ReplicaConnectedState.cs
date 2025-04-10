// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Link connected state. </summary>
    public readonly partial struct ReplicaConnectedState : IEquatable<ReplicaConnectedState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ReplicaConnectedState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ReplicaConnectedState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisconnectedValue = "DISCONNECTED";
        private const string ConnectedValue = "CONNECTED";

        /// <summary> DISCONNECTED. </summary>
        public static ReplicaConnectedState Disconnected { get; } = new ReplicaConnectedState(DisconnectedValue);
        /// <summary> CONNECTED. </summary>
        public static ReplicaConnectedState Connected { get; } = new ReplicaConnectedState(ConnectedValue);
        /// <summary> Determines if two <see cref="ReplicaConnectedState"/> values are the same. </summary>
        public static bool operator ==(ReplicaConnectedState left, ReplicaConnectedState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ReplicaConnectedState"/> values are not the same. </summary>
        public static bool operator !=(ReplicaConnectedState left, ReplicaConnectedState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ReplicaConnectedState"/>. </summary>
        public static implicit operator ReplicaConnectedState(string value) => new ReplicaConnectedState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ReplicaConnectedState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ReplicaConnectedState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
