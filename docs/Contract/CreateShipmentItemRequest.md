# Simplic.OxS.SDK.Contract.CreateShipmentItemRequest
Shared model of shipment item.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Text** | **string** | Gets or sets the text.  The text is a field for the user to give more context to the shipment item and the billing. | [optional] 
**LoadingMeters** | **double?** | Gets or sets the loading meters.  Loading meters define how many space a packed object will use on a trailer. | [optional] 
**Reference** | **string** | Gets or sets the external reference. | [optional] 
**Quantity** | [**QuantityModel**](QuantityModel.md) |  | [optional] 
**Weight** | [**QuantityModel**](QuantityModel.md) |  | [optional] 
**ArticleId** | **Guid?** | Gets or sets the article.  This just contains a part of the actual article class. | [optional] 
**LoadingAidId** | **Guid?** | Gets or sets the id of the loading aid. | [optional] 
**OrderNumber** | **int** | Gets or sets the order number of a shipment item. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

