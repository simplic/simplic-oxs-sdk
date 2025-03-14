# Simplic.OxS.SDK.Logistics.CreateTourActionRequest
Shared model of a tour action.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the id. | [optional] 
**OrderId** | **int** | Gets or sets the order id in which the actions are processed. | [optional] 
**DateTime** | **DateTime?** | Gets or sets the date time.     Represents the planned date and time of the action.   | [optional] 
**ActualDateTime** | **DateTime?** | Gets or sets the actual date time.     Represents the actual date and time of the action.   | [optional] 
**CalculatedDateTime** | **DateTime?** | Gets or sets the calculated date time.     Represents the calculated date and time of the action.   | [optional] 
**MirroredTourNumber** | **string** | Gets or sets the tour number of the mirrored tour.     The tour number will be used to make sure that all generated tours from this action have the same   tour number.   | [optional] 
**Type** | **string** | Gets or sets the type. | [optional] 
**Notes** | **string** | Gets or sets notes, which are attached to the current action in the tour | [optional] 
**EntityId** | **Guid?** | Gets or sets the id to resolve the entity. | [optional] 
**ResourceId** | **Guid?** | Gets or sets the id to resolve the resource. | [optional] 
**AddressId** | **Guid?** | Gets or sets the id to resolve the address. | [optional] 
**MirroredTourTags** | **List&lt;Guid&gt;** | Gets or sets the mirrored tour tags.      The mirrored tour tags will be used to add tags to the mirrored tour.   | [optional] 
**CleaningSlots** | [**List&lt;LoadingSlotModel&gt;**](LoadingSlotModel.md) | Gets or sets a list of used loading slots. | [optional] 
**UsedLoadingSlots** | [**List&lt;LoadingSlotModel&gt;**](LoadingSlotModel.md) | Gets or sets a list of used loading slots. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

