# Simplic.OxS.SDK.ERP.TransactionTypeModel
Represents the shared model for a transaction type.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**OrganizationId** | **Guid** |  | [optional] 
**IsDeleted** | **bool** |  | [optional] 
**Name** | **string** | Gets or sets the name. | [optional] 
**Number** | **int** | Gets or sets the number. | [optional] 
**ReportName** | **string** | Gets or sets the report title. | [optional] 
**ShortName** | **string** | Gets or sets the short name. | [optional] 
**Functions** | **List&lt;string&gt;** | Gets or sets a set of functions the transaction type has.     Examples for functions are: credit, debit, cancellation, incoming, outgoing, accounting_exportable, standing_order, workshop_order   | [optional] 
**Subtypes** | [**List&lt;TransactionSubtypeModel&gt;**](TransactionSubtypeModel.md) | Gets or sets the set of subtypes. | [optional] 
**CreateDateTime** | **DateTime** | Gets or sets the date and time the transaction type is created. | [optional] 
**CreateUserId** | **Guid?** | Gets or sets the id of the user that created the transaction type. | [optional] 
**CreateUserName** | **string** | Gets or sets the name of the user that created the transaction type. | [optional] 
**UpdateDateTime** | **DateTime** | Gets or sets the date and time the transaction type is updated. | [optional] 
**UpdateUserId** | **Guid?** | Gets or sets the id of the user that updated the transaction type. | [optional] 
**UpdateUserName** | **string** | Gets or sets the name of the user that updated the transaction type. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

