// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> Routing message. </summary>
    public partial class RoutingMessage
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

        /// <summary> Initializes a new instance of <see cref="RoutingMessage"/>. </summary>
        public RoutingMessage()
        {
            AppProperties = new ChangeTrackingDictionary<string, string>();
            SystemProperties = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="RoutingMessage"/>. </summary>
        /// <param name="body"> Body of routing message. </param>
        /// <param name="appProperties"> App properties. </param>
        /// <param name="systemProperties"> System properties. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RoutingMessage(string body, IDictionary<string, string> appProperties, IDictionary<string, string> systemProperties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Body = body;
            AppProperties = appProperties;
            SystemProperties = systemProperties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Body of routing message. </summary>
        public string Body { get; set; }
        /// <summary> App properties. </summary>
        public IDictionary<string, string> AppProperties { get; }
        /// <summary> System properties. </summary>
        public IDictionary<string, string> SystemProperties { get; }
    }
}
