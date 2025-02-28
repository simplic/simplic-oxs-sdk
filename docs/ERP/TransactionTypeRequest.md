# Simplic.OxS.SDK.ERP.TransactionTypeRequest
Represents a request to create a Simplic.OxS.ERP.Transaction.TransactionType.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Gets or sets the name. | 
**Number** | **int** | Gets or sets the number. | 
**ReportName** | **string** | Gets or sets the report title. | [optional] 
**ShortName** | **string** | Gets or sets the short name. | [optional] 
**Functions** | **List&lt;string&gt;** | Gets or sets a set of functions the transaction type has.  &lt;br&gt;  Examples for functions are: credit, debit, cancellation, incoming, outgoing, accounting_exportable, standing_order, workshop_order   | [optional] 
**Subtypes** | [**List&lt;TransactionSubtypeRequest&gt;**](TransactionSubtypeRequest.md) | Gets or sets the set of subtypes. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

