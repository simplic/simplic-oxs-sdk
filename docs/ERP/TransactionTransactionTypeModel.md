# Simplic.OxS.SDK.ERP.TransactionTransactionTypeModel
Represents the shared model for a transaction type in a transaction.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Gets or sets the ID. | [optional] 
**Name** | **string** | Gets or sets the name. | [optional] 
**Number** | **int** | Gets or sets the number. | [optional] 
**ReportName** | **string** | Gets or sets the report title. | [optional] 
**ShortName** | **string** | Gets or sets the short name. | [optional] 
**Functions** | **List&lt;string&gt;** | Gets or sets a set of functions the transaction type has.     Examples for functions are: credit, debit, cancellation, incoming, outgoing, accounting_exportable, standing_order, workshop_order   | [optional] 
**Subtype** | [**TransactionSubtypeModel**](TransactionSubtypeModel.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

