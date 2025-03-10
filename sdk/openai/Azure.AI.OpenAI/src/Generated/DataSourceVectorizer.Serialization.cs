// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.AI.OpenAI.Chat
{
    [PersistableModelProxy(typeof(InternalUnknownAzureChatDataSourceVectorizationSource))]
    public partial class DataSourceVectorizer : IJsonModel<DataSourceVectorizer>
    {
        void IJsonModel<DataSourceVectorizer>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataSourceVectorizer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataSourceVectorizer)} does not support writing '{format}' format.");
            }

            if (SerializedAdditionalRawData?.ContainsKey("type") != true)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type);
            }
            if (SerializedAdditionalRawData != null)
            {
                foreach (var item in SerializedAdditionalRawData)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
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

        DataSourceVectorizer IJsonModel<DataSourceVectorizer>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataSourceVectorizer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataSourceVectorizer)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataSourceVectorizer(document.RootElement, options);
        }

        internal static DataSourceVectorizer DeserializeDataSourceVectorizer(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "deployment_name": return InternalAzureChatDataSourceDeploymentNameVectorizationSource.DeserializeInternalAzureChatDataSourceDeploymentNameVectorizationSource(element, options);
                    case "endpoint": return InternalAzureChatDataSourceEndpointVectorizationSource.DeserializeInternalAzureChatDataSourceEndpointVectorizationSource(element, options);
                    case "integrated": return InternalAzureChatDataSourceIntegratedVectorizationSource.DeserializeInternalAzureChatDataSourceIntegratedVectorizationSource(element, options);
                    case "model_id": return InternalAzureChatDataSourceModelIdVectorizationSource.DeserializeInternalAzureChatDataSourceModelIdVectorizationSource(element, options);
                }
            }
            return InternalUnknownAzureChatDataSourceVectorizationSource.DeserializeInternalUnknownAzureChatDataSourceVectorizationSource(element, options);
        }

        BinaryData IPersistableModel<DataSourceVectorizer>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataSourceVectorizer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataSourceVectorizer)} does not support writing '{options.Format}' format.");
            }
        }

        DataSourceVectorizer IPersistableModel<DataSourceVectorizer>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataSourceVectorizer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataSourceVectorizer(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataSourceVectorizer)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataSourceVectorizer>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static DataSourceVectorizer FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDataSourceVectorizer(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
