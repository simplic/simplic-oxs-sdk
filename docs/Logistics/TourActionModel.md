# Simplic.OxS.SDK.Logistics.TourActionModel
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
**Notes** | **string** | Gets or sets notes, which are attached to the current action in the tour | [optional] 
**GlobalActionId** | **Guid** | Gets or sets the global action id. | [optional] 
**Entity** | [**TourEntityModel**](TourEntityModel.md) |  | [optional] 
**Resource** | [**ResourceModel**](ResourceModel.md) |  | [optional] 
**Address** | [**AddressModel**](AddressModel.md) |  | [optional] 
**CleaningSlots** | [**List&lt;LoadingSlotModel&gt;**](LoadingSlotModel.md) | Gets or sets a list of used loading slots. | [optional] 
**UsedLoadingSlots** | [**List&lt;LoadingSlotModel&gt;**](LoadingSlotModel.md) | Gets or sets a list of used loading slots. | [optional] 
**MirroredTourTags** | [**List&lt;TourTagModel&gt;**](TourTagModel.md) | Gets or sets the mirrored tour tags.   &lt;br&gt;  The mirrored tour tags will be used to add tags to the mirrored tour.   | [optional] 
**MirroredTourStatus** | [**TourStatusModel**](TourStatusModel.md) |  | [optional] 
**OutOfTour** | **bool** | Gets or sets whether the tour action is not happening during the tour, but is required to be   present for attached resources and entities being complete.  &lt;br&gt;  The property does only need to be set in mirrored tours and should ALWAYS be false in \&quot;normal\&quot; tours.   | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

