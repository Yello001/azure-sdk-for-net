// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    [PersistableModelProxy(typeof(UnknownMonitorComputeConfigurationBase))]
    public partial class MonitorComputeConfigurationBase : IUtf8JsonSerializable, IJsonModel<MonitorComputeConfigurationBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitorComputeConfigurationBase>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MonitorComputeConfigurationBase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorComputeConfigurationBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorComputeConfigurationBase)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("computeType"u8);
            writer.WriteStringValue(ComputeType.ToString());
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

        MonitorComputeConfigurationBase IJsonModel<MonitorComputeConfigurationBase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorComputeConfigurationBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorComputeConfigurationBase)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorComputeConfigurationBase(document.RootElement, options);
        }

        internal static MonitorComputeConfigurationBase DeserializeMonitorComputeConfigurationBase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("computeType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ServerlessSpark": return MonitorServerlessSparkCompute.DeserializeMonitorServerlessSparkCompute(element);
                }
            }
            return UnknownMonitorComputeConfigurationBase.DeserializeUnknownMonitorComputeConfigurationBase(element);
        }

        BinaryData IPersistableModel<MonitorComputeConfigurationBase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorComputeConfigurationBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MonitorComputeConfigurationBase)} does not support '{options.Format}' format.");
            }
        }

        MonitorComputeConfigurationBase IPersistableModel<MonitorComputeConfigurationBase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorComputeConfigurationBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMonitorComputeConfigurationBase(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MonitorComputeConfigurationBase)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MonitorComputeConfigurationBase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
