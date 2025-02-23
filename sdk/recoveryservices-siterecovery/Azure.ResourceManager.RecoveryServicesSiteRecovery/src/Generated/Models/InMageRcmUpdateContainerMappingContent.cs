// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageRcm update protection container mapping. </summary>
    public partial class InMageRcmUpdateContainerMappingContent : ReplicationProviderSpecificUpdateContainerMappingContent
    {
        /// <summary> Initializes a new instance of <see cref="InMageRcmUpdateContainerMappingContent"/>. </summary>
        /// <param name="enableAgentAutoUpgrade"> A value indicating whether agent auto upgrade has to be enabled. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="enableAgentAutoUpgrade"/> is null. </exception>
        public InMageRcmUpdateContainerMappingContent(string enableAgentAutoUpgrade)
        {
            Argument.AssertNotNull(enableAgentAutoUpgrade, nameof(enableAgentAutoUpgrade));

            EnableAgentAutoUpgrade = enableAgentAutoUpgrade;
            InstanceType = "InMageRcm";
        }

        /// <summary> Initializes a new instance of <see cref="InMageRcmUpdateContainerMappingContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="enableAgentAutoUpgrade"> A value indicating whether agent auto upgrade has to be enabled. </param>
        internal InMageRcmUpdateContainerMappingContent(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData, string enableAgentAutoUpgrade) : base(instanceType, serializedAdditionalRawData)
        {
            EnableAgentAutoUpgrade = enableAgentAutoUpgrade;
            InstanceType = instanceType ?? "InMageRcm";
        }

        /// <summary> Initializes a new instance of <see cref="InMageRcmUpdateContainerMappingContent"/> for deserialization. </summary>
        internal InMageRcmUpdateContainerMappingContent()
        {
        }

        /// <summary> A value indicating whether agent auto upgrade has to be enabled. </summary>
        public string EnableAgentAutoUpgrade { get; }
    }
}
