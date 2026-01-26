# Simplic.OxS.SDK.Logistics.PatchShipmentItemRequest
Shared model of shipment item.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Text** | **string** | Gets or sets the text.     The text is a field for the user to give more context to the shipment item and the billing.   | [optional] 
**LoadingMeters** | **double** | Gets or sets the loading meters.     Loading meters define how many space a packed object will use on a trailer.   | [optional] 
**Reference** | **string** | Gets or sets the external reference. | [optional] 
**Quantity** | [**QuantityModel**](QuantityModel.md) |  | [optional] 
**Weight** | [**QuantityModel**](QuantityModel.md) |  | [optional] 
**Article** | [**ShipmentArticleModel**](ShipmentArticleModel.md) |  | [optional] 
**WeightNotes** | [**List&lt;WeightNoteModel&gt;**](WeightNoteModel.md) | Gets or sets the weight notes.     Weight notes are used to get the real amount of the driven freight.   | [optional] 
**Status** | [**ShipmentItemStatusModel**](ShipmentItemStatusModel.md) |  | [optional] 
**LoadigAidId** | **Guid?** | Gets or sets the id of the loading aid. | [optional] 
**OrderNumber** | **int?** | Gets or sets the number to order the shipment items within the shipment. | [optional] 
**Id** | **Guid** | Gets or sets the unique identifier of the shipmen item. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

