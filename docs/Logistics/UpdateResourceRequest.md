# Simplic.OxS.SDK.Logistics.UpdateResourceRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Gets the type of the resource.  &lt;br&gt;  E.g. \&quot;Driver\&quot; or \&quot;Tractor Unit\&quot;   | [optional] 
**MatchCode** | **string** | Gets or sets the match code.  &lt;br&gt;  This will be a non unique human readable number for the resource.   | [optional] 
**DisplayName** | **string** | Gets or sets the user-friendly display name  &lt;br&gt;  This will be the display-name of the resource. E.g. for drivers  this might be the first- and lastname. For vehicles this might be   the registration plate.   | [optional] 
**LoadingSlots** | [**List&lt;LoadingSlotModel&gt;**](LoadingSlotModel.md) | Gets or sets the loading slots of the resource. | [optional] 
**Location** | [**ResourceLocationModel**](ResourceLocationModel.md) |  | [optional] 
**IsLoadable** | **bool** | Gets or sets whether the resource is loadable | [optional] 
**PlanningOrderKey** | **string** | Gets or sets an order key for the disposition | [optional] 
**UsableUntil** | **DateTime?** | Gets or sets a date, until | [optional] 
**Notes** | **string** | Gets or sets resource notes | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

