// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.ContentSafety
{
    public partial class AddOrUpdateTextBlocklistItemsOptions : IUtf8JsonSerializable, IJsonModel<AddOrUpdateTextBlocklistItemsOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AddOrUpdateTextBlocklistItemsOptions>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AddOrUpdateTextBlocklistItemsOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AddOrUpdateTextBlocklistItemsOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AddOrUpdateTextBlocklistItemsOptions)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("blocklistItems"u8);
            writer.WriteStartArray();
            foreach (var item in BlocklistItems)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        AddOrUpdateTextBlocklistItemsOptions IJsonModel<AddOrUpdateTextBlocklistItemsOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AddOrUpdateTextBlocklistItemsOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AddOrUpdateTextBlocklistItemsOptions)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAddOrUpdateTextBlocklistItemsOptions(document.RootElement, options);
        }

        internal static AddOrUpdateTextBlocklistItemsOptions DeserializeAddOrUpdateTextBlocklistItemsOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<TextBlocklistItem> blocklistItems = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("blocklistItems"u8))
                {
                    List<TextBlocklistItem> array = new List<TextBlocklistItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TextBlocklistItem.DeserializeTextBlocklistItem(item));
                    }
                    blocklistItems = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AddOrUpdateTextBlocklistItemsOptions(blocklistItems, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AddOrUpdateTextBlocklistItemsOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AddOrUpdateTextBlocklistItemsOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AddOrUpdateTextBlocklistItemsOptions)} does not support '{options.Format}' format.");
            }
        }

        AddOrUpdateTextBlocklistItemsOptions IPersistableModel<AddOrUpdateTextBlocklistItemsOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AddOrUpdateTextBlocklistItemsOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAddOrUpdateTextBlocklistItemsOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AddOrUpdateTextBlocklistItemsOptions)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AddOrUpdateTextBlocklistItemsOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AddOrUpdateTextBlocklistItemsOptions FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAddOrUpdateTextBlocklistItemsOptions(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
