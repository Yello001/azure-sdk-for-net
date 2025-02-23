// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ArmServiceTypeHealthPolicy : IUtf8JsonSerializable, IJsonModel<ArmServiceTypeHealthPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ArmServiceTypeHealthPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ArmServiceTypeHealthPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmServiceTypeHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmServiceTypeHealthPolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MaxPercentUnhealthyServices))
            {
                writer.WritePropertyName("maxPercentUnhealthyServices"u8);
                writer.WriteNumberValue(MaxPercentUnhealthyServices.Value);
            }
            if (Optional.IsDefined(MaxPercentUnhealthyPartitionsPerService))
            {
                writer.WritePropertyName("maxPercentUnhealthyPartitionsPerService"u8);
                writer.WriteNumberValue(MaxPercentUnhealthyPartitionsPerService.Value);
            }
            if (Optional.IsDefined(MaxPercentUnhealthyReplicasPerPartition))
            {
                writer.WritePropertyName("maxPercentUnhealthyReplicasPerPartition"u8);
                writer.WriteNumberValue(MaxPercentUnhealthyReplicasPerPartition.Value);
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

        ArmServiceTypeHealthPolicy IJsonModel<ArmServiceTypeHealthPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmServiceTypeHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmServiceTypeHealthPolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeArmServiceTypeHealthPolicy(document.RootElement, options);
        }

        internal static ArmServiceTypeHealthPolicy DeserializeArmServiceTypeHealthPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> maxPercentUnhealthyServices = default;
            Optional<int> maxPercentUnhealthyPartitionsPerService = default;
            Optional<int> maxPercentUnhealthyReplicasPerPartition = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxPercentUnhealthyServices"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxPercentUnhealthyServices = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxPercentUnhealthyPartitionsPerService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxPercentUnhealthyPartitionsPerService = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxPercentUnhealthyReplicasPerPartition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxPercentUnhealthyReplicasPerPartition = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ArmServiceTypeHealthPolicy(Optional.ToNullable(maxPercentUnhealthyServices), Optional.ToNullable(maxPercentUnhealthyPartitionsPerService), Optional.ToNullable(maxPercentUnhealthyReplicasPerPartition), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ArmServiceTypeHealthPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmServiceTypeHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ArmServiceTypeHealthPolicy)} does not support '{options.Format}' format.");
            }
        }

        ArmServiceTypeHealthPolicy IPersistableModel<ArmServiceTypeHealthPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmServiceTypeHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeArmServiceTypeHealthPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ArmServiceTypeHealthPolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ArmServiceTypeHealthPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
