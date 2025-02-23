// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.LabServices.Mocking;
using Azure.ResourceManager.LabServices.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.LabServices
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.LabServices. </summary>
    public static partial class LabServicesExtensions
    {
        private static MockableLabServicesArmClient GetMockableLabServicesArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableLabServicesArmClient(client0));
        }

        private static MockableLabServicesResourceGroupResource GetMockableLabServicesResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableLabServicesResourceGroupResource(client, resource.Id));
        }

        private static MockableLabServicesSubscriptionResource GetMockableLabServicesSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableLabServicesSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="LabVirtualMachineImageResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="LabVirtualMachineImageResource.CreateResourceIdentifier" /> to create a <see cref="LabVirtualMachineImageResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLabServicesArmClient.GetLabVirtualMachineImageResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="LabVirtualMachineImageResource"/> object. </returns>
        public static LabVirtualMachineImageResource GetLabVirtualMachineImageResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableLabServicesArmClient(client).GetLabVirtualMachineImageResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="LabPlanResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="LabPlanResource.CreateResourceIdentifier" /> to create a <see cref="LabPlanResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLabServicesArmClient.GetLabPlanResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="LabPlanResource"/> object. </returns>
        public static LabPlanResource GetLabPlanResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableLabServicesArmClient(client).GetLabPlanResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="LabResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="LabResource.CreateResourceIdentifier" /> to create a <see cref="LabResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLabServicesArmClient.GetLabResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="LabResource"/> object. </returns>
        public static LabResource GetLabResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableLabServicesArmClient(client).GetLabResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="LabServicesScheduleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="LabServicesScheduleResource.CreateResourceIdentifier" /> to create a <see cref="LabServicesScheduleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLabServicesArmClient.GetLabServicesScheduleResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="LabServicesScheduleResource"/> object. </returns>
        public static LabServicesScheduleResource GetLabServicesScheduleResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableLabServicesArmClient(client).GetLabServicesScheduleResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="LabUserResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="LabUserResource.CreateResourceIdentifier" /> to create a <see cref="LabUserResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLabServicesArmClient.GetLabUserResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="LabUserResource"/> object. </returns>
        public static LabUserResource GetLabUserResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableLabServicesArmClient(client).GetLabUserResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="LabVirtualMachineResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="LabVirtualMachineResource.CreateResourceIdentifier" /> to create a <see cref="LabVirtualMachineResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLabServicesArmClient.GetLabVirtualMachineResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="LabVirtualMachineResource"/> object. </returns>
        public static LabVirtualMachineResource GetLabVirtualMachineResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableLabServicesArmClient(client).GetLabVirtualMachineResource(id);
        }

        /// <summary>
        /// Gets a collection of LabPlanResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLabServicesResourceGroupResource.GetLabPlans()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of LabPlanResources and their operations over a LabPlanResource. </returns>
        public static LabPlanCollection GetLabPlans(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableLabServicesResourceGroupResource(resourceGroupResource).GetLabPlans();
        }

        /// <summary>
        /// Retrieves the properties of a Lab Plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labPlans/{labPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LabPlans_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LabPlanResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLabServicesResourceGroupResource.GetLabPlanAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="labPlanName"> The name of the lab plan that uniquely identifies it within containing resource group. Used in resource URIs and in UI. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="labPlanName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="labPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<LabPlanResource>> GetLabPlanAsync(this ResourceGroupResource resourceGroupResource, string labPlanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableLabServicesResourceGroupResource(resourceGroupResource).GetLabPlanAsync(labPlanName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves the properties of a Lab Plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labPlans/{labPlanName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LabPlans_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LabPlanResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLabServicesResourceGroupResource.GetLabPlan(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="labPlanName"> The name of the lab plan that uniquely identifies it within containing resource group. Used in resource URIs and in UI. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="labPlanName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="labPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<LabPlanResource> GetLabPlan(this ResourceGroupResource resourceGroupResource, string labPlanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableLabServicesResourceGroupResource(resourceGroupResource).GetLabPlan(labPlanName, cancellationToken);
        }

        /// <summary>
        /// Gets a collection of LabResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLabServicesResourceGroupResource.GetLabs()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of LabResources and their operations over a LabResource. </returns>
        public static LabCollection GetLabs(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableLabServicesResourceGroupResource(resourceGroupResource).GetLabs();
        }

        /// <summary>
        /// Returns the properties of a lab resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Labs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LabResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLabServicesResourceGroupResource.GetLabAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="labName"> The name of the lab that uniquely identifies it within containing lab plan. Used in resource URIs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="labName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="labName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<LabResource>> GetLabAsync(this ResourceGroupResource resourceGroupResource, string labName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableLabServicesResourceGroupResource(resourceGroupResource).GetLabAsync(labName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns the properties of a lab resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Labs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LabResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLabServicesResourceGroupResource.GetLab(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="labName"> The name of the lab that uniquely identifies it within containing lab plan. Used in resource URIs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="labName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="labName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<LabResource> GetLab(this ResourceGroupResource resourceGroupResource, string labName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableLabServicesResourceGroupResource(resourceGroupResource).GetLab(labName, cancellationToken);
        }

        /// <summary>
        /// Returns a list of all lab plans within a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.LabServices/labPlans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LabPlans_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LabPlanResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLabServicesSubscriptionResource.GetLabPlans(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="filter"> The filter to apply to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="LabPlanResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<LabPlanResource> GetLabPlansAsync(this SubscriptionResource subscriptionResource, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableLabServicesSubscriptionResource(subscriptionResource).GetLabPlansAsync(filter, cancellationToken);
        }

        /// <summary>
        /// Returns a list of all lab plans within a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.LabServices/labPlans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LabPlans_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LabPlanResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLabServicesSubscriptionResource.GetLabPlans(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="filter"> The filter to apply to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="LabPlanResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<LabPlanResource> GetLabPlans(this SubscriptionResource subscriptionResource, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableLabServicesSubscriptionResource(subscriptionResource).GetLabPlans(filter, cancellationToken);
        }

        /// <summary>
        /// Returns a list of all labs for a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.LabServices/labs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Labs_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LabResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLabServicesSubscriptionResource.GetLabs(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="filter"> The filter to apply to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="LabResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<LabResource> GetLabsAsync(this SubscriptionResource subscriptionResource, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableLabServicesSubscriptionResource(subscriptionResource).GetLabsAsync(filter, cancellationToken);
        }

        /// <summary>
        /// Returns a list of all labs for a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.LabServices/labs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Labs_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LabResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLabServicesSubscriptionResource.GetLabs(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="filter"> The filter to apply to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="LabResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<LabResource> GetLabs(this SubscriptionResource subscriptionResource, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableLabServicesSubscriptionResource(subscriptionResource).GetLabs(filter, cancellationToken);
        }

        /// <summary>
        /// Returns a list of Azure Lab Services resource SKUs.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.LabServices/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLabServicesSubscriptionResource.GetSkus(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="filter"> The filter to apply to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="AvailableLabServicesSku"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<AvailableLabServicesSku> GetSkusAsync(this SubscriptionResource subscriptionResource, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableLabServicesSubscriptionResource(subscriptionResource).GetSkusAsync(filter, cancellationToken);
        }

        /// <summary>
        /// Returns a list of Azure Lab Services resource SKUs.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.LabServices/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLabServicesSubscriptionResource.GetSkus(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="filter"> The filter to apply to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="AvailableLabServicesSku"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<AvailableLabServicesSku> GetSkus(this SubscriptionResource subscriptionResource, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableLabServicesSubscriptionResource(subscriptionResource).GetSkus(filter, cancellationToken);
        }

        /// <summary>
        /// Returns list of usage per SKU family for the specified subscription in the specified region.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.LabServices/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_ListByLocation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLabServicesSubscriptionResource.GetUsages(AzureLocation,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location name. </param>
        /// <param name="filter"> The filter to apply to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="LabServicesUsage"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<LabServicesUsage> GetUsagesAsync(this SubscriptionResource subscriptionResource, AzureLocation location, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableLabServicesSubscriptionResource(subscriptionResource).GetUsagesAsync(location, filter, cancellationToken);
        }

        /// <summary>
        /// Returns list of usage per SKU family for the specified subscription in the specified region.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.LabServices/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Usages_ListByLocation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLabServicesSubscriptionResource.GetUsages(AzureLocation,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location name. </param>
        /// <param name="filter"> The filter to apply to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="LabServicesUsage"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<LabServicesUsage> GetUsages(this SubscriptionResource subscriptionResource, AzureLocation location, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableLabServicesSubscriptionResource(subscriptionResource).GetUsages(location, filter, cancellationToken);
        }
    }
}
