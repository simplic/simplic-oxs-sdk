# Simplic.OxS.SDK.Logistics.ShipmentItemModel
Shared model of shipment item.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Text** | **string** | Gets or sets the text.     The text is a field for the user to give more context to the shipment item and the billing.   | [optional] 
**LoadingMeters** | **double** | Gets or sets the loading meters.     Loading meters define how many space a packed object will use on a trailer.   | [optional] 
**Reference** | **string** | Gets or sets the external reference. | [optional] 
**Quantity** | [**QuantityModel**](QuantityModel.md) |  | [optional] 
**Weight** | [**QuantityModel**](QuantityModel.md) |  | [optional] 
**OrderNumber** | **int?** | Gets or sets the number to order the shipment items within the shipment. | [optional] 
**Id** | **Guid** | Gets or sets the id.     Represents the id of a shipment-item, this id must be unique   | [optional] 
**Status** | [**ShipmentItemStatusModel**](ShipmentItemStatusModel.md) |  | [optional] 
**BillingLines** | [**List&lt;BillingLineModel&gt;**](BillingLineModel.md) | Gets or sets the billing lines.     Billing lines determine which persons can be billed which amounts.   | [optional] 
**Article** | [**ShipmentArticleModel**](ShipmentArticleModel.md) |  | [optional] 
**WeightNotes** | [**List&lt;WeightNoteModel&gt;**](WeightNoteModel.md) | Gets or sets the weight notes.     Weight notes are used to get the real amount of the driven freight.   | [optional] 
**LoadingAidType** | [**ShipmentLoadingAidTypeModel**](ShipmentLoadingAidTypeModel.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

