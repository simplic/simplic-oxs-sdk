# Simplic.OxS.SDK.Logistics.Model.BillingLineModel
Shared model of billing line.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the id.  &lt;br&gt;  Represents the unique identifier of a billing line.   | [optional] 
**Type** | **BillingLineType** |  | [optional] 
**BillableContact** | [**BillableContactModel**](BillableContactModel.md) |  | [optional] 
**Pricing** | [**BillingLinePricingModel**](BillingLinePricingModel.md) |  | [optional] 
**Status** | [**BillingLineStatusModel**](BillingLineStatusModel.md) |  | [optional] 
**SinglePrice** | **double** | Gets or sets the single price.  &lt;br&gt;  Represents the price of a single item.   | [optional] 
**TotalPrice** | **double** | Gets or sets the total price.  &lt;br&gt;  Represents the price of all items.   | [optional] 
**Quantity** | [**QuantityModel**](QuantityModel.md) |  | [optional] 
**TransactionItems** | [**List&lt;BillingLineTransationItemModel&gt;**](BillingLineTransationItemModel.md) | Gets or sets the transaction items where the billing line is present in.  &lt;br&gt;  The list will be filled during the billing process.   | [optional] 
**Article** | [**ShipmentArticleModel**](ShipmentArticleModel.md) |  | [optional] 
**WeightNoteId** | **Guid?** | Gets or sets the weight note id that will be billed | [optional] 
**Reference** | **string** | Gets or sets the external reference. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

