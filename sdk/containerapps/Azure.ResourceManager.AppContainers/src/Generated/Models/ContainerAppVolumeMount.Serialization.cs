// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppVolumeMount : IUtf8JsonSerializable, IJsonModel<ContainerAppVolumeMount>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppVolumeMount>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppVolumeMount>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppVolumeMount>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppVolumeMount)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(VolumeName))
            {
                writer.WritePropertyName("volumeName"u8);
                writer.WriteStringValue(VolumeName);
            }
            if (Optional.IsDefined(MountPath))
            {
                writer.WritePropertyName("mountPath"u8);
                writer.WriteStringValue(MountPath);
            }
            if (Optional.IsDefined(SubPath))
            {
                writer.WritePropertyName("subPath"u8);
                writer.WriteStringValue(SubPath);
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

        ContainerAppVolumeMount IJsonModel<ContainerAppVolumeMount>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppVolumeMount>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppVolumeMount)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppVolumeMount(document.RootElement, options);
        }

        internal static ContainerAppVolumeMount DeserializeContainerAppVolumeMount(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> volumeName = default;
            Optional<string> mountPath = default;
            Optional<string> subPath = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("volumeName"u8))
                {
                    volumeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mountPath"u8))
                {
                    mountPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subPath"u8))
                {
                    subPath = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppVolumeMount(volumeName.Value, mountPath.Value, subPath.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerAppVolumeMount>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppVolumeMount>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppVolumeMount)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppVolumeMount IPersistableModel<ContainerAppVolumeMount>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppVolumeMount>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppVolumeMount(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppVolumeMount)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppVolumeMount>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
