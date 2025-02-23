// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SqlServerVersionCapability : IUtf8JsonSerializable, IJsonModel<SqlServerVersionCapability>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlServerVersionCapability>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SqlServerVersionCapability>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerVersionCapability>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlServerVersionCapability)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SupportedEditions))
            {
                writer.WritePropertyName("supportedEditions"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedEditions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SupportedElasticPoolEditions))
            {
                writer.WritePropertyName("supportedElasticPoolEditions"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedElasticPoolEditions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (Optional.IsDefined(Reason))
            {
                writer.WritePropertyName("reason"u8);
                writer.WriteStringValue(Reason);
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

        SqlServerVersionCapability IJsonModel<SqlServerVersionCapability>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerVersionCapability>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlServerVersionCapability)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlServerVersionCapability(document.RootElement, options);
        }

        internal static SqlServerVersionCapability DeserializeSqlServerVersionCapability(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<IReadOnlyList<EditionCapability>> supportedEditions = default;
            Optional<IReadOnlyList<ElasticPoolEditionCapability>> supportedElasticPoolEditions = default;
            Optional<SqlCapabilityStatus> status = default;
            Optional<string> reason = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedEditions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EditionCapability> array = new List<EditionCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EditionCapability.DeserializeEditionCapability(item));
                    }
                    supportedEditions = array;
                    continue;
                }
                if (property.NameEquals("supportedElasticPoolEditions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ElasticPoolEditionCapability> array = new List<ElasticPoolEditionCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ElasticPoolEditionCapability.DeserializeElasticPoolEditionCapability(item));
                    }
                    supportedElasticPoolEditions = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToSqlCapabilityStatus();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SqlServerVersionCapability(name.Value, Optional.ToList(supportedEditions), Optional.ToList(supportedElasticPoolEditions), Optional.ToNullable(status), reason.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SqlServerVersionCapability>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerVersionCapability>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SqlServerVersionCapability)} does not support '{options.Format}' format.");
            }
        }

        SqlServerVersionCapability IPersistableModel<SqlServerVersionCapability>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerVersionCapability>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlServerVersionCapability(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlServerVersionCapability)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlServerVersionCapability>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
