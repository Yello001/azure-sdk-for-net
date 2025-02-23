// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class ComputeStartStopCronSchedule : IUtf8JsonSerializable, IJsonModel<ComputeStartStopCronSchedule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ComputeStartStopCronSchedule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ComputeStartStopCronSchedule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeStartStopCronSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputeStartStopCronSchedule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(StartTime))
            {
                if (StartTime != null)
                {
                    writer.WritePropertyName("startTime"u8);
                    writer.WriteStringValue(StartTime);
                }
                else
                {
                    writer.WriteNull("startTime");
                }
            }
            if (Optional.IsDefined(TimeZone))
            {
                writer.WritePropertyName("timeZone"u8);
                writer.WriteStringValue(TimeZone);
            }
            if (Optional.IsDefined(Expression))
            {
                writer.WritePropertyName("expression"u8);
                writer.WriteStringValue(Expression);
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

        ComputeStartStopCronSchedule IJsonModel<ComputeStartStopCronSchedule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeStartStopCronSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputeStartStopCronSchedule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeComputeStartStopCronSchedule(document.RootElement, options);
        }

        internal static ComputeStartStopCronSchedule DeserializeComputeStartStopCronSchedule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> startTime = default;
            Optional<string> timeZone = default;
            Optional<string> expression = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        startTime = null;
                        continue;
                    }
                    startTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeZone"u8))
                {
                    timeZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expression"u8))
                {
                    expression = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ComputeStartStopCronSchedule(startTime.Value, timeZone.Value, expression.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ComputeStartStopCronSchedule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeStartStopCronSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ComputeStartStopCronSchedule)} does not support '{options.Format}' format.");
            }
        }

        ComputeStartStopCronSchedule IPersistableModel<ComputeStartStopCronSchedule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeStartStopCronSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeComputeStartStopCronSchedule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ComputeStartStopCronSchedule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ComputeStartStopCronSchedule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
