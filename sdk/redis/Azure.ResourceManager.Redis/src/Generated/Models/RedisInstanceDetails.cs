// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Redis.Models
{
    /// <summary> Details of single instance of redis. </summary>
    public partial class RedisInstanceDetails
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

        /// <summary> Initializes a new instance of <see cref="RedisInstanceDetails"/>. </summary>
        internal RedisInstanceDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RedisInstanceDetails"/>. </summary>
        /// <param name="sslPort"> Redis instance SSL port. </param>
        /// <param name="nonSslPort"> If enableNonSslPort is true, provides Redis instance Non-SSL port. </param>
        /// <param name="zone"> If the Cache uses availability zones, specifies availability zone where this instance is located. </param>
        /// <param name="shardId"> If clustering is enabled, the Shard ID of Redis Instance. </param>
        /// <param name="isMaster"> Specifies whether the instance is a primary node. </param>
        /// <param name="isPrimary"> Specifies whether the instance is a primary node. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RedisInstanceDetails(int? sslPort, int? nonSslPort, string zone, int? shardId, bool? isMaster, bool? isPrimary, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SslPort = sslPort;
            NonSslPort = nonSslPort;
            Zone = zone;
            ShardId = shardId;
            IsMaster = isMaster;
            IsPrimary = isPrimary;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Redis instance SSL port. </summary>
        public int? SslPort { get; }
        /// <summary> If enableNonSslPort is true, provides Redis instance Non-SSL port. </summary>
        public int? NonSslPort { get; }
        /// <summary> If the Cache uses availability zones, specifies availability zone where this instance is located. </summary>
        public string Zone { get; }
        /// <summary> If clustering is enabled, the Shard ID of Redis Instance. </summary>
        public int? ShardId { get; }
        /// <summary> Specifies whether the instance is a primary node. </summary>
        public bool? IsMaster { get; }
        /// <summary> Specifies whether the instance is a primary node. </summary>
        public bool? IsPrimary { get; }
    }
}
