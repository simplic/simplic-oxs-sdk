# Simplic.OxS.SDK.Logistics.Model.BillingLineTransationItemModel
Shared model of billing line transaction.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionId** | **Guid** | Gets or sets the transaction id.  &lt;br&gt;  This represents the unique identifier of a Simplic.Erp.Transaction.   | [optional] 
**TransactionItemId** | **Guid** | Gets or sets the transaction item id.  &lt;br&gt;  This represents the unique identifier fo a Simplic.Erp.TransactionItem.   | [optional] 
**Number** | **string** | Gets or sets the transaction number.  &lt;br&gt;  This represents the number of a transaction, which is a human readable number to represent the transaction.   | [optional] 
**TypeName** | **string** | Gets or sets the type name.  &lt;br&gt;  Represents the name of the type of the transaction.   | [optional] 
**SubtypeName** | **string** | Gets or sets the subtype name.  &lt;br&gt;  Represents the name of the subtype of the transaction.   | [optional] 
**CreateDateTime** | **DateTime** | Gets or sets the create date time.  &lt;br&gt;  Represents the create date and time of the transaction.   | [optional] 
**SinglePrice** | **double** | Gets or sets the single price.  &lt;br&gt;  Represents the single price of the transaction item.   | [optional] 
**TotalPrice** | **double** | Gets or sets the total price.  &lt;br&gt;  Represents the total price of a transaction item.   | [optional] 
**Quantity** | [**QuantityModel**](QuantityModel.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

