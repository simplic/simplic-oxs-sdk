# Simplic.OxS.SDK.Logistics.BillingLineModel
Shared model of billing line.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the id.     Represents the unique identifier of a billing line.   | [optional] 
**Type** | **BillingLineType** |  | [optional] 
**Status** | [**BillingLineStatusModel**](BillingLineStatusModel.md) |  | [optional] 
**SinglePrice** | **double** | Gets or sets the single price.     Represents the price of a single item.   | [optional] 
**TotalPrice** | **double** | Gets or sets the total price.     Represents the price of all items.   | [optional] 
**Quantity** | [**QuantityModel**](QuantityModel.md) |  | [optional] 
**Reference** | **string** | Gets or sets the external reference. | [optional] 
**Text** | **string** | Gets or sets the billing line text | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

