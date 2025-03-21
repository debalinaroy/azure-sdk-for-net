// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Conversations.Authoring
{
    public partial class AssignedProjectDeploymentMetadata : IUtf8JsonSerializable, IJsonModel<AssignedProjectDeploymentMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AssignedProjectDeploymentMetadata>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AssignedProjectDeploymentMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssignedProjectDeploymentMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AssignedProjectDeploymentMetadata)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("deploymentName"u8);
            writer.WriteStringValue(DeploymentName);
            writer.WritePropertyName("lastDeployedDateTime"u8);
            writer.WriteStringValue(LastDeployedOn, "O");
            writer.WritePropertyName("deploymentExpirationDate"u8);
            writer.WriteStringValue(DeploymentExpiresOn, "D");
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        AssignedProjectDeploymentMetadata IJsonModel<AssignedProjectDeploymentMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssignedProjectDeploymentMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AssignedProjectDeploymentMetadata)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAssignedProjectDeploymentMetadata(document.RootElement, options);
        }

        internal static AssignedProjectDeploymentMetadata DeserializeAssignedProjectDeploymentMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string deploymentName = default;
            DateTimeOffset lastDeployedDateTime = default;
            DateTimeOffset deploymentExpirationDate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deploymentName"u8))
                {
                    deploymentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastDeployedDateTime"u8))
                {
                    lastDeployedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("deploymentExpirationDate"u8))
                {
                    deploymentExpirationDate = property.Value.GetDateTimeOffset("D");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AssignedProjectDeploymentMetadata(deploymentName, lastDeployedDateTime, deploymentExpirationDate, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AssignedProjectDeploymentMetadata>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssignedProjectDeploymentMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AssignedProjectDeploymentMetadata)} does not support writing '{options.Format}' format.");
            }
        }

        AssignedProjectDeploymentMetadata IPersistableModel<AssignedProjectDeploymentMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssignedProjectDeploymentMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAssignedProjectDeploymentMetadata(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AssignedProjectDeploymentMetadata)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AssignedProjectDeploymentMetadata>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AssignedProjectDeploymentMetadata FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAssignedProjectDeploymentMetadata(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
