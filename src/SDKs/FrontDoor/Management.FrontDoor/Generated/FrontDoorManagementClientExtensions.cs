// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.FrontDoor
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for FrontDoorManagementClient.
    /// </summary>
    public static partial class FrontDoorManagementClientExtensions
    {
            /// <summary>
            /// Check the availability of a Front Door resource name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='checkFrontDoorNameAvailabilityInput'>
            /// Input to check.
            /// </param>
            public static CheckNameAvailabilityOutput CheckFrontDoorNameAvailability(this IFrontDoorManagementClient operations, CheckNameAvailabilityInput checkFrontDoorNameAvailabilityInput)
            {
                return operations.CheckFrontDoorNameAvailabilityAsync(checkFrontDoorNameAvailabilityInput).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Check the availability of a Front Door resource name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='checkFrontDoorNameAvailabilityInput'>
            /// Input to check.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CheckNameAvailabilityOutput> CheckFrontDoorNameAvailabilityAsync(this IFrontDoorManagementClient operations, CheckNameAvailabilityInput checkFrontDoorNameAvailabilityInput, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckFrontDoorNameAvailabilityWithHttpMessagesAsync(checkFrontDoorNameAvailabilityInput, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Check the availability of a Front Door subdomain.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='checkFrontDoorNameAvailabilityInput'>
            /// Input to check.
            /// </param>
            public static CheckNameAvailabilityOutput CheckFrontDoorNameAvailabilityWithSubscription(this IFrontDoorManagementClient operations, CheckNameAvailabilityInput checkFrontDoorNameAvailabilityInput)
            {
                return operations.CheckFrontDoorNameAvailabilityWithSubscriptionAsync(checkFrontDoorNameAvailabilityInput).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Check the availability of a Front Door subdomain.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='checkFrontDoorNameAvailabilityInput'>
            /// Input to check.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CheckNameAvailabilityOutput> CheckFrontDoorNameAvailabilityWithSubscriptionAsync(this IFrontDoorManagementClient operations, CheckNameAvailabilityInput checkFrontDoorNameAvailabilityInput, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckFrontDoorNameAvailabilityWithSubscriptionWithHttpMessagesAsync(checkFrontDoorNameAvailabilityInput, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
