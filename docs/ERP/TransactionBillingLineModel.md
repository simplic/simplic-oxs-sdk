# Simplic.OxS.SDK.ERP.TransactionBillingLineModel
Represents the shared model for Simplic.OxS.ERP.TransactionBillingLine.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the ID. | [optional] 
**Text** | **string** | Gets or sets the text describing this billing line. | [optional] 
**QuantityUnit** | [**QuantityUnitModel**](QuantityUnitModel.md) |  | [optional] 
**PriceUnit** | [**QuantityUnitModel**](QuantityUnitModel.md) |  | [optional] 
**TaxRate** | [**TransactionTaxRateModel**](TransactionTaxRateModel.md) |  | [optional] 
**Reference** | **string** | Gets or sets the main reference. | [optional] 
**References** | [**List&lt;BillingLineReferenceModel&gt;**](BillingLineReferenceModel.md) | Gets or sets a set of additional references. | [optional] 
**IsManualBillingLine** | **bool** | Gets or sets the flag indicating whether the billing line was created manually. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

