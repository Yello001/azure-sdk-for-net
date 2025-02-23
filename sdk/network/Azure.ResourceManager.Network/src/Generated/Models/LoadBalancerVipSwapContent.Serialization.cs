// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class LoadBalancerVipSwapContent : IUtf8JsonSerializable, IJsonModel<LoadBalancerVipSwapContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LoadBalancerVipSwapContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LoadBalancerVipSwapContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadBalancerVipSwapContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LoadBalancerVipSwapContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(FrontendIPConfigurations))
            {
                writer.WritePropertyName("frontendIPConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in FrontendIPConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        LoadBalancerVipSwapContent IJsonModel<LoadBalancerVipSwapContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadBalancerVipSwapContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LoadBalancerVipSwapContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLoadBalancerVipSwapContent(document.RootElement, options);
        }

        internal static LoadBalancerVipSwapContent DeserializeLoadBalancerVipSwapContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<LoadBalancerVipSwapRequestFrontendIPConfiguration>> frontendIPConfigurations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("frontendIPConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LoadBalancerVipSwapRequestFrontendIPConfiguration> array = new List<LoadBalancerVipSwapRequestFrontendIPConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LoadBalancerVipSwapRequestFrontendIPConfiguration.DeserializeLoadBalancerVipSwapRequestFrontendIPConfiguration(item));
                    }
                    frontendIPConfigurations = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LoadBalancerVipSwapContent(Optional.ToList(frontendIPConfigurations), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LoadBalancerVipSwapContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadBalancerVipSwapContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LoadBalancerVipSwapContent)} does not support '{options.Format}' format.");
            }
        }

        LoadBalancerVipSwapContent IPersistableModel<LoadBalancerVipSwapContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadBalancerVipSwapContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLoadBalancerVipSwapContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LoadBalancerVipSwapContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LoadBalancerVipSwapContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
