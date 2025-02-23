// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Describes an available DMS SKU. </summary>
    public partial class ResourceSku
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ResourceSku"/>. </summary>
        internal ResourceSku()
        {
            Locations = new ChangeTrackingList<string>();
            ApiVersions = new ChangeTrackingList<string>();
            Costs = new ChangeTrackingList<ResourceSkuCosts>();
            Capabilities = new ChangeTrackingList<ResourceSkuCapabilities>();
            Restrictions = new ChangeTrackingList<ResourceSkuRestrictions>();
        }

        /// <summary> Initializes a new instance of <see cref="ResourceSku"/>. </summary>
        /// <param name="resourceType"> The type of resource the SKU applies to. </param>
        /// <param name="name"> The name of SKU. </param>
        /// <param name="tier"> Specifies the tier of DMS in a scale set. </param>
        /// <param name="size"> The Size of the SKU. </param>
        /// <param name="family"> The Family of this particular SKU. </param>
        /// <param name="kind"> The Kind of resources that are supported in this SKU. </param>
        /// <param name="capacity"> Not used. </param>
        /// <param name="locations"> The set of locations that the SKU is available. </param>
        /// <param name="apiVersions"> The api versions that support this SKU. </param>
        /// <param name="costs"> Metadata for retrieving price info. </param>
        /// <param name="capabilities"> A name value pair to describe the capability. </param>
        /// <param name="restrictions"> The restrictions because of which SKU cannot be used. This is empty if there are no restrictions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceSku(string resourceType, string name, string tier, string size, string family, string kind, ResourceSkuCapacity capacity, IReadOnlyList<string> locations, IReadOnlyList<string> apiVersions, IReadOnlyList<ResourceSkuCosts> costs, IReadOnlyList<ResourceSkuCapabilities> capabilities, IReadOnlyList<ResourceSkuRestrictions> restrictions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceType = resourceType;
            Name = name;
            Tier = tier;
            Size = size;
            Family = family;
            Kind = kind;
            Capacity = capacity;
            Locations = locations;
            ApiVersions = apiVersions;
            Costs = costs;
            Capabilities = capabilities;
            Restrictions = restrictions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The type of resource the SKU applies to. </summary>
        public string ResourceType { get; }
        /// <summary> The name of SKU. </summary>
        public string Name { get; }
        /// <summary> Specifies the tier of DMS in a scale set. </summary>
        public string Tier { get; }
        /// <summary> The Size of the SKU. </summary>
        public string Size { get; }
        /// <summary> The Family of this particular SKU. </summary>
        public string Family { get; }
        /// <summary> The Kind of resources that are supported in this SKU. </summary>
        public string Kind { get; }
        /// <summary> Not used. </summary>
        public ResourceSkuCapacity Capacity { get; }
        /// <summary> The set of locations that the SKU is available. </summary>
        public IReadOnlyList<string> Locations { get; }
        /// <summary> The api versions that support this SKU. </summary>
        public IReadOnlyList<string> ApiVersions { get; }
        /// <summary> Metadata for retrieving price info. </summary>
        public IReadOnlyList<ResourceSkuCosts> Costs { get; }
        /// <summary> A name value pair to describe the capability. </summary>
        public IReadOnlyList<ResourceSkuCapabilities> Capabilities { get; }
        /// <summary> The restrictions because of which SKU cannot be used. This is empty if there are no restrictions. </summary>
        public IReadOnlyList<ResourceSkuRestrictions> Restrictions { get; }
    }
}
