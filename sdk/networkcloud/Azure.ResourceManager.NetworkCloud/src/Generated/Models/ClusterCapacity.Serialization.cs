// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class ClusterCapacity : IUtf8JsonSerializable, IJsonModel<ClusterCapacity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterCapacity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ClusterCapacity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterCapacity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterCapacity)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AvailableApplianceStorageGB))
            {
                writer.WritePropertyName("availableApplianceStorageGB"u8);
                writer.WriteNumberValue(AvailableApplianceStorageGB.Value);
            }
            if (Optional.IsDefined(AvailableCoreCount))
            {
                writer.WritePropertyName("availableCoreCount"u8);
                writer.WriteNumberValue(AvailableCoreCount.Value);
            }
            if (Optional.IsDefined(AvailableHostStorageGB))
            {
                writer.WritePropertyName("availableHostStorageGB"u8);
                writer.WriteNumberValue(AvailableHostStorageGB.Value);
            }
            if (Optional.IsDefined(AvailableMemoryGB))
            {
                writer.WritePropertyName("availableMemoryGB"u8);
                writer.WriteNumberValue(AvailableMemoryGB.Value);
            }
            if (Optional.IsDefined(TotalApplianceStorageGB))
            {
                writer.WritePropertyName("totalApplianceStorageGB"u8);
                writer.WriteNumberValue(TotalApplianceStorageGB.Value);
            }
            if (Optional.IsDefined(TotalCoreCount))
            {
                writer.WritePropertyName("totalCoreCount"u8);
                writer.WriteNumberValue(TotalCoreCount.Value);
            }
            if (Optional.IsDefined(TotalHostStorageGB))
            {
                writer.WritePropertyName("totalHostStorageGB"u8);
                writer.WriteNumberValue(TotalHostStorageGB.Value);
            }
            if (Optional.IsDefined(TotalMemoryGB))
            {
                writer.WritePropertyName("totalMemoryGB"u8);
                writer.WriteNumberValue(TotalMemoryGB.Value);
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

        ClusterCapacity IJsonModel<ClusterCapacity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterCapacity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterCapacity)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterCapacity(document.RootElement, options);
        }

        internal static ClusterCapacity DeserializeClusterCapacity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> availableApplianceStorageGB = default;
            Optional<long> availableCoreCount = default;
            Optional<long> availableHostStorageGB = default;
            Optional<long> availableMemoryGB = default;
            Optional<long> totalApplianceStorageGB = default;
            Optional<long> totalCoreCount = default;
            Optional<long> totalHostStorageGB = default;
            Optional<long> totalMemoryGB = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("availableApplianceStorageGB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availableApplianceStorageGB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("availableCoreCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availableCoreCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("availableHostStorageGB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availableHostStorageGB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("availableMemoryGB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availableMemoryGB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalApplianceStorageGB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalApplianceStorageGB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalCoreCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalCoreCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalHostStorageGB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalHostStorageGB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalMemoryGB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalMemoryGB = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ClusterCapacity(Optional.ToNullable(availableApplianceStorageGB), Optional.ToNullable(availableCoreCount), Optional.ToNullable(availableHostStorageGB), Optional.ToNullable(availableMemoryGB), Optional.ToNullable(totalApplianceStorageGB), Optional.ToNullable(totalCoreCount), Optional.ToNullable(totalHostStorageGB), Optional.ToNullable(totalMemoryGB), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ClusterCapacity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterCapacity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ClusterCapacity)} does not support '{options.Format}' format.");
            }
        }

        ClusterCapacity IPersistableModel<ClusterCapacity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterCapacity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClusterCapacity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClusterCapacity)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterCapacity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
