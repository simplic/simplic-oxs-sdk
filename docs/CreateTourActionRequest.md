# Simplic.OxS.SDK.Logistics.Model.CreateTourActionRequest
Shared model of a tour action.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the id. | [optional] 
**OrderId** | **int** | Gets or sets the order id in which the actions are processed. | [optional] 
**DateTime** | **DateTime?** | Gets or sets the date time.  &lt;br&gt;  Represents the planned date and time of the action.   | [optional] 
**ActualDateTime** | **DateTime?** | Gets or sets the actual date time.  &lt;br&gt;  Represents the actual date and time of the action.   | [optional] 
**CalculatedDateTime** | **DateTime?** | Gets or sets the calculated date time.  &lt;br&gt;  Represents the calculated date and time of the action.   | [optional] 
**MirroredTourNumber** | **string** | Gets or sets the tour number of the mirrored tour.  &lt;br&gt;  The tour number will be used to make sure that all generated tours from this action have the same   tour number.   | [optional] 
**Type** | **string** | Gets or sets the type. | [optional] 
**EntityId** | **Guid?** | Gets or sets the id to resolve the entity. | [optional] 
**ResourceId** | **Guid?** | Gets or sets the id to resolve the resource. | [optional] 
**AddressId** | **Guid?** | Gets or sets the id to resolve the address. | [optional] 
**MirroredTourTags** | **List&lt;Guid&gt;** | Gets or sets the mirrored tour tags.   &lt;br&gt;  The mirrored tour tags will be used to add tags to the mirrored tour.   | [optional] 
**MirroredTourStatusId** | **Guid?** | Gets ors sets the id of the status of the mirrored tour.  &lt;br&gt;  The tour status will make sure that all generated tours from this action have the right status.    The status will currently not be resolved and will only be set manually. | [optional] 
**CleaningSlots** | [**List&lt;LoadingSlotModel&gt;**](LoadingSlotModel.md) | Gets or sets a list of used loading slots. | [optional] 
**UsedLoadingSlots** | [**List&lt;LoadingSlotModel&gt;**](LoadingSlotModel.md) | Gets or sets a list of used loading slots. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

