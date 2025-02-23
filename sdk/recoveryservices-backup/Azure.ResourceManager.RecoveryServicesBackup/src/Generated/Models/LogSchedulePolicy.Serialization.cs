// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class LogSchedulePolicy : IUtf8JsonSerializable, IJsonModel<LogSchedulePolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LogSchedulePolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LogSchedulePolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogSchedulePolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogSchedulePolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ScheduleFrequencyInMins))
            {
                writer.WritePropertyName("scheduleFrequencyInMins"u8);
                writer.WriteNumberValue(ScheduleFrequencyInMins.Value);
            }
            writer.WritePropertyName("schedulePolicyType"u8);
            writer.WriteStringValue(SchedulePolicyType);
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

        LogSchedulePolicy IJsonModel<LogSchedulePolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogSchedulePolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogSchedulePolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLogSchedulePolicy(document.RootElement, options);
        }

        internal static LogSchedulePolicy DeserializeLogSchedulePolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> scheduleFrequencyInMins = default;
            string schedulePolicyType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scheduleFrequencyInMins"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduleFrequencyInMins = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("schedulePolicyType"u8))
                {
                    schedulePolicyType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LogSchedulePolicy(schedulePolicyType, serializedAdditionalRawData, Optional.ToNullable(scheduleFrequencyInMins));
        }

        BinaryData IPersistableModel<LogSchedulePolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogSchedulePolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LogSchedulePolicy)} does not support '{options.Format}' format.");
            }
        }

        LogSchedulePolicy IPersistableModel<LogSchedulePolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogSchedulePolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLogSchedulePolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LogSchedulePolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LogSchedulePolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
