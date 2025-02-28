# Simplic.OxS.SDK.ERP.ConvertTransactionsRequest
Represents a request to convert a set of transactions.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionSubsets** | **Dictionary&lt;string, Dictionary&lt;string, double&gt;&gt;** | Gets or sets the set of transactions mapped to their booked transaction item IDs and quantities. | 
**TargetTypeId** | **Guid** | Gets or sets the type of the result transaction by ID. | 
**TargetSubtypeId** | **Guid?** | Gets or sets the subtype of the result transaction by ID. | [optional] 
**CheckCompatibleProperties** | **List&lt;string&gt;** | Gets or sets the set of properties to check for each input transaction to ensure compatibility. | [optional] 
**Commit** | **bool** | Gets or sets the commit flag. If raised, the convert operation will be committed | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

