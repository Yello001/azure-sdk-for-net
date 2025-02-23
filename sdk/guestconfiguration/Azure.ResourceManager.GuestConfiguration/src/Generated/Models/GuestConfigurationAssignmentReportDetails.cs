// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    /// <summary> Details of the guest configuration assignment report. </summary>
    public partial class GuestConfigurationAssignmentReportDetails
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

        /// <summary> Initializes a new instance of <see cref="GuestConfigurationAssignmentReportDetails"/>. </summary>
        internal GuestConfigurationAssignmentReportDetails()
        {
            Resources = new ChangeTrackingList<AssignmentReportResourceInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="GuestConfigurationAssignmentReportDetails"/>. </summary>
        /// <param name="complianceStatus"> A value indicating compliance status of the machine for the assigned guest configuration. </param>
        /// <param name="startOn"> Start date and time of the guest configuration assignment compliance status check. </param>
        /// <param name="endOn"> End date and time of the guest configuration assignment compliance status check. </param>
        /// <param name="jobId"> GUID of the report. </param>
        /// <param name="operationType"> Type of report, Consistency or Initial. </param>
        /// <param name="resources"> The list of resources for which guest configuration assignment compliance is checked. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GuestConfigurationAssignmentReportDetails(AssignedGuestConfigurationMachineComplianceStatus? complianceStatus, DateTimeOffset? startOn, DateTimeOffset? endOn, Guid? jobId, GuestConfigurationAssignmentReportType? operationType, IReadOnlyList<AssignmentReportResourceInfo> resources, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ComplianceStatus = complianceStatus;
            StartOn = startOn;
            EndOn = endOn;
            JobId = jobId;
            OperationType = operationType;
            Resources = resources;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A value indicating compliance status of the machine for the assigned guest configuration. </summary>
        public AssignedGuestConfigurationMachineComplianceStatus? ComplianceStatus { get; }
        /// <summary> Start date and time of the guest configuration assignment compliance status check. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> End date and time of the guest configuration assignment compliance status check. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> GUID of the report. </summary>
        public Guid? JobId { get; }
        /// <summary> Type of report, Consistency or Initial. </summary>
        public GuestConfigurationAssignmentReportType? OperationType { get; }
        /// <summary> The list of resources for which guest configuration assignment compliance is checked. </summary>
        public IReadOnlyList<AssignmentReportResourceInfo> Resources { get; }
    }
}
