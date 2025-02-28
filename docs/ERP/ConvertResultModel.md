# Simplic.OxS.SDK.ERP.ConvertResultModel
Represents the shared model for the result of converting a transaction.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Transaction** | [**TransactionModel**](TransactionModel.md) |  | [optional] 
**Errors** | [**List&lt;ConvertErrorInfoModel&gt;**](ConvertErrorInfoModel.md) | Gets or sets a set of Simplic.OxS.ERP.ConvertErrorInfo objects. | [optional] 
**ConvertStates** | [**Dictionary&lt;string, TransactionConvertState&gt;**](TransactionConvertState.md) | Gets or sets a set of convert states.  For each converted transaction the convert state is given as the value of a dictionary entry, the key being the transaction&#39;s ID.  &lt;para&gt;&lt;/para&gt; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

