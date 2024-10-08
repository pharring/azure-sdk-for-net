// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> Details for the next renewal term of a subscription. </summary>
    public partial class SubscriptionRenewalTermDetails
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

        /// <summary> Initializes a new instance of <see cref="SubscriptionRenewalTermDetails"/>. </summary>
        internal SubscriptionRenewalTermDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SubscriptionRenewalTermDetails"/>. </summary>
        /// <param name="billingFrequency"> The billing frequency in ISO8601 format of product in the subscription. Example: P1M, P3M, P1Y. </param>
        /// <param name="productId"> Id of the product for which the subscription is purchased. </param>
        /// <param name="productTypeId"> Type Id of the product for which the subscription is purchased. </param>
        /// <param name="skuId"> The SKU ID of the product for which the subscription is purchased. This field is is only available  for Microsoft Customer Agreement billing accounts. </param>
        /// <param name="termDuration"> The duration in ISO8601 format for which you can use the subscription. Example: P1M, P3M, P1Y. </param>
        /// <param name="quantity"> The quantity of licenses or fulfillment units for the subscription. </param>
        /// <param name="termEndOn"> End date of the term in UTC time. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SubscriptionRenewalTermDetails(string billingFrequency, string productId, string productTypeId, string skuId, TimeSpan? termDuration, long? quantity, DateTimeOffset? termEndOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            BillingFrequency = billingFrequency;
            ProductId = productId;
            ProductTypeId = productTypeId;
            SkuId = skuId;
            TermDuration = termDuration;
            Quantity = quantity;
            TermEndOn = termEndOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The billing frequency in ISO8601 format of product in the subscription. Example: P1M, P3M, P1Y. </summary>
        [WirePath("billingFrequency")]
        public string BillingFrequency { get; }
        /// <summary> Id of the product for which the subscription is purchased. </summary>
        [WirePath("productId")]
        public string ProductId { get; }
        /// <summary> Type Id of the product for which the subscription is purchased. </summary>
        [WirePath("productTypeId")]
        public string ProductTypeId { get; }
        /// <summary> The SKU ID of the product for which the subscription is purchased. This field is is only available  for Microsoft Customer Agreement billing accounts. </summary>
        [WirePath("skuId")]
        public string SkuId { get; }
        /// <summary> The duration in ISO8601 format for which you can use the subscription. Example: P1M, P3M, P1Y. </summary>
        [WirePath("termDuration")]
        public TimeSpan? TermDuration { get; }
        /// <summary> The quantity of licenses or fulfillment units for the subscription. </summary>
        [WirePath("quantity")]
        public long? Quantity { get; }
        /// <summary> End date of the term in UTC time. </summary>
        [WirePath("termEndDate")]
        public DateTimeOffset? TermEndOn { get; }
    }
}
