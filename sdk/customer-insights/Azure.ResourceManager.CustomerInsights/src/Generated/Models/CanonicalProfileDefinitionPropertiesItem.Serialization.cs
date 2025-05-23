// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class CanonicalProfileDefinitionPropertiesItem : IUtf8JsonSerializable, IJsonModel<CanonicalProfileDefinitionPropertiesItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CanonicalProfileDefinitionPropertiesItem>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CanonicalProfileDefinitionPropertiesItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CanonicalProfileDefinitionPropertiesItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CanonicalProfileDefinitionPropertiesItem)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ProfileName))
            {
                writer.WritePropertyName("profileName"u8);
                writer.WriteStringValue(ProfileName);
            }
            if (Optional.IsDefined(ProfilePropertyName))
            {
                writer.WritePropertyName("profilePropertyName"u8);
                writer.WriteStringValue(ProfilePropertyName);
            }
            if (Optional.IsDefined(Rank))
            {
                writer.WritePropertyName("rank"u8);
                writer.WriteNumberValue(Rank.Value);
            }
            if (Optional.IsDefined(ValueType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ValueType.Value.ToString());
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        CanonicalProfileDefinitionPropertiesItem IJsonModel<CanonicalProfileDefinitionPropertiesItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CanonicalProfileDefinitionPropertiesItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CanonicalProfileDefinitionPropertiesItem)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCanonicalProfileDefinitionPropertiesItem(document.RootElement, options);
        }

        internal static CanonicalProfileDefinitionPropertiesItem DeserializeCanonicalProfileDefinitionPropertiesItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string profileName = default;
            string profilePropertyName = default;
            int? rank = default;
            CanonicalPropertyValueType? type = default;
            string value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("profileName"u8))
                {
                    profileName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("profilePropertyName"u8))
                {
                    profilePropertyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rank"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rank = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new CanonicalPropertyValueType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CanonicalProfileDefinitionPropertiesItem(
                profileName,
                profilePropertyName,
                rank,
                type,
                value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CanonicalProfileDefinitionPropertiesItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CanonicalProfileDefinitionPropertiesItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CanonicalProfileDefinitionPropertiesItem)} does not support writing '{options.Format}' format.");
            }
        }

        CanonicalProfileDefinitionPropertiesItem IPersistableModel<CanonicalProfileDefinitionPropertiesItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CanonicalProfileDefinitionPropertiesItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeCanonicalProfileDefinitionPropertiesItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CanonicalProfileDefinitionPropertiesItem)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CanonicalProfileDefinitionPropertiesItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
