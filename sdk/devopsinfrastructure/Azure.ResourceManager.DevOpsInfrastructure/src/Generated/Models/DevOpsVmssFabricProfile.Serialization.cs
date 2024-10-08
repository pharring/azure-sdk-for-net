// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevOpsInfrastructure.Models
{
    public partial class DevOpsVmssFabricProfile : IUtf8JsonSerializable, IJsonModel<DevOpsVmssFabricProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevOpsVmssFabricProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DevOpsVmssFabricProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevOpsVmssFabricProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevOpsVmssFabricProfile)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("sku"u8);
            writer.WriteObjectValue(Sku, options);
            writer.WritePropertyName("images"u8);
            writer.WriteStartArray();
            foreach (var item in Images)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(OSProfile))
            {
                writer.WritePropertyName("osProfile"u8);
                writer.WriteObjectValue(OSProfile, options);
            }
            if (Optional.IsDefined(StorageProfile))
            {
                writer.WritePropertyName("storageProfile"u8);
                writer.WriteObjectValue(StorageProfile, options);
            }
            if (Optional.IsDefined(NetworkProfile))
            {
                writer.WritePropertyName("networkProfile"u8);
                writer.WriteObjectValue(NetworkProfile, options);
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind);
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

        DevOpsVmssFabricProfile IJsonModel<DevOpsVmssFabricProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevOpsVmssFabricProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevOpsVmssFabricProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevOpsVmssFabricProfile(document.RootElement, options);
        }

        internal static DevOpsVmssFabricProfile DeserializeDevOpsVmssFabricProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DevOpsAzureSku sku = default;
            IList<DevOpsPoolVmImage> images = default;
            DevOpsOSProfile osProfile = default;
            DevOpsStorageProfile storageProfile = default;
            DevOpsNetworkProfile networkProfile = default;
            string kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    sku = DevOpsAzureSku.DeserializeDevOpsAzureSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("images"u8))
                {
                    List<DevOpsPoolVmImage> array = new List<DevOpsPoolVmImage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DevOpsPoolVmImage.DeserializeDevOpsPoolVmImage(item, options));
                    }
                    images = array;
                    continue;
                }
                if (property.NameEquals("osProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osProfile = DevOpsOSProfile.DeserializeDevOpsOSProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("storageProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageProfile = DevOpsStorageProfile.DeserializeDevOpsStorageProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("networkProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkProfile = DevOpsNetworkProfile.DeserializeDevOpsNetworkProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DevOpsVmssFabricProfile(
                kind,
                serializedAdditionalRawData,
                sku,
                images,
                osProfile,
                storageProfile,
                networkProfile);
        }

        BinaryData IPersistableModel<DevOpsVmssFabricProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevOpsVmssFabricProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevOpsVmssFabricProfile)} does not support writing '{options.Format}' format.");
            }
        }

        DevOpsVmssFabricProfile IPersistableModel<DevOpsVmssFabricProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevOpsVmssFabricProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevOpsVmssFabricProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevOpsVmssFabricProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevOpsVmssFabricProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
