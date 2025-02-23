// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Properties of a managed Cassandra cluster public status. </summary>
    public partial class CassandraClusterPublicStatus
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

        /// <summary> Initializes a new instance of <see cref="CassandraClusterPublicStatus"/>. </summary>
        internal CassandraClusterPublicStatus()
        {
            ConnectionErrors = new ChangeTrackingList<CassandraConnectionError>();
            Errors = new ChangeTrackingList<CassandraError>();
            DataCenters = new ChangeTrackingList<CassandraClusterPublicStatusDataCentersItem>();
        }

        /// <summary> Initializes a new instance of <see cref="CassandraClusterPublicStatus"/>. </summary>
        /// <param name="etag"></param>
        /// <param name="reaperStatus"></param>
        /// <param name="connectionErrors"> List relevant information about any connection errors to the Datacenters. </param>
        /// <param name="errors"> List relevant information about any errors about cluster, data center and connection error. </param>
        /// <param name="dataCenters"> List of the status of each datacenter in this cluster. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CassandraClusterPublicStatus(ETag? etag, CassandraReaperStatus reaperStatus, IReadOnlyList<CassandraConnectionError> connectionErrors, IReadOnlyList<CassandraError> errors, IReadOnlyList<CassandraClusterPublicStatusDataCentersItem> dataCenters, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ETag = etag;
            ReaperStatus = reaperStatus;
            ConnectionErrors = connectionErrors;
            Errors = errors;
            DataCenters = dataCenters;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the e tag. </summary>
        public ETag? ETag { get; }
        /// <summary> Gets the reaper status. </summary>
        public CassandraReaperStatus ReaperStatus { get; }
        /// <summary> List relevant information about any connection errors to the Datacenters. </summary>
        public IReadOnlyList<CassandraConnectionError> ConnectionErrors { get; }
        /// <summary> List relevant information about any errors about cluster, data center and connection error. </summary>
        public IReadOnlyList<CassandraError> Errors { get; }
        /// <summary> List of the status of each datacenter in this cluster. </summary>
        public IReadOnlyList<CassandraClusterPublicStatusDataCentersItem> DataCenters { get; }
    }
}
