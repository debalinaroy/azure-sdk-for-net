// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Search;

/// <summary>
/// Describes the properties of an existing Shared Private Link Resource
/// managed by the search service.
/// </summary>
public partial class SharedSearchServicePrivateLinkResourceProperties : ProvisionableConstruct
{
    /// <summary>
    /// Status of the shared private link resource. Valid values are Pending,
    /// Approved, Rejected or Disconnected.
    /// </summary>
    public BicepValue<SharedSearchServicePrivateLinkResourceStatus> Status 
    {
        get { Initialize(); return _status!; }
        set { Initialize(); _status!.Assign(value); }
    }
    private BicepValue<SharedSearchServicePrivateLinkResourceStatus>? _status;

    /// <summary>
    /// The provisioning state of the shared private link resource. Valid
    /// values are Updating, Deleting, Failed, Succeeded or Incomplete.
    /// </summary>
    public BicepValue<SharedSearchServicePrivateLinkResourceProvisioningState> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
        set { Initialize(); _provisioningState!.Assign(value); }
    }
    private BicepValue<SharedSearchServicePrivateLinkResourceProvisioningState>? _provisioningState;

    /// <summary>
    /// The resource ID of the resource the shared private link resource is for.
    /// </summary>
    public BicepValue<ResourceIdentifier> PrivateLinkResourceId 
    {
        get { Initialize(); return _privateLinkResourceId!; }
        set { Initialize(); _privateLinkResourceId!.Assign(value); }
    }
    private BicepValue<ResourceIdentifier>? _privateLinkResourceId;

    /// <summary>
    /// The group ID from the provider of resource the shared private link
    /// resource is for.
    /// </summary>
    public BicepValue<string> GroupId 
    {
        get { Initialize(); return _groupId!; }
        set { Initialize(); _groupId!.Assign(value); }
    }
    private BicepValue<string>? _groupId;

    /// <summary>
    /// The message for requesting approval of the shared private link resource.
    /// </summary>
    public BicepValue<string> RequestMessage 
    {
        get { Initialize(); return _requestMessage!; }
        set { Initialize(); _requestMessage!.Assign(value); }
    }
    private BicepValue<string>? _requestMessage;

    /// <summary>
    /// Optional. Can be used to specify the Azure Resource Manager location of
    /// the resource for which a shared private link is being created. This is
    /// only required for those resources whose DNS configuration are regional
    /// (such as Azure Kubernetes Service).
    /// </summary>
    public BicepValue<AzureLocation> ResourceRegion 
    {
        get { Initialize(); return _resourceRegion!; }
        set { Initialize(); _resourceRegion!.Assign(value); }
    }
    private BicepValue<AzureLocation>? _resourceRegion;

    /// <summary>
    /// Creates a new SharedSearchServicePrivateLinkResourceProperties.
    /// </summary>
    public SharedSearchServicePrivateLinkResourceProperties()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// SharedSearchServicePrivateLinkResourceProperties.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _status = DefineProperty<SharedSearchServicePrivateLinkResourceStatus>("Status", ["status"]);
        _provisioningState = DefineProperty<SharedSearchServicePrivateLinkResourceProvisioningState>("ProvisioningState", ["provisioningState"]);
        _privateLinkResourceId = DefineProperty<ResourceIdentifier>("PrivateLinkResourceId", ["privateLinkResourceId"]);
        _groupId = DefineProperty<string>("GroupId", ["groupId"]);
        _requestMessage = DefineProperty<string>("RequestMessage", ["requestMessage"]);
        _resourceRegion = DefineProperty<AzureLocation>("ResourceRegion", ["resourceRegion"]);
    }
}
