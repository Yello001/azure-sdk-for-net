// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Health.Insights.ClinicalMatching
{
    /// <summary> The results of the model's work for a single patient. </summary>
    public partial class TrialMatcherPatientResult
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

        /// <summary> Initializes a new instance of <see cref="TrialMatcherPatientResult"/>. </summary>
        /// <param name="id"> The identifier given for the patient in the request. </param>
        /// <param name="inferences"> The model's inferences for the given patient. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="inferences"/> is null. </exception>
        internal TrialMatcherPatientResult(string id, IEnumerable<TrialMatcherInference> inferences)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(inferences, nameof(inferences));

            Id = id;
            Inferences = inferences.ToList();
            NeededClinicalInfo = new ChangeTrackingList<ExtendedClinicalCodedElement>();
        }

        /// <summary> Initializes a new instance of <see cref="TrialMatcherPatientResult"/>. </summary>
        /// <param name="id"> The identifier given for the patient in the request. </param>
        /// <param name="inferences"> The model's inferences for the given patient. </param>
        /// <param name="neededClinicalInfo"> Clinical information which is needed to provide better trial matching results for the patient. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TrialMatcherPatientResult(string id, IReadOnlyList<TrialMatcherInference> inferences, IReadOnlyList<ExtendedClinicalCodedElement> neededClinicalInfo, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Inferences = inferences;
            NeededClinicalInfo = neededClinicalInfo;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TrialMatcherPatientResult"/> for deserialization. </summary>
        internal TrialMatcherPatientResult()
        {
        }

        /// <summary> The identifier given for the patient in the request. </summary>
        public string Id { get; }
        /// <summary> The model's inferences for the given patient. </summary>
        public IReadOnlyList<TrialMatcherInference> Inferences { get; }
        /// <summary> Clinical information which is needed to provide better trial matching results for the patient. </summary>
        public IReadOnlyList<ExtendedClinicalCodedElement> NeededClinicalInfo { get; }
    }
}
