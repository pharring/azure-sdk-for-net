// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> Eligibility to delete a billing profile result. </summary>
    public partial class DeleteBillingProfileEligibilityResult
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

        /// <summary> Initializes a new instance of <see cref="DeleteBillingProfileEligibilityResult"/>. </summary>
        internal DeleteBillingProfileEligibilityResult()
        {
            EligibilityDetails = new ChangeTrackingList<DeleteBillingProfileEligibilityDetail>();
        }

        /// <summary> Initializes a new instance of <see cref="DeleteBillingProfileEligibilityResult"/>. </summary>
        /// <param name="eligibilityStatus"> Status describing if billing profile is eligible to be deleted. </param>
        /// <param name="eligibilityDetails"> Validation details of delete billing profile eligibility. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeleteBillingProfileEligibilityResult(DeleteBillingProfileEligibilityStatus? eligibilityStatus, IReadOnlyList<DeleteBillingProfileEligibilityDetail> eligibilityDetails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EligibilityStatus = eligibilityStatus;
            EligibilityDetails = eligibilityDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Status describing if billing profile is eligible to be deleted. </summary>
        [WirePath("eligibilityStatus")]
        public DeleteBillingProfileEligibilityStatus? EligibilityStatus { get; }
        /// <summary> Validation details of delete billing profile eligibility. </summary>
        [WirePath("eligibilityDetails")]
        public IReadOnlyList<DeleteBillingProfileEligibilityDetail> EligibilityDetails { get; }
    }
}
