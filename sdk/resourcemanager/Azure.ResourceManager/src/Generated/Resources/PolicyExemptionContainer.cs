// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing collection of PolicyExemption and their operations over a Tenant. </summary>
    public partial class PolicyExemptionContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly PolicyExemptionsRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="PolicyExemptionContainer"/> class for mocking. </summary>
        protected PolicyExemptionContainer()
        {
        }

        /// <summary> Initializes a new instance of PolicyExemptionContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal PolicyExemptionContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new PolicyExemptionsRestOperations(_clientDiagnostics, Pipeline, BaseUri);
        }

        /// <summary> Verify that the input resource Id is a valid container for this type. </summary>
        /// <param name="identifier"> The input resource Id to check. </param>
        protected override void ValidateResourceType(ResourceIdentifier identifier)
        {
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceIdentifier.RootResourceIdentifier.ResourceType;

        // Container level operations.

        /// <summary> This operation creates or updates a policy exemption with the given scope and name. Policy exemptions apply to all resources contained within their scope. For example, when you create a policy exemption at resource group scope for a policy assignment at the same or above level, the exemption exempts to all applicable resources in the resource group. </summary>
        /// <param name="policyExemptionName"> The name of the policy exemption to delete. </param>
        /// <param name="parameters"> Parameters for the policy exemption. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyExemptionName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual PolicyExemptionCreateOrUpdateOperation CreateOrUpdate(string policyExemptionName, PolicyExemptionData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (policyExemptionName == null)
            {
                throw new ArgumentNullException(nameof(policyExemptionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PolicyExemptionContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id, policyExemptionName, parameters, cancellationToken);
                var operation = new PolicyExemptionCreateOrUpdateOperation(Parent, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation creates or updates a policy exemption with the given scope and name. Policy exemptions apply to all resources contained within their scope. For example, when you create a policy exemption at resource group scope for a policy assignment at the same or above level, the exemption exempts to all applicable resources in the resource group. </summary>
        /// <param name="policyExemptionName"> The name of the policy exemption to delete. </param>
        /// <param name="parameters"> Parameters for the policy exemption. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyExemptionName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<PolicyExemptionCreateOrUpdateOperation> CreateOrUpdateAsync(string policyExemptionName, PolicyExemptionData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (policyExemptionName == null)
            {
                throw new ArgumentNullException(nameof(policyExemptionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PolicyExemptionContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id, policyExemptionName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new PolicyExemptionCreateOrUpdateOperation(Parent, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="policyExemptionName"> The name of the policy exemption to delete. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<PolicyExemption> Get(string policyExemptionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyExemptionContainer.Get");
            scope.Start();
            try
            {
                if (policyExemptionName == null)
                {
                    throw new ArgumentNullException(nameof(policyExemptionName));
                }

                var response = _restClient.Get(Id, policyExemptionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PolicyExemption(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="policyExemptionName"> The name of the policy exemption to delete. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<PolicyExemption>> GetAsync(string policyExemptionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyExemptionContainer.Get");
            scope.Start();
            try
            {
                if (policyExemptionName == null)
                {
                    throw new ArgumentNullException(nameof(policyExemptionName));
                }

                var response = await _restClient.GetAsync(Id, policyExemptionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new PolicyExemption(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyExemptionName"> The name of the policy exemption to delete. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<PolicyExemption> GetIfExists(string policyExemptionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyExemptionContainer.GetIfExists");
            scope.Start();
            try
            {
                if (policyExemptionName == null)
                {
                    throw new ArgumentNullException(nameof(policyExemptionName));
                }

                var response = _restClient.Get(Id, policyExemptionName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<PolicyExemption>(null, response.GetRawResponse())
                    : Response.FromValue(new PolicyExemption(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyExemptionName"> The name of the policy exemption to delete. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<PolicyExemption>> GetIfExistsAsync(string policyExemptionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyExemptionContainer.GetIfExists");
            scope.Start();
            try
            {
                if (policyExemptionName == null)
                {
                    throw new ArgumentNullException(nameof(policyExemptionName));
                }

                var response = await _restClient.GetAsync(Id, policyExemptionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<PolicyExemption>(null, response.GetRawResponse())
                    : Response.FromValue(new PolicyExemption(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyExemptionName"> The name of the policy exemption to delete. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string policyExemptionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyExemptionContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (policyExemptionName == null)
                {
                    throw new ArgumentNullException(nameof(policyExemptionName));
                }

                var response = GetIfExists(policyExemptionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyExemptionName"> The name of the policy exemption to delete. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string policyExemptionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyExemptionContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (policyExemptionName == null)
                {
                    throw new ArgumentNullException(nameof(policyExemptionName));
                }

                var response = await GetIfExistsAsync(policyExemptionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation retrieves the list of all policy exemptions associated with the given subscription that match the optional given $filter. Valid values for $filter are: &apos;atScope()&apos;, &apos;atExactScope()&apos;, &apos;excludeExpired()&apos; or &apos;policyAssignmentId eq &apos;{value}&apos;&apos;. If $filter is not provided, the unfiltered list includes all policy exemptions associated with the subscription, including those that apply directly or from management groups that contain the given subscription, as well as any applied to objects contained within the subscription. </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: &apos;atScope()&apos;, &apos;atExactScope()&apos;, &apos;excludeExpired()&apos; or &apos;policyAssignmentId eq &apos;{value}&apos;&apos;. If $filter is not provided, no filtering is performed. If $filter is not provided, the unfiltered list includes all policy exemptions associated with the scope, including those that apply directly or apply from containing scopes. If $filter=atScope() is provided, the returned list only includes all policy exemptions that apply to the scope, which is everything in the unfiltered list except those applied to sub scopes contained within the given scope. If $filter=atExactScope() is provided, the returned list only includes all policy exemptions that at the given scope. If $filter=excludeExpired() is provided, the returned list only includes all policy exemptions that either haven&apos;t expired or didn&apos;t set expiration date. If $filter=policyAssignmentId eq &apos;{value}&apos; is provided. the returned list only includes all policy exemptions that are associated with the give policyAssignmentId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PolicyExemption" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PolicyExemption> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<PolicyExemption> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyExemptionContainer.GetAll");
                scope.Start();
                try
                {
                    if (Id.TryGetResourceGroupName(out var resourceGroupName))
                    {
                        if (Id.ResourceType.Equals(ResourceGroup.ResourceType))
                        {
                            var response = _restClient.GetForResourceGroup(Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken);
                            return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                        }
                        else
                        {
                            var parent = Id.Parent;
                            var parentParts = new List<string>();
                            while (!parent.ResourceType.Equals(ResourceGroup.ResourceType))
                            {
                                parentParts.Insert(0, $"{parent.ResourceType.Types[parent.ResourceType.Types.Count - 1]}/{parent.Name}");
                                parent = parent.Parent;
                            }
                            var parentResourcePath = parentParts.Count > 0 ? string.Join("/", parentParts) : "";
                            Id.TryGetSubscriptionId(out var subscriptionId);
                            var response = _restClient.GetForResource(subscriptionId, resourceGroupName, Id.ResourceType.Namespace, parentResourcePath, Id.ResourceType.Types[Id.ResourceType.Types.Count - 1], Id.Name, filter, cancellationToken: cancellationToken);
                            return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                        }
                    }
                    else if (Id.TryGetSubscriptionId(out _))
                    {
                        var response = _restClient.GetAll(Id.Name, filter, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    else
                    {
                        var response = _restClient.GetForManagementGroup(Id.Name, filter, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PolicyExemption> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyExemptionContainer.GetAll");
                scope.Start();
                try
                {
                    if (Id.TryGetResourceGroupName(out var resourceGroupName))
                    {
                        if (Id.ResourceType.Equals(ResourceGroup.ResourceType))
                        {
                            var response = _restClient.GetForResourceGroupNextPage(nextLink, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken);
                            return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                        }
                        else
                        {
                            var parent = Id.Parent;
                            var parentParts = new List<string>();
                            while (!parent.ResourceType.Equals(ResourceGroup.ResourceType))
                            {
                                parentParts.Insert(0, $"{parent.ResourceType.Types[parent.ResourceType.Types.Count - 1]}/{parent.Name}");
                                parent = parent.Parent;
                            }
                            var parentResourcePath = parentParts.Count > 0 ? string.Join("/", parentParts) : "";
                            Id.TryGetSubscriptionId(out var subscriptionId);
                            var response = _restClient.GetForResourceNextPage(nextLink, subscriptionId, resourceGroupName, Id.ResourceType.Namespace, parentResourcePath, Id.ResourceType.Types[Id.ResourceType.Types.Count - 1], Id.Name, filter, cancellationToken: cancellationToken);
                            return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                        }
                    }
                    else if (Id.TryGetSubscriptionId(out _))
                    {
                        var response = _restClient.GetAllNextPage(nextLink, Id.Name, filter, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    else
                    {
                        var response = _restClient.GetForManagementGroupNextPage(nextLink, Id.Name, filter, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> This operation retrieves the list of all policy exemptions associated with the given subscription that match the optional given $filter. Valid values for $filter are: &apos;atScope()&apos;, &apos;atExactScope()&apos;, &apos;excludeExpired()&apos; or &apos;policyAssignmentId eq &apos;{value}&apos;&apos;. If $filter is not provided, the unfiltered list includes all policy exemptions associated with the subscription, including those that apply directly or from management groups that contain the given subscription, as well as any applied to objects contained within the subscription. </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: &apos;atScope()&apos;, &apos;atExactScope()&apos;, &apos;excludeExpired()&apos; or &apos;policyAssignmentId eq &apos;{value}&apos;&apos;. If $filter is not provided, no filtering is performed. If $filter is not provided, the unfiltered list includes all policy exemptions associated with the scope, including those that apply directly or apply from containing scopes. If $filter=atScope() is provided, the returned list only includes all policy exemptions that apply to the scope, which is everything in the unfiltered list except those applied to sub scopes contained within the given scope. If $filter=atExactScope() is provided, the returned list only includes all policy exemptions that at the given scope. If $filter=excludeExpired() is provided, the returned list only includes all policy exemptions that either haven&apos;t expired or didn&apos;t set expiration date. If $filter=policyAssignmentId eq &apos;{value}&apos; is provided. the returned list only includes all policy exemptions that are associated with the give policyAssignmentId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PolicyExemption" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PolicyExemption> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<PolicyExemption>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyExemptionContainer.GetAll");
                scope.Start();
                try
                {
                    if (Id.TryGetResourceGroupName(out var resourceGroupName))
                    {
                        if (Id.ResourceType.Equals(ResourceGroup.ResourceType))
                        {
                            var response = await _restClient.GetForResourceGroupAsync(Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                            return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                        }
                        else
                        {
                            var parent = Id.Parent;
                            var parentParts = new List<string>();
                            while (!parent.ResourceType.Equals(ResourceGroup.ResourceType))
                            {
                                parentParts.Insert(0, $"{parent.ResourceType.Types[parent.ResourceType.Types.Count - 1]}/{parent.Name}");
                                parent = parent.Parent;
                            }
                            var parentResourcePath = parentParts.Count > 0 ? string.Join("/", parentParts) : "";
                            Id.TryGetSubscriptionId(out var subscriptionId);
                            var response = await _restClient.GetForResourceAsync(subscriptionId, resourceGroupName, Id.ResourceType.Namespace, parentResourcePath, Id.ResourceType.Types[Id.ResourceType.Types.Count - 1], Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                            return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                        }
                    }
                    else if (Id.TryGetSubscriptionId(out _))
                    {
                        var response = await _restClient.GetAllAsync(Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    else
                    {
                        var response = await _restClient.GetForManagementGroupAsync(Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PolicyExemption>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyExemptionContainer.GetAll");
                scope.Start();
                try
                {
                    if (Id.TryGetResourceGroupName(out var resourceGroupName))
                    {
                        if (Id.ResourceType.Equals(ResourceGroup.ResourceType))
                        {
                            var response = await _restClient.GetForResourceGroupNextPageAsync(nextLink, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                            return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                        }
                        else
                        {
                            var parent = Id.Parent;
                            var parentParts = new List<string>();
                            while (!parent.ResourceType.Equals(ResourceGroup.ResourceType))
                            {
                                parentParts.Insert(0, $"{parent.ResourceType.Types[parent.ResourceType.Types.Count - 1]}/{parent.Name}");
                                parent = parent.Parent;
                            }
                            var parentResourcePath = parentParts.Count > 0 ? string.Join("/", parentParts) : "";
                            Id.TryGetSubscriptionId(out var subscriptionId);
                            var response = await _restClient.GetForResourceNextPageAsync(nextLink, subscriptionId, resourceGroupName, Id.ResourceType.Namespace, parentResourcePath, Id.ResourceType.Types[Id.ResourceType.Types.Count - 1], Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                            return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                        }
                    }
                    else if (Id.TryGetSubscriptionId(out _))
                    {
                        var response = await _restClient.GetAllNextPageAsync(nextLink, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    else
                    {
                        var response = await _restClient.GetForManagementGroupNextPageAsync(nextLink, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="PolicyExemption" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyExemptionContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(PolicyExemption.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="PolicyExemption" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyExemptionContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(PolicyExemption.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, PolicyExemption, PolicyExemptionData> Construct() { }
    }
}
