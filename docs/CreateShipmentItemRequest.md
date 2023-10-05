# Simplic.OxS.SDK.Logistics.CreateShipmentItemRequest
Shared model of shipment item.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Text** | **string** | Gets or sets the text.  &lt;br&gt;  The text is a field for the user to give more context to the shipment item and the billing.   | [optional] 
**LoadingMeters** | **double** | Gets or sets the loading meters.  &lt;br&gt;  Loading meters define how many space a packed object will use on a trailer.   | [optional] 
**Reference** | **string** | Gets or sets the external reference. | [optional] 
**Quantity** | [**QuantityModel**](QuantityModel.md) |  | [optional] 
**Weight** | [**QuantityModel**](QuantityModel.md) |  | [optional] 
**BillingLines** | [**List&lt;BillingLineModel&gt;**](BillingLineModel.md) | Gets or sets the billing lines.  &lt;br&gt;  Billing lines determine which persons can be billed which amounts.   | [optional] 
**Article** | [**ShipmentArticleModel**](ShipmentArticleModel.md) |  | [optional] 
**WeightNotes** | [**List&lt;WeightNoteModel&gt;**](WeightNoteModel.md) | Gets or sets the weight notes.  &lt;br&gt;  Weight notes are used to get the real amount of the driven freight.   | [optional] 
**Status** | [**ShipmentItemStatusModel**](ShipmentItemStatusModel.md) |  | [optional] 
**LoadigAidId** | **Guid?** | Gets or sets the id of the loading aid. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

