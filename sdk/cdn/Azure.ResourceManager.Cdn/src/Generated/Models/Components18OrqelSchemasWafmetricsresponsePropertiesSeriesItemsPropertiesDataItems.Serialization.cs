// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems : IUtf8JsonSerializable, IJsonModel<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DateOn))
            {
                writer.WritePropertyName("dateTime"u8);
                writer.WriteStringValue(DateOn.Value, "O");
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteNumberValue(Value.Value);
            }
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
            writer.WriteEndObject();
        }

        Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems IJsonModel<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeComponents18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems(document.RootElement, options);
        }

        internal static Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems DeserializeComponents18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> dateTime = default;
            Optional<float> value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems(Optional.ToNullable(dateTime), Optional.ToNullable(value), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems)} does not support '{options.Format}' format.");
            }
        }

        Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems IPersistableModel<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeComponents18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
