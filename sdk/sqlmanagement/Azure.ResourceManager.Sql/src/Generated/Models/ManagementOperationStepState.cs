// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The ManagementOperationStepState. </summary>
    public readonly partial struct ManagementOperationStepState : IEquatable<ManagementOperationStepState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ManagementOperationStepState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ManagementOperationStepState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotStartedValue = "NotStarted";
        private const string InProgressValue = "InProgress";
        private const string SlowedDownValue = "SlowedDown";
        private const string CompletedValue = "Completed";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";

        /// <summary> NotStarted. </summary>
        public static ManagementOperationStepState NotStarted { get; } = new ManagementOperationStepState(NotStartedValue);
        /// <summary> InProgress. </summary>
        public static ManagementOperationStepState InProgress { get; } = new ManagementOperationStepState(InProgressValue);
        /// <summary> SlowedDown. </summary>
        public static ManagementOperationStepState SlowedDown { get; } = new ManagementOperationStepState(SlowedDownValue);
        /// <summary> Completed. </summary>
        public static ManagementOperationStepState Completed { get; } = new ManagementOperationStepState(CompletedValue);
        /// <summary> Failed. </summary>
        public static ManagementOperationStepState Failed { get; } = new ManagementOperationStepState(FailedValue);
        /// <summary> Canceled. </summary>
        public static ManagementOperationStepState Canceled { get; } = new ManagementOperationStepState(CanceledValue);
        /// <summary> Determines if two <see cref="ManagementOperationStepState"/> values are the same. </summary>
        public static bool operator ==(ManagementOperationStepState left, ManagementOperationStepState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ManagementOperationStepState"/> values are not the same. </summary>
        public static bool operator !=(ManagementOperationStepState left, ManagementOperationStepState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ManagementOperationStepState"/>. </summary>
        public static implicit operator ManagementOperationStepState(string value) => new ManagementOperationStepState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManagementOperationStepState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ManagementOperationStepState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
